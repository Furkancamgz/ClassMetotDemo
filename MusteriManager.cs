using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteriler Takip Sistemine Eklendi" + " " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.MusteriSehir + " " + musteri.MusteriTelefon);

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteriler Takip Sisteminden Silindi" + " " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.MusteriSehir + " " + musteri.MusteriTelefon);
        }
    }
}
