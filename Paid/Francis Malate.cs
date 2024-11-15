using System;

namespace Finals
{
    class Arithmetic
    {
        // This method adds two integers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // This method subtracts the second integer from the first
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        // This method multiplies two integers
        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        // This method divides the first integer by the second
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

    }
    class Activities
    {
        public void ShowMenu()
        {
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
        }
        public void ActivityNo1()
        {
            Console.WriteLine("Activity 1: \n");

            // Declaring an integer variable and assigning a value
            int integerVariable = 10;

            // Declaring a string variable and assigning a value
            string nameAndCourse = "EMMANUEL JR D. MISOLA: BSIT - First Year";

            // Declaring a char variable and assigning a value
            char grade = 'A';

            // Declaring a double variable and assigning a value
            double gradePointAverage = 10.0f;

            // Declaring a long variable and assigning a value
            long largeNumber = 100000000;

            // Declaring a bool variable and assigning a value
            bool isEnrolled = true;

            // Outputting the values of the variables to the console
            Console.WriteLine("This is an int: " + integerVariable);
            Console.WriteLine("This is a string: " + nameAndCourse);
            Console.WriteLine("This is a char: " + grade);
            Console.WriteLine("This is a double: " + gradePointAverage);
            Console.WriteLine("This is a long: " + largeNumber);
            Console.WriteLine("This is a bool: " + isEnrolled);

        }

        public void ActivityNo2()
        {
            Console.WriteLine("Activity 1: \n");

            // Declaring an integer variable and assigning a value
            int integerVariable = 10;

            // Declaring a string variable and assigning a value
            string nameAndCourse = "UR NAME: BSIT - First Year";

            // Declaring a char variable and assigning a value
            char grade = 'A';

            // Declaring a double variable and assigning a value
            double gradePointAverage = 10.0f;

            // Declaring a long variable and assigning a value
            long largeNumber = 100000000;

            // Declaring a bool variable and assigning a value
            bool isEnrolled = true;

            // Outputting the values of the variables to the console
            Console.WriteLine("This is an int: " + integerVariable);
            Console.WriteLine("This is a string: " + nameAndCourse);
            Console.WriteLine("This is a char: " + grade);
            Console.WriteLine("This is a double: " + gradePointAverage);
            Console.WriteLine("This is a long: " + largeNumber);
            Console.WriteLine("This is a bool: " + isEnrolled);
        }

        public void ActivityNo3()
        {
            Console.WriteLine("Activity 3: ");

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

        public void ActivityNo4()
        {
            Console.WriteLine("Activity 4: ");
            // Uses Escape Sequence: "\" - Used to include double quotes within the string.
            Console.WriteLine("Strings should be enclosed in quotation marks like so \"this is a string\"");
            // Uses Escape Sequence: "\\" - Used to include a backslash in the path. Inside of its C:\Windows\System32
            Console.WriteLine("You should not delete C:\\Windows\\System32");
            // Uses Escape Sequence: \t - Tab, \n - End
            Console.WriteLine("Hello \t\n\t Classmates!");
        }

        public void ActivityNo5()
        {
            Console.WriteLine("Activity 5: ");

            // 1st set of numbers
            int firstSetFirstNumber = 10;
            int firstSetSecondNumber = 101;
            int firstSetThirdNumber = 11;

            // 2nd set of numbers
            int secondSetFirstNumber = 23;
            int secondSetSecondNumber = 3;
            int secondSetThirdNumber = 12;

            // 3rd set of numbers
            int thirdSetFirstNumber = 9;
            int thirdSetSecondNumber = 11;
            int thirdSetThirdNumber = 24;

            // Method to find the biggest and smallest number in a set
            void FindBiggestAndSmallest(int num1, int num2, int num3, string setName)
            {
                int biggestNumber;
                int smallestNumber;

                // Finding the biggest number
                if (num1 >= num2 && num1 >= num3)
                {
                    biggestNumber = num1;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    biggestNumber = num2;
                }
                else
                {
                    biggestNumber = num3;
                }

                // Finding the smallest number
                if (num1 <= num2 && num1 <= num3)
                {
                    smallestNumber = num1;
                }
                else if (num2 <= num1 && num2 <= num3)
                {
                    smallestNumber = num2;
                }
                else
                {
                    smallestNumber = num3;
                }

                // Output for the set
                Console.WriteLine(setName + ": " + num1 + ", " + num2 + ", " + num3);
                Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
                Console.WriteLine();
            }

            // Call the method for each set
            FindBiggestAndSmallest(firstSetFirstNumber, firstSetSecondNumber, firstSetThirdNumber, "1st set");
            FindBiggestAndSmallest(secondSetFirstNumber, secondSetSecondNumber, secondSetThirdNumber, "2nd set");
            FindBiggestAndSmallest(thirdSetFirstNumber, thirdSetSecondNumber, thirdSetThirdNumber, "3rd set");
        }

        public void ActivityNo6()
        {
            Console.WriteLine("Activity 6: "); // Output the activity title
            bool isContinueProgram = true; // Initialize the loop control variable

            do
            {
                try
                {
                    Console.Write("Enter Age: "); // Prompt the user for input
                    string userInput = Console.ReadLine(); // Read the input from the user

                    // Check if input is null
                    if (userInput == null)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        continue;
                    }

                    // Try to parse the input to an integer
                    if (!int.TryParse(userInput, out int age))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        continue;
                    }

                    else
                    {
                        // Determine the age group based on the entered age
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
                // Handle exceptions for invalid format
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (isContinueProgram); // Continue the loop until isContinueProgram is false
        }

        public void ActivityNo7()
        {
            Console.WriteLine("Activity 7: \n");

            // Array of labels for the columns
            string[] labels = { "Name", "Course", "Year" };

            // 2D array of student details
            string[,] students = {
            {"Juan", "BSIT", "1st"},
            {"Pedro", "BSCS", "2nd"},
            {"Cecil", "BSIT", "2nd"},
            {"Martin", "BSCS", "1st"}
        };

            // Loop through each label in the labels array and print it
            foreach (var label in labels)
            {
                Console.Write(label + "\t");
            }
            Console.WriteLine(); // New line after the labels
            Console.WriteLine(); // Another new line for spacing

            // Loop through the students array
            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < students.GetLength(1); j++)
                {
                    // Print each element of the students array
                    Console.Write(students[i, j] + "\t");
                }
                Console.WriteLine(); // New line after each student
            }
        }

