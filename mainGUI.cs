using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace madMaxGUI
{

    public partial class mainGUI : Form
    {

        //Computer\HKEY_USERS\S-1-5-21-4000077218-945148693-2747979120-1001\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\chia-blockchain\DisplayVersion

        const int maxKeyLength = 96;
        private const double GiBfactor = 0.931323;
        

        string userProfile;
        string chiaVersion;
        int physicalCores;

        string tmpPath_1;
        string tmpPath_2;
        string finalPath_1;


        private Timer TimerRAM;
        private Timer TimerCPU;

        public mainGUI()
        {
            InitializeComponent();
        }

        public string getRegistryValue(string regPath, string keyName)
        {
            return Registry.GetValue(regPath, keyName, String.Empty).ToString();
        }

        public float getAvailableMemory()
        {
            System.Diagnostics.PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available Bytes");
            return ramCounter.NextValue();
        }

        public DriveInfo getDriveInfo(string drivePath)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            return driveInfos.Where(n => n.Name.ToLowerInvariant().StartsWith(drivePath.Substring(0, 3).ToLowerInvariant())).FirstOrDefault();
        }
        public void setDriveInfo(Label sourceLabel, Label targetLabel)
        {
            
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            if (sourceLabel.Text!="(none)")
            {
                var driveInfo = getDriveInfo(sourceLabel.Text);
                
                if (driveInfo!=null)
                {
                    var gb = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024;
                    targetLabel.Text = String.Format("(Space Available {0:0.00}GB / {1:0.00}GiB)", gb, gb* GiBfactor);
                }
            }
        }


        public int getCPUusage()
        {
            System.Diagnostics.PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time","_Total");

            int percentage = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_PerfFormattedData_PerfOS_Processor").Get())
            {
                if ((string)item["Name"]=="_Total")
                Int32.TryParse(item["PercentProcessorTime"].ToString(), out percentage);
            }

            return percentage;
        }

        private void TimerRAM_Tick(object sender, EventArgs e) 
        {
            var ramAvail = getAvailableMemory();
            lbFreeRAM.Text = (ramAvail / 1024 / 1024 /1024).ToString() + " GB";
        }
        private void TimerCPU_Tick(object sender, EventArgs e)
        {
            var cpuUsed = getCPUusage();
            lbCPUusage.Text = cpuUsed + " %";
        }

        private void InitRAMTimer()
        {
            TimerRAM = new Timer();
            TimerRAM.Tick += new EventHandler(TimerRAM_Tick);
            TimerRAM.Interval = 1000;
            TimerRAM.Start();
        }
        private void InitCPUTimer()
        {
            TimerCPU = new Timer();
            TimerCPU.Tick += new EventHandler(TimerCPU_Tick);
            TimerCPU.Interval = 1000;
            TimerCPU.Start();
        }

        private void mainGUI_Load(object sender, EventArgs e)
        {

            InitRAMTimer();
            InitCPUTimer();

            long memKb;
            physicalCores = 0;
            lbProcessor.Text = "";

            chiaVersion = getRegistryValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\chia-blockchain\", "DisplayVersion");

            foreach (var item in new System.Management.ManagementObjectSearcher("Select Capacity from Win32_PhysicalMemory").Get())
            {
                if (Int64.TryParse(item["Capacity"].ToString(), out memKb))
                    lbRAM.Text = (memKb / 1024 / 1024).ToString() + " GB";
            }

            userProfile = System.Environment.GetEnvironmentVariable("USERPROFILE").ToString();
            
            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfCores from Win32_Processor").Get())
            {
                Int32.TryParse(item["NumberOfCores"].ToString(), out physicalCores);
            }

            foreach (var item in new System.Management.ManagementObjectSearcher("Select Name from Win32_Processor").Get())
            {
                lbProcessor.Text += item["Name"];
            }
            lbCores.Text = physicalCores.ToString();

            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfProcessors from Win32_ComputerSystem").Get())
            {
                lbCPUCount.Text = item["NumberOfProcessors"].ToString();
            }

            foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfLogicalProcessors from Win32_ComputerSystem").Get())
            {
                lbLogicalCPUs.Text =  item["NumberOfLogicalProcessors"].ToString();
            }
        }


        private void btnTmpPath1Pick_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    tmpPath_1 = fbd.SelectedPath;
                    lbTmpPath1_currentPath.Text = tmpPath_1;
                    setDriveInfo(lbTmpPath1_currentPath, lbTmp1AvailSpace);
                    setWarningLabels(lbPlotCountSuggested, tmpPath_1, 220, (int)nudPlotCount.Value);
                }
            }
           
        }

        private void btnTmpPath2Pick_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tmpPath_2 = fbd.SelectedPath;
                    lbTmpPath2_currentPath.Text = tmpPath_2;
                    setDriveInfo(lbTmpPath2_currentPath, lbTmp2AvailSpace);
                }
            }
        }

        private void btnFinalDest1Pick_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    finalPath_1 = fbd.SelectedPath;
                    lbFinalDest1_currentPath.Text = finalPath_1;
                    setDriveInfo(lbFinalDest1_currentPath, lbFinal1AvailSpace);
                }
            }
        }

        private void btnAutoGetKeys_Click(object sender, EventArgs e)
        {
            try
            {
                string output;
                string error;

                var pStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    //FileName = @"Z:\Administrator\AppData\Local\chia-blockchain\app-1.1.7\resources\app.asar.unpacked\daemon\chia.exe",
                    WorkingDirectory = userProfile + @"\AppData\Local\chia-blockchain\app-"+chiaVersion+@"\resources\app.asar.unpacked\daemon\",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                };
                using (Process process = new Process())
                {
                    process.StartInfo = pStartInfo;

                    process.Start();
                    process.StandardInput.WriteLine(userProfile + @"\AppData\Local\chia-blockchain\app-"+chiaVersion+@"\resources\app.asar.unpacked\daemon\chia.exe keys show");
                    process.StandardInput.AutoFlush = true;
                    process.StandardInput.Close();

                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();

                    process.WaitForExit();
                }
                var outputLines = output.ToLowerInvariant().Split("\r\n");

                if (output.ToLowerInvariant().Contains("farmer public key"))
                {
                    var farmerKey = outputLines.Where(s => s.StartsWith("farmer public key")).Select(k=>k.ToString().Substring(k.ToString().Length- maxKeyLength)).FirstOrDefault();
                    txFarmerKey.Text = farmerKey;
                }
                if (output.ToLowerInvariant().Contains("pool public key"))
                {
                    var poolKey = outputLines.Where(s => s.StartsWith("pool public key")).Select(k => k.ToString().Substring(k.ToString().Length - maxKeyLength)).FirstOrDefault();
                    txPoolKey.Text = poolKey;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void setIndicatorColor(TextBox textBox, Label label)
        {
            if (textBox.Text.Length == maxKeyLength)
                label.ForeColor = Color.Green;
            if (textBox.Text.Length > 0 && textBox.Text.Length != maxKeyLength)
                label.ForeColor = Color.Red;
            if (textBox.Text.Length == 0)
                label.ForeColor = Color.DarkGray;
        }

        private void setWarningLabels(Label targetLabel, string drivePath, float minimumPerFile, int multiplier=1)
        {
            var driveInfo = getDriveInfo(drivePath);
            var gib = (driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024) * GiBfactor;
            if (gib / (minimumPerFile*multiplier) < 1)
            {
                targetLabel.Text = "Not enough space";
                targetLabel.ForeColor = Color.DarkRed;
            }
            else
            {
                targetLabel.Text = String.Format("(Suggested:{0:0})", Math.Truncate((gib / (minimumPerFile * multiplier))));
                targetLabel.ForeColor = Color.DarkGray;
            }
        }

        private void lbFmKIndicator_Changed(object sender, EventArgs e)
        {
            setIndicatorColor(this.txFarmerKey, this.lbFmKIndicator);
        }

        private void lbPlKIndicator_Changed(object sender, EventArgs e)
        {
            setIndicatorColor(this.txPoolKey,this.lbPlKeyIndicator);
        }

       
    }
}
