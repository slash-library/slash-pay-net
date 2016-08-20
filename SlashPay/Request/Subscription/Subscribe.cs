using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Subscription
{
    public class Subscribe: Request
    {
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
