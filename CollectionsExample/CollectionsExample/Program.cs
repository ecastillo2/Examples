using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();

            dogs.Add("BullDog");
            dogs.Add("Collie");
            dogs.Add("Retriever");
            dogs.Add("Boxer");

            //foreach to move through the list

            foreach (var dog in dogs)
            {

                Console.WriteLine(dog );
            }


            int[] a1 = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in a1)
            {
                Console.WriteLine(i);

            }


            Console.ReadLine();
        }
    }
}
