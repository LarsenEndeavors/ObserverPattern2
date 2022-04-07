FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ObserverPattern2.csproj", "./"]
RUN dotnet restore "ObserverPattern2.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "ObserverPattern2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObserverPattern2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObserverPattern2.dll"]
