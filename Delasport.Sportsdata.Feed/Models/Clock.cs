namespace Delasport.Sportsdata.Feed.Models
{
    using Newtonsoft.Json;

    public class Clock
    {
        [JsonProperty("isCountdown")]
        public int? IsCountdown { get; set; } = default;

        [JsonProperty("isStopped")]
        public int? IsStopped { get; set; } = default;

        [JsonProperty("startSecond")]
        public int? StartSecond { get; set; } = default;

        [JsonProperty("startTimestamp")]
        public int? StartTimestamp { get; set; } = default;
    }
}
