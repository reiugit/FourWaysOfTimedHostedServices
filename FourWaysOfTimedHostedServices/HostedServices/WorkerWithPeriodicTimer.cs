using FourWaysOfTimedHostedServices.Services;

namespace FourWaysOfTimedHostedServices.HostedServices;

public class WorkerWithPeriodicTimer() : BackgroundService
{
    private int count;

    public int Count => count;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

        try
        {
            while (await timer.WaitForNextTickAsync(stoppingToken))
            {
                CounterService.IncrementCounter(this, ref count);
            }
        }
        catch (OperationCanceledException)
        {
        }
    }
}
