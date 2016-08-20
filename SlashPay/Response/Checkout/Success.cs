using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Response.Checkout
{
    public class Success: SuccessResponse
    {
        [JsonProperty("result")]
        public Component.Result Result { get; set; }
        [JsonProperty("options")]
        public Component.Option Options { get; set; }
    }
}
