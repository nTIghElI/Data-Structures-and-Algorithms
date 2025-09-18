using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;
class ProgramCashe
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = "localhost:6379";
            options.InstanceName = "SampleInstance";
        });
        var provider = services.BuildServiceProvider();
        var cache = provider.GetService<IDistributedCache>();
        string cacheKey = "SharedCounter";
        string cachedValue = await cache.GetStringAsync(cacheKey);
        int counter = cachedValue != null ? int.Parse(cachedValue) : 0;
        counter++;
        await cache.SetStringAsync(cacheKey, counter.ToString());
        Console.WriteLine($"Updated Counter: {counter}");
    }
}
