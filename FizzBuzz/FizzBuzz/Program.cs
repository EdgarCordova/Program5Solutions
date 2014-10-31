using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {

                    if (i % 5 == 0)
                    {
                        Console.WriteLine("fizz buzz");
                    }
                    else
                    {
                        Console.WriteLine("fizz");
                    }
                }
                else if (i % 5 == 0)
                {

                    if (i % 3 == 0)
                    {
                        Console.WriteLine("fizz buzz");
                    }
                    else
                    {
                        Console.WriteLine("buzz");
                    }
                }
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}   

