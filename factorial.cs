using System;
namespace hello
{
    public class Factorial
    {
        public static void Main(string[] args)
        {
            int fact = 1;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                fact *= i;
            Console.WriteLine(fact);
            Console.ReadKey();
        }

    }
}