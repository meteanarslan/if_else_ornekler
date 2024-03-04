using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazaifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti alınmamaktadır. Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren programı yazalım.
            Console.WriteLine("Ürünüz Fiyatını Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 100)
            {
                Console.WriteLine("Ürünün Fiyatı {0}",sayi+5);
            }
            else
            {
                Console.WriteLine("Ürünün Fiyatı {0}",sayi);
            }
            Console.ReadKey();
        }
    }
}
