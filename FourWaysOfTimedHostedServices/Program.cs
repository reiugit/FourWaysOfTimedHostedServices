using FourWaysOfTimedHostedServices.HostedServices;

var builder = Host.CreateApplicationBuilder(args);
{
    builder.Services.AddSingleton(TimeProvider.System);

    builder.Services.AddHostedService<WorkerWithTaskDelay>();
    builder.Services.AddHostedService<WorkerWithPeriodicTimer>();
    builder.Services.AddHostedService<HostedServiceWithTimer>();
    builder.Services.AddHostedService< HostedServiceWithTimeProvider>();
}

var host = builder.Build();
host.Run();
