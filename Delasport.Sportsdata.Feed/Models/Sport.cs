namespace Delasport.Sportsdata.Feed.Models
{
    using Newtonsoft.Json;

    public class Sport
    {
        [JsonProperty("id")]
        public string? Id { get; set; } = default;

        [JsonProperty("title")]
        public string? Title { get; set; } = default;

        [JsonProperty("key")]
        public string? Key { get; set; } = default;
    }
}
