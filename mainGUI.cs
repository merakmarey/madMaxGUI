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
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace madFurry
{

    public partial class mainGUI : Form
    {

        //Computer\HKEY_USERS\S-1-5-21-4000077218-945148693-2747979120-1001\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\chia-blockchain\DisplayVersion

        const int maxKeyLength = 96;
        const int contractAddressMaxLength = 62;

        private List<string> allowedCRCs = new List<string>() { "83bffa8c994899603479a5a8645f455d", "2f9f1fcd6a0fe9eedc6b3b7cd869adc7", "e393b8ed60a4bde6212e6111edab98bb" };

        private const double GiBfactor = 0.931323;
        


        string userProfile;
        string chiaVersion;
        int physicalCores;

        string tmpPath_1;
        string tmpPath_2;
        string finalPath_1;


        private System.Timers.Timer TimerRAM;
        private System.Timers.Timer TimerCPU;
        private System.Timers.Timer TimerTask;
        private System.Timers.Timer TimerDriveInfo;


        
        List<PlotTask> plotTasks = new List<PlotTask>();

        public mainGUI()
        {
            InitializeComponent();
        }

        #region general tool functions 
        public string getRegistryValue(string regPath, string keyName)
        {
            try
            {
                object value = Registry.GetValue(regPath, keyName, String.Empty);
                if (String.IsNullOrEmpty(value.ToString()))
                    return String.Empty;
                return value.ToString();
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }
        public float getAvailableMemory()
        {
            System.Diagnostics.PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available Bytes");
            return ramCounter.NextValue();
        }
        private string checkEndSlash(string path)
        {
            return path + (path.EndsWith(@"\") ? String.Empty : @"\");
        }
        public DriveInfo getDriveInfo(string drivePath)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            return driveInfos.Where(n => n.Name.ToLowerInvariant().StartsWith(drivePath.Substring(0, 3).ToLowerInvariant())).FirstOrDefault();
        }
        public void setDriveInfo(Label sourceLabel, Label targetLabel)
        {

            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            if (sourceLabel.Text != "(none)")
            {
                var driveInfo = getDriveInfo(sourceLabel.Text);

                if (driveInfo != null)
                {
                    var gb = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024;
                    if (targetLabel.InvokeRequired)
                    {
                        targetLabel.Invoke(new MethodInvoker(delegate {
                            targetLabel.Text = String.Format("(Space Available {0:0.00}GB / {1:0.00}GiB)", gb, gb * GiBfactor);
                        }));
                    } else
                    {
                        targetLabel.Text = String.Format("(Space Available {0:0.00}GB / {1:0.00}GiB)", gb, gb * GiBfactor);
                    }
                }
            }
        }
        public int getCPUusage()
        {
            System.Diagnostics.PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            int percentage = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_PerfFormattedData_PerfOS_Processor").Get())
            {
                if ((string)item["Name"] == "_Total")
                    Int32.TryParse(item["PercentProcessorTime"].ToString(), out percentage);
            }

            return percentage;
        }
        private string formatPath(string path)
        {
            string tmpString = "\"" + path;
            tmpString += (!tmpString.EndsWith(@"\\") ? @"\" : String.Empty);
            tmpString += (!tmpString.EndsWith(@"\\") ? @"\" : String.Empty);
            tmpString += "\"";
            return tmpString;
        }
        private bool checkChiaPlotter(string file)
        {
            StringBuilder sb = new StringBuilder();
            using (Stream fStream = File.OpenRead(file) )
            {
                byte[] hashBytes = MD5.Create().ComputeHash(fStream);
                foreach (byte bt in hashBytes)  
                {
                    sb.Append(bt.ToString("x2"));
                }
            }
            if (allowedCRCs.Contains(sb.ToString()))
                return true;
            return false;
        }
        private void Log(List<string> logEvents)
        {
            File.AppendAllLines(checkEndSlash(AppDomain.CurrentDomain.BaseDirectory) + String.Format("log_{0}.log", DateTime.Now.ToString("MM-dd-yyyy")), logEvents);
        }
        #endregion

        

        #region timer controls
        private void TimerRAM_Tick(object sender, EventArgs e)
        {
            var ramAvail = getAvailableMemory();
            if (lbFreeRAM.InvokeRequired)
            {
                lbFreeRAM.Invoke(new MethodInvoker(delegate {
                    lbFreeRAM.Text = (ramAvail / 1024 / 1024 / 1024).ToString() + " GB";
                }));
            }
        }
        private void TimerCPU_Tick(object sender, EventArgs e)
        {
            var cpuUsed = getCPUusage();
            if (lbCPUusage.InvokeRequired)
            {
                lbCPUusage.Invoke(new MethodInvoker(delegate {
                    lbCPUusage.Text = cpuUsed + " %";
                }));
            }
           
        }
        private void TimerTask_Tick(object sender, EventArgs e)
        {
            if (dgvPlotTasks.Rows.Count > 0)
                foreach (var item in plotTasks)
                {
                    try
                    {
                        var row = dgvPlotTasks.GetRowByColumnValue("Plot", item.plot_filename);
                        if (item.process != null)
                            if ((!item.process.HasExited) && (row != null))
                            {
                                var child_process = item.process.GetChildProcesses();
                                if (child_process.Count() > 0)
                                {
                                    var chia_process = child_process.Where(p => p.ProcessName == "chia_plot").FirstOrDefault();
                                    if (chia_process != null)
                                        dgvPlotTasks.SetRowCellByColumnValue(row, "TimeElapsed", (chia_process.StartTime - DateTime.Now).ToString(@"hh\:mm\:ss"));
                                }
                            }
                    }
                    catch (Exception ex)
                    {
                        // nothing to do.
                    }
                }
        }
        private void TimerDriveInfos_Tick(object sender, EventArgs e)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            //return driveInfos.Where(n => n.Name.ToLowerInvariant().StartsWith(drivePath.Substring(0, 3).ToLowerInvariant())).FirstOrDefault();

            setDriveInfo(lbTmpPath1_currentPath, lbTmp1AvailSpace);
            setDriveInfo(lbTmpPath2_currentPath, lbTmp2AvailSpace);

            foreach (DataGridViewRow item in dgvFinalDrives.Rows)
            {
                var driveInfo = driveInfos.Where(n => n.Name.ToLowerInvariant().StartsWith(item.Cells["Path"].Value.ToString().Substring(0, 3).ToLowerInvariant())).FirstOrDefault();
                var gb = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024;
                var newInfo = String.Format("(Space Available {0:0.00}GB / {1:0.00}GiB)", gb, gb * GiBfactor);
                dgvFinalDrives.SetRowCellByColumnValue(item, "Space", newInfo);
            }
        }
        private void InitRAMTimer()
        {
            TimerRAM = new System.Timers.Timer();
            TimerRAM.Elapsed += TimerRAM_Tick;
            TimerRAM.Interval = 1000;
            TimerRAM.Start();
        }
        private void InitCPUTimer()
        {
            TimerCPU = new System.Timers.Timer();
            TimerCPU.Elapsed += TimerCPU_Tick;
            TimerCPU.Interval = 1000;
            TimerCPU.Start();
        }
        private void InitDriveInfoTimer()
        {
            TimerDriveInfo = new System.Timers.Timer();
            TimerDriveInfo.Elapsed += TimerDriveInfos_Tick;
            TimerDriveInfo.Interval = 1000 * 10; // every 10 secs
            TimerDriveInfo.Start();
        }
        private void InitPlotTasksTimer()
        {
            TimerTask = new System.Timers.Timer();
            TimerTask.Elapsed +=TimerTask_Tick;
            TimerTask.Interval = 1000;
            TimerTask.Start();
        }
        #endregion


        #region processes manipulation
        private void KillChildProcesses(Process process)
        {
            foreach (Process childProcess in process.GetChildProcesses())
            {
                KillChildProcesses(childProcess);
                childProcess.Kill(true);
            }
        }

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

        private void SetHighIOPriority(Process process)
        {
            int priority = 3;
            int PROCESS_INFORMATION_CLASS_ProcessIoPriority = 33;

            var result = NtSetInformationProcess(process.Handle, PROCESS_INFORMATION_CLASS_ProcessIoPriority, ref priority, sizeof(int));
        }


        #endregion


        #region click events
        private void mainGUI_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("madFurry (v{0}) - GUI/Plot Manager for madMax Chia Plotter", madFurry.Properties.Settings.Default.version);
        }

        private void mainGUI_Shown(object sender, EventArgs e)
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
                    lbRAM.Text = (memKb / 1024 / 1024 / 1024).ToString() + " GB";
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
                lbThreads.Text = item["NumberOfLogicalProcessors"].ToString();
            }

            lbThreadsSuggested.Text = String.Format("(Suggested:{0})", ((lbThreads.Text.ToInt() * lbCPUCount.Text.ToInt()) / (int)nudPlotCount.Value).ToString());
        }

        private void mainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in plotTasks)
            {
                KillChildProcesses(item.process);
                try
                {
                    if (item.process!=null)
                    item.process.Kill(true);
                }
                catch (Exception ex) { };
            }
        }

        private void btnTmpPath1Pick_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
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
                    var index = dgvFinalDrives.Rows.Add();
                    dgvFinalDrives.Rows[index].Cells["Path"].Value = finalPath_1;
                    var driveInfo = getDriveInfo(finalPath_1);

                    if (driveInfo != null)
                    {
                        var gb = driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024;
                        dgvFinalDrives.Rows[index].Cells["Space"].Value = String.Format("(Space Available {0:0.00}GB / {1:0.00}GiB)", gb, gb * GiBfactor);
                    }
                }
            }
        }

        private string getRegularProcessOutput(string processLocation, string processCL)
        {
            string output;
            string error;
            try
            {
                var pStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    //FileName = @"Z:\Administrator\AppData\Local\chia-blockchain\app-1.1.7\resources\app.asar.unpacked\daemon\chia.exe",
                    WorkingDirectory = checkEndSlash(processLocation),
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
                    process.StandardInput.WriteLine(checkEndSlash(processLocation) + processCL);
                    process.StandardInput.AutoFlush = true;
                    process.StandardInput.Close();

                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();

                    process.WaitForExit();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK);
            }
            return String.Empty;
        }

        private void btnAutoGetKeys_Click(object sender, EventArgs e)
        {
            try
            {
                btnAutoGetKeys.Enabled = false;
                lbAutoWorking.Text = "Working..";
                lbAutoWorking.ForeColor = System.Drawing.Color.Red;
                lbAutoWorking.Refresh();

                var output = getRegularProcessOutput(userProfile + @"\AppData\Local\chia-blockchain\app-" + chiaVersion + @"\resources\app.asar.unpacked\daemon\", "chia.exe keys show");
                var outputLines = output.ToLowerInvariant().Split("\r\n");

                if (output.ToLowerInvariant().Contains("farmer public key"))
                {
                    var farmerKey = outputLines.Where(s => s.StartsWith("farmer public key")).Select(k => k.ToString().Substring(k.ToString().Length - maxKeyLength)).FirstOrDefault();
                    txFarmerKey.Text = farmerKey;
                }

                if (rbSolo.Checked)
                {
                    if (output.ToLowerInvariant().Contains("pool public key"))
                    {
                        var poolKey = outputLines.Where(s => s.StartsWith("pool public key")).Select(k => k.ToString().Substring(k.ToString().Length - maxKeyLength)).FirstOrDefault();
                        txPoolKey.Text = poolKey;
                        txContractAddress.Text = String.Empty;
                    }
                }
                else
                {
                    var output2 = getRegularProcessOutput(userProfile + @"\AppData\Local\chia-blockchain\app-" + chiaVersion + @"\resources\app.asar.unpacked\daemon\", "chia.exe plotnft show");
                    var outputLines2 = output2.ToLowerInvariant().Split("\r\n");
                    if (output2.ToLowerInvariant().Contains("p2 singleton address"))
                    {
                        var contractAddress = outputLines2.Where(s => s.StartsWith("p2 singleton address")).Select(k => k.ToString().Substring(k.ToString().Length - contractAddressMaxLength)).FirstOrDefault();
                        txContractAddress.Text = contractAddress;
                        txPoolKey.Text = String.Empty;
                        cmbContractWallets.Items.Clear();
                        string initialPair = String.Empty;
                        foreach (var item in outputLines2)
                        {
                            if (item.StartsWith("current pool url:") && (!String.IsNullOrEmpty(initialPair)))
                            {
                                cmbContractWallets.Items.Add(String.Format("{0} - {1}", item.Substring(17), initialPair));
                                initialPair = String.Empty;
                            }
                            if (item.StartsWith("p2 singleton address")) 
                            {
                                initialPair = item.Substring(item.Length - contractAddressMaxLength);
                            }
                        }
                        if (cmbContractWallets.Items.Count>0)
                        {
                            cmbContractWallets.SelectedIndex = 0;
                        }
                    }
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

        private void btnRemoveDrives_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvFinalDrives.SelectedRows)
            {
                dgvFinalDrives.Rows.RemoveAt(item.Index);
            }
        }

        private void dgvPlotTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPlotTasks.Columns["Output"].Index && e.RowIndex >= 0)
            {
                var plotName = dgvPlotTasks.Rows[e.RowIndex].Cells["Plot"].Value.ToString();
                var outputText = plotTasks.Where(p => p.plot_filename == plotName).First().output;
                if (!String.IsNullOrEmpty(outputText))
                {
                    var outputForm = new OutputForm();
                    outputForm.Text = plotName;
                    outputForm.txOutput.Text = outputText;
                    outputForm.Show();
                    outputForm.txOutput.DeselectAll();
                    outputForm.txOutput.Refresh();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (TimerDriveInfo==null)
                InitDriveInfoTimer();

            plotTasks.Clear();

            if (String.IsNullOrEmpty(tmpPath_1))
            {
                MessageBox.Show("Tmp path # 1 cannot be empty", "Tmp path # 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txFarmerKey.Text) || (txFarmerKey.Text.Length != maxKeyLength ))
            {
                MessageBox.Show("Farmer keys cannot be empty/invalid", "Keys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var case1 = (txContractAddress.Text.Length == contractAddressMaxLength) && (txPoolKey.Text.Length == 0);
            var case2 = (txContractAddress.Text.Length == 0) && (txPoolKey.Text.Length == maxKeyLength);

            if ((!case1) && (!case2))
            {
                MessageBox.Show("Please enter EITHER a valid Pool key or a valid Contract Address", "Keys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            btnStart.Enabled = false;
            int finalDirIndex = 0;

            for (int i = 0; i < nudPlotCount.Value; i++)
            {
                string currentFinalDir;

                if (dgvFinalDrives.Rows.Count > 0)
                {
                    currentFinalDir = dgvFinalDrives.Rows[finalDirIndex].Cells[0].Value.ToString().ToLowerInvariant();

                    if (finalDirIndex < dgvFinalDrives.Rows.Count - 1)
                        finalDirIndex++;
                    else
                        finalDirIndex = 0;
                }
                else
                {
                    currentFinalDir = tmpPath_1.ToLowerInvariant();
                }

                var newTask = new PlotTask()
                {
                    threads = nudThreads.Value.ToString(),
                    buckets = (cbBuckets.Text.ToLowerInvariant().StartsWith("default") ? String.Empty : cbBuckets.Text.ToLowerInvariant()),
                    buckets34 = (cbBuckets34.Text.ToLowerInvariant().StartsWith("default") ? String.Empty : cbBuckets34.Text.ToLowerInvariant()),

                    copyOnSeparatedTask = cbSeparatedTaskCopy.Checked,
                    useInternalCopy = cbInternalCopy.Checked,
                    //validateAfterCopy = cbValidatePlot.Checked,
                    contractAddress = txContractAddress.Text,
                    farmerKey = txFarmerKey.Text,
                    poolKey = txPoolKey.Text,

                    finalDir = currentFinalDir,
                    status = TaskStatus.NotStarted
                };

                // dirs
                if (cbAlternate.Checked && !String.IsNullOrEmpty(tmpPath_2))
                {
                    if (i % 2 == 0)
                    {
                        newTask.tmpDir1 = tmpPath_1.ToLowerInvariant();
                        newTask.tmpDir2 = tmpPath_2.ToLowerInvariant();
                    }
                    else
                    {
                        newTask.tmpDir1 = tmpPath_2.ToLowerInvariant();
                        newTask.tmpDir2 = tmpPath_1.ToLowerInvariant();
                    }
                }
                else
                {
                    newTask.tmpDir1 = tmpPath_1.ToLowerInvariant();
                    if (!String.IsNullOrEmpty(tmpPath_2))
                        newTask.tmpDir2 = tmpPath_2.ToLowerInvariant();
                }


                newTask.cmdString = createCommand(newTask);
                plotTasks.Add(newTask);
            }

            StartPlottingAllTasks(plotTasks);
        }

        private void btnClearTmp2_Click(object sender, EventArgs e)
        {
            lbTmpPath2_currentPath.Text = "(none)";
            tmpPath_2 = String.Empty;
        }

        private void cmbContractWallets_Changed(object sender, EventArgs e)
        {
            var selectedOption = cmbContractWallets.Items[cmbContractWallets.SelectedIndex].ToString();
            txContractAddress.Text = selectedOption.Substring(selectedOption.Length - contractAddressMaxLength);
            txContractAddress.Refresh();
        }
        #endregion


        #region UI manipulation
        private void setIndicatorColor(TextBox textBox, Label label, int maxKeyLength = maxKeyLength)
        {
            if (textBox.Text.Length == maxKeyLength)
                label.ForeColor = Color.Green;
            if (textBox.Text.Length > 0 && textBox.Text.Length != maxKeyLength)
                label.ForeColor = Color.Red;
            if (textBox.Text.Length == 0)
                label.ForeColor = Color.DarkGray;
        }

        private void setWarningLabels(Label targetLabel, string drivePath, float minimumPerFile, int suggested = 1)
        {
            if ((drivePath != "(none)") && (!String.IsNullOrEmpty(drivePath)))
            {
                var driveInfo = getDriveInfo(drivePath);
                var gib = (driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024) * GiBfactor;
                if ((gib / minimumPerFile < 1) || (Math.Truncate(gib / minimumPerFile) < suggested))
                {
                    targetLabel.Text = "Not enough space";
                    targetLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    targetLabel.Text = String.Format("(Suggested:{0:0})", Math.Truncate(gib / minimumPerFile));
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
            setIndicatorColor(this.txPoolKey, this.lbPlKeyIndicator);
        }

        private void lblContractAddressIndicator_Changed(object sender, EventArgs e)
        {
            setIndicatorColor(this.txContractAddress, this.lblContractAddressIndicator, contractAddressMaxLength);
        }

        private void nudPlotCount_Changed(object sender, EventArgs e)
        {
            setWarningLabels(lbPlotCountSuggested, tmpPath_1, 220, (int)nudPlotCount.Value);
            var suggestedThreads = (lbThreads.Text.ToInt() * lbCPUCount.Text.ToInt() / (int)nudPlotCount.Value);
            suggestedThreads = (suggestedThreads < 1 ? 1 : suggestedThreads);
            lbThreadsSuggested.Text = String.Format("(Suggested:{0})", suggestedThreads.ToString());
        }

        private void updateCopyProgress(string plot_filename, double ProgressPercentage, DataGridView dgv)
        {

            //DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Plot"].Value.ToString().Equals(plot_filename)).FirstOrDefault();
            var row = dgv.GetRowByColumnValue("Plot", plot_filename);

            if (row != null)
            {
                dgv.SetRowCellByColumnValue(row, "LastMessage", String.Format("Copying: {0}% completed", Math.Round(ProgressPercentage, 2)));
            }
        }

        private void updateCopyTimer(PlotTask item)
        {
            var row = dgvPlotTasks.GetRowByColumnValue("Plot", item.plot_filename);
            if (row != null)
            {
                dgvPlotTasks.SetRowCellByColumnValue(row, "TimeElapsed", (item.copyStarted - DateTime.Now).ToString(@"hh\:mm\:ss"));
            }
        }
        #endregion


        private void doCopy(PlotTask item)
        {
            if ((!String.IsNullOrEmpty(item.finalDir)) && (item.finalDir.ToLowerInvariant() != item.tmpDir1.ToLowerInvariant()))
            {
                
                if (!item.useInternalCopy)
                {

                    var copyHandler = new XCopy();
                    copyHandler.RegularCopy(checkEndSlash(item.tmpDir1) + item.plot_filename, checkEndSlash(item.finalDir) + item.plot_filename, 1024 * 1024 * 10,
                        new EventHandler<ProgressChangedEventArgs>((o, s) => { updateCopyProgress(item.plot_filename, s.ProgressPercentage, dgvPlotTasks); }));
                    if (copyHandler.IsCompleted)
                    {
                        File.Delete(item.tmpDir1 + @"\" + item.plot_filename);
                    }
                    else
                    {
                        Log(new List<string>() { copyHandler.error, item.plot_filename });
                    }
                }
                else
                {

                    XCopy.Copy(checkEndSlash(item.tmpDir1) + item.plot_filename, checkEndSlash(item.finalDir) + item.plot_filename, true, true,
                         new EventHandler<ProgressChangedEventArgs>((o, s) =>
                         {
                             updateCopyProgress(item.plot_filename, s.ProgressPercentage, dgvPlotTasks);
                         }),
                         new EventHandler((o, s) =>
                         {
                             File.Delete(item.tmpDir1 + @"\" + item.plot_filename);
                         })
                        );
                }

            }
        }

        private void handleFileCopy(PlotTask item)
        {

            dgvPlotTasks.DisableButtonByColumnValue("Plot", item.plot_filename, "Output");

            if ((!String.IsNullOrEmpty(item.finalDir)) && (item.finalDir.ToLowerInvariant() != item.tmpDir1.ToLowerInvariant()))
            {

                item.copyStarted = DateTime.Now;
                item.updateCopyTime.Elapsed += (o, s) => { updateCopyTimer(item); };
                item.updateCopyTime.Interval = 1000;
                item.updateCopyTime.Start();


                if (item.copyOnSeparatedTask)
                {

                    var task = System.Threading.Tasks.Task.Factory.StartNew(() =>
                    {

                        doCopy(item);

                    }).ContinueWith(antecedent =>
                    {
                        item.StopCopyTimer();
                        dgvPlotTasks.RemoveRowByColumnValue("Plot", item.plot_filename);
                    });

                }
                else
                {
                    doCopy(item);
                    dgvPlotTasks.RemoveRowByColumnValue("Plot", item.plot_filename);
                }
            }
        }

        private void RestartPlottingTask(PlotTask item)
        {
            if ((item.status == TaskStatus.AwaitingRestart) && (cbContinuousMode.Checked))
            {
                item.error = String.Empty;
                item.output = String.Empty;
                item.plot_filename = String.Empty;
                StartPlottingTask(item);
            }
        }

        private void CompletePlottingTask(PlotTask item)
        {
            item.status = TaskStatus.Completed;

            if (dgvPlotTasks.Rows.Count==0)
            {
                if (plotTasks.Select(i => i.process.GetChildProcesses().Count() > 0).Count() > 0)
                {
                    if (btnStart.InvokeRequired)
                    {
                        btnStart.Invoke(new MethodInvoker(delegate {
                            btnStart.Enabled = true;
                        }));
                    }
                    else
                    {
                        btnStart.Enabled = true;
                    }
                }
            }
        }

        private void StartPlottingTask_FAKE(PlotTask item)
        {
            item.status = TaskStatus.NotStarted;

            var task = System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                string plotname = String.Format("plot-{0}",Guid.NewGuid());
                FileStream fs = new FileStream(@"C:\tmp chia\" + plotname+".plot", FileMode.Create);
                item.outputProcessor("Plot name: " + plotname, dgvPlotTasks);
                fs.SetLength(1024L * 1024 * 1024 * 25);
                System.Threading.Thread.Sleep(1000 * 5);
                fs.Close();
                
            }, TaskCreationOptions.None).ContinueWith(antecedent =>
            {
                if (antecedent.IsCompletedSuccessfully)
                {
                    var shadowCopyPlotTask = new PlotTask()
                    {
                        plot_filename = item.plot_filename,
                        tmpDir1 = item.tmpDir1,
                        finalDir = item.finalDir,
                        useInternalCopy = item.useInternalCopy,
                        copyOnSeparatedTask = item.copyOnSeparatedTask,
                        
                    };


                    handleFileCopy(shadowCopyPlotTask);

                    if (cbContinuousMode.Checked)
                    {
                        item.status = TaskStatus.AwaitingRestart;
                        RestartPlottingTask(item);
                    }
                    else
                    {
                        item.status = TaskStatus.Completed;
                        CompletePlottingTask(item);
                    }
                }
            });
        }

        private void StartPlottingTask(PlotTask item)
        {
            item.status = TaskStatus.NotStarted;

            var task = System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                try
                {
                    var pStartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        WorkingDirectory = checkEndSlash(AppDomain.CurrentDomain.BaseDirectory) + @"madMax\",
                        Arguments = "/C " + "chia_plot.exe " + item.cmdString,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    };

                    if (checkChiaPlotter(pStartInfo.WorkingDirectory + "chia_plot.exe"))
                    {
                        using (item.process = new Process())
                        {
                            item.process.StartInfo = pStartInfo;

                            item.process.EnableRaisingEvents = true;

                            item.process.Start();
                            /*item.process.StandardInput.WriteLine("chia_plot.exe " + item.cmdString);
                            item.process.StandardInput.AutoFlush = true;*/

                            item.process.OutputDataReceived += new DataReceivedEventHandler((sender, e) => { item.outputProcessor(e.Data, dgvPlotTasks); });

                            item.process.ErrorDataReceived += (object sendingProcess, DataReceivedEventArgs outline) => { item.errorProcessor(outline.Data); };

                            item.process.BeginOutputReadLine();
                            item.process.BeginErrorReadLine();

                            bool waitforchia_plotter_process = true;
                            var initialTme = DateTime.Now;

                            System.Threading.Thread.Sleep(500);

                            while (waitforchia_plotter_process)
                            {
                                var currentTime = DateTime.Now;
                                TimeSpan elapsed = currentTime - initialTme;
                                if (elapsed.Seconds > 10)
                                {
                                    waitforchia_plotter_process = false;
                                    // process failed to start under 10 seconds
                                    Log(new List<string>() { item.output });
                                    toolStripStatusLabel.Text = "Last message: Unable to start chia plot process. See log file for details";
                                }
                                var childprocs = item.process.GetChildProcesses();
                                try
                                {
                                    if ((childprocs.Count() > 0) && (childprocs.Where(p => p.ProcessName == "chia_plot").Count() > 0))
                                        waitforchia_plotter_process = false;
                                }
                                catch (Exception ex)
                                {
                                    waitforchia_plotter_process = false;
                                }
                            }
                            item.status = TaskStatus.Running;

                            if (!item.process.HasExited)
                                foreach (Process childProcess in item.process.GetChildProcesses())
                                {
                                    if ((childProcess.ProcessName == "chia_plot") && (!childProcess.HasExited))
                                    {
                                        childProcess.PriorityClass = ProcessPriorityClass.High;
                                        SetHighIOPriority(childProcess);
                                    }
                                }
                            item.process.WaitForExit();
                        }
                    } else
                    {
                        
                        toolStripStatusLabel.Text = "Invalid chia plotter";
                        Log(new List<string>() { toolStripStatusLabel.Text });
                    }
                }
                catch (Exception ex)
                {
                    Log(new List<string>() { ex.Message, ex.InnerException.Message, ex.StackTrace + "\r\n" });
                }

            }, TaskCreationOptions.None).ContinueWith(antecedent =>
            {
                if (antecedent.IsCompletedSuccessfully)
                {

                    var shadowCopyPlotTask = new PlotTask()
                    {
                        plot_filename = item.plot_filename,
                        tmpDir1 = item.tmpDir1,
                        finalDir = item.finalDir,
                        useInternalCopy = item.useInternalCopy,
                        copyOnSeparatedTask = item.copyOnSeparatedTask,
                    };


                    handleFileCopy(shadowCopyPlotTask);

                    if (cbContinuousMode.Checked)
                    {
                        item.status = TaskStatus.AwaitingRestart;
                        RestartPlottingTask(item);
                    }
                    else
                    {
                        item.status = TaskStatus.Completed;
                        CompletePlottingTask(item);
                    }
                }
            });
        }

        private void StartPlottingAllTasks(List<PlotTask> tasks)
        {
            toolStripStatusLabel.Text = "Running..";
            foreach (var item in tasks)
            {
                StartPlottingTask(item);
            }
            InitPlotTasksTimer();
        }

        private string createCommand(PlotTask pTask)
        {
            string cmd;

            cmd = " -n 1" + (!String.IsNullOrEmpty(pTask.threads) ? " -r " + pTask.threads : String.Empty) +
                (!String.IsNullOrEmpty(pTask.buckets) ? " -u " + pTask.buckets : String.Empty) +
                (!String.IsNullOrEmpty(pTask.buckets34) ? " -v " + pTask.buckets34 : String.Empty) +
                " -t " + formatPath(pTask.tmpDir1) +
                (String.IsNullOrEmpty(pTask.tmpDir2) ? String.Empty : " -2 " + formatPath(pTask.tmpDir2)) + " -f " + pTask.farmerKey;

                var condCmd = " -p " + pTask.poolKey;

                if ((!String.IsNullOrEmpty(pTask.contractAddress)) && (pTask.contractAddress.Length==contractAddressMaxLength))
                {
                    condCmd = " -c " + pTask.contractAddress;
                }
                cmd += condCmd;
                // cmd += (!pTask.copyOnSeparatedTask && !pTask.useInternalCopy ? " -d " + formatPath(pTask.finalDir) : String.Empty);
            return cmd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plotTasks.First().process.GetChildProcesses().Where(p => p.ProcessName.ToLowerInvariant().StartsWith("chia_plot")).FirstOrDefault().Suspend();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plotTasks.First().process.GetChildProcesses().Where(p => p.ProcessName.ToLowerInvariant().StartsWith("chia_plot")).FirstOrDefault().Resume();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var config = new Dictionary<string, object>();

            var finalDirList = new List<string>();

            config.Add("tmpDir1",tmpPath_1);
            config.Add("tmpDir2", tmpPath_2);

            finalDirList = dgvFinalDrives.Rows.OfType<DataGridViewRow>().Where(x => x.Cells["Path"].Value != null).Select(x => x.Cells["Path"].Value.ToString()).ToList();

            config.Add("finalDirs", (finalDirList.Count>0 ? finalDirList : new List<string>() { "-" }));

            config.Add("poolkey", txPoolKey);
            config.Add("farmerkey", txFarmerKey);
            config.Add("contractaddress", txContractAddress);


        }
    }
}
