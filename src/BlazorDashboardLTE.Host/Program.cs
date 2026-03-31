using BlazorDashboardLTE.Host.Components;
using BlazorDashboardLTE.Application;
using BlazorDashboardLTE.Infrastructure;
using BlazorDashboardLTE.Theme;
using BlazorDashboardLTE.Theme.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddProblemDetails();
builder.Services.AddHealthChecks();
builder.Services.AddResponseCompression();

builder.Services.AddDashboardApplication();
builder.Services.AddDashboardInfrastructure();
builder.Services.AddDashboardTheme(options =>
{
    options.AppName = "AdminHub";
    options.UserDisplayName = "Platform Admin";
    options.NavigationItems.Clear();
    options.NavigationItems.Add(new DashboardNavItem("Dashboard", "/", "fa-solid fa-gauge"));
    options.NavigationItems.Add(new DashboardNavItem("Analytics", "/analytics", "fa-solid fa-chart-column"));
    options.NavigationItems.Add(new DashboardNavItem("Operations", "/operations", "fa-solid fa-screwdriver-wrench"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseResponseCompression();
app.UseHttpsRedirection();
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);

app.UseAntiforgery();

app.MapStaticAssets();
app.MapHealthChecks("/health");
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
