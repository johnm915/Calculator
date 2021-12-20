using System;

namespace Practice_Calculator_1
{
    class Program
    {
        static void Main (string[] args)

        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Plaese enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number to add to the first number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            



        } 

    }
}

