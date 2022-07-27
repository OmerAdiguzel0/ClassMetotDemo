using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.TC = "4324232132";
            musteri1.Ad = "Ömer";
            musteri1.Soyad = "Adıgüzel";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 1;
            musteri2.TC = "16521654624";
            musteri2.Ad = "Sude Nur";
            musteri2.Soyad = "Can";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 1;
            musteri3.TC = "654981246240";
            musteri3.Ad = "Muhammed Semih";
            musteri3.Soyad = "Bayram";


            Musteri[] musteriler = new Musteri[]
            {
                musteri1, musteri2, musteri3
            };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TC);
                Console.WriteLine("---------------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Guncelle(musteri3);
        }
    }
}