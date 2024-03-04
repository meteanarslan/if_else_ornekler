using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplamacikarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //: Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) seçildiğinde, sonucu hesaplayarak ekranda gösteren programı yazalım.
            Console.WriteLine("Birinci Sayıyı Giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlemi Giriniz");
            string isaret= Console.ReadLine();
            if (isaret =="+")
            {
                double sonuc = sayi + sayi1;
                Console.WriteLine("{0} + {1} = {2}",sayi,sayi1,sonuc);
            }
            else if (isaret == "-")
            {
                double sonuc = sayi - sayi1;
                Console.WriteLine("{0} - {1} = {2}", sayi, sayi1, sonuc);
            }
            else if (isaret == "*")
            {
                double sonuc = sayi * sayi1;
                Console.WriteLine("{0} * {1} = {2}", sayi, sayi1, sonuc);
            }
            else if(isaret == "/") 
            {
                double sonuc = sayi / sayi1;
                Console.WriteLine("{0} / {1} = {2}", sayi, sayi1, sonuc);
            }
            else
            {
                Console.WriteLine("Yanlis İsaret Tuşladınız");
            }
            Console.ReadKey();  
        }
    }
}
