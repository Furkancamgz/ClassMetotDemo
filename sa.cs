using System;

namespace Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriAd = "Furkan";
            musteri1.MusteriSoyad = "Camgöz";
            musteri1.MusteriSehir = "Balıkesir";
            musteri1.MusteriTelefon = 0551125283556;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriAd = "Berşan";
            musteri2.MusteriSoyad = "Çelik";
            musteri2.MusteriSehir = "İstanbul";
            musteri2.MusteriTelefon = 05363724515;

            Musteri musteri3 = new Musteri();

            musteri3.MusteriAd = "Ahmet";
            musteri3.MusteriSoyad = "Yılmaz";
            musteri3.MusteriSehir = "Bursa";
            musteri3.MusteriTelefon = 052415485102;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAd);
                Console.WriteLine(musteri.MusteriSoyad);
                Console.WriteLine(musteri.MusteriSehir);
                Console.WriteLine(musteri.MusteriTelefon);
                MusteriManager musteriManager = new MusteriManager();
                Console.WriteLine();
                musteriManager.MusteriEkle(musteri);
                Console.WriteLine();
                musteriManager.MusteriSil(musteri);

                Console.WriteLine("---------------------");
            }
        }
    }
}
