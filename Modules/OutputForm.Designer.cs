
namespace madFurry
{
    partial class OutputForm
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
            this.txOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txOutput
            // 
            this.txOutput.AcceptsReturn = true;
            this.txOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txOutput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txOutput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txOutput.Location = new System.Drawing.Point(4, 0);
            this.txOutput.Multiline = true;
            this.txOutput.Name = "txOutput";
            this.txOutput.ReadOnly = true;
            this.txOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txOutput.Size = new System.Drawing.Size(794, 447);
            this.txOutput.TabIndex = 0;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txOutput);
            this.Name = "OutputForm";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txOutput;
    }
}