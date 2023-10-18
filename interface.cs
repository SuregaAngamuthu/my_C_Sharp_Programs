using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    interface hello
    {
        void Print();
    }
    interface h1 :hello
    {
        void Message();
    }
    interface h3
    {
        void Print();
    }
    class Hello:hello
    {
        public void Print()
        {
            Console.WriteLine("Surega");
        }
        //public void Message()
        //{
        //    Console.WriteLine("CSE");
        //}
    }
    class Program :hello,h1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            ((hello)p).Print();
            ((h3)p).Print();
            hello h = new Program();
            Hello h2 = new Hello();
            h2.Print();
            h1 d = new Program();
            //h.Print();
            d.Message();
            d.Print();
            h.Print();
            Console.ReadKey();
        }
        
        public void Print()
        {
            Console.WriteLine("hellooooo...");

        }
        public void Message()
        {
            Console.WriteLine("BC");
        }
    }
}
