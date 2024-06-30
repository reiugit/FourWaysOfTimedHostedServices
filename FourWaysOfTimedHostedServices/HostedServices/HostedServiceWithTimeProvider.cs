using FourWaysOfTimedHostedServices.Services;

namespace FourWaysOfTimedHostedServices.HostedServices;

public class HostedServiceWithTimeProvider(TimeProvider timeProvider) : IHostedService, IDisposable
{
    private ITimer? _timer;
    private int count;

    public int Count => count;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = timeProvider.CreateTimer(callback: IncrementCounter, 
                                          state: null,
                                          dueTime: TimeSpan.FromSeconds(1),
                                          period: TimeSpan.FromSeconds(1));
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.InfiniteTimeSpan, Timeout.InfiniteTimeSpan);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
        GC.SuppressFinalize(this);
    }

    private void IncrementCounter(object? state = null)
        => CounterService.IncrementCounter(this, ref count);
}
