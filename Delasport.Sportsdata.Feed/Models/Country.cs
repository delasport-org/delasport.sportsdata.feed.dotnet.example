namespace Delasport.Sportsdata.Feed.Models
{
    using Newtonsoft.Json;

    public class Country
    {
        [JsonProperty("id")]
        public string? Id { get; set; } = default;

        [JsonProperty("title")]
        public string? Title { get; set; } = default;
    }
}
