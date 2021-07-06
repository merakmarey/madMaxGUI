using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace madMaxGUI
{
    public partial class GenTest : Form
    {
        string sourcefile;
        string destinationfolder;

        public GenTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog source = new OpenFileDialog();
            source.ShowDialog();
            sourcefile = source.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    destinationfolder= fbd.SelectedPath;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var task = System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                var filename = Path.GetFileName(sourcefile);
                XCopy.Copy(sourcefile, destinationfolder + @"\" + filename, true, true, new EventHandler<ProgressChangedEventArgs>((o, s) =>
                {
                    lbpercentage.Text = s.ProgressPercentage.ToString() + "%";
                    lbpercentage.Refresh();
                }));
            });
            var elapsed = DateTime.Now - now;
            lbtime.Text = elapsed.ToString(@"hh\:mm\:ss");
        }
    }
}
