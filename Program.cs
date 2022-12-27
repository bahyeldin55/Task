using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number:");
            int startNun = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter end number:");


            int endNum = int.Parse(Console.ReadLine());
            Console.WriteLine("These are the numbers between {0} and {1}", startNun, endNum);
            for (int i = startNun; i <= endNum; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;




                        break;
                    }

                }
                if (counter == 0 && i != 1)
                {
                    Console.WriteLine(" {0} ", i);
                }
                Console.ReadKey();
            }
        }
    }
}
