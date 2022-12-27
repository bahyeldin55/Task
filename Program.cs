using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the two number");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("perfect numbers are :");

            for (int i = n1; i <= n2; i++)
            {
                int n = i;
                int sum = 0, factor = 1;
                while (factor < n)
                {
                    if ((n % factor) == 0)
                    {
                        sum = sum + factor;
                    }
                    factor++;
                }

                if (sum == i)
                {
                    Console.WriteLine(i + " ");
                }
                Console.ReadKey();
            }
        }
    }
}
