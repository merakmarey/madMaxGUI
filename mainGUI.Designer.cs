
namespace madMaxGUI
{
    partial class mainGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lbFinal1AvailSpace = new System.Windows.Forms.Label();
            this.lbTmp2AvailSpace = new System.Windows.Forms.Label();
            this.lbTmp1AvailSpace = new System.Windows.Forms.Label();
            this.cbAlternateStorage = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFinalDest1Pick = new System.Windows.Forms.Button();
            this.lbFinalDest1_currentPath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTmpPath2_currentPath = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTmpPath2Pick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTmpPath1_currentPath = new System.Windows.Forms.Label();
            this.lbtmpPath1CurrentPath = new System.Windows.Forms.Label();
            this.btnTmpPath1Pick = new System.Windows.Forms.Button();
            this.lbTmpPath1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbKeys = new System.Windows.Forms.GroupBox();
            this.btnAutoGetKeys = new System.Windows.Forms.Button();
            this.lbPlKeyIndicator = new System.Windows.Forms.Label();
            this.lbFmKIndicator = new System.Windows.Forms.Label();
            this.txPoolKey = new System.Windows.Forms.TextBox();
            this.lbPoolKey = new System.Windows.Forms.Label();
            this.txFarmerKey = new System.Windows.Forms.TextBox();
            this.lbFarmerKey = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCPUusage = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbFreeRAM = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbCPUCount = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCores = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbLogicalCPUs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProcessor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lbPlotCountSuggested = new System.Windows.Forms.Label();
            this.cbBuckets34 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbBuckets = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbThreadsSuggested = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.nudPlotCount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeElapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbPaths.SuspendLayout();
            this.gbKeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlotCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.AutoSize = true;
            this.gbPaths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPaths.Controls.Add(this.label23);
            this.gbPaths.Controls.Add(this.lbFinal1AvailSpace);
            this.gbPaths.Controls.Add(this.lbTmp2AvailSpace);
            this.gbPaths.Controls.Add(this.lbTmp1AvailSpace);
            this.gbPaths.Controls.Add(this.cbAlternateStorage);
            this.gbPaths.Controls.Add(this.label11);
            this.gbPaths.Controls.Add(this.label10);
            this.gbPaths.Controls.Add(this.button3);
            this.gbPaths.Controls.Add(this.label9);
            this.gbPaths.Controls.Add(this.btnFinalDest1Pick);
            this.gbPaths.Controls.Add(this.lbFinalDest1_currentPath);
            this.gbPaths.Controls.Add(this.label5);
            this.gbPaths.Controls.Add(this.label4);
            this.gbPaths.Controls.Add(this.lbTmpPath2_currentPath);
            this.gbPaths.Controls.Add(this.checkBox1);
            this.gbPaths.Controls.Add(this.label2);
            this.gbPaths.Controls.Add(this.btnTmpPath2Pick);
            this.gbPaths.Controls.Add(this.label1);
            this.gbPaths.Controls.Add(this.lbTmpPath1_currentPath);
            this.gbPaths.Controls.Add(this.lbtmpPath1CurrentPath);
            this.gbPaths.Controls.Add(this.btnTmpPath1Pick);
            this.gbPaths.Controls.Add(this.lbTmpPath1);
            this.gbPaths.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbPaths.Location = new System.Drawing.Point(10, 120);
            this.gbPaths.Margin = new System.Windows.Forms.Padding(0);
            this.gbPaths.MinimumSize = new System.Drawing.Size(640, 80);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Padding = new System.Windows.Forms.Padding(10);
            this.gbPaths.Size = new System.Drawing.Size(640, 236);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "2.- Paths";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(419, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(150, 15);
            this.label23.TabIndex = 21;
            this.label23.Text = "(Space Available 0GB/0GiB)";
            // 
            // lbFinal1AvailSpace
            // 
            this.lbFinal1AvailSpace.AutoSize = true;
            this.lbFinal1AvailSpace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFinal1AvailSpace.Location = new System.Drawing.Point(349, 122);
            this.lbFinal1AvailSpace.Name = "lbFinal1AvailSpace";
            this.lbFinal1AvailSpace.Size = new System.Drawing.Size(150, 15);
            this.lbFinal1AvailSpace.TabIndex = 20;
            this.lbFinal1AvailSpace.Text = "(Space Available 0GB/0GiB)";
            // 
            // lbTmp2AvailSpace
            // 
            this.lbTmp2AvailSpace.AutoSize = true;
            this.lbTmp2AvailSpace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTmp2AvailSpace.Location = new System.Drawing.Point(328, 69);
            this.lbTmp2AvailSpace.Name = "lbTmp2AvailSpace";
            this.lbTmp2AvailSpace.Size = new System.Drawing.Size(150, 15);
            this.lbTmp2AvailSpace.TabIndex = 19;
            this.lbTmp2AvailSpace.Text = "(Space Available 0GB/0GiB)";
            // 
            // lbTmp1AvailSpace
            // 
            this.lbTmp1AvailSpace.AutoSize = true;
            this.lbTmp1AvailSpace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTmp1AvailSpace.Location = new System.Drawing.Point(245, 22);
            this.lbTmp1AvailSpace.Name = "lbTmp1AvailSpace";
            this.lbTmp1AvailSpace.Size = new System.Drawing.Size(150, 15);
            this.lbTmp1AvailSpace.TabIndex = 18;
            this.lbTmp1AvailSpace.Text = "(Space Available 0GB/0GiB)";
            // 
            // cbAlternateStorage
            // 
            this.cbAlternateStorage.AutoSize = true;
            this.cbAlternateStorage.Location = new System.Drawing.Point(349, 172);
            this.cbAlternateStorage.Name = "cbAlternateStorage";
            this.cbAlternateStorage.Size = new System.Drawing.Size(64, 19);
            this.cbAlternateStorage.TabIndex = 17;
            this.cbAlternateStorage.Text = "Disable";
            this.cbAlternateStorage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(96, 195);
            this.label11.MaximumSize = new System.Drawing.Size(500, 0);
            this.label11.MinimumSize = new System.Drawing.Size(500, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(500, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "(none)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Current path:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Final Alternative destination (Slow Big Storage)";
            // 
            // btnFinalDest1Pick
            // 
            this.btnFinalDest1Pick.Location = new System.Drawing.Point(267, 118);
            this.btnFinalDest1Pick.Name = "btnFinalDest1Pick";
            this.btnFinalDest1Pick.Size = new System.Drawing.Size(75, 23);
            this.btnFinalDest1Pick.TabIndex = 12;
            this.btnFinalDest1Pick.Text = "Select";
            this.btnFinalDest1Pick.UseVisualStyleBackColor = true;
            this.btnFinalDest1Pick.Click += new System.EventHandler(this.btnFinalDest1Pick_Click);
            // 
            // lbFinalDest1_currentPath
            // 
            this.lbFinalDest1_currentPath.AutoSize = true;
            this.lbFinalDest1_currentPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbFinalDest1_currentPath.Location = new System.Drawing.Point(96, 146);
            this.lbFinalDest1_currentPath.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbFinalDest1_currentPath.MinimumSize = new System.Drawing.Size(500, 0);
            this.lbFinalDest1_currentPath.Name = "lbFinalDest1_currentPath";
            this.lbFinalDest1_currentPath.Size = new System.Drawing.Size(500, 15);
            this.lbFinalDest1_currentPath.TabIndex = 11;
            this.lbFinalDest1_currentPath.Text = "(none)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final destination (Slow Big Storage)";
            // 
            // lbTmpPath2_currentPath
            // 
            this.lbTmpPath2_currentPath.AutoSize = true;
            this.lbTmpPath2_currentPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTmpPath2_currentPath.Location = new System.Drawing.Point(96, 93);
            this.lbTmpPath2_currentPath.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbTmpPath2_currentPath.MinimumSize = new System.Drawing.Size(500, 0);
            this.lbTmpPath2_currentPath.Name = "lbTmpPath2_currentPath";
            this.lbTmpPath2_currentPath.Size = new System.Drawing.Size(500, 15);
            this.lbTmpPath2_currentPath.TabIndex = 8;
            this.lbTmpPath2_currentPath.Text = "(none)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(258, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Disable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current path:";
            // 
            // btnTmpPath2Pick
            // 
            this.btnTmpPath2Pick.Location = new System.Drawing.Point(164, 65);
            this.btnTmpPath2Pick.Name = "btnTmpPath2Pick";
            this.btnTmpPath2Pick.Size = new System.Drawing.Size(75, 23);
            this.btnTmpPath2Pick.TabIndex = 5;
            this.btnTmpPath2Pick.Text = "Select";
            this.btnTmpPath2Pick.UseVisualStyleBackColor = true;
            this.btnTmpPath2Pick.Click += new System.EventHandler(this.btnTmpPath2Pick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tmp Path # 2 (RAM Disk)";
            // 
            // lbTmpPath1_currentPath
            // 
            this.lbTmpPath1_currentPath.AutoSize = true;
            this.lbTmpPath1_currentPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTmpPath1_currentPath.Location = new System.Drawing.Point(96, 44);
            this.lbTmpPath1_currentPath.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbTmpPath1_currentPath.MinimumSize = new System.Drawing.Size(500, 0);
            this.lbTmpPath1_currentPath.Name = "lbTmpPath1_currentPath";
            this.lbTmpPath1_currentPath.Size = new System.Drawing.Size(500, 15);
            this.lbTmpPath1_currentPath.TabIndex = 3;
            this.lbTmpPath1_currentPath.Text = "(none)";
            // 
            // lbtmpPath1CurrentPath
            // 
            this.lbtmpPath1CurrentPath.AutoSize = true;
            this.lbtmpPath1CurrentPath.Location = new System.Drawing.Point(13, 44);
            this.lbtmpPath1CurrentPath.Name = "lbtmpPath1CurrentPath";
            this.lbtmpPath1CurrentPath.Size = new System.Drawing.Size(77, 15);
            this.lbtmpPath1CurrentPath.TabIndex = 2;
            this.lbtmpPath1CurrentPath.Text = "Current path:";
            // 
            // btnTmpPath1Pick
            // 
            this.btnTmpPath1Pick.Location = new System.Drawing.Point(164, 18);
            this.btnTmpPath1Pick.Name = "btnTmpPath1Pick";
            this.btnTmpPath1Pick.Size = new System.Drawing.Size(75, 23);
            this.btnTmpPath1Pick.TabIndex = 1;
            this.btnTmpPath1Pick.Text = "Select";
            this.btnTmpPath1Pick.UseVisualStyleBackColor = true;
            this.btnTmpPath1Pick.Click += new System.EventHandler(this.btnTmpPath1Pick_Click);
            // 
            // lbTmpPath1
            // 
            this.lbTmpPath1.AutoSize = true;
            this.lbTmpPath1.Location = new System.Drawing.Point(8, 22);
            this.lbTmpPath1.Name = "lbTmpPath1";
            this.lbTmpPath1.Size = new System.Drawing.Size(145, 15);
            this.lbTmpPath1.TabIndex = 0;
            this.lbTmpPath1.Text = "Tmp Path # 1 (SSD/NVME)";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // gbKeys
            // 
            this.gbKeys.Controls.Add(this.btnAutoGetKeys);
            this.gbKeys.Controls.Add(this.lbPlKeyIndicator);
            this.gbKeys.Controls.Add(this.lbFmKIndicator);
            this.gbKeys.Controls.Add(this.txPoolKey);
            this.gbKeys.Controls.Add(this.lbPoolKey);
            this.gbKeys.Controls.Add(this.txFarmerKey);
            this.gbKeys.Controls.Add(this.lbFarmerKey);
            this.gbKeys.Location = new System.Drawing.Point(10, 14);
            this.gbKeys.Name = "gbKeys";
            this.gbKeys.Size = new System.Drawing.Size(640, 103);
            this.gbKeys.TabIndex = 1;
            this.gbKeys.TabStop = false;
            this.gbKeys.Text = "1.- Keys";
            // 
            // btnAutoGetKeys
            // 
            this.btnAutoGetKeys.Location = new System.Drawing.Point(556, 22);
            this.btnAutoGetKeys.Name = "btnAutoGetKeys";
            this.btnAutoGetKeys.Size = new System.Drawing.Size(75, 23);
            this.btnAutoGetKeys.TabIndex = 6;
            this.btnAutoGetKeys.Text = "AutoGet";
            this.btnAutoGetKeys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutoGetKeys.UseVisualStyleBackColor = true;
            this.btnAutoGetKeys.Click += new System.EventHandler(this.btnAutoGetKeys_Click);
            // 
            // lbPlKeyIndicator
            // 
            this.lbPlKeyIndicator.AutoSize = true;
            this.lbPlKeyIndicator.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbPlKeyIndicator.Location = new System.Drawing.Point(531, 69);
            this.lbPlKeyIndicator.Name = "lbPlKeyIndicator";
            this.lbPlKeyIndicator.Size = new System.Drawing.Size(19, 15);
            this.lbPlKeyIndicator.TabIndex = 5;
            this.lbPlKeyIndicator.Text = "☻";
            // 
            // lbFmKIndicator
            // 
            this.lbFmKIndicator.AutoSize = true;
            this.lbFmKIndicator.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbFmKIndicator.Location = new System.Drawing.Point(531, 26);
            this.lbFmKIndicator.Name = "lbFmKIndicator";
            this.lbFmKIndicator.Size = new System.Drawing.Size(19, 15);
            this.lbFmKIndicator.TabIndex = 4;
            this.lbFmKIndicator.Text = "☻";
            // 
            // txPoolKey
            // 
            this.txPoolKey.Location = new System.Drawing.Point(86, 66);
            this.txPoolKey.Name = "txPoolKey";
            this.txPoolKey.Size = new System.Drawing.Size(439, 23);
            this.txPoolKey.TabIndex = 3;
            this.txPoolKey.TextChanged += new System.EventHandler(this.lbPlKIndicator_Changed);
            // 
            // lbPoolKey
            // 
            this.lbPoolKey.AutoSize = true;
            this.lbPoolKey.Location = new System.Drawing.Point(14, 69);
            this.lbPoolKey.Name = "lbPoolKey";
            this.lbPoolKey.Size = new System.Drawing.Size(53, 15);
            this.lbPoolKey.TabIndex = 2;
            this.lbPoolKey.Text = "Pool Key";
            // 
            // txFarmerKey
            // 
            this.txFarmerKey.Location = new System.Drawing.Point(86, 23);
            this.txFarmerKey.Name = "txFarmerKey";
            this.txFarmerKey.Size = new System.Drawing.Size(439, 23);
            this.txFarmerKey.TabIndex = 1;
            this.txFarmerKey.TextChanged += new System.EventHandler(this.lbFmKIndicator_Changed);
            // 
            // lbFarmerKey
            // 
            this.lbFarmerKey.AutoSize = true;
            this.lbFarmerKey.Location = new System.Drawing.Point(14, 26);
            this.lbFarmerKey.Name = "lbFarmerKey";
            this.lbFarmerKey.Size = new System.Drawing.Size(66, 15);
            this.lbFarmerKey.TabIndex = 0;
            this.lbFarmerKey.Text = "Farmer Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCPUusage);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lbFreeRAM);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lbCPUCount);
            this.groupBox1.Controls.Add(this.lbRAM);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbCores);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbLogicalCPUs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbProcessor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(656, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            // 
            // lbCPUusage
            // 
            this.lbCPUusage.AutoSize = true;
            this.lbCPUusage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCPUusage.Location = new System.Drawing.Point(121, 67);
            this.lbCPUusage.Name = "lbCPUusage";
            this.lbCPUusage.Size = new System.Drawing.Size(23, 15);
            this.lbCPUusage.TabIndex = 13;
            this.lbCPUusage.Text = "0%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "CPU Usage";
            // 
            // lbFreeRAM
            // 
            this.lbFreeRAM.AutoSize = true;
            this.lbFreeRAM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbFreeRAM.Location = new System.Drawing.Point(260, 50);
            this.lbFreeRAM.Name = "lbFreeRAM";
            this.lbFreeRAM.Size = new System.Drawing.Size(28, 15);
            this.lbFreeRAM.TabIndex = 11;
            this.lbFreeRAM.Text = "0GB";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(170, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "Free RAM (GB)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(136, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = " x ";
            // 
            // lbCPUCount
            // 
            this.lbCPUCount.AutoSize = true;
            this.lbCPUCount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCPUCount.Location = new System.Drawing.Point(121, 19);
            this.lbCPUCount.Name = "lbCPUCount";
            this.lbCPUCount.Size = new System.Drawing.Size(19, 15);
            this.lbCPUCount.TabIndex = 8;
            this.lbCPUCount.Text = "00";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbRAM.Location = new System.Drawing.Point(121, 50);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(34, 15);
            this.lbRAM.TabIndex = 7;
            this.lbRAM.Text = "none";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total RAM (GB)";
            // 
            // lbCores
            // 
            this.lbCores.AutoSize = true;
            this.lbCores.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCores.Location = new System.Drawing.Point(121, 34);
            this.lbCores.Name = "lbCores";
            this.lbCores.Size = new System.Drawing.Size(34, 15);
            this.lbCores.TabIndex = 5;
            this.lbCores.Text = "none";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cores";
            // 
            // lbLogicalCPUs
            // 
            this.lbLogicalCPUs.AutoSize = true;
            this.lbLogicalCPUs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbLogicalCPUs.Location = new System.Drawing.Point(282, 34);
            this.lbLogicalCPUs.Name = "lbLogicalCPUs";
            this.lbLogicalCPUs.Size = new System.Drawing.Size(34, 15);
            this.lbLogicalCPUs.TabIndex = 3;
            this.lbLogicalCPUs.Text = "none";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Maximum Threads";
            // 
            // lbProcessor
            // 
            this.lbProcessor.AutoSize = true;
            this.lbProcessor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbProcessor.Location = new System.Drawing.Point(155, 18);
            this.lbProcessor.Name = "lbProcessor";
            this.lbProcessor.Size = new System.Drawing.Size(34, 15);
            this.lbProcessor.TabIndex = 1;
            this.lbProcessor.Text = "none";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Processor";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lbPlotCountSuggested);
            this.gbOptions.Controls.Add(this.cbBuckets34);
            this.gbOptions.Controls.Add(this.label19);
            this.gbOptions.Controls.Add(this.cbBuckets);
            this.gbOptions.Controls.Add(this.label18);
            this.gbOptions.Controls.Add(this.lbThreadsSuggested);
            this.gbOptions.Controls.Add(this.checkBox2);
            this.gbOptions.Controls.Add(this.nudPlotCount);
            this.gbOptions.Controls.Add(this.label15);
            this.gbOptions.Controls.Add(this.numericUpDown1);
            this.gbOptions.Controls.Add(this.label14);
            this.gbOptions.Location = new System.Drawing.Point(656, 124);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(387, 187);
            this.gbOptions.TabIndex = 3;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "3.- Options";
            // 
            // lbPlotCountSuggested
            // 
            this.lbPlotCountSuggested.AutoSize = true;
            this.lbPlotCountSuggested.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbPlotCountSuggested.Location = new System.Drawing.Point(144, 25);
            this.lbPlotCountSuggested.Name = "lbPlotCountSuggested";
            this.lbPlotCountSuggested.Size = new System.Drawing.Size(85, 15);
            this.lbPlotCountSuggested.TabIndex = 10;
            this.lbPlotCountSuggested.Text = "(Suggested : 0)";
            // 
            // cbBuckets34
            // 
            this.cbBuckets34.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBuckets34.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBuckets34.DisplayMember = "1";
            this.cbBuckets34.FormattingEnabled = true;
            this.cbBuckets34.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512"});
            this.cbBuckets34.Location = new System.Drawing.Point(112, 118);
            this.cbBuckets34.Name = "cbBuckets34";
            this.cbBuckets34.Size = new System.Drawing.Size(59, 23);
            this.cbBuckets34.TabIndex = 9;
            this.cbBuckets34.Text = "256";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Buckets Phase3/4";
            // 
            // cbBuckets
            // 
            this.cbBuckets.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBuckets.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBuckets.DisplayMember = "1";
            this.cbBuckets.FormattingEnabled = true;
            this.cbBuckets.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512"});
            this.cbBuckets.Location = new System.Drawing.Point(112, 89);
            this.cbBuckets.Name = "cbBuckets";
            this.cbBuckets.Size = new System.Drawing.Size(59, 23);
            this.cbBuckets.TabIndex = 7;
            this.cbBuckets.Text = "256";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Buckets";
            // 
            // lbThreadsSuggested
            // 
            this.lbThreadsSuggested.AutoSize = true;
            this.lbThreadsSuggested.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbThreadsSuggested.Location = new System.Drawing.Point(144, 54);
            this.lbThreadsSuggested.Name = "lbThreadsSuggested";
            this.lbThreadsSuggested.Size = new System.Drawing.Size(85, 15);
            this.lbThreadsSuggested.TabIndex = 5;
            this.lbThreadsSuggested.Text = "(Suggested : 0)";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(260, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Continuos mode";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // nudPlotCount
            // 
            this.nudPlotCount.Location = new System.Drawing.Point(78, 23);
            this.nudPlotCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlotCount.Name = "nudPlotCount";
            this.nudPlotCount.Size = new System.Drawing.Size(59, 23);
            this.nudPlotCount.TabIndex = 3;
            this.nudPlotCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Plot Count";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(78, 52);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Threads";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plotting tasks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Phase,
            this.TimeElapsed,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(10, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // Phase
            // 
            this.Phase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phase.HeaderText = "Phase";
            this.Phase.Name = "Phase";
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeElapsed.HeaderText = "Time Elapsed";
            this.TimeElapsed.Name = "TimeElapsed";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(897, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 41);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Tasks";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 519);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKeys);
            this.Controls.Add(this.gbPaths);
            this.Name = "mainGUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "mainGUI";
            this.Load += new System.EventHandler(this.mainGUI_Load);
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbKeys.ResumeLayout(false);
            this.gbKeys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlotCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnTmpPath1Pick;
        private System.Windows.Forms.Label lbTmpPath1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbTmpPath1_currentPath;
        private System.Windows.Forms.Label lbtmpPath1CurrentPath;
        private System.Windows.Forms.Label lbTmpPath2_currentPath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTmpPath2Pick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalDest1Pick;
        private System.Windows.Forms.Label lbFinalDest1_currentPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbKeys;
        private System.Windows.Forms.Label lbFmKIndicator;
        private System.Windows.Forms.TextBox txPoolKey;
        private System.Windows.Forms.Label lbPoolKey;
        private System.Windows.Forms.TextBox txFarmerKey;
        private System.Windows.Forms.Label lbFarmerKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPlKeyIndicator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAutoGetKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbProcessor;
        private System.Windows.Forms.Label lbLogicalCPUs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbAlternateStorage;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lbRAM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbCPUCount;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown nudPlotCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbBuckets;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbThreadsSuggested;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbBuckets34;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbFreeRAM;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbCPUusage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phase;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeElapsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbFinal1AvailSpace;
        private System.Windows.Forms.Label lbTmp2AvailSpace;
        private System.Windows.Forms.Label lbTmp1AvailSpace;
        private System.Windows.Forms.Label lbPlotCountSuggested;
    }
}

