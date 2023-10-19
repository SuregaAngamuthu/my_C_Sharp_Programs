using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_defined_input
{
    class Program
    {
        //public static int a, b;
        public static int ans = 1;
        static void Main(string[] args)
        {
            Operation o = new Operation();
            List<int> num = new List<int> { 20, 30, 40 };
            o.Multiply(out ans,num);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
    class Operation
    {
        public void Multiply(out int ans,List<int> num)
        {
            ans = 1;
            foreach(int n in num)
            {
                 ans*= n;
            }
        }
    }
}
