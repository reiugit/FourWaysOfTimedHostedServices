using Microsoft.Extensions.Time.Testing;
using FourWaysOfTimedHostedServices.HostedServices;

namespace ExampleTests;

public class HostedServiceWithFakeTimeProviderTests
{
    [Fact]
    public async Task HostedServiceWithFakeTimeProvider_ShouldReturn_2()
    {
        //Arrange
        var fakeTimeProvider = new FakeTimeProvider(DateTimeOffset.UtcNow);
        var sut = new HostedServiceWithTimeProvider(fakeTimeProvider);
        await sut.StartAsync(CancellationToken.None);

        //Act
        fakeTimeProvider.Advance(TimeSpan.FromSeconds(1.5)); //no delay
        
        //Assert
        Assert.Equal(1, sut.Count);

        await sut.StopAsync(CancellationToken.None);
    }
}