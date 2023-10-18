using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("The value of Sum is {0}", sum);
            sum=Add(ref a, b);
            Console.WriteLine("The value of Sum is {0}", sum);
            Console.ReadKey();
        }
        static int Add(ref int a,int b)
        {
            a = 30;
            int sum = a + b;
            return sum;

        }
    }
}
