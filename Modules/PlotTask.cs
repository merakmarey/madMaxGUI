using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


using madFurry.Models;


namespace madFurry
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
        public string tmpDir1;
        public string tmpDir2;
        public string finalDir;

        public string poolKey;
        public string farmerKey;
        public string contractAddress;

        public string threads;
        public string buckets;
        public string buckets34;

        public bool copyOnSeparatedTask;
        public bool useInternalCopy;
        public bool threadMultiplier;

        public bool createLog;

        public LogModel logModel = new LogModel();

        public int phase = 1;

        public TaskStatus status;

        public string cmdString;
        public string output;
        public string error;

        public string plot_filename;

        public Process process;

        public int currentPhase = 1;

        public DateTime copyStarted = DateTime.Now;
        public System.Timers.Timer updateCopyTime = new System.Timers.Timer();

        #region METHODS
        public void StopCopyTimer()
        {
            updateCopyTime.Stop();
        }
        public void outputProcessor(string outputLine, System.Windows.Forms.DataGridView dgv)
        {
            if (!String.IsNullOrEmpty(outputLine))
            {
                output += outputLine + Environment.NewLine;

                if (outputLine.ToLowerInvariant().StartsWith("plot name:"))
                {
                    var tmp_plot_filename = outputLine.Substring(11) + ".plot";
                    DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Plot"].Value.ToString().Equals(tmp_plot_filename)).FirstOrDefault();
                    
                    if ((row == null)&& (dgv.InvokeRequired))
                    {
                        dgv.Invoke(new Action(() => { dgv.Rows.Add(tmp_plot_filename, "(none yet)", "--:--:--", "Running" ); }));
                        plot_filename = tmp_plot_filename;
                        logModel.plotname = plot_filename;
                    }

                }
                else
                {
                    if (!String.IsNullOrEmpty(plot_filename))
                    {
                        DataGridViewRow row = dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Plot"].Value.ToString().Equals(plot_filename)).FirstOrDefault();
                        row.Cells["LastMessage"].Value = outputLine;
                    }

                    var expandedLine = outputLine.Split(" ");
                    if (expandedLine.Count()>4)
                    if ((expandedLine[0]=="phase") && (expandedLine[2]=="took")) 
                    {
                        int phaseNumber = expandedLine[1].ToInt();
                        int seconds = expandedLine[3].ToInt();
                        if (seconds*phaseNumber!=0)
                        {
                            logModel.phaseTimes.Add(phaseNumber, seconds);
                        }
                    }
                    if (outputLine.StartsWith("total plot creation time"))
                    {
                        logModel.completed = true;
                    }

                }

                if ((createLog) && (!String.IsNullOrEmpty(plot_filename)))
                {
                    string logPath = AppDomain.CurrentDomain.BaseDirectory + @"\Logs";
                    System.IO.Directory.CreateDirectory(logPath);
                    if (outputLine.ToLowerInvariant().StartsWith("plot name:"))
                    {
                        File.AppendAllLines(logPath + @"\" +plot_filename+ ".log", new List<string>() { output });
                    } else
                    {
                        File.AppendAllLines(logPath + @"\" + plot_filename + ".log", new List<string>() { outputLine });
                    }
                }
            }
        }
        public void errorProcessor(string outputLine)
        {
            if (!String.IsNullOrEmpty(outputLine))
            {
                output += outputLine + Environment.NewLine;
                error += outputLine + Environment.NewLine;
            }
        }
        #endregion
    }
}
