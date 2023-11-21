using madFurry.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;

using System.Text;

namespace madFurry.Modules
{
    public class RemoteAPI
    {

        public static async void UpdateStats(string clientID, string clientID_sub, string jsonStats, string baseURL)
        {
            var payload = new StatsModel();

            payload.clientID = clientID;
            payload.clientID_Sub = clientID_sub;
            payload.date = DateTime.Now;
            payload.stats = jsonStats;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync("api/stats", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static async void UpdateScreens(string clientID, string clientID_sub, Image image, string baseURL)
        {
            

            var payload = new ClientScreenModel();

            payload.clientID = clientID;
            payload.clientID_Sub = clientID_sub;
            payload.date = DateTime.Now;
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = m.ToArray();
                payload.screenImage = Convert.ToBase64String(imageBytes);
                //using (FileStream fs = new FileStream(@"c:\tmp\p.jpg",FileMode.Create, FileAccess.ReadWrite)) { fs.Write(imageBytes, 0, imageBytes.Length); }
            }


            try 
            { 
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync("api/send", new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }

        }
    }
}
