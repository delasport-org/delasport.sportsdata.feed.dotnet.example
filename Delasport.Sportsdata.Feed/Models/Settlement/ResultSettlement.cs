namespace Delasport.Sportsdata.Feed.Models.Settlement
{
    using Newtonsoft.Json;

    public class ResultSettlement
    {
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("selectionStatus")]
        public string SelectionStatus { get; set; } = default!;

        [JsonProperty("oddId")]
        public string OddId { get; set; } = default!;

        [JsonProperty("marketId")]
        public string MarketId { get; set; } = default!;

        [JsonProperty("eventId")]
        public string EventId { get; set; } = default!;

        [JsonProperty("marketTypeId")]
        public string? MarketTypeId { get; set; } = default;

        [JsonProperty("sportId")]
        public string? SportId { get; set; } = default;

        [JsonProperty("leagueId")]
        public string? LeagueId { get; set; } = default;

        [JsonProperty("foreignKey")]
        public string? ForeignKey { get; set; } = default;

        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; } = default;
    }
}
