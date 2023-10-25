using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                id = 101,
                name = "SUREGA",
                salary = 70000
            };
            Employee e2 = new Employee()
            {
                id = 102,
                name = "Uma",
                salary = 100000
            };
            Dictionary<string, Employee> emp = new Dictionary<string, Employee>();
            emp.Add(e1.name, e1);
            emp.Add(e2.name, e2);
            Employee e2Uma = emp["Uma"];
            Console.WriteLine($"id={e2Uma.id},name={e2Uma.name},salary={e2Uma.salary}");
            Employee e1SUREGA = emp["SUREGA"];
            Console.WriteLine($"id={e1SUREGA.id},name={e1SUREGA.name},salary={e1SUREGA.salary}");
            Console.ReadKey();
        }
        
    }
    public class Employee

    {
        public int id;
        public string name;
        public int salary;
    }
}
