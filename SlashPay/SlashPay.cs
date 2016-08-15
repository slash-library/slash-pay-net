using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay
{
    public class SlashPay
    {
        protected string ApiUrl = "http://localhost:1337/"; // https://api.slash.us.com/
        protected string ApiVersion = "v1";
        protected string PublicKey = "";
        protected string PrivateKey = "";
        protected Request.RequestGateway Request = null;
        protected Api.CheckoutApi CheckoutApi = null;
        protected Api.RedirectApi RedirectApi = null;
        protected Api.SubscriptionApi SubscriptionApi = null;

        public SlashPay(string publicKey, string privateKey)
        {
            this.PublicKey = publicKey;
            this.PrivateKey = privateKey;
            this.Request = new Request.RequestGateway(ApiUrl + ApiVersion + '/');
            this.CheckoutApi = new Api.CheckoutApi(this.PrivateKey, this.Request);
            this.RedirectApi = new Api.RedirectApi(this.PrivateKey, this.Request);
            this.SubscriptionApi = new Api.SubscriptionApi(this.PrivateKey, this.Request);
        }

        /// Pay
        /// API Method
        /// 
        public string Pay(Dictionary<string, string> data)
        {
            return this.CheckoutApi.Pay(data);
        }

        /// Charge
        /// API Method
        /// 
        public string Charge(Dictionary<string, string> data)
        {
            return this.CheckoutApi.Charge(data);
        }

        /// Redirect
        /// API Method
        /// 
        public string Redirect(Dictionary<string, string> data)
        {
            return this.RedirectApi.Redirect(data);
        }

        /// Confirm
        /// API Method
        /// 
        public string Confirm(Dictionary<string, string> data)
        {
            return this.RedirectApi.Confirm(data);
        }

        /// Subscribe
        /// API Method
        /// 
        public string Subscribe(Dictionary<string, string> data)
        {
            return this.SubscriptionApi.Subscribe(data);
        }

        /// Unsubscribe
        /// API Method
        /// 
        public string Unsubscribe(Dictionary<string, string> data)
        {
            return this.SubscriptionApi.Unsubscribe(data);
        }
    }
}
