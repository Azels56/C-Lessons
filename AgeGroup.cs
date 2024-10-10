using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool continueProgram = true;

        do
        {
            try
            {
                Console.Write("Enter Age: ");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }
                if (!int.TryParse(input, out int age))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }
                if (age < 0)
                {
                    Console.WriteLine("Invalid Input. Age cannot be negative.");
                    continueProgram = false;            
                }
                else if (age > 120)
                {
                    Console.WriteLine("Invalid Input. Age is out of realistic range.");
                    continue;
                }
                else
                {
                    switch (age)
                    {
                        case int userAge when (userAge >= 0 && userAge <= 6):
                            Console.WriteLine("Age group: Toddler");
                            break;
                        case int userAge when (userAge >= 7 && userAge <= 12):
                            Console.WriteLine("Age group: Kid");
                            break;
                        case int userAge when (userAge >= 13 && userAge <= 19):
                            Console.WriteLine("Age group: Teen");
                            break;
                        case int userAge when (userAge >= 20 && userAge <= 30):
                            Console.WriteLine("Age group: Young Adult");
                            break;
                        case int userAge when (userAge >= 31 && userAge <= 59):
                            Console.WriteLine("Age group: Adult");
                            break;
                        case int userAge when (userAge >= 60):
                            Console.WriteLine("Age group: Senior");
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (continueProgram); 
     }
}
