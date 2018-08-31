FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 51702
EXPOSE 44352

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY Haptix.RAMHX.Management/Haptix.RAMHX.Management.csproj Haptix.RAMHX.Management/
RUN dotnet restore Haptix.RAMHX.Management/Haptix.RAMHX.Management.csproj
COPY . .
WORKDIR /src/Haptix.RAMHX.Management
RUN dotnet build Haptix.RAMHX.Management.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Haptix.RAMHX.Management.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Haptix.RAMHX.Management.dll"]
