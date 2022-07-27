using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad);
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Guncellendi: " + musteri.Ad);
        }

    }
}
