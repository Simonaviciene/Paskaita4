using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i, j, row;

            row = 10;

           
            for (i = 1; i < row; i++)
            {
                for (j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++) //kodel 2*?
                    Console.Write("*");
                // NAUJA LINIJA PO ATSPAUSDINTOS PIRAMIDES
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
