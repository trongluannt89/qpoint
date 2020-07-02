using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace qpoint.Models
{
    public class Languages {
        [JsonProperty("Languages")]
        public List<Language> languages { get; set; }
    }
    public class Language
    {
        [JsonProperty("LanguageID")]
        public string LanguageId { get; set; }

        [JsonProperty("LanguageDescription")]
        public string LanguageDescription { get; set; }
    }
}
