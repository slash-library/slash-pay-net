using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Messaging
{
    public class Send: Request
    {
        [JsonProperty("to")]
        public string To { get; set; }
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
