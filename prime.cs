using System;
namespace Sum
{
    class Hello
    {
        static int Prime(int num)
        {
            int flag = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag++;
                    break;
                }
            }
            return flag;
        }
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int flag = Prime(num);
            if (flag == 0)
            {
                Console.WriteLine("{0} is not prime", num);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{0} is prime", num);
                Console.ReadKey();
            }
        }

    }
}