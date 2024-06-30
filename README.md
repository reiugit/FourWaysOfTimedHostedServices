# Four ways of Timed HostedServices in .Net 8

1. 'HostedService' - timed with TimeProvider . . . best choice for Unit Tests
2. 'HostedService' - timed with Timer
3. 'Worker' - timed with Task.Delay
4. 'Worker' - timed with PeriodicTimer

### 1. 'HostedService' - timed with TimeProvider
This kind of Hosted Service enables Unit Testing without delays.<br>
For Unit Tests simply install NuGet package 'Microsoft.Extensions.TimeProvider.Testing'.<br>
Then inject Microsoft.Extensions.Time.Testing.FakeTimeProvider instead of TimeProvider.System.

### 2. 'HostedService' - timed with Timer
A Timer is not perfect for unit tests.

### 3. 'Worker' - timed with Task.Delay
Task.Delay is not perfect for unit tests.

### 4. 'Worker' - timed with PeriodicTimer
A PeriodicTimer is not perfect for unit tests.
