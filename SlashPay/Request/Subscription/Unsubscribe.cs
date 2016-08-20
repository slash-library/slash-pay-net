using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Subscription
{
    public class Unsubscribe: Request
    {
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
