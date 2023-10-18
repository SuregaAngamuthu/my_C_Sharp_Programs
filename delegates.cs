using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate void Hello(int num, string s);
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter your roll no:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            string s = Console.ReadLine();
            Hello h = new Hello(h1);
            h(num, s);
            Console.ReadKey();
        }
        public static void h1(int num, string s)
        {
            Console.WriteLine($"Welcome..{s}-{num}.");
        }
    }
}
