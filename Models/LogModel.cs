using System;
using System.Collections.Generic;
using System.Text;

namespace madFurry.Models
{
    class LogModel
    {
        public string plotname { get; set; }
        public bool completed { get; set; }
        public Dictionary<int, int> phaseTimes { get; set; }

        public int threads { get; set; }

        public int buckets { get; set; }

        public int buckets34 { get; set; }

        public bool threadMultiplier { get; set; }

        public LogModel()
        {
            completed = false;
            phaseTimes = new Dictionary<int, int>();
        }

    }
}
