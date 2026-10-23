FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY 1.1GettingStarted.csproj .
RUN dotnet restore 1.1GettingStarted.csproj

COPY . .
RUN dotnet publish 1.1GettingStarted.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "1.1GettingStarted.dll"]
