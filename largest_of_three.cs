using System;

class Program
{
    static void Main() {
        int a,b,c;
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        c=int.Parse(Console.ReadLine());
        if(a>b && a>c)
        Console.WriteLine(" {0} is largest",a);
        else if(b>c)
        Console.WriteLine(" {0} is largest",b);
        else
        Console.WriteLine(" {0} is largest",c);
        
    }
}