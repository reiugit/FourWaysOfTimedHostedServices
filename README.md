# Four ways of Timed HostedServices in .Net 8

1. 'HostedService' - timed with TimeProvider.Timer . . . best choice for Unit Tests
2. 'HostedService' - timed with Timer
3. 'Worker' - timed with Task.Delay
4. 'Worker' - timed with PeriodicTimer
&nbsp;<br><br>

### 1. 'HostedService' - timed with TimeProvider.Timer
This kind of Hosted Service enables Unit Testing without delays.
* Create your Timers with timeProvider.CreateTimer(...) instead of new Timer(...).
* For Unit Tests simply install NuGet package 'Microsoft.Extensions.TimeProvider.Testing'.<br>
* Then inject Microsoft.Extensions.Time.Testing.FakeTimeProvider instead of TimeProvider.System.
* Now you can change the time within your unit tests for example with fakeTimeProvider.Advance(timespan).

### 2. 'HostedService' - timed with Timer
A traditional Timer is not perfect for unit tests.

### 3. 'Worker' - timed with Task.Delay
Task.Delay is not perfect for unit tests.

### 4. 'Worker' - timed with PeriodicTimer
A PeriodicTimer is not perfect for unit tests.
