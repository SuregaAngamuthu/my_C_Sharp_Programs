using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_custom_input
{
    class Program
    {
        //public static int a, b;
        public static int ans = 1;
        static void Main(string[] args)
        {
            Operation o = new Operation();
            List<int> num = new List<int>();
            Console.WriteLine("Enter the number of elements");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            for(int i=1;i<=size;i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                
                num.Add(a);
            }
            o.Multiply(out ans, num);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
    class Operation
    {
        public void Multiply(out int ans, List<int> num)
        {
            ans = 1;
            foreach (int n in num)
            {
                ans *= n;
            }
        }
    }
}
