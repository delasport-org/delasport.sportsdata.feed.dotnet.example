namespace Delasport.Sportsdata.Feed.Models.Settlement
{
    using Newtonsoft.Json;

    public class Odd
    {
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("selectionStatus")]
        public string? SelectionStatus { get; set; } = default;
    }
}
