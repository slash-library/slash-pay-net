using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Request.Redirect
{
    public class Confirm: Request
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
