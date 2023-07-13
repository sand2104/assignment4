using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive: \t" + num);
                if (num % 2 == 0)
                {
                    Console.WriteLine("The Number is even.");
                    Console.ReadLine();
                }


            }
            else
            {
                Console.WriteLine("the number is negative :\t" + num);
                if (num % 2 != 0)

                {
                    Console.WriteLine("the number is Odd.");
                    Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}