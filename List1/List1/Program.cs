using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int ilgisSk = 10;

            List<int> atsitiktiniaiSkaiciai = new List<int>();

            Random atsitiktinis = new Random();

            for (int i = 0; i < ilgisSk; i++)
            {
                atsitiktiniaiSkaiciai.Add(atsitiktinis.Next(1100));

            }
            for (int i = 0; i < ilgisSk; i++)
            {
                if (atsitiktiniaiSkaiciai[i] % 2 == 0)
                {
                    Console.WriteLine("{0}", atsitiktiniaiSkaiciai[i]);
                }
                
            }

            
            Console.ReadLine();
            
            
            



           
        }
    }
}
