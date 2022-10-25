#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["./services/Gouro.Clientes.API/Gouro.Clientes.API.csproj", "services/Gouro.Clientes.API/"]
COPY ["./building blocks/Gouro.Core/Gouro.Core.csproj", "building blocks/Gouro.WebApi.Core/"]
COPY ["./building blocks/Gouro.WebApi.Core/Gouro.WebApi.Core.csproj", "building blocks/Gouro.WebApi.Core/"]
COPY ["./building blocks/Gouro.MessageBus/Gouro.MessageBus.csproj", "building blocks/Gouro.MessageBus/"]

RUN dotnet restore "services/Gouro.Clientes.API/Gouro.Clientes.API.csproj"
COPY . .
WORKDIR "services/Gouro.Clientes.API"
RUN dotnet build "Gouro.Clientes.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gouro.Clientes.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gouro.Clientes.API.dll"]