using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("----------Müşteri Listesi----------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Id'si : " + musteri.Id);
                Console.WriteLine("Adı : " + musteri.Adi);
                Console.WriteLine("Soyadı : " + musteri.Soyadi);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " müşterisi silindi.");
        }
    }
}
