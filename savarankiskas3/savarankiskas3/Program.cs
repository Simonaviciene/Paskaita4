using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekstas;
            
            Console.WriteLine("Ivesti teksta:");

            tekstas = Console.ReadLine();

            for (int i = tekstas.Length - 1; i >= 0; i--)
            {
                char a = tekstas[i];
                Console.Write("{0}", a);
            }
            Console.ReadLine();
        }
    }
}
