using BlazorDashboardLTE.Application.Abstractions;
using BlazorDashboardLTE.Application.Models;

namespace BlazorDashboardLTE.Infrastructure.Services;

internal sealed class InMemoryDashboardMetricsService : IDashboardMetricsService
{
    public Task<IReadOnlyList<DashboardMetric>> GetOverviewAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyList<DashboardMetric> metrics =
        [
            new("Active Users", "12,480", "fa-solid fa-users", 5.6m),
            new("Revenue", "$84,320", "fa-solid fa-chart-line", 3.1m),
            new("Open Tickets", "37", "fa-solid fa-life-ring", -2.4m),
            new("Deploy Success", "99.94%", "fa-solid fa-rocket", 0.8m)
        ];

        return Task.FromResult(metrics);
    }

    public Task<IReadOnlyList<ActivityFeedItem>> GetRecentActivityAsync(CancellationToken cancellationToken = default)
    {
        var now = DateTimeOffset.UtcNow;

        IReadOnlyList<ActivityFeedItem> items =
        [
            new("Billing sync completed", "Nightly billing import finished with 0 failed records.", now.AddMinutes(-14), "badge-soft-success"),
            new("New admin invited", "A new tenant administrator was invited to the Finance workspace.", now.AddMinutes(-43), "badge-soft-info"),
            new("Background job warning", "Sales aggregate projection retried once due to timeout.", now.AddHours(-2), "badge-soft-warning"),
            new("Deployment finished", "Production deployment completed for version 2026.3.31.", now.AddHours(-5), "badge-soft-primary")
        ];

        return Task.FromResult(items);
    }
}
