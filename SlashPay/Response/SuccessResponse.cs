using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Response
{
    public abstract class SuccessResponse: Response
    {
        [JsonProperty("success")]
        public Boolean Success {
            get
            {
                return true;
            }
        }
    }
}
