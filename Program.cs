using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
    class clsA
    {
        public int x1 = 10;
        private int x2 = 20;
        protected int x3 = 30;
        public int fun1()
        {
            return 100;
        }
        private int fun2()
        {
            return 200;
        }
        protected int fun3()
        {
            return 300;
        }

    }
    class clsB : clsA
    {

        public int fun4()
        {
            return x1 + x3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*clsPerson FirstPerson = new clsPerson();

            Console.WriteLine("Accessing object 1: ");
            FirstPerson.FirstName = "Carlos";
            FirstPerson.LastName = "costa";
            Console.WriteLine(FirstPerson.FullName());

            clsPerson SecondPerson = new clsPerson();

            Console.WriteLine("Accessing object 2: ");
            SecondPerson.FirstName = "Ricardo";
            SecondPerson.LastName = "costa";
            Console.WriteLine(SecondPerson.FullName());
            */
            //access modifiers exp

            clsA A = new clsA();
            Console.WriteLine("Accessing public members:");
            Console.WriteLine("x1={0}", A.x1);
            Console.WriteLine("result of fun1={0}", A.fun1());

            clsB B = new clsB();
            Console.WriteLine("\nObjects from class B expose all public members from the base class");
            Console.WriteLine("x1={0}", B.x1);
            Console.WriteLine("result of fun1={0}", B.fun1());

            Console.ReadKey();

        }
    }
}
