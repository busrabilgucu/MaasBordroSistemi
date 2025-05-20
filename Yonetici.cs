using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroSistemi
{
    public class Yonetici : Personel
    {
        public decimal EkMaasOdeme { get; set; }

        // en dusuk saatlik ücret 500 TL olmalidir.
        public Yonetici(string ad, string soyad, int yas, decimal saatlikUcret, int tecrubeYili, int calismaSaati, decimal ekMaasOdeme)
            : base(ad, soyad, yas, saatlikUcret < 500 ? 500 : saatlikUcret, tecrubeYili, calismaSaati)
        {
            EkMaasOdeme = ekMaasOdeme;
        }
        public override decimal MaasHesapla()  //Personal abstract oldugundan override yapilir.
        {
            return (CalismaSaati * SaatlikUcret) + EkMaasOdeme;
        }

        public override string ToString()
        {
            return base.ToString() + $", Ek Maaş: {EkMaasOdeme:C}, Maaş: {MaasHesapla():C}";
        }
    }
}
