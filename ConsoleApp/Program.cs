using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Adet = 15;
            urun1.Aciklama = "amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Armut";
            urun2.Adet = 19;
            urun2.Aciklama = "Deveci armutu";

            Product[] urunler = new Product[] {urun1, urun2 };

            foreach (var item in urunler)
            {
                Console.WriteLine("Ürün Adı: " + item.Adi + " Ürün Adedi : " + item.Adet + " Ürün açıklaması : " + item.Aciklama);
            }

            int i = 0;
            while (i < urunler.Length)
            {
                Console.WriteLine(urunler[i].Adet);
                i++;
            }


            for (int a = 0; a < urunler.Length; a++)
            {
                Console.WriteLine(urunler[a].Aciklama);
            }

            Console.WriteLine("*************** Methots **************");

            // instance
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
