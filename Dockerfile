
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80



RUN dotnet restore "./DevOpsContentful.csproj"
COPY . .

RUN dotnet publish "DevOpsContentful.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevOpsContentful.dll"]