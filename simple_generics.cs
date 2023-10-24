using System;
namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                arr[i]=Convert.ToInt32(isEqual(a, b));
            }
            foreach(int a in arr)
            {
                Console.WriteLine(Convert.ToBoolean(arr[a]));
            }
            Console.ReadKey();
        }
        public static bool isEqual<T>(T a,T b)
        {
            a = (T)Convert.ChangeType(a, typeof(T));
            b = (T)Convert.ChangeType(b, typeof(T));
            if(a.Equals(b))
            {
                return true;
            }
            else
                return false;
        }
        
    }
    
}