using Microsoft.Extensions.DependencyInjection;
using BlazorDashboardLTE.Application.Abstractions;
using BlazorDashboardLTE.Infrastructure.Services;

namespace BlazorDashboardLTE.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddDashboardInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IDashboardMetricsService, InMemoryDashboardMetricsService>();
        return services;
    }
}
