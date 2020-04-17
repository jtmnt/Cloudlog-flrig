using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cloudlog_flrig.CloudlogAPI
{
    public class CloudlogResult
    {
        public string status { get; set; }
        public string reason { get; set; }
    }

    public class CloudlogAPIClient : IDisposable
    {
        private WebClient _webClient;

        public CloudlogAPIClient()
        {
            _webClient = new WebClient();
        }

        public void Dispose()
        {
            _webClient.Dispose();
        }

        public CloudlogResult SendRadioInfo(string cloudlogURL, string cloudlogAPIKey, Models.RadioInfo radioInfo)
        {
            var request = new
            {
                key = cloudlogAPIKey,
                radio = string.IsNullOrWhiteSpace(radioInfo.RadioName) ? "FLRig" : radioInfo.RadioName,
                frequency = radioInfo.Frequency,
                mode = radioInfo.Mode,
                timestamp = DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm")
            };

            var requestUrl = new Uri(new Uri($"{cloudlogURL.TrimEnd('/')}/"), "index.php/api/radio");

            string response = _webClient.UploadString(requestUrl, JsonConvert.SerializeObject(request));

            if (!string.IsNullOrWhiteSpace(response))
            {
                var result = JsonConvert.DeserializeObject(response, typeof(CloudlogResult)) as CloudlogResult;

                if (result != null)
                {
                    return result;
                }
            }

            return new CloudlogResult() { status = "failed", reason = "unknown" };

        }
    }
}
