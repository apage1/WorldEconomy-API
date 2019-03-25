using Newtonsoft.Json;

namespace WorldEconomy.Models
{
    public class Region
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iso2code")]
        public string Iso2Code { get; set; }

        [JsonProperty("value")]
        public string Name { get; set; }
    }
}