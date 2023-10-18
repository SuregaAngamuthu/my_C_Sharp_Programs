using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        private string name;
        private int age;
        public string Name2
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            set
            {
                Age1 = value;
            }
            get
            {
                return Age1;
            }
            //    get;
            //    set;
        }

        public int Age1 { get => age; set => age = value; }

        static void Main(string[] args)
        { 
            Program p = new Program();
            p.Name2 = Console.ReadLine();
            p.Age=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Convert.ToInt32(p.Age));
            Console.WriteLine(p.Name2);
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
    }
}
