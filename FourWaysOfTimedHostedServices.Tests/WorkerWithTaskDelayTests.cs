using FourWaysOfTimedHostedServices.HostedServices;

namespace FourWaysOfTimedHostedServices.Tests;

public class WorkerWithTaskDelayTests
{
    [Fact]
    public async Task WorkerWithTaskDelay_ShouldReturn_1()
    {
        //Arrange
        var sut = new WorkerWithTaskDelay();
        await sut.StartAsync(CancellationToken.None);

        //Act
        await Task.Delay(1500);

        //Assert
        Assert.Equal(1, sut.Count);

        await sut.StopAsync(CancellationToken.None);
    }
}