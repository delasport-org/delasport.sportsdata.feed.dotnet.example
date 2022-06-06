namespace Delasport.Sportsdata.Common
{
    using Confluent.Kafka;
    using Delasport.Sportsdata.Common;
    using Confluent.Kafka.SyncOverAsync;
    using Confluent.SchemaRegistry.Serdes;

    public abstract class WorkerBase<TMessage>  : BackgroundService where TMessage : class
    {
        protected readonly ILogger<WorkerBase<TMessage>> _logger;
        private readonly IApplicationSettings _settings;

        public abstract Task ProcessMessage(TMessage message);

        public WorkerBase(
            ILogger<WorkerBase<TMessage>> logger,
            IApplicationSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumerConfig = new ConsumerConfig
            {
                BootstrapServers = _settings.Server,
                GroupId = _settings.GroupId,
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslMechanism = SaslMechanism.Plain,
                ClientId = "pilot_dotnet",
                SaslUsername = _settings.Key,
                SaslPassword = _settings.Secret,
                AutoOffsetReset = AutoOffsetReset.Latest
            };

            using var consumer =
               new ConsumerBuilder<Ignore, TMessage>(consumerConfig)
                   .SetValueDeserializer(new JsonDeserializer<TMessage>().AsSyncOverAsync())
                   .SetErrorHandler((_, e) => Console.WriteLine($"Error: {e.Reason}"))
                   .Build();

            consumer.Subscribe(_settings.Topic);

            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                    var result = consumer.Consume(stoppingToken);


                    await ProcessMessage(result.Message.Value);
                }
            }
            catch (OperationCanceledException)
            {
                consumer.Close();
            }
        }
    }
}