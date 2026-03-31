using BlazorDashboardLTE.Application.Models;

namespace BlazorDashboardLTE.Application.Tests;

public class DashboardMetricTests
{
    [Theory]
    [InlineData(3.2, "+3.2%", "trend-up")]
    [InlineData(0, "+0%", "trend-up")]
    [InlineData(-4.9, "-4.9%", "trend-down")]
    public void CreatesExpectedTrendMetadata(decimal delta, string expectedLabel, string expectedCss)
    {
        var metric = new DashboardMetric("Availability", "99.9%", "fa-solid fa-heart-pulse", delta);

        Assert.Equal(expectedLabel, metric.DeltaLabel);
        Assert.Equal(expectedCss, metric.TrendCss);
    }
}
