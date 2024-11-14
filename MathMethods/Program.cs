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
                Console.Clear(); // Clear the console for invalid input
                Console.WriteLine("Invalid Number. Please Try Again.");
                continue;
            }

            if (!int.TryParse(secondinput, out secondnumber))
            {
                Console.Clear(); // Clear the console for invalid input
                Console.WriteLine("Invalid Number. Please Try Again.");
                continue;
            }

            Console.Clear(); // Clear the console before displaying everything again
            Console.WriteLine("Input 1st number: " + firstnumber);
            Console.WriteLine("Input 2nd number: " + secondnumber);

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("Add - Addition");
                Console.WriteLine("Sub - Subtraction");
                Console.WriteLine("Mul - Multiplication");
                Console.WriteLine("Div - Division");
                Console.Write("\nPlease select an Option: ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "add" && choice != "sub" && choice != "mul" && choice != "div")
                {
                    Console.Clear(); // Clear the console for invalid selection
                    Console.WriteLine("Invalid selection. Please try again.\n");
                    continue;
                }

                Console.Clear(); // Clear the console before displaying the result
                Console.WriteLine("Input 1st number: " + firstnumber);
                Console.WriteLine("Input 2nd number: " + secondnumber);

                Console.WriteLine("\nOptions:");
                Console.WriteLine("Add - Addition");
                Console.WriteLine("Sub - Subtraction");
                Console.WriteLine("Mul - Multiplication");
                Console.WriteLine("Div - Division");

                Console.WriteLine("\nPlease select an Option: " + choice);

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
                }

                break;
            }

            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "yes")
            {
                break;
            }
            Console.Clear(); // Clear the console before starting a new calculation
        }
    }
}
