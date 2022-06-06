namespace Delasport.Sportsdata.Feed.Models
{
    using Newtonsoft.Json;

    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("awayTeam")]
        public Team? AwayTeam { get; set; } = default;

        [JsonProperty("country")]
        public Country? Country { get; set; } = default;

        [JsonProperty("hasLiveStreaming")]
        public bool? HasLiveStreaming { get; set; } = default;

        [JsonProperty("homeTeam")]
        public Team? HomeTeam { get; set; } = default;

        [JsonProperty("league")]
        public League? League { get; set; } = default;

        [JsonProperty("liveClockTimestamp")]
        public string? LiveClockTimestamp { get; set; } = default;

        [JsonProperty("liveGamePeriod")]
        public string? LiveGamePeriod { get; set; } = default;

        [JsonProperty("marketCount")]
        public int? MarketCount { get; set; } = default;

        [JsonProperty("sport")]
        public Sport? Sport { get; set; } = default;

        [JsonProperty("startDate")]
        public string? StartDate { get; set; } = default;

        [JsonProperty("state")]
        public string? State { get; set; } = default;

        [JsonProperty("status")]
        public string? Status { get; set; } = default;

        [JsonProperty("timeRange")]
        public string? TimeRange { get; set; } = default;
    }
}
