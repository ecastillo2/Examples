using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Steve");

            Child c = new Child();
            c.Examine("Tom");
            c.Incoculate();

            UnderFive uf = new UnderFive();
            uf.Examine("Will");

            Console.ReadLine();
        }

        public class Patient
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public int Weight { get; set; }
            public long SSN { get; set; }

            public void Examine(string pname)
            {
                Console.WriteLine("Examination of " + pname + "completed");

            }

            public void Billing(long ssn)
            {
                Console.WriteLine("Billing completed....");

            }

        }

        public class Child : Patient
        {

            public void Incoculate()
            {

                Console.WriteLine("Child has been incoculated....");
            }


        }

        public class UnderFive: Child
        {

            public void UnderFileMethod()
            {

                Console.WriteLine("Under Five Method....");
            }


        }



    }
}
