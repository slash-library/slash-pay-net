using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Response.Checkout.Component
{
    public class Option: OptionResponse
    {
        [JsonProperty("paymentService")]
        public string PaymentService
        {
            get;
            set;
        }
    }
}
