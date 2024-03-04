using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace univizefinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üniversitede öğrencilerin ortalamaları 50 ve üzerinde ise dersten başarılı sayılmaktadırlar. Öğrencinin vize notu ortalamaya %40, final notu %60 etki ettiği bildiğine göre öğrencilerin ders başarı durumlarını hesaplayan programı yapalım.

            Console.WriteLine("Vize Notunu Giriniz");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final Notunu Giriniz");
            double final = Convert.ToDouble(Console.ReadLine());
            double ort = (vize*0.4)+(final*0.6);

            if (ort >=50)
            {
                Console.WriteLine("Geçtiniz Ortalamanız:{0}",ort);
            }
            else
            {
                Console.WriteLine("Kaldınız Ortalamanız:{0}", ort);
            }
            Console.ReadKey();
        }
    }
}
