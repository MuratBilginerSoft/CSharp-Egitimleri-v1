using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_29_Tür_Dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 256;
            int c=256;
            byte b,d;

            checked
            {
                unchecked
                {
                    b = (byte)a;
                }

                d = (byte)c;

            }
           

            Console.WriteLine(b);

            Console.ReadKey();
            
        }
    }
}
