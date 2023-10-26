using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace synchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new System.Diagnostics.Stopwatch();
            time.Start();
            Employee.SchoolEnter();
            Employee.myClass();
            Employee.Class_Test();
            Employee.Break();
            time.Stop();
            Console.WriteLine(time.ElapsedMilliseconds);
        }
    }
    public class Employee
    {
        public static void SchoolEnter()
        {
            Console.WriteLine("PRAYER ASSEMBLY");
            Thread.Sleep(6000);
        }
        public static void myClass()
        {
            Console.WriteLine("Entering the class");
            Thread.Sleep(1000);
        }
        public static void Class_Test()
        {
            Console.WriteLine("Writing the test...");
            Thread.Sleep(9000);
        }
        public static void Break()
        {
            Console.WriteLine("Break Hour");
            Thread.Sleep(1000);
        }


    }
}
