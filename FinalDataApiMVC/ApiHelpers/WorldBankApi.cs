using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WorldEconomy.Models;

namespace WorldEconomy.ApiHelpers
{
    public static class WorldBankApi
    {
        static WorldBankApi()
        {
            JsonSerializerSettings = new JsonSerializerSettings();
            JsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            JsonSerializerSettings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            JsonSerializerSettings.DateParseHandling = DateParseHandling.None;

            BaseUrl = "https://api.worldbank.org/v2/";

            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private static readonly HttpClient HttpClient;
        private static readonly string BaseUrl;
        private static readonly JsonSerializerSettings JsonSerializerSettings;

        public static string GetJsonFromApi(string path)
        {
            return HttpClient.GetStringAsync(new Uri(BaseUrl + path)).Result;
        }

        public static List<T> DeserializeJson<T>(string json)
        {
            var array = (JArray)JsonConvert.DeserializeObject(json);

            return JsonConvert.DeserializeObject<List<T>>(array[1].ToString(), JsonSerializerSettings);
        }

        public static List<CountryEntry> GetWorldBankApiCountries()
        {
            return DeserializeJson<CountryEntry>(GetJsonFromApi("countries?per_page=12000&format=json"));
        }
        public static List<GdpEntry> GetWorldBankApiGdps()
        {
            return DeserializeJson<GdpEntry>(GetJsonFromApi("countries/all/indicators/NY.GDP.MKTP.CD?per_page=12000&format=json&date=2017"));
        }
    }
}