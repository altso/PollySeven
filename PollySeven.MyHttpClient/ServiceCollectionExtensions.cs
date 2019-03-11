using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace PollySeven.MyHttpClient
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            services.AddHttpClient<MyService>()
                .AddTransientHttpErrorPolicy(p => p.RetryAsync());
            return services;
        }
    }
}