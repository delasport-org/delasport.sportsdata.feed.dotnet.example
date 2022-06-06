namespace Delasport.Sportsdata.Feed
{
    using Delasport.Sportsdata.Common;
    using Microsoft.Extensions.Logging;
    using Models;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;

    public class MarketWorker : WorkerBase<Market>
    {
        public MarketWorker(
            ILogger<WorkerBase<Market>> logger, IOptions<MarketSettings> settings) : base(logger, settings.Value)
        { }

        public override Task ProcessMessage(Market message)
        {
            // TO DO Implement logic
            return Task.CompletedTask;
        }
    }
}
