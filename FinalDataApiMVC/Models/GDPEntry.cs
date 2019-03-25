using Newtonsoft.Json;

namespace WorldEconomy.Models
{
    public class GdpEntry
    {
        [JsonProperty("indicator")]
        public Indicator Indicator { get; set; }

        [JsonProperty("country")]
        public Indicator CountryEntry { get; set; }

        [JsonProperty("countryiso3code")]
        public string CountryiIso3Code { get; set; }

        [JsonProperty("date")]
        public int Year { get; set; }

        [JsonProperty("value")]
        public double? Gdp { get; set; }
    }
}