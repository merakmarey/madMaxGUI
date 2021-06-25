
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
            this.cbAlternateStorage = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lbCores = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbLogicalCPUs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProcessor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.gbPaths.SuspendLayout();
            this.gbKeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.AutoSize = true;
            this.gbPaths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPaths.Controls.Add(this.cbAlternateStorage);
            this.gbPaths.Controls.Add(this.label11);
            this.gbPaths.Controls.Add(this.label10);
            this.gbPaths.Controls.Add(this.button3);
            this.gbPaths.Controls.Add(this.label9);
            this.gbPaths.Controls.Add(this.button2);
            this.gbPaths.Controls.Add(this.label6);
            this.gbPaths.Controls.Add(this.label5);
            this.gbPaths.Controls.Add(this.label4);
            this.gbPaths.Controls.Add(this.label3);
            this.gbPaths.Controls.Add(this.checkBox1);
            this.gbPaths.Controls.Add(this.label2);
            this.gbPaths.Controls.Add(this.button1);
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
            this.gbPaths.Text = "Paths";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(96, 146);
            this.label6.MaximumSize = new System.Drawing.Size(500, 0);
            this.label6.MinimumSize = new System.Drawing.Size(500, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "(none)";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(96, 93);
            this.label3.MaximumSize = new System.Drawing.Size(500, 0);
            this.label3.MinimumSize = new System.Drawing.Size(500, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "(none)";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
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
            this.gbKeys.Text = "Keys";
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
            this.lbLogicalCPUs.Location = new System.Drawing.Point(121, 49);
            this.lbLogicalCPUs.Name = "lbLogicalCPUs";
            this.lbLogicalCPUs.Size = new System.Drawing.Size(34, 15);
            this.lbLogicalCPUs.TabIndex = 3;
            this.lbLogicalCPUs.Text = "none";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Threads";
            // 
            // lbProcessor
            // 
            this.lbProcessor.AutoSize = true;
            this.lbProcessor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbProcessor.Location = new System.Drawing.Point(121, 19);
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
            this.gbOptions.Location = new System.Drawing.Point(656, 124);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(387, 232);
            this.gbOptions.TabIndex = 3;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "RAM (GB)";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbRAM.Location = new System.Drawing.Point(121, 64);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(34, 15);
            this.lbRAM.TabIndex = 7;
            this.lbRAM.Text = "none";
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 519);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
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
    }
}

