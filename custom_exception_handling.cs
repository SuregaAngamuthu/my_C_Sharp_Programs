using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception_hanling
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 30)
                throw new NumberException("Number Exception : given age is less than 30");
            Console.ReadKey();
        }
    }
    class NumberException : Exception
    {
        public NumberException(string str) : base(str)
        {
        }
    }
}
