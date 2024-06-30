using FourWaysOfTimedHostedServices.HostedServices;

namespace FourWaysOfTimedHostedServicesTests;

public class HostedServiceWithTimerTests
{
    [Fact]
    public async Task HostedServiceWithTimer_ShouldReturn_1()
    {
        //Arrange
        var sut = new HostedServiceWithTimer();
        await sut.StartAsync(CancellationToken.None);

        //Act
        await Task.Delay(1500);

        //Assert
        Assert.Equal(1, sut.Count);

        await sut.StopAsync(CancellationToken.None);
    }
}