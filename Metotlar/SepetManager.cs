using System;
namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi."+urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stok)
        {
            Console.WriteLine("Sepete eklendi." + urunAdi);
        }
    }
}
