using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudlog_flrig.FLRigAPI
{
    public class FLRigClient
    {
        public Models.RadioInfo GetRadioInfo()
        {
            Models.RadioInfo radioInfo = new Models.RadioInfo();

            FLRigProxy proxy = XmlRpcProxyGen.Create<FLRigProxy>();
            proxy.Url = Properties.Settings.Default.FLRigURL;
            
            var objVfo = proxy.get_vfo();
            radioInfo.Frequency = objVfo != null ? Convert.ToInt32(objVfo) : 0;


            //var objMode = proxy.get_mode();

            //radioInfo.Mode = objMode != null ? (string)objMode : "";


            var objInfo = proxy.get_info();
            if (objInfo != null)
            {
                //R:FT-891
                //T:R
                //FA:0
                //M:LSB
                //L:2400
                //U:
                //N:1500
                //Vol:25
                //Mic:40
                //Rfg:30
                var infoList = objInfo.ToString().Split('\n').Select(line =>
                {
                    var lineItems = line.Split(':');
                    return new { key = lineItems.FirstOrDefault(), value = lineItems.Skip(1).FirstOrDefault() };
                });

                radioInfo.RadioName = infoList.Where(i => i.key == "R").Select(i => i.value).FirstOrDefault();
                radioInfo.Mode = TranslateModeToCloudlogValues(infoList.Where(i => i.key == "M").Select(i => i.value).FirstOrDefault());
            }
            return radioInfo;
        }

        private string TranslateModeToCloudlogValues(string v)
        {
            string mode;

            switch (v)
            {
                case "CW-L":
                case "CW-U":
                case "CW":
                    mode = "CW";
                    break;
                case "RTTY-L":
                case "RTTY-U":
                case "RTTY":
                    mode = "RTTY";
                    break;
                case "LSB":
                case "USB":
                case "SSB":
                    mode = "SSB";
                    break;
                case "DATA-U":
                case "DATA-L":
                case "DATA":
                    mode = "DIGI";
                    break;
                case "AM":
                    mode = "AMD";
                    break;
                case "FM":
                    mode = "FM";
                    break;
                default:
                    mode = "OTHER";
                    break;
            }

            return mode;
        }
    }
}
