using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashPay.Response.Component
{
    class Result
    {
        private string transactionId;
        public string TransactionId
        {
            get
            {
                return this.transactionId;
            }
            set
            {
                this.transactionId = value;
            }
        }
        private float total;
        public float Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }
    }
}
