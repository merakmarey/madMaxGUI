using madFurry.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace madFurry.Modules
{
    public static class Stats
    {
        public static List<LogModel> loadStats(string filename)
        {
            var data = new List<LogModel>();
            try
            {
                var json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Stats\" + filename).TrimEnd(',');
                data = JsonConvert.DeserializeObject<List<LogModel>>("[" + json + "]");
            }
            catch (Exception ex) { }
            return data;
        }
        public static List<LogModel> loadStats(List<string> filenames)
        {
            var data = new List<LogModel>();
            
            try
            {
                string json = String.Empty;
                foreach (var filename in filenames)
                {
                    json += System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Stats\" + filename);
                }
               
                var tmpdata = JsonConvert.DeserializeObject<List<LogModel>>("[" + json.TrimEnd(',') + "]");
            }
            catch (Exception ex) { }
            return data;
        }
        public static List<LogModel> loadTodayStats()
        {
            var filename = DateTime.Now.ToString("yyyy-MM-dd") + ".stats";
            return loadStats(filename);
        }
    }
}
