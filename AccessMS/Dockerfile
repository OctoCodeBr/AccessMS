FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["./AccessMS/AccessMS.csproj", "AccessMS/"]
RUN dotnet restore "AccessMS/AccessMS.csproj"
COPY . .
WORKDIR "/src/AccessMS"
RUN dotnet build "AccessMS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AccessMS.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AccessMS.dll"]