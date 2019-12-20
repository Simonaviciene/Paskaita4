using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProgressBar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {

                Thread.Sleep(100);
                System.Console.WriteLine("#");
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");
            Console.ReadLine();

        }
    }
}
