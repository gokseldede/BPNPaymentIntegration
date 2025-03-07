# .NET Core 8 Runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# .NET Core 8 SDK Image (Build ve Publish Ýçin)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Proje dosyalarýný kopyala ve baðýmlýlýklarý yükle
COPY ["BPNPaymentIntegration/BPNPaymentIntegration.csproj", "BPNPaymentIntegration/"]
RUN dotnet restore "BPNPaymentIntegration/BPNPaymentIntegration.csproj"

# Projeyi build et
COPY . .
WORKDIR "/src/BPNPaymentIntegration"
RUN dotnet build -c Release -o /app/build

# Yayýnlanabilir dosyalarý hazýrla
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# Çalýþtýrýlabilir container image oluþtur
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BPNPaymentIntegration.dll"]
