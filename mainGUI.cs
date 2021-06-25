using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;

namespace madMaxGUI
{
    
    public partial class mainGUI : Form
    {
        const int maxKeyLength = 96;

        string userProfile;
        int physicalCores;

        string tmpPath_1;
        string tmpPath_2;

        public mainGUI()
        {
            InitializeComponent();
        }


        private void mainGUI_Load(object sender, EventArgs e)
        {
            long memKb;
            physicalCores = 0;
            lbProcessor.Text = "";

            foreach (var item in new System.Management.ManagementObjectSearcher("Select Capacity from Win32_PhysicalMemory").Get())
            {
                if (Int64.TryParse(item["Capacity"].ToString(), out memKb))
                    lbRAM.Text = (memKb / 1024 / 1024).ToString() + "GB";
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

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                lbProcessor.Text = "("+ item["NumberOfProcessors"]+") " + lbProcessor.Text;
            }

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
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
                    WorkingDirectory = userProfile + @"\AppData\Local\chia-blockchain\app-1.1.7\resources\app.asar.unpacked\daemon\",
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
                    process.StandardInput.WriteLine(userProfile + @"\AppData\Local\chia-blockchain\app-1.1.7\resources\app.asar.unpacked\daemon\chia.exe keys show");
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
