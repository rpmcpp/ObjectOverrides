using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {

        // FIELD DATA ---------------------------------------------------------------------------

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }



        // CTORs --------------------------------------------------------------------------------

        public Person(){}
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }


        // METHODS -------------------------------------------------------------------------------


        public override string ToString()
        {
            string myState = string .Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            var temp = (Person) obj;
            if (temp.FirstName == this.FirstName
                && temp.LastName == this.LastName
                && temp.Age == this.Age)
            {
                return true;
            }
            return false;

            // OR
            //return obj.ToString() == this.ToString();
            // IF ToString is in good order
        }

        // Return a hashcode based on unique field (SSN)
        public override int GetHashCode()
        {
            //return SSN.GetHashCode();
            // Or if nothing unique, hash ToString
            return this.ToString().GetHashCode();
        }




    }
}

