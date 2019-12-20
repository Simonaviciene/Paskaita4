using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas2
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius;
            Console.WriteLine("Iveskite bet koki skaiciu:");
            skaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lyginiai skaiciai");
            for (int i = 0; i < skaicius; i =+ 2)
            {
               
                Console.WriteLine("{0}", i);

            }
            Console.ReadLine();



        }
    }
}
