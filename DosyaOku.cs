using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaasBordroSistemi
{
    public static class DosyaOku
    {
        public static List<Personel> PersonelVerileriniOku(string dosyaYolu)
        {
            try
            {
                var jsonVerisi = File.ReadAllText(dosyaYolu);
                var personelListesi = new List<Personel>();

                // JSON verisinin dogru okundugunu gormek icin konsola yazdiriyoruz
                Console.WriteLine("Personeller belirlendi. ");
                Console.WriteLine(jsonVerisi);

                var jsonArray = JArray.Parse(jsonVerisi);

                foreach (var item in jsonArray)
                {
                    Console.WriteLine("Personel Verileri:  ");
                    Console.WriteLine(item.ToString());

                    string title = item["title"]?.ToString(); // Null kontrolu eklendi

                    if (title == "Yonetici")
                    {
                        var yonetici = item.ToObject<Yonetici>();
                        personelListesi.Add(yonetici);
                    }
                    else if (title == "Memur")
                    {
                        var memur = item.ToObject<Memur>();
                        personelListesi.Add(memur);
                    }
                    else
                    {
                        Console.WriteLine($"Gecersiz bir personel tipi: {title}");
                    }
                }

                return personelListesi;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return new List<Personel>();
            }
        }

    }
}
