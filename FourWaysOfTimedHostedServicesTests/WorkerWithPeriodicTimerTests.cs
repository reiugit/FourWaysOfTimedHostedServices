using FourWaysOfTimedHostedServices.HostedServices;

namespace FourWaysOfTimedHostedServicesTests;

public class WorkerWithPeriodicTimerTests
{
    [Fact]
    public async Task WorkerWithPeriodicTimer_ShouldReturn_1()
    {
        //Arrange
        var sut = new WorkerWithPeriodicTimer();
        await sut.StartAsync(CancellationToken.None);

        //Act
        await Task.Delay(1500);

        //Assert
        Assert.Equal(1, sut.Count);

        await sut.StopAsync(CancellationToken.None);
    }
}