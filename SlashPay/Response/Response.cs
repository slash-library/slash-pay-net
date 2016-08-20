using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlashPay.Response
{
    public abstract class Response
    {
        //[JsonProperty("result")]
        //public abstract ResultResponse Result { get; set; }
        [JsonProperty("code")]
        public Boolean Code { get; set; }
        //[JsonProperty("options")]
        //public abstract OptionResponse Options { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }

    }
}
