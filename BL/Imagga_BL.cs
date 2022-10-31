using DP;
using DP.Imagga;
using Newtonsoft.Json;
using System;

namespace BL
{
    public class Imagga_BL
    {
        public ImaggaParams PicDetails(string picUrl)
        {
            DAL.ImaggaAdapter dal=new DAL.ImaggaAdapter();
            string ImaggaJson= dal.GetPicTag(picUrl);
            ImaggaParams imaggaParams = new ImaggaParams();
            if (ImaggaJson != null)
            {
                Root myPic = JsonConvert.DeserializeObject<Root>(ImaggaJson);
                imaggaParams.ImageSource = picUrl;
                imaggaParams.IsFood=false;
                foreach (var item in myPic.result.tags)
                {
                    if (item.tag.en == "food"&& item.confidence>70)
                    {
                        imaggaParams.IsFood = true;
                        break;
                    }
                }
                //imaggaParams.IsFood = tagChek(myPic);
            }
            return imaggaParams;
        }
        //public bool tagChek(Root ImaggaRoot)
        //{
        //    bool flag = false;
        //    foreach (var item in ImaggaRoot.result.tags)
        //    {
        //        if (item.tag.en == "food")
        //        {
        //            flag = true;
        //            break;
        //        }
        //    }
        //    return flag;
        //}
    }
}
