using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Checkout
{
    public class Pay : Token
    {
        [JsonProperty("total")]
        public string Total { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
