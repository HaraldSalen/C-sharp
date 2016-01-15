using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kvadratens längd :");
            int längd = int.Parse(Console.ReadLine());
            Console.WriteLine("\n A. Beräkna area\n V. Beräkna volym\n Q. Quit\n Välj mellan A och V");

            string val = Console.ReadLine();
            if (val == "A" || val == "a") 
            {
                Console.WriteLine("Area = " + (längd*längd));    
            }
            else if(val =="V" || val =="v")
            {
                Console.WriteLine("Volym = " + (längd * längd * längd));

            }

            Console.ReadKey();
            

        }
    }
}
