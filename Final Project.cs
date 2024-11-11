using System;
using System.Resources;

namespace FinalProject
{
    class MathMethods
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
    class Activies
    { 
        public void ActivityNo1()
        {
            Console.WriteLine("Activity 1 coding: \n");
            // Declaring an integer variable and assigning a value
            int intValue = 10;

            // Declaring a string variable and assigning a value
            string stringValue = "EMMANUEL JR D. MISOLA: BSIT - First Year";

            // Declaring a char variable and assigning a value
            char charValue = 'A';

            // Declaring a double variable and assigning a value
            double doubleValue = 10.0f;

            // Declaring a long variable and assigning a value
            long longValue = 100000000;

            // Declaring a bool variable and assigning a value
            bool boolValue = true;

            // Outputting the values of the variables to the console
            Console.WriteLine("This is an int: " + intValue);
            Console.WriteLine("This is a string: " + stringValue);
            Console.WriteLine("This is a char: " + charValue);
            Console.WriteLine("This is a double: " + doubleValue);
            Console.WriteLine("This is a long: " + longValue);
            Console.WriteLine("This is a bool: " + boolValue);

        }

        public void ActivityNo2()
        {
            Console.WriteLine("Activity 2 coding:");
            // Declaring an integer variable and assigning a value
            int intValue = 10;

            // Declaring a string variable and assigning a value
            string stringValue = "EMMANUEL JR D. MISOLA: BSIT - First Year";

            // Declaring a char variable and assigning a value
            char charValue = 'A';

            // Declaring a double variable and assigning a value
            double doubleValue = 10.0f;

            // Declaring a long variable and assigning a value
            long longValue = 100000000;

            // Declaring a bool variable and assigning a value
            bool boolValue = true;

            // Outputting the values of the variables to the console
            Console.WriteLine("This is an int: " + intValue);
            Console.WriteLine("This is a string: " + stringValue);
            Console.WriteLine("This is a char: " + charValue);
            Console.WriteLine("This is a double: " + doubleValue);
            Console.WriteLine("This is a long: " + longValue);
            Console.WriteLine("This is a bool: " + boolValue);
        }

        public void ActivityNo3()
        {
            Console.WriteLine("Activity 3 coding:");
            // Calculate the sum of 10 and 15
            int sumNumber = 10 + 15;

            // Calculate the difference between 12 and 9
            int differenceNumber = 12 - 9;

            // Calculate the product of 11 and 7
            int productNumber = 11 * 7;

            // Calculate the quotient of 42 divided by 5
            float quotientNumber = 42f / 5f;

            // Calculate the remainder of 42 divided by 5
            float remainderNumber = 42f % 5f;

            // Calculate 10 raised to the power of 5
            double resultNumber = Math.Pow(10, 5);

            // Output the results to the console
            Console.WriteLine("Sum of 10 & 15: " + sumNumber);
            Console.WriteLine("Difference of 12 & 9: " + differenceNumber);
            Console.WriteLine("Product of 11 & 7: " + productNumber);
            Console.WriteLine("Quotient and Remainder of 42 & 5: " + quotientNumber + " r " + remainderNumber);
            Console.WriteLine("Result of 10 raised to 5: " + resultNumber);
        }

        public void ActivityNo4()
        {
            Console.WriteLine("Activity 4 coding:");
            // Uses Escape Sequence: "\" - Used to include double quotes within the string.
            Console.WriteLine("Strings should be enclosed in quotation marks like so \"this is a string\"");
            // Uses Escape Sequence: "\\" - Used to include a backslash in the path. Inside of its C:\Windows\System32
            Console.WriteLine("You should not delete C:\\Windows\\System32");
            // Uses Escape Sequence: \t - Tab, \n - End
            Console.WriteLine("Hello \t\n\t Classmates!");
        }

        public void ActivityNo5()
        {
            Console.WriteLine("Activity 5 coding:");
            // 1st set of numbers
            int FirstSet_1stNumber = 10;
            int FirstSet_2ndNumber = 101;
            int FirstSet_3rdNumber = 11;

            // 2nd set of numbers
            int SecondSet_1stNumber = 23;
            int SecondSet_2ndNumber = 3;
            int SecondSet_3rdNumber = 12;

            // 3rd set of numbers
            int ThirdSet_1stNumber = 9;
            int ThirdSet_2ndNumber = 11;
            int ThirdSet_3rdNumber = 24;

            // Method to find biggest and smallest number in a set
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
            FindBiggestAndSmallest(FirstSet_1stNumber, FirstSet_2ndNumber, FirstSet_3rdNumber, "1st set");
            FindBiggestAndSmallest(SecondSet_1stNumber, SecondSet_2ndNumber, SecondSet_3rdNumber, "2nd set");
            FindBiggestAndSmallest(ThirdSet_1stNumber, ThirdSet_2ndNumber, ThirdSet_3rdNumber, "3rd set");
        }

        public void ActivityNo6()
        {
            Console.WriteLine("Activity 6 coding:"); // Output the activity title
            bool continueProgram = true; // Initialize the loop control variable

            do
            {
                try
                {
                    Console.Write("Enter Age: "); // Prompt the user for input
                    string input = Console.ReadLine(); // Read the input from the user

                    // Check if input is null
                    if (input == null)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        continue;
                    }

                    // Try to parse the input to an integer
                    if (!int.TryParse(input, out int age))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        continue;
                    }

                    // Check if the age is negative
                    if (age < 0)
                    {
                        Console.WriteLine("Invalid Input. Age cannot be negative.");
                        continueProgram = false; // End the loop if the age is negative
                    }
                    // Check if the age is unrealistically high
                    else if (age > 120)
                    {
                        Console.WriteLine("Invalid Input. Age is out of realistic range.");
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
            } while (continueProgram); // Continue the loop until continueProgram is false
        }

