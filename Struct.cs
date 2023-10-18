using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.Name = "Surega";
            //e1.Id_no = 45;
            //e1.print();
            //Employee e2 = new Employee()
            //{
            //    Id_no = 31,
            //    Name = "Poos"
            //};
            //e2.print();
            //Console.ReadKey();
            Console.WriteLine("Enter Number of Employees");
            int num = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[num];
            for (int i = 0; i <num; i++)
            {
                Console.WriteLine("Enter your name : ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter your id number : ");
                int Id_no = Convert.ToInt32(Console.ReadLine());
                emp[i] = new Employee(Id_no,Name);
            }
            Console.WriteLine("The New Employees are listed below....................................................................");

            for (int i=0;i<num;i++)
            {
                emp[i].print();
            }
            Console.ReadKey();
        }
    }
    struct Employee
    {
        private string name;
        private int id_no;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Id_no
        {
            get
            {
                return this.id_no;
            }
            set
            {
                this.id_no = value;
            }
        }
        public Employee(int Id_no,string Name)
        {
            this.id_no = Id_no;
            this.name = Name;
        }
        public void print()
        {
            Console.WriteLine($"{name} - {id_no}");
            //Console.WriteLine(this.name);
        }
    }
}
