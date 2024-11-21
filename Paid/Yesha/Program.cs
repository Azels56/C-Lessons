using System;

namespace FinalsProject
{
    class MathMethods
    {
        // This method adds two integers
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        // This method subtracts two integers
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        // This method multiplies two integers
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // This method divides two integers
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class Activities
    {
        public void Activity1()
        {
            int age = 18;
            string nameCourseYear = "Yesha Mae Vengco - BSIT: First Year";
            char grade = 'A';
            float score = 40.2f;
            double gradeAverage = 10.0f;
            long largeNumber = 9000000000000;
            bool isEnrolled = true;

            Console.WriteLine("This is an int: " + age);
            Console.WriteLine("This is a string: " + nameCourseYear);
            Console.WriteLine("This is a char: " + grade);
            Console.WriteLine("This is a float: " + score);
            Console.WriteLine("This is a double: " + gradeAverage);
            Console.WriteLine("This is a long: " + largeNumber);
            Console.WriteLine("This is a bool: " + isEnrolled);
        } 

        public void Activity2()
        {
            // Declaring an integer variable and assigning a value
            int age = 18;

            // Declaring a string variable and assigning a value
            string nameCourseYear = "Yesha Mae Vengco - BSIT: First Year";

            // Declaring a char variable and assigning a value
            char grade = 'A';

            // Declaring a float variable and assigning a value
            float score = 40.2f;

            // Declaring a double variable and assigning a value
            double gradeAverage = 10.0f;

            // Declaring a long variable and assigning a value
            long largeNumber = 9000000000000;

            // Declaring a bool variable and assigning a value
            bool isEnrolled = true;

            // Outputting the values of the variables to the console
            Console.WriteLine("This is an int: " + age);
            Console.WriteLine("This is a string: " + nameCourseYear);
            Console.WriteLine("This is a char: " + grade);
            Console.WriteLine("This is a float: " + score);
            Console.WriteLine("This is a double: " + gradeAverage);
            Console.WriteLine("This is a long: " + largeNumber);
            Console.WriteLine("This is a bool: " + isEnrolled);
        }

        public void Activity3()
        {
            // Calculate the sum of 10 and 15
            int sum = 10 + 15;

            // Calculate the difference between 12 and 9
            int difference = 12 - 9;

            // Calculate the product of 11 and 7
            int product = 11 * 7;

            // Calculate the quotient of 42 divided by 5
            float quotient = 42f / 5f;

            // Calculate the remainder of 42 divided by 5
            float remainder = 42f % 5f;

            // Calculate 10 raised to the power of 5
            double powerResult = Math.Pow(10, 5);

            // Output the results to the console
            Console.WriteLine("Sum of 10 & 15: " + sum);
            Console.WriteLine("Difference of 12 & 9: " + difference);
            Console.WriteLine("Product of 11 & 7: " + product);
            Console.WriteLine("Quotient and Remainder of 42 & 5: " + quotient + " r " + remainder);
            Console.WriteLine("Result of 10 raised to 5: " + powerResult);
        }

        public void Activity4()
        {
            // Uses Escape Sequence: "\" - Used to include double quotes within the string.
            Console.WriteLine("Strings should be enclosed in quotation marks like so \"this is a string\".");
            // Uses Escape Sequence: "\\" - Used to include a backslash in the path. Inside of its C:\Windows\System32
            Console.WriteLine("You should not delete C:\\Windows\\System32");   
            // Uses Escape Sequence: \t - Tab, \n - End
            Console.WriteLine("Hello \t\n\t Classmates!");
        }

        public void Activity5()
        {
            // First set of numbers
            int num1_set1 = 10, num2_set1 = 101, num3_set1 = 11;
            Console.WriteLine("1st set: 10, 101, 11");
            DetermineBiggestAndSmallest(num1_set1, num2_set1, num3_set1);
            // Second set of numbers
            int num1_set2 = 23, num2_set2 = 3, num3_set2 = 12;
            Console.WriteLine("2nd set: 23, 3, 12");
            DetermineBiggestAndSmallest(num1_set2, num2_set2, num3_set2);
            // Third set of numbers
            int num1_set3 = 9, num2_set3 = 11, num3_set3 = 24;
            Console.WriteLine("3rd set: 9, 11, 24");
            DetermineBiggestAndSmallest(num1_set3, num2_set3, num3_set3);
        }
        static void DetermineBiggestAndSmallest(int num1, int num2, int num3)
        {
            int biggest, smallest;
            // Determine the biggest number
            if (num1 >= num2 && num1 >= num3)
            {
                biggest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                biggest = num2;
            }
            else
            {
                biggest = num3;
            }
            // Determine the smallest number
            if (num1 <= num2 && num1 <= num3)
            {

                smallest = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
            // Output the results
            Console.WriteLine($"Biggest: {biggest}");
            Console.WriteLine($"Smallest: {smallest}");
            Console.WriteLine();
        }

        public void Activity6()
        {
            bool isContinueProgram = true; // Initialize the loop control variable

            do
            {
                Console.Write("Enter Age: "); // Prompt the user for input
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    // Determine the age group based on the entered age using switch
                    switch (age)
                    {
                        case int n when n >= 0 && n <= 6:
                            Console.WriteLine("Age group: Toddler");
                            break;
                        case int n when n >= 7 && n <= 12:
                            Console.WriteLine("Age group: Kid");
                            break;
                        case int n when n >= 13 && n <= 19:
                            Console.WriteLine("Age group: Teen");
                            break;
                        case int n when n >= 20 && n <= 30:
                            Console.WriteLine("Age group: Young Adult");
                            break;
                        case int n when n >= 31 && n <= 59:
                            Console.WriteLine("Age group: Adult");
                            break;
                        case int n when n >= 60:
                            Console.WriteLine("Age group: Senior");
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            break;
                    }

                    // Prompt for another calculation
                    Console.Write("Do you want to perform another calculation? (yes/no): ");
                    isContinueProgram = Console.ReadLine().ToLower() == "yes";
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (isContinueProgram); // Continue the loop until isContinueProgram is false
        }

        public void Activity7()
        {
            string[,] students = {
            {"Juan", "BSIT", "1st"},
            {"Pedro", "BSCS", "2nd"},
            {"Cecil", "BSIT", "2nd"},
            {"Martin", "BSCS", "1st"}
        };

            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Name", "Course", "Year");

            Console.WriteLine();

            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", students[i, 0], students[i, 1], students[i, 2]);
            }
        }

        public void Activity8()
        {
            while (true)
            {
                int firstNumber = 0;
                int secondNumber = 0;

                Console.Write("Input 1st number: ");
                string firstInput = Console.ReadLine();
                Console.Write("Input 2nd number: ");
                string secondInput = Console.ReadLine();

                if (!int.TryParse(firstInput, out firstNumber))
                {
                    Console.Clear(); // Clear the console for invalid input
                    Console.WriteLine("Invalid Number. Please Try Again.");
                    continue;
                }

                if (!int.TryParse(secondInput, out secondNumber))
                {
                    Console.Clear(); // Clear the console for invalid input
                    Console.WriteLine("Invalid Number. Please Try Again.");
                    continue;
                }

                Console.Clear(); // Clear the console before displaying everything again
                Console.WriteLine("Input 1st number: " + firstNumber);
                Console.WriteLine("Input 2nd number: " + secondNumber);

                while (true)
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("Add - Addition");
                    Console.WriteLine("Sub - Subtraction");
                    Console.WriteLine("Mul - Multiplication");
                    Console.WriteLine("Div - Division");
                    Console.Write("\nPlease select an Option: ");
                    string operationChoice = Console.ReadLine().ToLower();


                    if (operationChoice != "add" && operationChoice != "sub" && operationChoice != "mul" && operationChoice != "div")
                    {
                        Console.Clear(); // Clear the console for invalid selection
                        Console.WriteLine("Invalid selection. Please try again.\n");
                        continue;
                    }

                    Console.Clear(); // Clear the console before displaying the result
                    Console.WriteLine("Input 1st number: " + firstNumber);
                    Console.WriteLine("Input 2nd number: " + secondNumber);

                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("Add - Addition");
                    Console.WriteLine("Sub - Subtraction");
                    Console.WriteLine("Mul - Multiplication");
                    Console.WriteLine("Div - Division");

                    Console.WriteLine("\nPlease select an Option: " + operationChoice);

                    switch (operationChoice)
                    {
                        case "add":
                            Console.WriteLine("\nResult is: " + Arithmetic.Addition(firstNumber, secondNumber) + "\n");
                            break;
                        case "sub":
                            Console.WriteLine("\nResult is: " + Arithmetic.Subtract(firstNumber, secondNumber) + "\n");
                            break;
                        case "mul":
                            Console.WriteLine("\nResult is: " + Arithmetic.Multiply(firstNumber, secondNumber) + "\n");
                            break;
                        case "div":
                            Console.WriteLine("\nResult is: " + Arithmetic.Division(firstNumber, secondNumber) + "\n");
                            break;
                    }

                    break;
                }

                Console.Write("Do you want to perform another calculation? ");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear(); // Clear the console before starting a new calculation
            }
        }

        public void PrelimExam()
        {
            Console.WriteLine("Patrick Q. Malana" + " " + 18 + " " + 'M');
        }

        public void MidtermExam()
        {
            // 00:00 to 23:59
            int time = 2333; // Military time
            int hours = time / 100; // Extract hours
            string period = hours >= 12 ? "PM" : "AM"; // Determine if the time is AM or PM

            // Check if the time input is within the valid range and the minutes part is valid
            if ((time >= 0 && time <= 2359) && (time % 100 < 60))
            {
                if (time == 0)
                {
                    // Handle special case for midnight (00:00)
                    Console.WriteLine("It is 12:00 AM standard time.");
                }
                else if (time > 0 && time <= 59)
                {
                    // Handle special case for times between 00:01 and 00:59
                    Console.WriteLine("It is 12:" + (time < 10 ? "0" : "") + time + " AM standard time.");
                }
                else
                {
                    // Adjust hours for 12-hour format
                    if (hours > 12) hours -= 12;
                    if (hours == 0) hours = 12;

                    // Manual formatting of minutes with leading zero if needed
                    Console.WriteLine("It is " + hours + ":" + (time % 100 < 10 ? "0" : "") + (time % 100) + " " + period + " standard time.");
                }
            }
            else
            {
                // Handle invalid time input
                Console.WriteLine("Invalid Value");
            }
        }

        public void SemiFinalExam()
        {
            bool loop = true;
            int width;
            int length;
            int height;
            int selection;
            String exitDecision;

            while (loop)
            {
                Console.WriteLine("Select Design:");
                Console.WriteLine("1. Rectangle\n2. Right Pyramid\n3. Pyramid\n4. Exit\n");


                Console.WriteLine("Enter your Selection");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input\n");
                    continue;
                }

                switch (selection)
                {
                    case 1:

                        Console.Write("\nInput Width: ");

                        try
                        {
                            width = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter appropriate value\n");
                            continue;
                        }

                        Console.Write("Input Length: ");

                        try
                        {
                            length = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter appropriate value\n");
                            continue;
                        }

                        for (int row = 1; row <= width; row++)
                        {
                            Console.WriteLine();
                            for (int col = 1; col <= length; col++)
                            {
                                Console.Write("* ");
                            }
                        }

                        Console.WriteLine("\n");
                        break;

                    case 2:

                        Console.Write("\nInput Height: ");

                        try
                        {
                            height = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter appropriate value\n");
                            continue;
                        }

                        for (int row = 1; row <= height; row++)
                        {
                            Console.WriteLine();
                            for (int col = 1; col <= row; col++)
                            {
                                Console.Write("* ");
                            }
                        }

                        Console.WriteLine("\n");
                        break;

                    case 3:

                        Console.Write("\nInput Height: ");

                        try
                        {
                            height = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter appropriate value\n");
                            continue;
                        }

                        for (int row = 1; row <= height; row++)
                        {
                            Console.WriteLine();
                            for (int space = height; space >= row; space--)
                            {
                                Console.Write(" ");
                            }
                            for (int col = 1; col <= row; col++)
                            {
                                Console.Write("* ");
                            }
                        }

                        Console.WriteLine("\n");
                        break;

                    case 4:

                        loop = false;
                        Console.WriteLine();
                        continue;

                    default:

                        Console.WriteLine("Invalid Selection \n");
                        continue;

                }

                Console.WriteLine("Do you wish to exit?");
                exitDecision = Console.ReadLine();

                if (exitDecision == "yes" || exitDecision == "YES" || exitDecision == "Yes")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine();
                    continue;
                }
            }
        }

