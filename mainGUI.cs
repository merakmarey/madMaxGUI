using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

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


        private System.Windows.Forms.Timer TimerRAM;
        private System.Windows.Forms.Timer TimerCPU;
        private System.Windows.Forms.Timer TimerTask;

        List<Task> plottingTasks = new List<Task>();
        List<PlotTask> plotTasks = new List<PlotTask>();

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
        private void TimerTask_Tick(object sender, EventArgs e)
        {
            if (dgvPlotTasks.Rows.Count>0)
            foreach (var item in plotTasks)
            {
                var row = dgvPlotTasks.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Plot"].Value.ToString().Equals(item.plot_filename)).First();
                var chia_process = item.process.GetChildProcesses().Where(p => p.ProcessName == "chia_plot").First();
                row.Cells["TimeElapsed"].Value = (chia_process.StartTime- DateTime.Now).ToString(@"hh\:mm\:ss");
            }
        }
        private void InitRAMTimer()
        {
            TimerRAM = new System.Windows.Forms.Timer();
            TimerRAM.Tick += new EventHandler(TimerRAM_Tick);
            TimerRAM.Interval = 1000;
            TimerRAM.Start();
        }
        private void InitCPUTimer()
        {
            TimerCPU = new System.Windows.Forms.Timer();
            TimerCPU.Tick += new EventHandler(TimerCPU_Tick);
            TimerCPU.Interval = 1000;
            TimerCPU.Start();
        }
        private void InitPlotTasksTimer()
        {
            TimerTask = new System.Windows.Forms.Timer();
            TimerTask.Tick += new EventHandler(TimerTask_Tick);
            TimerTask.Interval = 1000;
            TimerTask.Start();
        }


        private void KillChildProcesses(Process process)
        {
            foreach (Process childProcess in process.GetChildProcesses())
            {
                KillChildProcesses(childProcess);
                childProcess.Kill(true);
            }
        }
        private void mainGUI_Load(object sender, EventArgs e)
        {

            InitRAMTimer();
            InitCPUTimer();

            long memKb;
            physicalCores = 0;
            lbProcessor.Text = "";

            chiaVersion = getRegistryValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\chia-blockchain\", "DisplayVersion");

            foreach (var item in new System.Management.ManagementObjectSearcher("Select TotalPhysicalMemory from Win32_ComputerSystem").Get())
            {
                if (Int64.TryParse(item["TotalPhysicalMemory"].ToString(), out memKb))
                    lbRAM.Text = (memKb / 1024 / 1024/ 1024).ToString() + " GB";
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
                lbThreads.Text =  item["NumberOfLogicalProcessors"].ToString();
            }

            lbThreadsSuggested.Text = String.Format("(Suggested:{0})" , ((lbThreads.Text.ToInt() * lbCPUCount.Text.ToInt()) / (int)nudPlotCount.Value).ToString());
        }

        private void mainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in plotTasks)
            {
                KillChildProcesses(item.process);
                item.process.Kill(true);
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
                    var index = gvFinalDrives.Rows.Add();
                    gvFinalDrives.Rows[index].Cells["Path"].Value = finalPath_1;
                    var driveInfo = getDriveInfo(finalPath_1);

                    if (driveInfo != null)
                    {
                        var gb = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024;
                        gvFinalDrives.Rows[index].Cells["Space"].Value = String.Format("(Space Available {0:0.00}GB / {1:0.00}GiB)", gb, gb * GiBfactor);
                    }
                }
            }
        }

        private void btnAutoGetKeys_Click(object sender, EventArgs e)
        {
            try
            {
                string output;
                string error;
                lbAutoWorking.Text = "Working!";
                lbAutoWorking.ForeColor = System.Drawing.Color.Red;
                btnAutoGetKeys.Enabled = false;
                lbAutoWorking.Refresh();

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
                MessageBox.Show(ex.Message, "Auto Keys Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAutoGetKeys.Enabled = true;
                lbAutoWorking.Text = "Ready";
                lbAutoWorking.ForeColor = System.Drawing.Color.Green;
                lbAutoWorking.Refresh();
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

        private void setWarningLabels(Label targetLabel, string drivePath, float minimumPerFile, int suggested=1)
        {
            if ((drivePath != "(none)") && (!String.IsNullOrEmpty(drivePath)))
            {
                var driveInfo = getDriveInfo(drivePath);
                var gib = (driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024) * GiBfactor;
                if ((gib / minimumPerFile < 1) || (Math.Truncate(gib / minimumPerFile)< suggested))
                {
                    targetLabel.Text = "Not enough space";
                    targetLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    targetLabel.Text = String.Format("(Suggested:{0:0})", Math.Truncate(gib /minimumPerFile));
                    targetLabel.ForeColor = Color.DarkSlateGray;
                }
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

        private void nudPlotCount_Changed(object sender, EventArgs e) 
        {
            setWarningLabels(lbPlotCountSuggested, tmpPath_1, 220, (int)nudPlotCount.Value);
            var suggestedThreads = (lbCores.Text.ToInt() * lbThreads.Text.ToInt() * lbCPUCount.Text.ToInt() / (int)nudPlotCount.Value);
            suggestedThreads = (suggestedThreads < 1 ? 1 : suggestedThreads);
            lbThreadsSuggested.Text = String.Format("(Suggested:{0})", suggestedThreads.ToString());
        }

        private void btnRemoveDrives_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in gvFinalDrives.SelectedRows)
            {
                gvFinalDrives.Rows.RemoveAt(item.Index);
            }
        }

        private void dgvPlotTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPlotTasks.Columns["Output"].Index && e.RowIndex>=0)
            {
                var plotName = dgvPlotTasks.Rows[e.RowIndex].Cells["Plot"].Value.ToString();
                var outputText = plotTasks.Where(p => p.plot_filename == plotName).First().output;
                var outputForm = new OutputForm();
                outputForm.txOutput.Text = outputText;
                outputForm.Show();
            }
        }

        private void StartPlottingTasks(List<PlotTask> tasks)
        {
            foreach (var item in tasks)
            {
                var task = System.Threading.Tasks.Task.Factory.StartNew(() => {

                    var pStartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory+@"madMax\",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    };
                    
                    using (item.process = new Process() )
                    {
                        item.process.StartInfo = pStartInfo;
                        
                        item.process.Start();
                        item.process.StandardInput.WriteLine("chia_plot.exe " + item.cmdString);
                        item.process.StandardInput.AutoFlush = true;
                       

                        item.process.OutputDataReceived += new DataReceivedEventHandler((sender, e)=> 
                        {
                            item.outputProcessor(e.Data, dgvPlotTasks);
                        });

                        //item.process.OutputDataReceived += (object sendingProcess, DataReceivedEventArgs outline) => {  };

                        item.process.ErrorDataReceived += (object sendingProcess, DataReceivedEventArgs outline) => { item.error += outline.Data; };

                        /*
                          
                        item.process.StandardInput.Close();

                        output = item.process.StandardOutput.ReadToEnd();
                        error = item.process.StandardError.ReadToEnd();

                        */
                        item.process.BeginOutputReadLine();

                        bool waitforchia_plotter_process = true;
                        while (waitforchia_plotter_process)
                        {
                            var childprocs = item.process.GetChildProcesses();
                            if (childprocs.Where(p => p.ProcessName == "chia_plot").Count() > 0)
                                waitforchia_plotter_process = false;
                        }

                        foreach (Process childProcess in item.process.GetChildProcesses())
                        {
                            if (childProcess.ProcessName=="chia_plot")
                            childProcess.PriorityClass = ProcessPriorityClass.AboveNormal;
                        }
                        item.process.WaitForExit();
                        
                    }
                    
                }, TaskCreationOptions.None );
            }
            InitPlotTasksTimer();
        }

        private string formatPath(string path)
        {
            string tmpString = "\"" + path;
            tmpString += (!tmpString.EndsWith(@"\\") ? @"\" : String.Empty);
            tmpString += (!tmpString.EndsWith(@"\\") ? @"\" : String.Empty);
            tmpString += "\"";
            return tmpString;
        }

        private string createCommand(PlotTask pTask)
        {
            string cmd;

            cmd = " -n 1" + (!String.IsNullOrEmpty(pTask.threads) ? " -r " + pTask.threads : String.Empty) +
                (!String.IsNullOrEmpty(pTask.buckets) ? " -u " + pTask.buckets : String.Empty) +
                (!String.IsNullOrEmpty(pTask.buckets34) ? " -v " + pTask.buckets34 : String.Empty) +
                " -t " + formatPath(pTask.tmpDir1) +
                (String.IsNullOrEmpty(pTask.tmpDir2)?String.Empty:" -2 " + formatPath(pTask.tmpDir2)) + 
                " -p " + pTask.poolKey + " -f " + pTask.farmerKey +
                (!pTask.copyOnSeparatedTask?" -d "+formatPath(pTask.finalDir):String.Empty);
            return cmd;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tmpPath_1))
            {
                MessageBox.Show( "Tmp path # 1 cannot be empty","Tmp path # 1",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            if (String.IsNullOrEmpty(txPoolKey.Text) || String.IsNullOrEmpty(txFarmerKey.Text) || (txFarmerKey.Text.Length+txPoolKey.Text.Length!= maxKeyLength*2) )
            {
                MessageBox.Show( "Pool/Farmer keys cannot be empty/invalid", "Keys",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int finalDirIndex = 0;

            for (int i = 0; i < nudPlotCount.Value; i++)
            {
                string currentFinalDir;

                if (gvFinalDrives.Rows.Count > 0)
                {
                    currentFinalDir = gvFinalDrives.Rows[finalDirIndex].Cells[0].Value.ToString();

                    if (finalDirIndex < gvFinalDrives.Rows.Count - 1)
                        finalDirIndex++;
                    else
                        finalDirIndex = 0;
                } else
                {
                    currentFinalDir = lbTmpPath1_currentPath.Text.ToLowerInvariant();
                }

                var newTask = new PlotTask() {
                    guid = Guid.NewGuid(),
                    
                    threads = nudThreads.Value.ToString(),
                    buckets = (cbBuckets.Text.ToLowerInvariant().StartsWith("default")? String.Empty : cbBuckets.Text.ToLowerInvariant()),
                    buckets34 = (cbBuckets34.Text.ToLowerInvariant().StartsWith("default") ? String.Empty : cbBuckets34.Text.ToLowerInvariant()),

                    copyOnSeparatedTask = cbSeparatedTaskCopy.Checked,
                    useInternalCopy = cbInternalCopy.Checked,
                    validateAfterCopy = cbValidatePlot.Checked,

                    farmerKey = txFarmerKey.Text,
                    poolKey = txPoolKey.Text,

                    finalDir = currentFinalDir,
                    status = TaskStatus.NotStarted
                };

                // dirs
                if (cbAlternate.Checked && !String.IsNullOrEmpty(lbTmpPath2_currentPath.Text))
                {
                    if (i % 2==0)
                    {
                        newTask.tmpDir1 = lbTmpPath1_currentPath.Text.ToLowerInvariant();
                        newTask.tmpDir2 = lbTmpPath2_currentPath.Text.ToLowerInvariant();
                    } else
                    {
                        newTask.tmpDir1 = lbTmpPath2_currentPath.Text.ToLowerInvariant();
                        newTask.tmpDir2 = lbTmpPath1_currentPath.Text.ToLowerInvariant();
                    }
                }
                else
                {
                    newTask.tmpDir1 = lbTmpPath1_currentPath.Text;
                    if (cbAlternate.Checked)
                        newTask.tmpDir2 = (lbTmpPath2_currentPath.Text.ToLowerInvariant().StartsWith("(") ? String.Empty : lbTmpPath2_currentPath.Text.ToLowerInvariant());
                    else
                        newTask.tmpDir2 = String.Empty;
                }


                newTask.cmdString = createCommand(newTask);
                plotTasks.Add(newTask);
            }

            StartPlottingTasks(plotTasks);
        }

        private void btnClearTmp2_Click(object sender, EventArgs e)
        {
            lbTmpPath2_currentPath.Text = "(none)";
        }

       
    }
}
