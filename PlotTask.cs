using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace madMaxGUI
{
    public enum TaskStatus
    {
        NotStarted,
        Running,
        AwaitingRestart,
        Completed
    }
    class PlotTask
    {
        public Guid guid;
        public string tmpDir1;
        public string tmpDir2;
        public string finalDir;
        public string poolKey;
        public string farmerKey;

        public string threads;
        public string buckets;
        public string buckets34;

        public bool copyOnSeparatedTask;
        public bool useInternalCopy;
        public bool validateAfterCopy;
        public TaskStatus status;

        public string cmdString;
        public string output;
        public string error;

        public string plot_filename;

        public Process process;

        public void outputProcessor(string outputLine, ref System.Windows.Forms.DataGridView dgv)
        {
            output += outputLine;
            if (outputLine.StartsWith("Plot name:"))
            {
                var tmp_plot_filename = outputLine.Substring(11);
                DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Plot"].Value.ToString().Equals(tmp_plot_filename)).FirstOrDefault();

                if (row==null)
                {
                    plot_filename = tmp_plot_filename;
                }

            } else
            {
                DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Plot"].Value.ToString().Equals(plot_filename)).FirstOrDefault();
            }
        }
    }
}
