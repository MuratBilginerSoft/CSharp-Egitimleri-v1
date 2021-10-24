using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7_Pin_Kodu_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string SUN = "Cemile", SPW = "12345";

            string UUN, UPW;

            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            UUN = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            UPW = Console.ReadLine();

            if (SUN==UUN && SPW==UPW)
            {
                Console.WriteLine("Girişiniz Başarılı Şekilde Gerçekleşti");
            }

            else
            {
                Console.WriteLine("Kullanıcı Adı Veya Şifreniz Yanlıştır");
            }

            Console.ReadKey();

        }
    }
}
