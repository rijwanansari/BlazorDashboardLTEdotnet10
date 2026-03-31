namespace BlazorDashboardLTE.Application.Models;

public sealed record ActivityFeedItem(string Title, string Description, DateTimeOffset OccurredAtUtc, string BadgeCss);
