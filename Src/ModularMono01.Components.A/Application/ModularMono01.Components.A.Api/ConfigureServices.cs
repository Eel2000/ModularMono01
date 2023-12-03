using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModularMono01.Components.A.Api
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddAComponent(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UseAComponent(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
