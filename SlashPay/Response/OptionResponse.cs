using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Response
{
    public class OptionResponse
    {
        [JsonProperty("slashTransactionId")]
        public string SlashTransactionId { get; set; }
    }
}
