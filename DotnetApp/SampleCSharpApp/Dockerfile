#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SampleCSharpApp/SampleCSharpApp.csproj", "SampleCSharpApp/"]
RUN dotnet restore "SampleCSharpApp/SampleCSharpApp.csproj"
COPY . .
WORKDIR "/src/SampleCSharpApp"
RUN dotnet build "SampleCSharpApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleCSharpApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:4321
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleCSharpApp.dll"]