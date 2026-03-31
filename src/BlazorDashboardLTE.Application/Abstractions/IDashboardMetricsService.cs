using BlazorDashboardLTE.Application.Models;

namespace BlazorDashboardLTE.Application.Abstractions;

public interface IDashboardMetricsService
{
    Task<IReadOnlyList<DashboardMetric>> GetOverviewAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<ActivityFeedItem>> GetRecentActivityAsync(CancellationToken cancellationToken = default);
}
