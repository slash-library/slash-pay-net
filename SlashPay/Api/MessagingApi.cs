using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay.Api
{
    public class MessagingApi: Api
    {
        const string SEND_ENDPOINT = "send";

        public MessagingApi(string privateKey, Request.RequestGateway request)
            : base(privateKey, request)
        { 
        }

        public string Send(Request.Messaging.Send data)
        {
            return this.Request.Post(MessagingApi.SEND_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }
    }
}
