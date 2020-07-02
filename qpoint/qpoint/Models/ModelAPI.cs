using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace qpoint.Models
{
    public partial class ModelAPI
    {
        [JsonProperty("LanguageID")]
        public string LanguageId { get; set; }

        [JsonProperty("LanguageDescription")]
        public string LanguageDescription { get; set; }

        [JsonProperty("DeviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("LoginStatusID")]
        public long LoginStatusId { get; set; }

        [JsonProperty("LoginSessionID")]
        public Guid LoginSessionId { get; set; }

        [JsonProperty("LoginMainAccount")]
        public bool LoginMainAccount { get; set; }
    }
}
