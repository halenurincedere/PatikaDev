using System;

class Program
{
    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is smaller than, equal to, or greater than 10
        if (number < 10)
        {
            Console.WriteLine("The number you entered is smaller than 10.");
        }
        else if (number == 10)
        {
            Console.WriteLine("The number you entered is equal to 10.");
        }
        else
        {
            Console.WriteLine("The number you entered is greater than 10.");
        }

        // Check if the number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine("The number you entered is even.");
        }
        else
        {
            Console.WriteLine("The number you entered is odd.");
        }
    }
}