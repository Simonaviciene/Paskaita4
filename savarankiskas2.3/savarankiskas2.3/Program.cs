using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sakinys = "Laimingu Naujuju Metu Visiems ";

            string[] words = sakinys.Split(' '); //ka daro split?
            StringBuilder s = new StringBuilder(); // StringBuilder?

            for (int i = words.Length - 1; i >= 0; i--)
            {
                s.Append(words[i]);
                s.Append(" ");
            }

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
