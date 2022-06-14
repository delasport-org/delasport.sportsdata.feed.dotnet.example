namespace Delasport.Sportsdata.Feed
{
    using Delasport.Sportsdata.Common;
    using Microsoft.Extensions.Logging;
    using Models.Settlement;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;

    public class ResultSettlementWorker : WorkerBase<ResultSettlement>
    {
        public ResultSettlementWorker(
            ILogger<WorkerBase<ResultSettlement>> logger, IOptions<ResultSettlementSettings> settings) : base(logger, settings.Value)
        { }

        public override Task ProcessMessage(ResultSettlement message)
        {
            // TO DO Implement logic
            return Task.CompletedTask;
        }
    }
}
