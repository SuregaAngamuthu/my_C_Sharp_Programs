using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the elements of the array :");
            for(int i=0;i<size;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            //Program p = new Program();
            Program.array(a,size);
            Console.ReadKey();
        }
        public static void array(int[] a,int size)
        {
            try
            {
                Console.WriteLine(a[6]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An array index out of range excepton has occured.", e.Message);
            }
        }
    }
}
