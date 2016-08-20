using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace SlashPay.Request
{
    public class RequestGateway
    {
        protected string ApiUrl = "";

        public RequestGateway(string url)
        {
            this.ApiUrl = url;
        }

        public string Post(string uri, Request data, Dictionary<String, String> headers)
        {
            string requestUri = this.ApiUrl + uri;
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            var postData = "";
            postData = JsonConvert.SerializeObject(data, Formatting.Indented);

            var dataPayload = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataPayload.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(dataPayload, 0, dataPayload.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public string Get(string uri, Dictionary<String, String> data, Dictionary<String, String> headers)
        {
            string requestUri = this.ApiUrl + uri;

            var postData = "";
            foreach (KeyValuePair<string, string> entry in data)
            {
                if (postData == "")
                {
                    postData = entry.Key + "=" + entry.Value;
                }
                else
                {
                    postData = "&" + entry.Key + "=" + entry.Value;
                }
            }
            
            var request = (HttpWebRequest)WebRequest.Create(requestUri + "?" + postData);

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
