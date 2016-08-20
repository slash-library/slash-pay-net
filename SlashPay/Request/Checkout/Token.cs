using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Checkout
{
    public class Token : Request
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("cc_no")]
        public string CardNumber { get; set; }
        [JsonProperty("expiry_month")]
        public string ExpiryMonth { get; set; }
        [JsonProperty("expiry_year")]
        public string ExpiryYear { get; set; }
    }
}
