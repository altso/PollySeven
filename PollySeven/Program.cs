using Microsoft.Extensions.DependencyInjection;
using PollySeven.MyHttpClient;

namespace PollySeven
{
    class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<MyService>();

            ServiceProvider provider = services.BuildServiceProvider(true);

            var service = provider.GetRequiredService<MyService>();

            // System.InvalidOperationException:
            // 'Unable to resolve service for type 'System.Net.Http.HttpClient' while attempting to activate 'PollySeven.MyHttpClient.MyService'.'
        }
    }
}
