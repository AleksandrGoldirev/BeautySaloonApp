using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonApp.Models
{
    class Users
    {
        [JsonProperty("idrole")]
        public int Idrole { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [JsonProperty("userLastName")]
        public string UserLastName { get; set; }
        [JsonProperty("userOtherName")]
        public string UserOtherName { get; set; }
        [JsonProperty("userLogin")]
        public string UserLogin { get; set; }
        [JsonProperty("userPassword")]
        public string UserPassword { get; set; }
        [JsonProperty("idroleNavigation")]
        public byte[] UidroleNavigation { get; set; }
    }
}
