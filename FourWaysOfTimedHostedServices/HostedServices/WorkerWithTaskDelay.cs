using FourWaysOfTimedHostedServices.Services;

namespace FourWaysOfTimedHostedServices.HostedServices;

public class WorkerWithTaskDelay() : BackgroundService
{
    public int Count;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (true)
        {
            await Task.Delay(1000, stoppingToken);

            CounterService.IncrementCounter(this, ref Count);
        }
    }
}
