using System;

public class Activity1
{
    int intValue = 10;
    int intValue2 = 20;
    public void Run()
    {
        Console.WriteLine ("This is a int: " + intValue);
    }
}
public class Activity2
{
    int intValue = 10;
    int intValue2 = 20;
    public void Run()
    {
        // Outputs the Integer
        Console.WriteLine("This is a int: " + intValue);
    }
}

public class Activity3
{
    public void Run()
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Pyramid");
            Console.WriteLine("4. Exit");
            Console.Write("Choose your shape: ");
            int selection = 0;
            string choice = Console.ReadLine();

            if (!int.TryParse(choice, out selection))
            {
                Console.WriteLine("Invalid Input. Please Try Again.");
                continue;
            }

            switch (selection)
            {
                case 1:
                    Console.Write("Input your length: ");
                    int rectanglelength = int.Parse(Console.ReadLine());
                    Console.Write("Input your width: ");
                    int rectanglewidth = int.Parse(Console.ReadLine());
                    for (int i = 0; i < rectanglelength; i++)
                    {
                        for (int j = 0; j < rectanglewidth; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int triangleheight = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= triangleheight; i++)
                    {
                        for (int j = i; j < triangleheight; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the height of the pyramid:");
                    int pyramidheight = int.Parse(Console.ReadLine());

                    for (int i = pyramidheight; i >= 1; i--)
                    {
                        for (int j = pyramidheight; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Please Try Again.");
                    continue;
            }

            if (selection != 4)
            {
                Console.WriteLine("Would you like to exit the activty 3? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                continueProgram = response == "yes" == false;
            }
        }
    }
}



public class Program
{
    static int activity1ViewCount = 0; 
    static int activity2ViewCount = 0;
    static int activity3ViewCount = 0;
    public static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("Viewlist: ");
            Console.WriteLine("Activity 1 Viewed: " + activity1ViewCount + " times");
            Console.WriteLine("Activity 2 Viewed: " + activity2ViewCount + " times");
            Console.WriteLine("Activity 3 Viewed: " + activity3ViewCount + " times");
            Console.Write("Insert your selection, act1, act2, act3: ");
            int userInput = 0;
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invaid Input");
                continue;
            }
            Console.Clear();
            switch (userInput)
            {
                case 1:
                    activity1ViewCount++;
                    Activity1 activity1 = new Activity1();
                    activity1.Run();
                    break;
                case 2:
                    activity2ViewCount++;
                    Activity2 activity2 = new Activity2();
                    activity2.Run();
                    break;
                case 3:
                    activity3ViewCount++;
                    Activity3 activity3 = new Activity3();
                    activity3.Run();
                    break;
                default:
                    break;
            }
            if (userInput != 4)
            {
                Console.WriteLine("Would you like to exit the program? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                continueProgram = response == "yes" == false;
                Console.Clear();
            }
        }

    }
}