        public void ActivityNo7()
        {
            Console.WriteLine("Activity 7 coding: \n");

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
            Console.WriteLine("Activity 8 coding:");
            while (true)
            {
                int firstnumber = 0;
                int secondnumber = 0;

                Console.Write("\nInput 1st number: ");
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
                Console.WriteLine("Activity 8 coding:");
                Console.WriteLine("\nInput 1st number: " + firstnumber);
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
                    Console.WriteLine("Activity 8 coding:");
                    Console.WriteLine("\nInput 1st number: " + firstnumber);
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

        public void PrelimExam()
        {
            Console.WriteLine("Prelim Exam coding:");
            // Prelim Exam code here
        }

        public void MidtermExam()
        {
            Console.WriteLine("Midterm Exam coding:");
            // Define the valid range for military time (00:00 - 23:59)
            // 2 integer variables: militaryTime and hours
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
                else // If hours is greater than 12, it subtracts 12 from hours and appends “PM”.
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
                    // Display the standard time without leading zero for minutes
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
            Console.WriteLine("Semi Final Exam coding:");
            bool continueProgram = true; // Initialize the loop control variable

            while (continueProgram)
            {
                // Display the menu options
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Pyramid");
                Console.WriteLine("4. Exit");
                Console.Write("Choose your shape: ");

                // Initialize selection variable and read user input
                int selection = 0;
                string choice = Console.ReadLine();

                // Validate if the input is an integer
                if (!int.TryParse(choice, out selection))
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");
                    continue; // Restart the loop if the input is invalid
                }

                // Execute the corresponding action based on user selection
                switch (selection)
                {
                    case 1:
                        // Handle rectangle drawing
                        Console.Write("Input your length: ");
                        int rectanglelength = int.Parse(Console.ReadLine());
                        Console.Write("Input your width: ");
                        int rectanglewidth = int.Parse(Console.ReadLine());

                        // Loop to print the rectangle shape
                        for (int i = 0; i < rectanglelength; i++)
                        {
                            for (int j = 0; j < rectanglewidth; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 2:
                        // Handle triangle drawing
                        Console.Write("Input your height: ");
                        int triangleheight = int.Parse(Console.ReadLine());

                        // Loop to print the triangle shape
                        for (int i = 0; i <= triangleheight; i++)
                        {
                            for (int j = i; j < triangleheight; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 3:
                        // Handle pyramid drawing
                        Console.WriteLine("Enter the height of the pyramid:");
                        int pyramidheight = int.Parse(Console.ReadLine());

                        // Loop to print the pyramid shape
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
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 4:
                        // Exit the loop
                        continueProgram = false;
                        break;

                    default:
                        // Handle invalid selections
                        Console.WriteLine("Invalid Selection. Please Try Again.");
                        continue; // Restart the loop if the selection is invalid
                }

                // Prompt user to exit or continue
                if (selection != 4)
                {
                    Console.WriteLine("Would you like to exit the program? (yes/no): ");
                    string response = Console.ReadLine().ToLower();
                    continueProgram = response == "no"; // Continue if the user answers "no"
                }
            }
        }


        public class Program
        {
            static void Main(string[] args)
            {
                Activies activies = new Activies();
                int[] viewedActivities = new int[11]; // Assuming a maximum of 11 unique activities
                int viewedCount = 0;
                bool continueViewing = true;

                while (continueViewing)
                {
                    // Display menu
                    ShowMenu();

                    // Read user input
                    Console.Write("\nPlease select which activity you want to view: ");
                    string input = Console.ReadLine();
                    Console.Clear();
                    int selectedActivity;

                    // Validate input
                    if (int.TryParse(input, out selectedActivity))
                    {
                        if (selectedActivity >= 1 && selectedActivity <= 11)
                        {
                            // Add to the viewed list
                            viewedActivities[viewedCount] = selectedActivity;
                            viewedCount++;

                            // Show the selected activity or exam
                            Console.WriteLine("\nYou are viewing Activity " + selectedActivity + "\n");
                            switch (selectedActivity)
                            {
                                case 1:
                                    activies.ActivityNo1();
                                    break;
                                case 2:
                                    activies.ActivityNo2();
                                    break;
                                case 3:
                                    activies.ActivityNo3();
                                    break;
                                case 4:
                                    activies.ActivityNo4();
                                    break;
                                case 5:
                                    activies.ActivityNo5();
                                    break;
                                case 6:
                                    activies.ActivityNo6();
                                    break;
                                case 7:
                                    activies.ActivityNo7();
                                    break;
                                case 8:
                                    activies.ActivityNo8();
                                    break;
                                case 9:
                                    activies.PrelimExam();
                                    break;
                                case 10:
                                    activies.MidtermExam();
                                    break;
                                case 11:
                                    activies.SemiFinalExam();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection. Please select a number between 1 and 11.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please enter a number.");
                    }


                    // Prompt to continue
                    Console.Write("\nDo you wish to continue? (Answer yes or no): ");
                    continueViewing = Console.ReadLine().ToLower() == "yes";
                    Console.Clear();
                }

                Console.WriteLine("You have viewed the following activities:\n");
                for (int i = 0; i < viewedCount; i++)
                {
                    Console.WriteLine("Activity " + viewedActivities[i] + "\n");
                }

                Console.WriteLine("Program ends");
            }

            static void ShowMenu()
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
        }
    }
}
