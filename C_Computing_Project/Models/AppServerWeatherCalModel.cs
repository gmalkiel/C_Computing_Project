using DP.WeatherCal;
using Newtonsoft.Json;
using RestSharp;

namespace C_Computing_Project.Models
{
    public class AppServerWeatherCalModel
    {
        public string GetWeatherCalService(string City)
        {
            var result = string.Empty;
            string Url = $"http://localhost:5152/api/WeatherCal?City={City}";
            var client = new RestClient(Url);
            var request = new RestRequest(new Uri(Url), Method.Get);
            RestResponse response = client.Execute(request);
         
            return response.Content;
        }
    }
}
