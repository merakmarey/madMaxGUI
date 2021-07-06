
namespace madMaxGUI
{
    partial class GenTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbpercentage = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbtime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "destination";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbpercentage
            // 
            this.lbpercentage.AutoSize = true;
            this.lbpercentage.Location = new System.Drawing.Point(466, 47);
            this.lbpercentage.Name = "lbpercentage";
            this.lbpercentage.Size = new System.Drawing.Size(23, 15);
            this.lbpercentage.TabIndex = 2;
            this.lbpercentage.Text = "0%";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "startcopy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(184, 98);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(43, 15);
            this.lbtime.TabIndex = 4;
            this.lbtime.Text = "lbTime";
            // 
            // GenTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbpercentage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GenTest";
            this.Text = "GenTest";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbpercentage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbtime;
    }
}