using System;

namespace KampIntro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama

            string kategoriEtiketi = "Kategori"; //değer tutucu, alias(takma isim)
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış okunu göster");
            }
            else
            {
                Console.WriteLine("Değişmedi imajı");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }





            Console.WriteLine(kategoriEtiketi);
        }
    } 
}
