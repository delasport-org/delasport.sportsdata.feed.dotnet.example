namespace Delasport.Sportsdata.Feed.Models
{
    using Newtonsoft.Json;

    public class Market
    {
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("eventId")]
        public string EventId { get; set; } = default!;

        [JsonProperty("invalidatedAt")]
        public string? InvalidatedAt { get; set; } = default;

        [JsonProperty("marketTypeId")]
        public string? MarketTypeId { get; set; } = default;

        [JsonProperty("gamePeriodId")]
        public string? GamePeriodId { get; set; } = default;

        [JsonProperty("lineEntityId")]
        public string? LineEntityId { get; set; } = default;

        [JsonProperty("marketKey")]
        public string? MarketKey { get; set; } = default;

        [JsonProperty("spread")]
        public float? Spread { get; set; } = default;

        [JsonProperty("index")]
        public int? Index { get; set; } = default;

        [JsonProperty("isHidden")]
        public int? IsHidden { get; set; } = default;

        [JsonProperty("isSuspended")]
        public int? IsSuspended { get; set; } = default;

        private IReadOnlyCollection<Odd>? Odds { get; set; } = default;
    }
}
