FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["src/SequenceFinder/SequenceFinder.csproj", "src/SequenceFinder/"]
RUN dotnet restore "src/SequenceFinder/SequenceFinder.csproj"

COPY . .
WORKDIR "/src/src/SequenceFinder"

RUN dotnet publish "SequenceFinder.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore

FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "SequenceFinder.dll"]