using Newtonsoft.Json;

namespace WorldEconomy.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class CountryEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iso2Code")]
        public string Iso2Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public Region Region { get; set; }

        [JsonProperty("adminregion")]
        public Region AdminRegion { get; set; }

        [JsonProperty("incomeLevel")]
        public Region IncomeLevel { get; set; }

        [JsonProperty("lendingType")]
        public Region LendingType { get; set; }

        [JsonProperty("capitalCity")]
        public string CapitalCity { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}