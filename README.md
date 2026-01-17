# Elektrik Tahsilat

Bu proje,Elektrik Tüketimini kontrol etmeyi amaçlayan masaüstü projesidir. 

## 🛠️ Kullanılan Teknolojiler

Bu proje, endüstri standartlarına uygun Microsoft teknolojileri ile geliştirilmiştir:

* **Backend:** C#
* **Veritabanı:** MSSQL (Microsoft SQL Server)
* **Veri Erişimi:** Entity Framework / ADO.NET *(Hangisini kullandıysanız buraya yazın)*
* **Geliştirme Ortamı (IDE):** Visual Studio 2022

## 🚀 Kurulum ve Çalıştırma

Projeyi yerel makinenizde (Localhost) çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi İndirin:**
    Repoyu ZIP olarak indirip çıkarın.
    
3.  **Projeyi Açın:**
    `ELEKTRIK.sln` dosyasını **Visual Studio 2022** ile açın.

4.  **Veritabanı Yapılandırması (Önemli!):**
    * MSSQL Server'ınızda veritabanını aktarın (`ELEKTRIK.bak`).
    * Projedeki `Web.config` dosyasını açın.
    * `connectionStrings` etiketi içindeki veritabanı bağlantı yolunu (Connection String) kendi yerel SQL sunucunuza göre güncelleyin.
    * 
## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

---
💻 **AYASCELL** tarafından Visual Studio 2022 ile geliştirilmiştir.
