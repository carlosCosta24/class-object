using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___object
{
    class clsPerson {

        public string FirstName;
        public string LastName;

        public string FullName() { 
            return FirstName + " " + LastName;
        }
    
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson FirstPerson = new clsPerson();

            Console.WriteLine("Accessing object 1: ");
            FirstPerson.FirstName = "Carlos";
            FirstPerson.LastName = "costa";
            Console.WriteLine(FirstPerson.FullName());

            clsPerson SecondPerson = new clsPerson();

            Console.WriteLine("Accessing object 2: ");
            SecondPerson.FirstName = "Ricardo";
            SecondPerson.LastName = "costa";
            Console.WriteLine(SecondPerson.FullName());
        }
    }
}
