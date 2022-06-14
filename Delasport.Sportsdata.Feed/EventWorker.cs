namespace Delasport.Sportsdata.Feed
{
    using Delasport.Sportsdata.Common;
    using Microsoft.Extensions.Logging;
    using Models.Event;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;

    public class EventWorker : WorkerBase<Event>
    {
        public EventWorker(
            ILogger<WorkerBase<Event>> logger, IOptions<EventSettings> settings) : base(logger, settings.Value)
        { }

        public override Task ProcessMessage(Event message)
        {
            // TO DO Implement logic
            return Task.CompletedTask;
        }
    }
}
