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

            //The FizzBuZZ problem is a common coding interview question. It usually looks like:

            //Output the integers from 1 10 aoo.
            //for each multiple of three, print 'Fizz'
            //for each multiple of five, print 'Buzz'
            //for each multiple of both three and five, print 'BizzFizz'


            for (var i = 1; i < 101; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }

                if ((i % 5) == 0 && (i % 3) == 0)
                {
                    Console.WriteLine("FuzzBuzz");
                }

                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
