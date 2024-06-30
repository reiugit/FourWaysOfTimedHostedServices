using Microsoft.Extensions.Time.Testing;
using FourWaysOfTimedHostedServices.HostedServices;

namespace ExampleTests;

public class HostedServiceWithFakeTimeProviderTests
{
    [Fact]
    public async Task HostedServiceWithFakeTimeProvider_ShouldReturn_2()
    {
        //Arrange
        var timeProvider = new FakeTimeProvider();
        var sut = new HostedServiceWithTimeProvider(timeProvider);
        await sut.StartAsync(CancellationToken.None);

        //Act
        timeProvider.Advance(TimeSpan.FromSeconds(1.5)); //no delay
        
        //Assert
        Assert.Equal(1, sut.Count);

        await sut.StopAsync(CancellationToken.None);
    }
}