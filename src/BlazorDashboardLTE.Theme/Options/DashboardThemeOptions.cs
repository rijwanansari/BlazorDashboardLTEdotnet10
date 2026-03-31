using BlazorDashboardLTE.Theme.Models;

namespace BlazorDashboardLTE.Theme.Options;

public sealed class DashboardThemeOptions
{
    public string AppName { get; set; } = "Blazor Dashboard";
    public string UserDisplayName { get; set; } = "Ops Admin";
    public IList<DashboardNavItem> NavigationItems { get; } =
    [
        new("Dashboard", "/", "fa-solid fa-gauge"),
        new("Analytics", "/analytics", "fa-solid fa-chart-pie"),
        new("Operations", "/operations", "fa-solid fa-gears")
    ];
}
