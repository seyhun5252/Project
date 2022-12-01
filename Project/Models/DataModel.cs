using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Data
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("expiration")]
        public DateTime Expiration { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }
    }

    public class StatusAndData
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }


}
