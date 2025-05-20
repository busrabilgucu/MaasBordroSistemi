using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroSistemi
{
    // Personel sinifi, abstract bir siniftir. Tum calisanlar buradan kalitim alacak.
    public abstract class Personel
    {
        // Personel genel bilgileri tanimlaniyor.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public decimal SaatlikUcret { get; set; }
        public int TecrubeYili { get; set; }
        public int CalismaSaati { get; set; }

        public Personel(string ad, string soyad, int yas, decimal saatlikUcret, int tecrubeYili, int calismaSaati)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            SaatlikUcret = saatlikUcret;
            TecrubeYili = tecrubeYili;
            CalismaSaati = calismaSaati;
        }

        // Abstract maas hesaplama methodu. alt siniflar uygulayacak.
        public abstract decimal MaasHesapla();

        // override edilen ToString metodu: Calisan bilgileri icin.
        public override string ToString()
        {
            return $"{Ad} {Soyad}, Yaş: {Yas}, Tecrübe: {TecrubeYili} yıl, Çalışma Saati: {CalismaSaati}, Saatlik Ücret: {SaatlikUcret:C}";
        }
    }
}