        static void Main(string[] args)
        {
            Activities activities = new Activities();
            int[] viewedActivities = new int[11]; // Array viewed activities (11)
            int viewedActivitiesCount = 0;
            bool isContinueViewing = true;

            while (isContinueViewing)
            {
                // Menu
                Console.WriteLine("1. Activity No.1");
                Console.WriteLine("2. Activity No.2");
                Console.WriteLine("3. Activity No.3");
                Console.WriteLine("4. Activity No.4");
                Console.WriteLine("5. Activity No.5");
                Console.WriteLine("6. Activity No.6");
                Console.WriteLine("7. Activity No.7");
                Console.WriteLine("8. Activity No.8");
                Console.WriteLine("9. Prelim Exam");
                Console.WriteLine("10. Midterm Exam");
                Console.WriteLine("11. Semi Final Exam");

                // User Input
                Console.Write("\nPlease select which activity you want to view: ");
                string userInput = Console.ReadLine();
                Console.Clear();
                int selectedActivity;

                // Validate input
                if (int.TryParse(userInput, out selectedActivity))
                {
                    if (selectedActivity >= 1 && selectedActivity <= 11)
                    {
                        // Add to the viewed list if not already viewed
                        bool isAlreadyViewed = false;
                        for (int i = 0; i < viewedActivitiesCount; i++)
                        {
                            if (viewedActivities[i] == selectedActivity)
                            {
                                isAlreadyViewed = true;
                                break;
                            }
                        }
                        if (!isAlreadyViewed)
                        {
                            viewedActivities[viewedActivitiesCount] = selectedActivity;
                            viewedActivitiesCount++;
                        }

                        // Show the selected activity or exam
                        Console.WriteLine("You are viewing Activity " + selectedActivity + "\n");
                        switch (selectedActivity)
                        {
                            case 1:
                                activities.Activity1();
                                break;
                            case 2:
                                activities.Activity2();
                                break;
                            case 3:
                                activities.Activity3();
                                break;
                            case 4:
                                activities.Activity4();
                                break;
                            case 5:
                                activities.Activity5();
                                break;
                            case 6:
                                activities.Activity6();
                                break;
                            case 7:
                                activities.Activity7();
                                break;
                            case 8:
                                activities.Activity8();
                                break;
                            case 9:
                                activities.PrelimExam();
                                break;
                            case 10:
                                activities.MidtermExam();
                                break;
                            case 11:
                                activities.SemiFinalExam();
                                break;
                        }

                        // Prompt to continue
                        Console.Write("\nDo you wish to continue? ");
                        isContinueViewing = Console.ReadLine().ToLower() == "yes";
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear(); // Clear the console for invalid selection
                        Console.WriteLine("Invalid Selection.\n");
                    }
                }
                else
                {
                    Console.Clear(); // Clear the console for invalid input
                    Console.WriteLine("Invalid Input.\n");
                }
            }

            Console.WriteLine("You viewed activities:\n");
            for (int i = 0; i < viewedActivitiesCount; i++)
            {
                Console.WriteLine("Activity No." + viewedActivities[i] /*"\n"*/);
            }

            Console.WriteLine("\nProgram ends");
        }
    }
}
