using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay.Api
{
    class SubscriptionApi: Api
    {
        const string SUBSCRIBE_ENDPOINT = "subscribe";
        const string UNSUBSCRIBE_ENDPOINT = "unsubscribe";

        public SubscriptionApi(string privateKey, Request.RequestGateway request)
            : base(privateKey, request)
        { 
        }

        public string Subscribe(Dictionary<string, string> data)
        {
            return this.Request.Post(SubscriptionApi.SUBSCRIBE_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }

        public string Unsubscribe(Dictionary<string, string> data)
        {
            return this.Request.Post(SubscriptionApi.UNSUBSCRIBE_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }
    }
}
