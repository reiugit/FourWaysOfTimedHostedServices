using FourWaysOfTimedHostedServices.Services;

namespace FourWaysOfTimedHostedServices.HostedServices;

public class WorkerWithTaskDelay() : BackgroundService
{
    private int count;

    public int Count => count;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (true)
        {
            await Task.Delay(1000, stoppingToken);

            CounterService.IncrementCounter(this, ref count);
        }
    }
}
