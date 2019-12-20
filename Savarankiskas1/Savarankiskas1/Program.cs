using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius;
            double skaiciuSuma = 0;
            
            Console.Write("Ivesti skaiciu: " );
            skaicius = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= skaicius; i++)
            {
                skaiciuSuma += i;
            }
            Console.WriteLine("skaiciu suma {0}", skaiciuSuma);
            Console.ReadLine();
            

        }
    }
}
