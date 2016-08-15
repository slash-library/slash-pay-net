using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay.Api
{
    class RedirectApi: Api
    {
        const string REDIRECT_ENDPOINT = "redirect";
        const string CONFIRM_ENDPOINT = "confirm";

        public RedirectApi(string privateKey, Request.RequestGateway request)
            : base(privateKey, request)
        { 
        }

        public string Redirect(Dictionary<string, string> data)
        {
            return this.Request.Post(RedirectApi.REDIRECT_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }

        public string Confirm(Dictionary<string, string> data)
        {
            return this.Request.Post(RedirectApi.CONFIRM_ENDPOINT, data, new Dictionary<string, string>() { 
                { "Authorization",  "Bearer" + this.PrivateKey}
            });
        }
    }
}
