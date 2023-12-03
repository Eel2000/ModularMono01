using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModularMono01.Components.B;

public static class ConfigureService
{
    public static IServiceCollection AddBComponent(this IServiceCollection services)
    {
        return services;
    }

    public static IApplicationBuilder UseBComponent(this IApplicationBuilder app)
    {
        return app;
    }
}
