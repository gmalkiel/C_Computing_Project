using DP.Imagga;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class HebCalAdapter
    {
        public string GetCommingMonth(string City)
        {
            var result= string.Empty;
            string Dts = DateForUrl(DateTime.Now);
            string Dte = DateForUrl(DateTime.Now.AddDays(30));
            string Url = $"https://www.hebcal.com/hebcal?v=1&cfg=json&maj=on&min=on&mod=on&nx=on&year=now&month=x&ss=on&mf=on&c=on&city={City}&M=on&s=on&start={Dts}&end={Dte}";
            var client = new RestClient(Url);
           
            var request = new RestRequest(new Uri(Url), Method.Get);
            RestResponse response = client.Execute(request);
            return response.Content;
            
        }
        public string DateForUrl(DateTime temp)
        {
            string td,y,m,d;
            y = temp.Year.ToString();
            m = temp.Month.ToString();
            d = temp.Day.ToString();
            td=y+"-"+m+"-"+d;
            return td;
        }
    }
}
