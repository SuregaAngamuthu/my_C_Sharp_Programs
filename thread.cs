using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(CountDown);
            Thread th2 = new Thread(CountUp);
            th.Start();
            th2.Start();
            Console.ReadKey();
        }
        public static void CountDown()
        {
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
