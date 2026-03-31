using BlazorDashboardLTE.Theme.Options;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDashboardLTE.Theme;

public static class DependencyInjection
{
    public static IServiceCollection AddDashboardTheme(this IServiceCollection services, Action<DashboardThemeOptions>? configure = null)
    {
        var optionsBuilder = services.AddOptions<DashboardThemeOptions>();

        if (configure is not null)
        {
            optionsBuilder.Configure(configure);
        }

        return services;
    }
}
