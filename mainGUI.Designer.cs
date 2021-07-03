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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.btnClearTmp2 = new System.Windows.Forms.Button();
            this.btnRemoveDrives = new System.Windows.Forms.Button();
            this.gvFinalDrives = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTmp2AvailSpace = new System.Windows.Forms.Label();
            this.lbTmp1AvailSpace = new System.Windows.Forms.Label();
            this.btnFinalDest1Pick = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTmpPath2_currentPath = new System.Windows.Forms.Label();
            this.cbAlternate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTmpPath2Pick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTmpPath1_currentPath = new System.Windows.Forms.Label();
            this.lbtmpPath1CurrentPath = new System.Windows.Forms.Label();
            this.btnTmpPath1Pick = new System.Windows.Forms.Button();
            this.lbTmpPath1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbKeys = new System.Windows.Forms.GroupBox();
            this.lbAutoWorking = new System.Windows.Forms.Label();
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
            this.lbThreads = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProcessor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbValidatePlot = new System.Windows.Forms.CheckBox();
            this.cbInternalCopy = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSeparatedTaskCopy = new System.Windows.Forms.CheckBox();
            this.lbPlotCountSuggested = new System.Windows.Forms.Label();
            this.cbBuckets34 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbBuckets = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbThreadsSuggested = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.nudPlotCount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPlotTasks = new System.Windows.Forms.DataGridView();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeElapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbPaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFinalDrives)).BeginInit();
            this.gbKeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlotCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlotTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPaths.Controls.Add(this.btnClearTmp2);
            this.gbPaths.Controls.Add(this.btnRemoveDrives);
            this.gbPaths.Controls.Add(this.gvFinalDrives);
            this.gbPaths.Controls.Add(this.lbTmp2AvailSpace);
            this.gbPaths.Controls.Add(this.lbTmp1AvailSpace);
            this.gbPaths.Controls.Add(this.btnFinalDest1Pick);
            this.gbPaths.Controls.Add(this.label4);
            this.gbPaths.Controls.Add(this.lbTmpPath2_currentPath);
            this.gbPaths.Controls.Add(this.cbAlternate);
            this.gbPaths.Controls.Add(this.label2);
            this.gbPaths.Controls.Add(this.btnTmpPath2Pick);
            this.gbPaths.Controls.Add(this.label1);
            this.gbPaths.Controls.Add(this.lbTmpPath1_currentPath);
            this.gbPaths.Controls.Add(this.lbtmpPath1CurrentPath);
            this.gbPaths.Controls.Add(this.btnTmpPath1Pick);
            this.gbPaths.Controls.Add(this.lbTmpPath1);
            this.gbPaths.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbPaths.Location = new System.Drawing.Point(10, 90);
            this.gbPaths.Margin = new System.Windows.Forms.Padding(0);
            this.gbPaths.MinimumSize = new System.Drawing.Size(640, 80);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Padding = new System.Windows.Forms.Padding(10);
            this.gbPaths.Size = new System.Drawing.Size(640, 262);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "2.- Paths";
            // 
            // btnClearTmp2
            // 
            this.btnClearTmp2.Location = new System.Drawing.Point(245, 65);
            this.btnClearTmp2.Name = "btnClearTmp2";
            this.btnClearTmp2.Size = new System.Drawing.Size(75, 23);
            this.btnClearTmp2.TabIndex = 22;
            this.btnClearTmp2.Text = "Clear";
            this.btnClearTmp2.UseVisualStyleBackColor = true;
            this.btnClearTmp2.Click += new System.EventHandler(this.btnClearTmp2_Click);
            // 
            // btnRemoveDrives
            // 
            this.btnRemoveDrives.Location = new System.Drawing.Point(303, 110);
            this.btnRemoveDrives.Name = "btnRemoveDrives";
            this.btnRemoveDrives.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDrives.TabIndex = 21;
            this.btnRemoveDrives.Text = "Remove";
            this.btnRemoveDrives.UseVisualStyleBackColor = true;
            this.btnRemoveDrives.Click += new System.EventHandler(this.btnRemoveDrives_Click);
            // 
            // gvFinalDrives
            // 
            this.gvFinalDrives.AllowUserToAddRows = false;
            this.gvFinalDrives.AllowUserToResizeRows = false;
            this.gvFinalDrives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFinalDrives.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFinalDrives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvFinalDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFinalDrives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.Space});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFinalDrives.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFinalDrives.Location = new System.Drawing.Point(10, 137);
            this.gvFinalDrives.Name = "gvFinalDrives";
            this.gvFinalDrives.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFinalDrives.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvFinalDrives.RowTemplate.Height = 25;
            this.gvFinalDrives.Size = new System.Drawing.Size(621, 112);
            this.gvFinalDrives.TabIndex = 20;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Space
            // 
            this.Space.HeaderText = "Space Available";
            this.Space.Name = "Space";
            this.Space.ReadOnly = true;
            // 
            // lbTmp2AvailSpace
            // 
            this.lbTmp2AvailSpace.AutoSize = true;
            this.lbTmp2AvailSpace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTmp2AvailSpace.Location = new System.Drawing.Point(422, 69);
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
            // btnFinalDest1Pick
            // 
            this.btnFinalDest1Pick.Location = new System.Drawing.Point(222, 111);
            this.btnFinalDest1Pick.Name = "btnFinalDest1Pick";
            this.btnFinalDest1Pick.Size = new System.Drawing.Size(75, 23);
            this.btnFinalDest1Pick.TabIndex = 12;
            this.btnFinalDest1Pick.Text = "Add";
            this.btnFinalDest1Pick.UseVisualStyleBackColor = true;
            this.btnFinalDest1Pick.Click += new System.EventHandler(this.btnFinalDest1Pick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final destination (Slower Big Storage)";
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
            // cbAlternate
            // 
            this.cbAlternate.AutoSize = true;
            this.cbAlternate.Location = new System.Drawing.Point(352, 68);
            this.cbAlternate.Name = "cbAlternate";
            this.cbAlternate.Size = new System.Drawing.Size(74, 19);
            this.cbAlternate.TabIndex = 7;
            this.cbAlternate.Text = "Alternate";
            this.cbAlternate.UseVisualStyleBackColor = true;
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
            this.gbKeys.Controls.Add(this.lbAutoWorking);
            this.gbKeys.Controls.Add(this.btnAutoGetKeys);
            this.gbKeys.Controls.Add(this.lbPlKeyIndicator);
            this.gbKeys.Controls.Add(this.lbFmKIndicator);
            this.gbKeys.Controls.Add(this.txPoolKey);
            this.gbKeys.Controls.Add(this.lbPoolKey);
            this.gbKeys.Controls.Add(this.txFarmerKey);
            this.gbKeys.Controls.Add(this.lbFarmerKey);
            this.gbKeys.Location = new System.Drawing.Point(10, 5);
            this.gbKeys.Name = "gbKeys";
            this.gbKeys.Size = new System.Drawing.Size(640, 82);
            this.gbKeys.TabIndex = 1;
            this.gbKeys.TabStop = false;
            this.gbKeys.Text = "1.- Keys";
            // 
            // lbAutoWorking
            // 
            this.lbAutoWorking.AutoSize = true;
            this.lbAutoWorking.ForeColor = System.Drawing.Color.Green;
            this.lbAutoWorking.Location = new System.Drawing.Point(574, 53);
            this.lbAutoWorking.Name = "lbAutoWorking";
            this.lbAutoWorking.Size = new System.Drawing.Size(39, 15);
            this.lbAutoWorking.TabIndex = 7;
            this.lbAutoWorking.Text = "Ready";
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
            this.lbPlKeyIndicator.Location = new System.Drawing.Point(531, 53);
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
            this.txPoolKey.Location = new System.Drawing.Point(86, 50);
            this.txPoolKey.Name = "txPoolKey";
            this.txPoolKey.Size = new System.Drawing.Size(439, 23);
            this.txPoolKey.TabIndex = 3;
            this.txPoolKey.TextChanged += new System.EventHandler(this.lbPlKIndicator_Changed);
            // 
            // lbPoolKey
            // 
            this.lbPoolKey.AutoSize = true;
            this.lbPoolKey.Location = new System.Drawing.Point(13, 53);
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
            this.groupBox1.Controls.Add(this.lbThreads);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbProcessor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(656, 5);
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
            // lbThreads
            // 
            this.lbThreads.AutoSize = true;
            this.lbThreads.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbThreads.Location = new System.Drawing.Point(312, 34);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(34, 15);
            this.lbThreads.TabIndex = 3;
            this.lbThreads.Text = "none";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Maximum Threads/Core";
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
            this.gbOptions.Controls.Add(this.label5);
            this.gbOptions.Controls.Add(this.cbValidatePlot);
            this.gbOptions.Controls.Add(this.cbInternalCopy);
            this.gbOptions.Controls.Add(this.label3);
            this.gbOptions.Controls.Add(this.cbSeparatedTaskCopy);
            this.gbOptions.Controls.Add(this.lbPlotCountSuggested);
            this.gbOptions.Controls.Add(this.cbBuckets34);
            this.gbOptions.Controls.Add(this.label19);
            this.gbOptions.Controls.Add(this.cbBuckets);
            this.gbOptions.Controls.Add(this.label18);
            this.gbOptions.Controls.Add(this.lbThreadsSuggested);
            this.gbOptions.Controls.Add(this.checkBox2);
            this.gbOptions.Controls.Add(this.nudPlotCount);
            this.gbOptions.Controls.Add(this.label15);
            this.gbOptions.Controls.Add(this.nudThreads);
            this.gbOptions.Controls.Add(this.label14);
            this.gbOptions.Location = new System.Drawing.Point(656, 115);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(387, 224);
            this.gbOptions.TabIndex = 3;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "3.- Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(20, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "(Only if Copy on separated Task is checked)";
            // 
            // cbValidatePlot
            // 
            this.cbValidatePlot.AutoSize = true;
            this.cbValidatePlot.Location = new System.Drawing.Point(7, 199);
            this.cbValidatePlot.Name = "cbValidatePlot";
            this.cbValidatePlot.Size = new System.Drawing.Size(147, 19);
            this.cbValidatePlot.TabIndex = 14;
            this.cbValidatePlot.Text = "Validate plot after copy";
            this.cbValidatePlot.UseVisualStyleBackColor = true;
            // 
            // cbInternalCopy
            // 
            this.cbInternalCopy.AutoSize = true;
            this.cbInternalCopy.Location = new System.Drawing.Point(6, 167);
            this.cbInternalCopy.Name = "cbInternalCopy";
            this.cbInternalCopy.Size = new System.Drawing.Size(219, 19);
            this.cbInternalCopy.TabIndex = 13;
            this.cbInternalCopy.Text = "Use internal Ultra Fast Copy function";
            this.cbInternalCopy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "(Beware If Continuos mode on, task will restart without waiting for copy to be \r\n" +
    "completed but plot file will remain on TmpDir1 until moved)";
            // 
            // cbSeparatedTaskCopy
            // 
            this.cbSeparatedTaskCopy.AutoSize = true;
            this.cbSeparatedTaskCopy.Location = new System.Drawing.Point(7, 118);
            this.cbSeparatedTaskCopy.Name = "cbSeparatedTaskCopy";
            this.cbSeparatedTaskCopy.Size = new System.Drawing.Size(234, 19);
            this.cbSeparatedTaskCopy.TabIndex = 11;
            this.cbSeparatedTaskCopy.Text = "Copy to destination on a separated task";
            this.cbSeparatedTaskCopy.UseVisualStyleBackColor = true;
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
            "default (=buckets)",
            "64",
            "128",
            "256",
            "512"});
            this.cbBuckets34.Location = new System.Drawing.Point(254, 89);
            this.cbBuckets34.Name = "cbBuckets34";
            this.cbBuckets34.Size = new System.Drawing.Size(121, 23);
            this.cbBuckets34.TabIndex = 9;
            this.cbBuckets34.Text = "default (=buckets)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(155, 92);
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
            "default (256)",
            "64",
            "128",
            "256",
            "512"});
            this.cbBuckets.Location = new System.Drawing.Point(58, 89);
            this.cbBuckets.Name = "cbBuckets";
            this.cbBuckets.Size = new System.Drawing.Size(91, 23);
            this.cbBuckets.TabIndex = 7;
            this.cbBuckets.Text = "default (256)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 93);
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
            this.nudPlotCount.ValueChanged += new System.EventHandler(this.nudPlotCount_Changed);
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
            // nudThreads
            // 
            this.nudThreads.Location = new System.Drawing.Point(78, 52);
            this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(59, 23);
            this.nudThreads.TabIndex = 1;
            this.nudThreads.Value = new decimal(new int[] {
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
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dgvPlotTasks);
            this.groupBox2.Location = new System.Drawing.Point(10, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1033, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plotting tasks";
            // 
            // dgvPlotTasks
            // 
            this.dgvPlotTasks.AllowUserToAddRows = false;
            this.dgvPlotTasks.AllowUserToDeleteRows = false;
            this.dgvPlotTasks.AllowUserToResizeColumns = false;
            this.dgvPlotTasks.AllowUserToResizeRows = false;
            this.dgvPlotTasks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPlotTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlotTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plot,
            this.LastMessage,
            this.TimeElapsed,
            this.Status,
            this.Output});
            this.dgvPlotTasks.EnableHeadersVisualStyles = false;
            this.dgvPlotTasks.Location = new System.Drawing.Point(10, 22);
            this.dgvPlotTasks.Name = "dgvPlotTasks";
            this.dgvPlotTasks.RowTemplate.Height = 25;
            this.dgvPlotTasks.Size = new System.Drawing.Size(1014, 180);
            this.dgvPlotTasks.TabIndex = 0;
            this.dgvPlotTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlotTasks_CellContentClick);
            // 
            // Plot
            // 
            this.Plot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            // 
            // LastMessage
            // 
            this.LastMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastMessage.HeaderText = "Last Message";
            this.LastMessage.Name = "LastMessage";
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
            // Output
            // 
            this.Output.HeaderText = "Output";
            this.Output.Name = "Output";
            this.Output.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Output.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Output.Text = "Open";
            this.Output.ToolTipText = "Open full output transcript on separated window";
            this.Output.UseColumnTextForButtonValue = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(903, 343);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 25);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Tasks";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 576);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKeys);
            this.Controls.Add(this.gbPaths);
            this.Name = "mainGUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "mainGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGUI_FormClosing);
            this.Load += new System.EventHandler(this.mainGUI_Load);
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFinalDrives)).EndInit();
            this.gbKeys.ResumeLayout(false);
            this.gbKeys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlotCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlotTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnTmpPath1Pick;
        private System.Windows.Forms.Label lbTmpPath1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbTmpPath1_currentPath;
        private System.Windows.Forms.Label lbtmpPath1CurrentPath;
        private System.Windows.Forms.Label lbTmpPath2_currentPath;
        private System.Windows.Forms.CheckBox cbAlternate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTmpPath2Pick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalDest1Pick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbKeys;
        private System.Windows.Forms.Label lbFmKIndicator;
        private System.Windows.Forms.TextBox txPoolKey;
        private System.Windows.Forms.Label lbPoolKey;
        private System.Windows.Forms.TextBox txFarmerKey;
        private System.Windows.Forms.Label lbFarmerKey;
        private System.Windows.Forms.Label lbPlKeyIndicator;
        private System.Windows.Forms.Button btnAutoGetKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbProcessor;
        private System.Windows.Forms.Label lbThreads;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lbRAM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudThreads;
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
        private System.Windows.Forms.DataGridView dgvPlotTasks;
        private System.Windows.Forms.Label lbTmp2AvailSpace;
        private System.Windows.Forms.Label lbTmp1AvailSpace;
        private System.Windows.Forms.Label lbPlotCountSuggested;
        private System.Windows.Forms.DataGridView gvFinalDrives;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Space;
        private System.Windows.Forms.Button btnRemoveDrives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSeparatedTaskCopy;
        private System.Windows.Forms.CheckBox cbInternalCopy;
        private System.Windows.Forms.CheckBox cbValidatePlot;
        private System.Windows.Forms.Button btnClearTmp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeElapsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Output;
        private System.Windows.Forms.Label lbAutoWorking;
    }
}

