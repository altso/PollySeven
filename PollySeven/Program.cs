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

            // System.TypeLoadException:
            // 'Could not load type 'Polly.RetrySyntaxAsync' from assembly 'Polly, Version=7.0.0.0, Culture=neutral, PublicKeyToken=c8a3ffc3f8f825cc'.'
        }
    }
}
