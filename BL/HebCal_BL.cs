using DP;
using DP.HebCal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class HebCal_BL
    {
        public HebCalParams MonthlyHoliday(string City)
        {
            HebCalParams hebCal = new HebCalParams();
            DAL.HebCalAdapter dal = new DAL.HebCalAdapter();
            string HebCalJson = dal.GetCommingMonth(City);
            if (HebCalJson != null)
            {
                Root myHolyday = JsonConvert.DeserializeObject<Root>(HebCalJson);
                hebCal.City = myHolyday.title;
                //hebCal.City = myHolyday.location.ToString();
                if(IsHoliday(myHolyday)!=null)
                {
                    hebCal.Holiday=IsHoliday(myHolyday);
                }
            }
            return hebCal;
        }
        public string IsHoliday(Root calenderm)
        {
            foreach(var item in calenderm.items)
            {
                if(item.category=="holiday")
                {
                    return item.title;
                }
            }
            return null;
        }
    }
}
