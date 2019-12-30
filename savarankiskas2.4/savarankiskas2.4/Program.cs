using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmasSk;
            int antrasSk;                   
            string operacija;
            int atsakymas;
            

            
            Console.Write("Irasykite pirma skaiciu: ");
            pirmasSk = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Irasykite antra skaiciu: ");
            antrasSk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pasirinkti operacija ( x , / , +, -) ");
            operacija = Console.ReadLine();

            if (operacija == "x")
            {
                atsakymas = pirmasSk * antrasSk;
                Console.WriteLine(pirmasSk + " x " + antrasSk + " = " + atsakymas);
                Console.ReadLine();
            }
            /*switch (MessageBox.Show("Do you want to create a new file?",
         "WonderWord",
         MessageBoxButtons.YesNoCancel,
         MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    break;

                case DialogResult.No:

                    break;

                case DialogResult.Cancel:

                    break;


            }*/
            else if (operacija == "/")
            {
                atsakymas = pirmasSk / antrasSk;
                Console.WriteLine(pirmasSk + " / " + antrasSk + " = " + atsakymas);
                Console.ReadLine();
            }

            else if (operacija == "+")
            {
                atsakymas = pirmasSk + antrasSk;
                Console.WriteLine(pirmasSk + " + " + antrasSk + " = " + atsakymas);
                Console.ReadLine();
            }
            else if (operacija == "-")
            {
                atsakymas = pirmasSk - pirmasSk;
                Console.WriteLine(pirmasSk + " - " + antrasSk + " = " + atsakymas);
                Console.ReadLine();
            }
            else
            {
                //Console.WriteLine("Ar testi toliau (taip/ne)?");
                //Console.ReadLine();
            }
        }
    }
}
    

