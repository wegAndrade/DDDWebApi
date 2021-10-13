#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["1.0 Presentation/DDDWebApi.Presentation/DDDWebApi.Presentation.csproj", "1.0 Presentation/DDDWebApi.Presentation/"]
RUN dotnet restore "1.0 Presentation/DDDWebApi.Presentation/DDDWebApi.Presentation.csproj"
COPY . .
WORKDIR "/src/1.0 Presentation/DDDWebApi.Presentation"
RUN dotnet build "DDDWebApi.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DDDWebApi.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DDDWebApi.Presentation.dll"]