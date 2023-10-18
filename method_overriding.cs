using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Fulltime_Employee();
            Employee emp2 = new Part_Time_Employee();
            emp.Message();
            emp1.Message();
            emp2.Message();
            Console.ReadKey();
        }
    }
    class Employee
    {
        public virtual void Message()
        {
            Console.WriteLine("HII....im a employee class");
        }
    }
    class Fulltime_Employee : Employee
    {
        public  override void  Message()
        {
            Console.WriteLine("Hii......Im a Fulltime_Employee class");
        }

    }
    class Part_Time_Employee : Employee
    {
        public new void Message()
        {
            Console.WriteLine("Hii..Im a Part_Time Employee class");
        }
    }

}
