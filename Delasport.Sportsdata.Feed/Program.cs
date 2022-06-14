using Delasport.Sportsdata.Common;
using Delasport.Sportsdata.Feed;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostetContext, services) =>
    {
        services
            .Configure<EventSettings>(
            hostetContext.Configuration.GetSection(nameof(EventSettings)),
            options => options.BindNonPublicProperties = true)
            .Configure<MarketSettings>(
            hostetContext.Configuration.GetSection(nameof(MarketSettings)),
            options => options.BindNonPublicProperties = true)
            .Configure<ResultSettlementSettings>(
            hostetContext.Configuration.GetSection(nameof(ResultSettlementSettings)),
            options => options.BindNonPublicProperties = true);

        services
            .AddHostedService<EventWorker>()
            .AddHostedService<MarketWorker>()
            .AddHostedService<ResultSettlementWorker>();
    })
    .Build();

await host.RunAsync();
