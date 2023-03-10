#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CleanArchitecture.API/CleanArchitecture.API.csproj", "CleanArchitecture.API/"]
RUN dotnet restore "CleanArchitecture.API/CleanArchitecture.API.csproj"
COPY . .
WORKDIR "/src/CleanArchitecture.API"
RUN dotnet build "CleanArchitecture.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CleanArchitecture.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.API.dll"]