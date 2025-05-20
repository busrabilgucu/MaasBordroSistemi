# Maaş Bordro Sistemi Projesi - README
# Proje Açıklaması
Bu proje, basit bir maaş bordro sistemi simülasyonudur.

- Personel abstract sınıfından kalıtım alan Memur ve Yönetici sınıfları vardır.

- Personel maaşları farklı hesaplama mantıkları ile hesaplanır.

- Personel bilgileri JSON dosyasından okunur.

- Maaşlar hesaplandıktan sonra JSON formatında ayrı dosyalara kaydedilir.

- 150 saatten az çalışan personeller konsola liste halinde yazdırılır.

# Proje Yapısı
- Personel (abstract) : Temel personel bilgilerini ve maaş hesaplama soyut metodunu içerir.

- Memur : Personel’den kalıtım alır, ek mesaiye göre maaş hesaplar.

- Yonetici : Personel’den kalıtım alır, minimum saatlik ücret kısıtlaması ve ek maaş içerir.

- MaasBordro : Maaşların hesaplanması ve dosyalara kaydedilmesi işlemlerini yapar.

- DosyaOku : Personel listesini JSON dosyasından okur ve nesne listesi döner.

- PersonalJson : JSON içindeki personel verisi için yardımcı sınıf.

- Program : Proje giriş noktası, dosya okuma, maaş hesaplama ve sonuçların gösterilmesi burada yapılır.

# Kullanım
Personal.json dosyasını "C:\Users\user\OneDrive\Desktop\MaasBilgileri\Personal.json" yoluna yerleştirin veya Program.cs içinde dosya yolunu değiştirin.

Programı çalıştırın.

Konsolda personel sayısı, 150 saatten az çalışanlar ve hesaplanan maaşlar görüntülenecektir.

MaasBordrolari klasörü altında her personel için klasörler ve içinde tarih bazlı maaş dosyaları oluşturulur.

# Gereksinimler
.NET Framework veya .NET Core

Newtonsoft.Json (JSON işlemleri için NuGet paketi)
