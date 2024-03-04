using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitifnegatif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu gösteren programın C# kodlarını yazalım.
            Console.WriteLine("Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                Console.WriteLine("Sayı Sıfırdır");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı Negatiftir");
            }
            else
            {
                Console.WriteLine("Sayı Pozitifdir");
            }
            Console.ReadKey();
        }
    }
}
