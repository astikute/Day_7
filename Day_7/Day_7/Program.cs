using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums - izvadit ievadita skaitla faktorialu!

            Console.Write("Ievadiet skaitli: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            int rez = 0;

            if (sk == 0) // Skaitla 0! = 1
            {
                Console.Write("0! = 1");
            }
            else
            { 
                for (int i = 1; i <= sk; i++) // Parejiem skaitliem, sakot no 1
                {
                    rez = rez + i;
                }
                Console.Write("{0}! = {1}", sk, rez);
            }
            Console.Read();
        }
    }
}
