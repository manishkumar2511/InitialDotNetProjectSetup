# DotNetCore Web API Template

A configurable `dotnet new` template for quickly scaffolding ASP.NET Core Web API projects — with options to include only the features you need.

## Install

```bash
dotnet new install DotNetCoreWebApiTemplate
```

## Create a new project

```bash
dotnet new dotnetcore-webapi -n MyProject --interactive
```

You'll be prompted for:

| Option | Type | Default | Description |
|---|---|---|---|
| `IncludeSwagger` | bool | `true` | Include Swagger/OpenAPI documentation |

You can also skip the prompt and pass the value directly:

```bash
dotnet new dotnetcore-webapi -n MyProject --IncludeSwagger false
```

## Run the project

```bash
cd MyProject
dotnet run
```

No solution file is required to build or run the project.

## Optional: create a solution file

If you want a `.sln` file (for example, to open the project in Visual Studio or add more projects later):

```bash
cd MyProject
dotnet new sln
dotnet sln add MyProject.csproj
```

## What's included

- ASP.NET Core Web API (.NET 10, Controllers-based)
- Optional Swagger/OpenAPI support via Swashbuckle.AspNetCore

## Update to the latest version

```bash
dotnet new update
```

## Uninstall

```bash
dotnet new uninstall DotNetCoreWebApiTemplate
```

## License

MIT