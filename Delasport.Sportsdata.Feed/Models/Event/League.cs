namespace Delasport.Sportsdata.Feed.Models.Event
{
    using Newtonsoft.Json;

    public class League
    {
        [JsonProperty("id")]
        public string? Id { get; set; } = default;

        [JsonProperty("title")]
        public string? Title { get; set; } = default;

        [JsonProperty("format")]
        public string? Format { get; set; } = default;
    }
}
