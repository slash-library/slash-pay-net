using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay.Api
{
    public class CheckoutApi: Api
    {
        const string PAY_ENDPOINT = "pay";
        const string CHARGE_ENDPOINT = "createcharge";

        public CheckoutApi(string privateKey, Request.RequestGateway request)
            : base(privateKey, request)
        { 
        }

        public string Pay(Request.Checkout.Pay data)
        {
            return this.Request.Post(CheckoutApi.PAY_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }

        public string Charge(Request.Checkout.Charge data)
        {
            return this.Request.Post(CheckoutApi.CHARGE_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }
    }
}
