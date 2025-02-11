# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy the .csproj file and restore any dependencies (via dotnet restore)
COPY ["TaskSyncAPI.csproj", "./"]
RUN dotnet restore "TaskSyncAPI.csproj"

# Copy the rest of the application
COPY . .

# Build the application and publish to the /app/publish directory
RUN dotnet publish "TaskSyncAPI.csproj" -c Release -o /app/publish

# Copy the build app from the publish stage
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TaskSyncAPI.dll"]
