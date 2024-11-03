using System;
using Arithmetic;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
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
                continue;
            }

            if (!int.TryParse(secondinput, out secondnumber))
            {
                Console.WriteLine("Invalid Number. Please Try Again.");
                continue;
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
                        break;
                    case "sub":
                        Console.WriteLine("\nResult is: " + MathMethods.Sub(firstnumber, secondnumber) + "\n");
                        break;
                    case "mul":
                        Console.WriteLine("\nResult is: " + MathMethods.Mul(firstnumber, secondnumber) + "\n");
                        break;
                    case "div":
                        Console.WriteLine("\nResult is: " + MathMethods.Div(firstnumber, secondnumber) + "\n");
                        break;
                    default:
                        Console.WriteLine("Invalid input, Please try again.\n");
                        continue;
                }
                break;
            }

            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "yes")
            {
                break;
            }
        }
    }
}
