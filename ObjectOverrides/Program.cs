using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** FUn with System.Object *****\n");

            Person p1 = new Person("Robert", "McGIrr", 54);

            // Use inherited members of System.Object
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash Code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            // Make some other references to p1
            Person p2 = p1;
            object o = p2;

            // Are the references pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }

            Console.WriteLine(p1.ToString());
            Console.ReadLine();

            // make identical Persons to test Equals and GetHashCode
            Person pp1 = new Person("Homer", "Simpson", 50);
            Person pp2 = new Person("Homer", "Simpson", 50);

            // Get stringed versiuon of objects
            Console.WriteLine("pp1.ToString() = {0}", pp1.ToString());
            Console.WriteLine("pp2.ToString() = {0}", pp2.ToString());

            // Test overridden Equals
            Console.WriteLine("pp1 = pp2?: {0}", pp1.Equals(pp2));

            // Test Hash Codes
            Console.WriteLine("Same Hash Codes?: {0}", pp1.GetHashCode() == pp2.GetHashCode());
            Console.WriteLine();

            // Change age of pp2 and test again
            pp2.Age = 45;
            Console.WriteLine("pp1.ToString = {0}", pp1.ToString());
            Console.WriteLine("pp2.ToString = {0}", pp2.ToString());
            Console.WriteLine("pp1 = pp2?: {0}", pp1.Equals(pp2));
            Console.WriteLine("Same Hash Codes?: {0}", pp1.GetHashCode() == pp2.GetHashCode());
            Console.ReadLine();


        }
    }
}
