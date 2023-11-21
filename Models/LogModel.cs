using System;
using System.Collections.Generic;
using System.Text;

namespace madFurry.Models
{
    public class LogModel
    {
        public string plotname { get; set; }
        public bool completed { get; set; }
        public Dictionary<int, double> phaseTimes { get; set; }

        public int threads { get; set; }

        public int buckets { get; set; }

        public int buckets34 { get; set; }

        public bool threadMultiplier { get; set; }

        public DateTime dateInit;

        public DateTime dateEnd;

        public LogModel()
        {
            completed = false;
            phaseTimes = new Dictionary<int, double>();
        }

    }
}
