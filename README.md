# Four ways of Timed HostedServices

1. HostedService with Timer
2. HostedService with TimeProvider
3. Worker with Task.Delay
4. Worker with PeriodicTimer

### 1. HostedService with TimeProvider
This kind of Hosted Service enables Unit Testing without delays.<br>
In a Unit Test simply install NuGet package 'Microsoft.Extensions.TimeProvider.Testing'.<br>
Inject Microsoft.Extensions.Time.Testing.FakeTimeProvider instead of TimeProvider.System.
### 2. HostedService with Timer
Difficult for unit tests.
### 3. Worker with Task.Delay
Difficult for unit tests.
### 4. Worker with PeriodicTimer
Difficult for unit tests.
