using System;
using System.Collections.Generic;
using System.Text;

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
        
    }
}
