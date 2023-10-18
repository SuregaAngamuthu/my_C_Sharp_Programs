using System;

class Program
{
    static string userInput;  // Make 'userInput' static

    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        userInput = Console.ReadLine();  // Assign the value to the static 'userInput'

        if (!string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("You entered: " + userInput);
        }
        else
        {
            Console.WriteLine("You did not enter a valid string.");
        }
    }
}
