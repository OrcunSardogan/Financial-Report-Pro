# 📊 Financial Report Application

Financial Report Application, .NET teknolojileri ile geliştirilmiş, kullanıcıların finansal verilerini analiz edip görselleştirmesini sağlayan dinamik bir raporlama aracıdır.  
Uygulama, **katmanlı mimari** yaklaşımıyla tasarlanmıştır ve **Entity Framework Core** kullanarak veritabanı işlemlerini yönetir.

---

## 🚀 Özellikler

- **Dinamik Raporlama:** Finansal verileri tarihe, kategoriye veya özelleştirilmiş filtrelere göre raporlar.
- **Grafik ve Görselleştirme:** Çizgi, pasta ve çubuk grafikler ile verilerinizi anlamlandırır.
- **Çoklu Format Desteği:** PDF, Excel ve CSV formatlarında rapor dışa aktarma.
- **Veri Analizi:** Toplam, ortalama, maksimum ve minimum değer hesaplamaları.
- **Katmanlı Mimari:** Ayrık veri, servis ve sunum katmanları.
- **Responsive UI:** Masaüstü ve web uyumlu tasarım.

---

## 🛠️ Teknolojiler

- **Backend:** C#, .NET 6+
- **ORM:** Entity Framework Core
- **Database:** SQL Server / SQLite
- **Frontend:** ASP.NET Core MVC / Razor Pages
- **Grafikler:** Chart.js
- **Dışa Aktarma:** ClosedXML (Excel), iText7 (PDF)

---

## 📂 Proje Yapısı

FinancialReport/
├── FinancialReport.Domain # Veri modelleri
├── FinancialReport.Infrastructure # EF Core ve veri erişim katmanı
├── FinancialReport.Application # Servisler ve iş mantığı
├── FinancialReport.WebUI # Sunum katmanı (MVC)
└── README.md

---

## 📦 Kurulum

1. Repoyu klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/FinancialReport.git
   cd FinancialReport
