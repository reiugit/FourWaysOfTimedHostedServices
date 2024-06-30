namespace FourWaysOfTimedHostedServices.Services;

internal static class CounterService
{
    static readonly object locker = new();
    static int lastCount;

    public static void IncrementCounter(object instance, ref int count)
    {
        lock (locker)
        {
            count++; //not necessary: Interlocked.Increment(ref count);

            if (count != lastCount)
            {
                Console.WriteLine();

                lastCount = count;
            }

            Console.WriteLine($"{count} - {instance.GetType().Name}");
        }
    }
}
