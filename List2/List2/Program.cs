using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pirmasStudentuSarasas = new List<string>();
            pirmasStudentuSarasas.Add("Mantas");
            pirmasStudentuSarasas.Add("Giedrius");
            pirmasStudentuSarasas.Add("Justas");
            pirmasStudentuSarasas.Add("Ugnius");

            List<string>antrasStudentuSarasas = new List<string>();
            antrasStudentuSarasas.Add("Ieva");
            antrasStudentuSarasas.Add("Maria");
            antrasStudentuSarasas.Add("Eva");
            antrasStudentuSarasas.Add("Gabija");

            antrasStudentuSarasas.AddRange(pirmasStudentuSarasas);

            foreach (var item in antrasStudentuSarasas)
            {
                Console.WriteLine(item);
            }

            antrasStudentuSarasas.Sort();

            foreach (var item in antrasStudentuSarasas)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
        

    }
}
