using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request
{
    public class Request
    {
        [JsonProperty("country")]
        public string Country { get; set; }

    }
}
