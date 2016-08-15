using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay.Api
{
    abstract class Api
    {
        protected string PrivateKey = "";
        protected Request.RequestGateway Request = null;

        public Api()
        {
        }

        public Api(string privateKey, Request.RequestGateway request)
        {
            this.PrivateKey = privateKey;
            this.Request = request;
        }
    }
}
