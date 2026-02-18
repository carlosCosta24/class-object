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
    class clsStatic {
        public int x1;
        //shard on the class level
        public static int x2;

        public int Method1() { 
            //non static methods can access static members
            return x1 + x2;
        }
        public static int Method2()
        {
            // only access a static member
            return x2;
        }

    }
    class clsEmployee { 
        //auto implemented prop
        public int IO {
            //read only property
            get;
        }
        public string Gender
        {

            set;
            get;
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
            /*
            clsA A = new clsA();
            Console.WriteLine("Accessing public members:");
            Console.WriteLine("x1={0}", A.x1);
            Console.WriteLine("result of fun1={0}", A.fun1());

            clsB B = new clsB();
            Console.WriteLine("\nObjects from class B expose all public members from the base class");
            Console.WriteLine("x1={0}", B.x1);
            Console.WriteLine("result of fun1={0}", B.fun1());
            */

            // static members
            /*
            clsStatic FirstObj = new clsStatic();
            clsStatic SecondObj = new clsStatic();

            FirstObj.x1 = 170;
            SecondObj.x1 = 180;
            clsStatic.x2 = 500;

            Console.WriteLine("FirstObj.x1:={0}", FirstObj.x1);
            Console.WriteLine("SecondObj.x1:={0}", SecondObj.x1);
            Console.WriteLine("FirstObj.method1 results:={0}", FirstObj.Method1());
            Console.WriteLine("SecondObj.method1 results:={0}", SecondObj.Method1());

            // in order to access a static method, the class name should be used

            Console.WriteLine("Static method2 result = {0}", clsStatic.Method2()) ;
            Console.WriteLine("static x2:= {0}", clsStatic.x2);
            */
            clsEmployee FirstEmployee= new clsEmployee();
       
            FirstEmployee.Gender = "M";
            Console.WriteLine("Employee ID: {0}", FirstEmployee.IO);
            Console.WriteLine("Employee Gender: {0}", FirstEmployee.Gender);
            Console.ReadKey();

        }
    }
}
