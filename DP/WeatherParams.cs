using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    [Serializable]
    public class WeatherParams
    {
        public string City { get; set; }
        public string ForeCast { get; set; }
        public double Degrees { get; set; }
    }
}
