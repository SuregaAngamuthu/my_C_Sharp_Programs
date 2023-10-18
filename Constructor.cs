using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int a =100;
    public static void Main(string[] args)
    {
        //Hello h = new Hello();
        basic6.Hello.Print(a);
        basic6.Hello1.Print(a);
        Console.ReadKey();

    }
    public Program(int a)
    {
        a = 10;
    }
    ~Program()
    {
        //clean up the code
    }
}
namespace basic6
{
    class Hello
    {
        public static void Print(int a)
        {
            //int a = 10;
            Console.WriteLine(a);
        }
    }
}
namespace basic6
{
    class Hello1
    {
        public static void Print(int a)
        {
            //int a = 10;
            Console.WriteLine(a);
            //Console.ReadKey();
        }
    }
}
