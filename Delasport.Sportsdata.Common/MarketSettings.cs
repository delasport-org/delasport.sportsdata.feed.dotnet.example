namespace Delasport.Sportsdata.Common
{
    public class MarketSettings : IApplicationSettings
    {
        public MarketSettings()
        {
            this.Server = default!;
            this.Key = default!;
            this.Secret = default!;
            this.Topic = default!;
            this.GroupId = default!;
        }

        public string Server { get; init; }
        public string Key { get; init; }
        public string Secret { get; init; }
        public string Topic { get; init; }
        public string GroupId { get; init; }
    }
}
