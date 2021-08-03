using chiaheaven.Models;
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
    class RemoteAPI
    {
        public void UpdateScreens_1(string clientID, string clientID_sub, Image image)
        {
            var baseURL = "http://localhost:59125/api/send";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURL);
            request.Method = "POST";

            var payload = new ClientScreenModel();

            payload.clientID = clientID;
            payload.clientID_Sub = clientID_sub;
            payload.date = DateTime.Now;
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                payload.screenImage = imageBytes.ToString();
            }


            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

            Byte[] byteArray = encoding.GetBytes(JsonConvert.SerializeObject(payload));

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;

                }
            }
            catch
            {
                
            }

           
                
        }

        public static async void UpdateScreens(string clientID, string clientID_sub, Image image)
        {
            var baseURL = "http://chiaheaven.com/";
           

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
