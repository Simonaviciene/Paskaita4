using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskasMasyvai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];

            Console.WriteLine("ivesti 5 skaicius:");
            

            for (int i = 0; i <= skaiciai.Length - 1; i++)
            {
                int skaicius = Convert.ToInt32(Console.ReadLine());
                skaiciai[i] = skaicius;
               
            }
            for (int i = skaiciai.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", skaiciai[i]);
            }

            Console.ReadLine();

        }
    }
}
