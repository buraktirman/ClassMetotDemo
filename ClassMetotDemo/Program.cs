using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 120;
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Tırman";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 201;
            musteri2.Adi = "Altay";
            musteri2.Soyadi = "Bayındır";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 310;
            musteri3.Adi = "Arda";
            musteri3.Soyadi = "Güler";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
