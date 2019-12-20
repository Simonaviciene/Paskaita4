using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterasijaPerStringa
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "C#Kursas";
            for (int i = 0; i < vardas.Length; i++)
            {
                char current = vardas[i];
                System.Console.WriteLine(current);
            }
            Console.ReadLine();

        }
    }
}
