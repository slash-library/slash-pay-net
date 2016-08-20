using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Response.Checkout.Component
{
    public class Result: ResultResponse
    {

        [JsonProperty("transactionId")]
        public string TransactionId
        {
            get;
            set;
        }
        [JsonProperty("total")]
        public float Total
        {
            get;
            set;
        }
        [JsonProperty("timestamp")]
        public long Timestamp
        {
            get;
            set;
        }
        [JsonProperty("currency")]
        public long Currency
        {
            get;
            set;
        }
    }
}
