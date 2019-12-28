using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            
            Console.Write("Iveskite bet koki skaiciu : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x");
            for (y = 1; y <= 10; y++)
            {
                Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
            }
            Console.ReadLine();


        }
    }
}
