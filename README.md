# Blazor demo

Blazor app built with C#, Blazor and Bootstrap, including unit tests built with .NET Core 3.1 in Visual Studio using the Microsoft unit test framework.

Tech stack:

- C#
- Blazor
- .NET Core
- Bootstrap
- Visual Studio

## Docker

Run the below commands in the terminal with Docker to run the app locally:

`` docker run -ti --rm -v `pwd`:/app mcr.microsoft.com/dotnet/core/sdk:3.1 bash ``
`cd /app/DevOpsBlazor`
`dotnet run`

Run the below commands with the same Docker image to run the unit tests:

`cd /app/DevOpsBlazor.UnitTests/`
`dotnet build --configuration Release`
`dotnet test --configuration Release`
