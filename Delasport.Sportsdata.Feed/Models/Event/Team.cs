namespace Delasport.Sportsdata.Feed.Models.Event
{
    using Newtonsoft.Json;

    public class Team
    {
        [JsonProperty("id")]
        public string? Id { get; set; } = default;

        [JsonProperty("color")]
        public string? Color { get; set; } = default;

        [JsonProperty("name")]
        public string? Name { get; set; } = default;
    }
}
