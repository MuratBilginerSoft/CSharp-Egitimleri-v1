using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_15_Do_While_Döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<10);

            Console.ReadKey();
        }
    }
}
