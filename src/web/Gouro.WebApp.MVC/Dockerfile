#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["./web/Gouro.WebApp.MVC/Gouro.WebApp.MVC.csproj", "web/Gouro.WebApp.MVC/"]
COPY ["./building blocks/Gouro.Core/Gouro.Core.csproj", "building blocks/Gouro.WebApi.Core/"]
COPY ["./building blocks/Gouro.WebApi.Core/Gouro.WebApi.Core.csproj", "building blocks/Gouro.WebApi.Core/"]

RUN dotnet restore "web/Gouro.WebApp.MVC/Gouro.WebApp.MVC.csproj"
COPY . .
WORKDIR "web/Gouro.WebApp.MVC"
RUN dotnet build "Gouro.WebApp.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gouro.WebApp.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gouro.WebApp.MVC.dll"]