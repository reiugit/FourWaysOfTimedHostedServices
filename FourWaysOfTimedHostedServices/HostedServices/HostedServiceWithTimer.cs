using FourWaysOfTimedHostedServices.Services;

namespace FourWaysOfTimedHostedServices.HostedServices;

public class HostedServiceWithTimer() : IHostedService, IDisposable
{
    private Timer? _timer;

    public int Count;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(IncrementCounter, null,
                           TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
        GC.SuppressFinalize(this);
    }

    private void IncrementCounter(object? state)
        => CounterService.IncrementCounter(this, ref Count);
}
