using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            int[] arr = new int[3];
            Program p = new Program();
            p.Sum(out ans,10, 20);
            Console.WriteLine(ans);
            p.Sum(out ans, 20, 30, 40);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        public void Sum(out int ans, params int[] arr)
        {
            int res = 0;
            foreach (int i in arr)
            {
                res += i;
            }
            ans = res;
        }
    }
}
