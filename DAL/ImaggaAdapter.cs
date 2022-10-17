using Newtonsoft.Json;
using RestSharp;
using System;

namespace DAL
{
    public class ImaggaAdapter
    {
        public string GetPicTag(string imageUrl)
        {
            string apiKey = "acc_af6f7e71795036a";
            string apiSecret = "f449b3beb945a5bf37a4673b6b667edd";
            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));
            var client = new RestClient("https://api.imagga.com/v2/tags");
            var request = new RestRequest(new Uri("https://api.imagga.com/v2/tags"), Method.Get);
            request.AddParameter("image_url", imageUrl);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            RestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
