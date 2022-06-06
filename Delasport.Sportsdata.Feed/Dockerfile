FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Delasport.Sportsdata.Feed/Delasport.Sportsdata.Feed.csproj", "Delasport.Sportsdata.Feed/"]
COPY ["Delasport.Sportsdata.Common/Delasport.Sportsdata.Common.csproj", "Delasport.Sportsdata.Common/"]
RUN dotnet restore "Delasport.Sportsdata.Feed/Delasport.Sportsdata.Feed.csproj"
COPY . .
WORKDIR "/src/Delasport.Sportsdata.Feed"
RUN dotnet build "Delasport.Sportsdata.Feed.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delasport.Sportsdata.Feed.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delasport.Sportsdata.Feed.dll"]