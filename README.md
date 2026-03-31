# BlazorDashboardLTE (.NET 10)

Production-grade, modular Blazor dashboard solution with an AdminLTE-style shell and clean layered architecture.

## Solution structure

- `src/BlazorDashboardLTE.Host`: App host and composition root
- `src/BlazorDashboardLTE.Theme`: Reusable Razor Class Library for shell/layout/components
- `src/BlazorDashboardLTE.Application`: Contracts and application-level abstractions
- `src/BlazorDashboardLTE.Infrastructure`: Service implementations and external concerns
- `tests/BlazorDashboardLTE.Application.Tests`: Unit tests

## Why this structure

- Modular by design: UI shell can be reused in other Blazor hosts
- Production defaults: centralized package management, analyzers, and health endpoint
- Layered boundaries: host depends on abstractions and implementations via DI extensions

## Run

```bash
dotnet restore
dotnet build BlazorDashboardLTE.slnx
dotnet run --project src/BlazorDashboardLTE.Host
```

Browse to `https://localhost:5001` or the URL shown in terminal.

## Reuse the theme in another project

1. Reference `BlazorDashboardLTE.Theme`.
2. Register services with `AddDashboardTheme()`.
3. Set your router default layout to `AdminShellLayout`.
4. Include CSS/JS from `_content/BlazorDashboardLTE.Theme/`.
