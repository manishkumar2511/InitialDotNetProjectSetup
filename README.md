# DotNetCore Web API Template

A `dotnet new` template that scaffolds a clean, ready-to-run **ASP.NET Core Web API** project in seconds so you don't have to set up the same boilerplate (project structure, Swagger, config files) every time you start a new backend service.

## Why use this?

Every new .NET Web API project starts with the same repetitive setup creating folders, wiring up Swagger, cleaning out sample code. This template automates that, so you go from `dotnet new` to writing actual business logic in one command.

## Requirements

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later
- Works on **Windows** (CMD/PowerShell), **macOS** (Terminal), and **Linux** (bash/zsh) — the commands below are identical on all three, since they're `dotnet` CLI commands, not OS-specific shell commands.

## Install

```console
dotnet new install DotNetCoreWebApiTemplate
```

## Create a new project

```console
dotnet new dotnetcore-webapi -n MyProject
```

Replace `MyProject` with your desired project/namespace name.

**By default, all available features are included.** You'll be prompted for each one just press Enter to accept the default (`true`) and keep the feature, or type `false` at the prompt to leave it out.

| Option | Type | Default | Description |
|---|---|---|---|
| `IncludeSwagger` | bool | `true` | Include Swagger/OpenAPI documentation |

If you don't want a specific feature, you don't need to go through the prompt just pass it explicitly on the command line:

```console
dotnet new dotnetcore-webapi -n MyProject --IncludeSwagger false
```

This skips the prompt for that option and generates the project without it, while everything else still defaults to included.

## Run the project

```console
cd MyProject
dotnet run
```

No `.sln` file is required to build or run the project from the command line — `dotnet run` works directly against the `.csproj`.

### Running in Visual Studio (Windows/Mac)

Visual Studio needs a solution (`.sln`) file to open a project. Since the template doesn't generate one, create it manually after scaffolding:

```console
cd MyProject
dotnet new sln
dotnet sln add MyProject.csproj
```

This creates `MyProject.sln` in the folder and adds your project to it. You can now double-click the `.sln` file (Windows) or open it via Visual Studio for Mac / VS Code to work with the project.

## What's included till Now.

- ASP.NET Core Web API (.NET 10, Controllers-based structure)
- Optional Swagger/OpenAPI support via Swashbuckle.AspNetCore
- Clean starting point — no sample/demo clutter left behind

## Roadmap — coming soon

This template is actively evolving. Planned additions:

- Clean Architecture folder structure (Domain / Application / Infrastructure / API layers)
- Repository pattern with generic repository + Unit of Work
- JWT Authentication & Authorization boilerplate
- Global exception handling middleware
- Serilog-based structured logging
- FluentValidation integration
- Dockerfile for containerized deployment

All future options will remain **opt-in by default inclusion** — enabled unless you explicitly turn them off.

## Update to the latest version

```console
dotnet new update
```

## Uninstall

```console
dotnet new uninstall DotNetCoreWebApiTemplate
```

## Contributing / Feedback

Found a bug or have a feature request? Open an issue on the [GitHub repository](https://github.com/manishkumar2511/DotNetCoreWebApiTemplate).

## License

MIT