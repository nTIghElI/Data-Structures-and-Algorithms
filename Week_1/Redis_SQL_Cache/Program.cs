using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // 1. Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // 2. Set up dependency injection
        var services = new ServiceCollection();

        // 3. Configure Redis cache using the connection string from appsettings.json
        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = configuration.GetConnectionString("Redis"); // Or configuration["Redis:ConnectionString"]
            options.InstanceName = "RedisSqlCache_";
        });

        var serviceProvider = services.BuildServiceProvider();
        var cache = serviceProvider.GetRequiredService<IDistributedCache>();

        Console.WriteLine("Redis cache configured via appsettings.json.");

        // Example: Caching a SQL query result
        string sqlKey = "products:all";
        string productsData = await GetOrSetCachedSqlData(cache, sqlKey, async () =>
        {
            // Simulate fetching data from a SQL database
            Console.WriteLine("Fetching products from SQL database...");
            await Task.Delay(1000); // Simulate network/database latency
            return "Product A, Product B, Product C";
        });

        Console.WriteLine($"Retrieved data: {productsData}");
    }

    static async Task<string> GetOrSetCachedSqlData(IDistributedCache cache, string key, Func<Task<string>> dataFetcher)
    {
        string cachedData = await cache.GetStringAsync(key);
        if (!string.IsNullOrEmpty(cachedData))
        {
            Console.WriteLine($"Cache hit for key: {key}");
            return cachedData;
        }

        Console.WriteLine($"Cache miss for key: {key}. Fetching and caching data...");
        string data = await dataFetcher();

        var cacheEntryOptions = new DistributedCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(1));

        await cache.SetStringAsync(key, data, cacheEntryOptions);
        return data;
    }
}