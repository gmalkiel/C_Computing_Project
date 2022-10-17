using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class WeatherCalAdapter
    {
        public string GetTodayWeather(string City)
        {
            string Url = $" https://api.openweathermap.org/data/2.5/weather?q={City}&appid=2ee95b40f4f126c98f6986d56d50ddb8&units=metric";
            var client = new RestClient(Url);
            var request = new RestRequest(new Uri(Url), Method.Get);
            RestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
