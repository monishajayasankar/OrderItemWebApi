FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet build
RUN dotnet publish -c Release -o outdir   


# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /src/outdir .
ENTRYPOINT ["dotnet", "OrderItemWebApi.dll"]