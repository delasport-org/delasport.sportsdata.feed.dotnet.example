namespace Delasport.Sportsdata.Feed.Models.Market
{
    using Newtonsoft.Json;

    public class Odd
    {
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("key")]
        public string? Key { get; set; } = default;

        [JsonProperty("value")]
        public string? Value { get; set; } = default;
    }
}
