using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace id_sifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı” mesajı veren Console uygulaması.
            Console.WriteLine("Kullanıcı Adı Belirleyiniz:");
            string id = Console.ReadLine();
            Console.WriteLine("Şifre Belirleyiniz:");
            string password = Console.ReadLine();
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.WriteLine("Kullanıcı Adı Giriniz:");
            string id1 = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz:");
            string password1 = Console.ReadLine();
            if (id == id1 && password == password1)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı");
            }
            Console.ReadKey();
        }
    }
}
