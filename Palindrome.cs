using System;
namespace Sum
{
    class Hello
    {
        public static void Main(string[] args)
        {
            int num1,num2,num3,num4,num5;
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            num3=int.Parse(Console.ReadLine());
            num4=int.Parse(Console.ReadLine());
            num5=int.Parse(Console.ReadLine());
            int sum=(num1+num2+num3+num4+num5);
            int avg=sum/5;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}