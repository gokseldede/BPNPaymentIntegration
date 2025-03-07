# 🚀 BPN Payment Integration

Bu proje, **BPN Balance Management API** ile entegre çalışan bir **e-ticaret ödeme entegrasyonu** sağlamaktadır.  
.NET Core 8 ve **Docker destekli** olarak geliştirilmiştir.

## **📌 Proje Özellikleri**
✅ **Ürün Listeleme** → `/api/products`  
✅ **Sipariş Oluşturma & Ödeme Rezervasyonu** → `/api/orders/create`  
✅ **Siparişi Tamamlama & Ödeme Onayı** → `/api/orders/{id}/complete`  
✅ **Hata Yönetimi & Retry Mekanizması**  
✅ **Swagger UI & API Dökümantasyonu**  
✅ **Unit & Integration Testler**  
✅ **Docker, CI/CD & GitHub Actions Desteği**  

---

## **📂 Proje Klasör Yapısı**
```bash
BPNPaymentIntegration/
│─ BPNPaymentIntegration.API
│   ├── Controllers/
│   ├── Middleware/
│   ├── Documentation/
│   ├── appsettings.json
│   └── Program.cs
│
│─ BPNPaymentIntegration.Application
│   ├── Services/
│   ├── Interfaces/
│   └── DTOs/
│
│─ BPNPaymentIntegration.Domain
│   ├── Entities/
│   └── Exceptions/
│
│─ BPNPaymentIntegration.Infrastructure
│   ├── Repositories/
│   └── Context/
│
│─ BPNPaymentIntegration.Tests
│   ├── UnitTests/
│   ├── IntegrationTests/
│   └── TestData/
│
│─ BPNPaymentIntegration.Deploy
│   ├── Dockerfile
│   ├── docker-compose.yml
│   └── GitHubActions.yml
│
│─ README.md
│─ .gitignore
│─ .editorconfig
```

---

## **🔧 Kurulum & Çalıştırma**
Bu projeyi kendi bilgisayarında çalıştırmak için aşağıdaki adımları takip edebilirsin.

### **1️⃣ Bağımlılıkları Kur**
```bash
dotnet restore
```

### **2️⃣ Projeyi Çalıştır**
```bash
dotnet run --project BPNPaymentIntegration.API
```
🔹 Proje çalıştırıldığında **Swagger UI** şu adreste açılacaktır:  
➡️ `https://localhost:7283/swagger`  

---

## **💪 Docker Kullanarak Çalıştırma**
### **1️⃣ Docker Image Oluştur**
```bash
docker build -t bpnpaymentintegration .
```
### **2️⃣ Container'ı Başlat**
```bash
docker run -p 5000:80 bpnpaymentintegration
```
🔹 Uygulamaya erişmek için **http://localhost:5000** adresini kullanabilirsin.

---

## **✅ Testler**
Projede **Unit Testler** ve **Integration Testler** bulunmaktadır.  
Tüm testleri çalıştırmak için:
```bash
dotnet test
```

---

## **📘 API Dökümantasyonu**
Proje Swagger UI desteğiyle birlikte gelir.  
**Swagger üzerinden API'yi test etmek için şu adrese git:**
```
https://localhost:7283/swagger
```

---

## **💪 Katkıda Bulunma**
1. **Fork yaparak projeyi kendi GitHub hesabına kopyala.**
2. Yeni bir özellik eklemek için **yeni bir branch oluştur**:
   ```bash
   git checkout -b feature/yeni-ozellik
   ```
3. **Kodlarını ekleyip commit yap**:
   ```bash
   git add .
   git commit -m "Yeni özellik eklendi"
   ```
4. **GitHub'a gönder**:
   ```bash
   git push origin feature/yeni-ozellik
   ```
5. **Pull request açarak değişikliklerini paylaş.**

---

## **📝 Lisans**
Bu proje **MIT Lisansı** ile lisanslanmıştır. **Serbestçe kullanabilir ve geliştirebilirsiniz.**  

---

🚀 **Bu proje hakkında herhangi bir sorunuz varsa, GitHub Issues üzerinden bizimle iletişime geçebilirsiniz!**

