class Program
{
    static void Main()
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
            
            if(!int.TryParse(choice, out selection))
            {
                Console.WriteLine("Invalid Input. Please Try Again.");
                continue;
            }

            switch(selection)
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

            if(selection != 4)
            {
                Console.WriteLine("Would you like to exit the program? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                continueProgram = response == "yes" == false;
            }
        }
    }
}
