using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic4
{
    class Program
    {
        static string a = "s123";
        static int res = 0;
        static void Main(string[] args)
        {
            bool b = int.TryParse(a, out res);
            Console.WriteLine(b);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
