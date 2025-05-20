using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MaasBordroSistemi
{
    public class MaasBordro
    {
        public static void MaaslariHesaplaVeKaydet(List<Personel> personeller)
        {
            string anaKlasor = "MaasBordrolari";
            Directory.CreateDirectory(anaKlasor);

            List<Personel> azCalisanlar = new List<Personel>();

            foreach (var personel in personeller)
            {
                decimal maas = personel.MaasHesapla();
                string personelKlasoru = Path.Combine(anaKlasor, personel.Ad + "_" + personel.Soyad);
                Directory.CreateDirectory(personelKlasoru);

                string dosyaAdi = Path.Combine(personelKlasoru, $"{DateTime.Now:yyyy-MM-dd}.json");
                File.WriteAllText(dosyaAdi, JsonConvert.SerializeObject(new { personel.Ad, personel.Soyad, maas }, Formatting.Indented));

                if (personel.CalismaSaati < 150)
                    azCalisanlar.Add(personel);

            }
            Console.WriteLine("\n150 Saatten Az Calisanlar:");
            foreach (var p in azCalisanlar)
            {
                Console.WriteLine(p);
            }
        }
    }
}
