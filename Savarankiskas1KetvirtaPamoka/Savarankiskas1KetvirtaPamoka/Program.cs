using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1KetvirtaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius;
            double skaiciuSuma = 0;

            Console.Write("Ivesti skaiciu: ");
            skaicius = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= skaicius; i++)
            {
                Console.Write("{0} ", i);
                if (i < skaicius)
                {
                    Console.Write("+ ");

                }
                else
                {
                    Console.Write("= ");
                }

                skaiciuSuma += i;
            }
            Console.WriteLine("{0}", skaiciuSuma);
            Console.ReadLine();
        }
    }
}
