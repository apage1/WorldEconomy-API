using Newtonsoft.Json;

namespace WorldEconomy.Models
{
    public class Indicator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Name { get; set; }
    }
}