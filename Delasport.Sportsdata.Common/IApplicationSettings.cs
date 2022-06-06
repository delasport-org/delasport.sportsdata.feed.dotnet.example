namespace Delasport.Sportsdata.Common
{
    public interface IApplicationSettings
    {
        public string Server { get; init; }

        public string Key { get; init; }

        public string Secret { get; init; }

        public string Topic { get; init; }

        public string GroupId { get; init; }
    }
}
