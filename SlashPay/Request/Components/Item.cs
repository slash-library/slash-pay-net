using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Components
{
    public class Item
    {
        [JsonProperty("qty")]
        public int Quantity { get; set; }
        [JsonProperty("amt")]
        public float Amount { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
