using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static float PI = 3.14f;
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.DarkRed;
           

            Console.WriteLine("Enter number for fibonacci");
            int fibNumber = Convert.ToInt32(Console.ReadLine());
            int fib0 = 0, fib1 = 1, fibFinal;
            if (fibNumber == 0)
                Console.WriteLine(fib0);
            else if (fibNumber == 1)
                Console.WriteLine(fib0 + " " + fib1);
            else
            {
                int i = 0;
                while (i < fibNumber)
                {
                    fibFinal = fib0 + fib1;
                    Console.Write(fib0 + " ");
                    fib0 = fib1;
                    fib1 = fibFinal;
                    i++;
                }
            }

            

        }

    }

}

