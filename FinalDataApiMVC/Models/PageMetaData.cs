using Newtonsoft.Json;

namespace WorldEconomy.Models
{
    public class PageMetadata
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}