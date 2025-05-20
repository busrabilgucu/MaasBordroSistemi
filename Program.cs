using MaasBordroSistemi;

public class Program
{

    static void Main()
    {
        // Dosya yolunu güncelle (Json dosyasi bilgisayarimda burada bulunyor.)
        string dosyaYolu = @"C:\Users\user\OneDrive\Desktop\MaasBilgileri\Personal.json";

        if (!File.Exists(dosyaYolu))
        {
            Console.WriteLine("Dosya bulunamadı.");
            return;
        }

        // Personel bilgilerininin json dosyasindan okunmasi
        List<Personel> personeller = DosyaOku.PersonelVerileriniOku(dosyaYolu);

        // Personel listesi kontrolu
        Console.WriteLine($"\n{personeller.Count} personel verisi okundu.");

        // maas hesabi  ve kaydet
        MaasBordro.MaaslariHesaplaVeKaydet(personeller);

        Console.WriteLine("Islem tamamlandi.");
    }
}