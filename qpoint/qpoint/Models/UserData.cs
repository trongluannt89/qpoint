using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace qpoint.Models
{
    public class UserData
    {
        [JsonProperty("DeviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("LanguageID")]
        public string LanguageId { get; set; }
    }
}
