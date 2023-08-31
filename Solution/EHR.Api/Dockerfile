#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Solution/EHR.Api/EHR.Api.csproj", "Solution/EHR.Api/"]
RUN dotnet restore "Solution/EHR.Api/EHR.Api.csproj"
COPY . .
WORKDIR "/src/Solution/EHR.Api"
RUN dotnet build "EHR.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EHR.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EHR.Api.dll"]