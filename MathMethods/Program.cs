using System;
using Arithmetic;

public class Program
{
    public static void Main(string[] args)
    {
        int firstnumber = 0;
        int secondnumber = 0;

        Console.Write("Input 1st number: ");
        string firstinput = Console.ReadLine();
        Console.Write("Input 2nd number: ");
        string secondinput = Console.ReadLine();

        if (!int.TryParse(firstinput, out firstnumber))
        {
            Console.WriteLine("Invalid Number. Please Try Again.");
            return;
        }

        if (!int.TryParse(secondinput, out secondnumber))
        {
            Console.WriteLine("Invalid Number. Please Try Again.");
            return;
        }

        Console.WriteLine("\nFirst Number: " + firstnumber);
        Console.WriteLine("Second Number: " + secondnumber);

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("Add - Addition");
            Console.WriteLine("Sub - Subtraction");
            Console.WriteLine("Mul - Multiplication");
            Console.WriteLine("Div - Division");
            Console.Write("\nPlease select an Option: ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "add":
                    Console.WriteLine("\nResult is: " + MathMethods.Add(firstnumber, secondnumber) + "\n");
                    return;
                case "sub":
                    Console.WriteLine("\nResult is: " + MathMethods.Sub(firstnumber, secondnumber) + "\n");
                    return;
                case "mul":
                    Console.WriteLine("\nResult is: " + MathMethods.Mul(firstnumber, secondnumber) + "\n");
                    return;
                case "div":
                    Console.WriteLine("\nResult is: " + MathMethods.Div(firstnumber, secondnumber) + "\n");
                    return;
                default:
                    Console.WriteLine("Invalid input, Please try again.\n");
                    break;
            }
        }
    }
}
