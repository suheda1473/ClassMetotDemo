using System;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void EkleMusteri(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine();
        }
        public void SilMusteri(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine();
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Tc = 1234567891,
                Ad = "Ali",
                Soyad = "Yılmaz",
                Yas = 32,
                Cinsiyet = "Erkek",
              
            };

            Musteri musteri2 = new Musteri()
            {
                Tc = 1236547125,
                Ad = "Ayşe",
                Soyad = "Yılmazer",
                Yas = 43,
                Cinsiyet = "Kadın",
                
            };

            Musteri[] musteriler = new Musteri[]
        {
            musteri1, musteri2
        };
            foreach (var Musteri in musteriler)
            {
                Console.WriteLine("Ad: " + Musteri.Ad);
                Console.WriteLine("Soyad: " + Musteri.Soyad);
                Console.WriteLine("Yaş: " + Musteri.Yas);
                Console.WriteLine("Cinsiyet: " + Musteri.Cinsiyet);
                Console.WriteLine();
            }

            MusteriManager manager = new MusteriManager();
            manager.EkleMusteri(musteri1);
            manager.EkleMusteri(musteri2);
            manager.SilMusteri(musteri2);
        }
    }

    class Musteri
    {   public double Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        
    }
        
}