        public void ActivityNo8()
        {
            Console.WriteLine("Activity 8:");

            while (true)
            {
                int firstNumber = 0;
                int secondNumber = 0;

                Console.Write("\nInput 1st number: ");
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
                Console.WriteLine("Activity 8:");
                Console.WriteLine("\nInput 1st number: " + firstNumber);
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
                    Console.WriteLine("Activity 8:");
                    Console.WriteLine("\nInput 1st number: " + firstNumber);
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
                            Console.WriteLine("\nResult is: " + Arithmetic.Add(firstNumber, secondNumber) + "\n");
                            break;
                        case "sub":
                            Console.WriteLine("\nResult is: " + Arithmetic.Sub(firstNumber, secondNumber) + "\n");
                            break;
                        case "mul":
                            Console.WriteLine("\nResult is: " + Arithmetic.Mul(firstNumber, secondNumber) + "\n");
                            break;
                        case "div":
                            Console.WriteLine("\nResult is: " + Arithmetic.Div(firstNumber, secondNumber) + "\n");
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

        public void PrelimExam()
        {
            Console.WriteLine("Prelim Exam:");
            Console.WriteLine("UR NAME" + " " + 17 + " " + 'M');
            Console.WriteLine("ANOTHER NAME" + " " + 19 + " " + 'F');
        }

        public void MidtermExam()
        {
            Console.WriteLine("Midterm Exam:");

            // Define the valid range for military time (00:00 - 23:59)
            // Declare two integer variables: militaryTime and hours
            // militaryTime represents time in HHMM format
            int militaryTime = 5959; // Example invalid time for demonstration
            int hours = militaryTime / 100; // Extract hours from militaryTime
            string period; // String to hold AM or PM period

            // Display the hours and minutes
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Minutes: " + (militaryTime % 100));

            // Check if the time is valid
            if ((militaryTime % 100 <= 59 && militaryTime <= 2359 && militaryTime % 100 > 0) && (hours >= 0 && militaryTime % 100 < 60))
            {
                // Determine AM/PM period
                if (hours == 0)
                {
                    hours = 12; // Convert 00 hours to 12 AM
                    period = "AM";
                }
                else if (hours < 12)
                {
                    period = "AM"; // Time is in the AM period
                }
                else if (hours == 12)
                {
                    period = "PM"; // 12 hours is 12 PM
                }
                else // If hours is greater than 12, subtract 12 from hours and append “PM”
                {
                    hours -= 12;
                    period = "PM";
                }

                // Display the standard time with appropriate format
                if (militaryTime % 100 < 10)
                {
                    // For minutes less than 10, add a leading zero
                    Console.WriteLine("It is " + hours + ":0" + (militaryTime % 100) + period + " standard time");
                }
                else
                {
                    // Display the standard time without a leading zero for minutes
                    Console.WriteLine("It is " + hours + ":" + (militaryTime % 100) + period + " standard time");
                }
            }
            else if (militaryTime == 0)
            {
                // Special case for midnight
                Console.WriteLine("It is 12 AM standard time");
            }
            else if (militaryTime <= 59 && militaryTime > 0)
            {
                // Special case for times between 00:01 and 00:59
                Console.WriteLine("It is 12:" + militaryTime + " AM standard time");
            }
            else
            {
                // If the input time is not valid, display an error message
                Console.WriteLine("Invalid Time");
            }
        }

        public void SemiFinalExam()
        {
            Console.WriteLine("Semi Final Exam:");
            bool isContinueProgram = true; // Initialize the loop control variable

            while (isContinueProgram)
            {
                // Display the menu options
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Pyramid");
                Console.WriteLine("4. Exit");
                Console.Write("Choose your shape: ");

                // Initialize selection variable and read user input
                int userSelection = 0;
                string userInput = Console.ReadLine();

                // Validate if the input is an integer
                if (!int.TryParse(userInput, out userSelection))
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");
                    continue; // Restart the loop if the input is invalid
                }

                // Execute the corresponding action based on user selection
                switch (userSelection)
                {
                    case 1:
                        // Handle rectangle drawing
                        Console.Write("Input your length: ");
                        int rectangleLength = int.Parse(Console.ReadLine());
                        Console.Write("Input your width: ");
                        int rectangleWidth = int.Parse(Console.ReadLine());

                        // Loop to print the rectangle shape
                        for (int i = 0; i < rectangleLength; i++)
                        {
                            for (int j = 0; j < rectangleWidth; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 2:
                        // Handle triangle drawing
                        Console.Write("Input your height: ");
                        int triangleHeight = int.Parse(Console.ReadLine());

                        // Loop to print the triangle shape
                        for (int i = 0; i <= triangleHeight; i++)
                        {
                            for (int j = i; j < triangleHeight; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 3:
                        // Handle pyramid drawing
                        Console.WriteLine("Enter the height of the pyramid:");
                        int pyramidHeight = int.Parse(Console.ReadLine());

                        // Loop to print the pyramid shape
                        for (int i = pyramidHeight; i >= 1; i--)
                        {
                            for (int j = pyramidHeight; j > i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 4:
                        // Exit the loop
                        isContinueProgram = false;
                        break;

                    default:
                        // Handle invalid selections
                        Console.WriteLine("Invalid Selection. Please Try Again.");
                        continue; // Restart the loop if the selection is invalid
                }

                // Prompt user to exit or continue
                if (userSelection != 4)
                {
                    Console.WriteLine("Would you like to exit the program? (yes/no): ");
                    string userResponse = Console.ReadLine().ToLower();
                    isContinueProgram = userResponse == "no"; // Continue if the user answers "no"
                }
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Activities activities = new Activities();
                int[] viewedActivities = new int[11]; // Array to track viewed activities
                int viewedActivitiesCount = 0;
                bool isContinueViewing = true;

                while (isContinueViewing)
                {
                    // Display menu
                    activities.ShowMenu();

                    // Read user input
                    Console.Write("\nPlease select which activity you want to view: ");
                    string userInput = Console.ReadLine();
                    Console.Clear();
                    int selectedActivity;

                    // Validate input
                    if (int.TryParse(userInput, out selectedActivity))
                    {
                        if (selectedActivity >= 1 && selectedActivity <= 11)
                        {
                            // Show the selected activity or exam
                            Console.WriteLine("\nYou are viewing Activity " + selectedActivity + "\n");
                            switch (selectedActivity)
                            {
                                case 1:
                                    activities.ActivityNo1();
                                    break;
                                case 2:
                                    activities.ActivityNo2();
                                    break;
                                case 3:
                                    activities.ActivityNo3();
                                    break;
                                case 4:
                                    activities.ActivityNo4();
                                    break;
                                case 5:
                                    activities.ActivityNo5();
                                    break;
                                case 6:
                                    activities.ActivityNo6();
                                    break;
                                case 7:
                                    activities.ActivityNo7();
                                    break;
                                case 8:
                                    activities.ActivityNo8();
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
                        }
                        else
                        {
                            Console.Clear(); // Clear the console for invalid selection
                            Console.WriteLine("Invalid Selection. Please select a number between 1 and 11.");
                        }
                    }
                    else
                    {
                        Console.Clear(); // Clear the console for invalid input
                        Console.WriteLine("Invalid Input. Please enter a number.");
                    }

                    // Prompt to continue
                    Console.Write("\nDo you wish to continue? (Answer yes or no): ");
                    isContinueViewing = Console.ReadLine().ToLower() == "yes";
                    Console.Clear();
                }

                Console.WriteLine("You have viewed the following activities:\n");
                for (int i = 0; i < viewedActivitiesCount; i++)
                {
                    Console.WriteLine("Activity " + viewedActivities[i] + "\n");
                }

                Console.WriteLine("Program ends");
            }
        }
    }
}
