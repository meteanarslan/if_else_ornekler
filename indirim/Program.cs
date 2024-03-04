using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indirim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.
            Console.WriteLine("Ürün Fiyatı Giriniz");
            double urun1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatını Giriniz");
            double urun2 = Convert.ToDouble(Console.ReadLine());
            if(urun1 + urun2 > 200)
            {
                urun2 = urun2 * 0.25;
                double urunfiyat = urun1 + urun2;
                Console.WriteLine("Ödeme Tutarınız: "+urunfiyat);
            }
            else
            {
                double urunfiyat = urun1 + urun2;
                Console.WriteLine("Ödeme Tutarınız: " + urunfiyat);
            }
            Console.ReadKey();
        }
    }
}
