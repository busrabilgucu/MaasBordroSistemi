using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroSistemi
{
    public class Memur : Personel // personelden kalitim aliyor.
    {
        public int MemurDerecesi { get; set; }

        public Memur(string ad, string soyad, int yas, decimal saatlikUcret, int tecrubeYili, int calismaSaati, int memurDerecesi)
            : base(ad, soyad, yas, saatlikUcret, tecrubeYili, calismaSaati)
        {
            MemurDerecesi = memurDerecesi;
        }

        public override decimal MaasHesapla()
        {
            int klasikSaat = CalismaSaati > 180 ? 180 : CalismaSaati;
            int ekMesaiSaat = CalismaSaati > 180 ? CalismaSaati - 180 : 0;

            return (klasikSaat * SaatlikUcret) + (ekMesaiSaat * SaatlikUcret * 1.5m);
        }

        public override string ToString()
        {
            return base.ToString() + $", Derece: {MemurDerecesi}, Maaş: {MaasHesapla():C}";
        }
    }
}
