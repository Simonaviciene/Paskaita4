using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] savaitesDienos =
            {
                "pirmadiens",
                "antradienis",
                "treciadienis",
                "ketvirtadienis",
                "penktadienis",
                "sestadienis",
                "sekmadienis"
            };
            //for (int i = 0; i < savaitesDienos.Length; i++)
            //{
            //    Console.WriteLine(savaitesDienos[i]);
            //}
            //Console.ReadLine();
            Console.WriteLine("Pries:");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            savaitesDienos[2] = "TRECIADIENIS";
            Console.WriteLine("");
            Console.WriteLine("Po");
            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            Console.ReadLine();
        }
        
    }
}
