using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen 2 sınav notunun ortalamalarını alıp geçip geçmediğini gösteren program
            Console.WriteLine("1. Sınav Notunu Giriniz");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sınav Notunu Giriniz");
            double b = Convert.ToDouble(Console.ReadLine());
            double ortalama = (a + b) / 2;
            if (ortalama >= 50)
            {
                Console.WriteLine("Geçtiniz Ortalamanız:{0}", ortalama);
            }
            else
            {
                Console.WriteLine("Kaldınız Ortalamanız:{0}", ortalama);
            }
            Console.ReadKey();
        }
    }
}
