using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekcift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının tek mi, çift mi olduğunu gösteren C# programını yazalım.
            Console.WriteLine("Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 ==0) 
            {
                Console.WriteLine("Sayı Çift");
            }
            else
            {
                Console.WriteLine("Sayı Tek");
            }
            Console.ReadKey();
        }
    }
}
