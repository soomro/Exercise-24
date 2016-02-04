using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            Console.Write(" please enter the power that you need \t");
            int n = int.Parse(Console.ReadLine());
            double power = 0;
            for (int i = 1; i < 11; i++)
            {
                m = i;
                power = Math.Pow(m,n);
                string mm = String.Format(CultureInfo.InvariantCulture,
                                 "{0:#,#}", power);
                Console.WriteLine("{0} raised to the power of {1} is equal to {2} ", m, n, mm);
              ////  Console.WriteLine(powerS.ToString("#,#", CultureInfo.InvariantCulture));
              ////  Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
              //                                  "{0:#,#}", powerS));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
