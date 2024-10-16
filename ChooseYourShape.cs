
class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Right-Angle Triangle");
            Console.WriteLine("3. Pyramid");
            Console.WriteLine("4. Diamond");
            Console.WriteLine("5. Exit");
            Console.Write("Choose a shape to print: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the length of the rectangle:");
                    int rectanglelength = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the width of the rectangle:");
                    int rectanglewidth = int.Parse(Console.ReadLine());

                    for (int i = 0; i < rectanglelength; i++) // For loop for length
                    {
                        for (int j = 0; j < rectanglewidth; j++) // For loop for width
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the height of the right-angle triangle:");
                    int triangleheight = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= triangleheight; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the height of the pyramid:");
                    int pyramidheight = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= pyramidheight; i++)
                    {
                        for (int j = i; j < pyramidheight; j++)
                        {
                            Console.Write("  ");
                        }
                        for (int k = 1; k <= (2 * i - 1); k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the height of the diamond:");
                    int diamondheight = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= diamondheight; i++)
                    {
                        for (int j = diamondheight; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = diamondheight - 1; i >= 1; i--)
                    {
                        for (int j = diamondheight; j>i; j--)
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
                case 5:
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }

            if (choice != 5)
            {
                Console.WriteLine("Would you like to choose another shape? (yes/no)");
                string response = Console.ReadLine().ToLower();
                continueProgram = response == "yes";
            }
        }
    }


}
