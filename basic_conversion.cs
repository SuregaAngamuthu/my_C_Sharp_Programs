using System;
namespace Hello
class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a value");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The entered Number is {num}");
    }
}