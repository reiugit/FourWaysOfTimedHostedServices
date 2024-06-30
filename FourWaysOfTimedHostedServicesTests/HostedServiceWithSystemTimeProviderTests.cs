using FourWaysOfTimedHostedServices.HostedServices;

namespace FourWaysOfTimedHostedServicesTests;

public class HostedServiceWithSystemTimeProviderTests
{
    [Fact]
    public async Task HostedServiceWithSystemTimeProvider_ShouldReturn_1()
    {
        //Arrange
        var timeProvider = TimeProvider.System;
        var sut = new HostedServiceWithTimeProvider(timeProvider);
        await sut.StartAsync(CancellationToken.None);

        //Act
        await Task.Delay(1500);

        //Assert
        Assert.Equal(1, sut.Count);

        await sut.StopAsync(CancellationToken.None);
    }
}