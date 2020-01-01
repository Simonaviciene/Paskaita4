using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskasMasyvai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            int suma;
                        
            Console.WriteLine("Ivesti 5 skaicius:");

            for (int i = 0; i < 5; i++)
            {
                suma += skaiciai.Sum();
                Console.WriteLine(suma);
            }

            Console.ReadLine();


        }
    }
}
