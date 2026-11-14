# Repository Guidance

## Project
- `DatingApp.sln` contains the `API` ASP.NET Core Web API project.
- The API targets .NET 9, with nullable reference types and implicit usings enabled.
- Application startup and middleware are configured in `API/Program.cs`; HTTP endpoints are implemented under `API/Controllers/`.
- `API/WeatherForecast.cs` and its controller are template examples, not domain-specific conventions.

## Build and Run
- Build the solution: `dotnet build DatingApp.sln`
- Run the API: `dotnet run --project API/API.csproj`
- The configured development URLs are `http://localhost:5123` and `https://localhost:7203`.
- In Development, OpenAPI is available at `/openapi/v1.json`. A sample request is in `API/API.http`.

## Change Guidelines
- Keep API behavior in controllers or an appropriate service; register dependencies in `API/Program.cs`.
- Preserve nullable-reference annotations and use the existing ASP.NET Core conventions.
- No test project is currently present. Add focused tests when introducing behavior that warrants them, and run the solution build after changes.