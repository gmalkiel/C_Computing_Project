using DP;
using DP.WeatherCal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class WeatherCal_BL
    {
        //public WeatherParams GetWeather(string City)
        //{
        //    DAL.WeatherCalAdapter dal=new DAL.WeatherCalAdapter();
        //    string WeatherJson = dal.GetTodayWeather(City);
        //    WeatherParams weather = new WeatherParams();
        //    if (WeatherJson != null)
        //    {
        //        Root myWeather = JsonConvert.DeserializeObject<Root>(WeatherJson);
        //        weather.City = myWeather.name;
        //        weather.Degrees = myWeather.main.temp;
        //        weather.ForeCast = myWeather.weather[0].description;
        //    }
        //    return weather;
        //}
        public double GetWeather(string City)
        {
            DAL.WeatherCalAdapter dal = new DAL.WeatherCalAdapter();
            string WeatherJson = dal.GetTodayWeather(City);
            WeatherParams weather = new WeatherParams();
            if (WeatherJson != null)
            {
                Root myWeather = JsonConvert.DeserializeObject<Root>(WeatherJson);
                weather.City = myWeather.name;
                weather.Degrees = myWeather.main.temp;
                weather.ForeCast = myWeather.weather[0].description;
            }
            return weather.Degrees;
        }
    }
}
