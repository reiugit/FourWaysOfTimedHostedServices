using FourWaysOfTimedHostedServices.HostedServices;

var builder = Host.CreateApplicationBuilder(args);
{
    builder.Services.AddHostedService<WorkerWithTaskDelay>();
    builder.Services.AddHostedService<WorkerWithPeriodicTimer>();
    builder.Services.AddHostedService<HostedServiceWithTimer>();
    builder.Services.AddHostedService(_ => new HostedServiceWithTimeProvider(TimeProvider.System));
}

var host = builder.Build();
host.Run();
