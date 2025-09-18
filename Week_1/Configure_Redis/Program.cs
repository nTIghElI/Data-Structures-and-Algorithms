using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;
class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = "localhost:6379";
            options.InstanceName = "SampleInstance";
        });
        var provider = services.BuildServiceProvider();
        var cache = provider.GetService<IDistributedCache>();
        Console.WriteLine("Redis Cache Configured!");
    }
}
