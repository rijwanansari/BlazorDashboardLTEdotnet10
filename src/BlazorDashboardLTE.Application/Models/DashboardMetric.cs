namespace BlazorDashboardLTE.Application.Models;

public sealed record DashboardMetric(string Name, string Value, string IconCss, decimal DeltaPercent)
{
    public string TrendCss => DeltaPercent >= 0 ? "trend-up" : "trend-down";
    public string DeltaLabel => $"{(DeltaPercent >= 0 ? "+" : string.Empty)}{DeltaPercent:0.#}%";
}
