using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Redirect
{
    public class Redirect: Request
    {
        [JsonProperty("items")]
        public List<Components.Item> Items { get; set; }
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
