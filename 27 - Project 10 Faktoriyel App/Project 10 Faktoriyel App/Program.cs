using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_Faktoriyel_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double Factoriel=1;
            

            Console.WriteLine("Hesaplanacak Değeri Giriniz:");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Factoriel = Factoriel * i;
            }

            Console.WriteLine(N+"!={0}",Factoriel);

            Console.ReadKey();

        }
    }
}
