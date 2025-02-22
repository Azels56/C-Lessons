using System;

namespace Finals
{
    class Arithmetic
    {
        // This method adds two integers
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        // This method subtracts the second integer from the first
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        // This method multiplies two integers
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // This method divides the first integer by the second
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class Activities
    {
        public void Activity1()
        {
            int age = 19;
            string nameAndCourse = "NAME: BSIT - First Year    ";
            char grade = 'A';
            float score = 49.5f;
            double gradePointAverage = 10.0f;          
            long largeNumber = 100000000;
            bool isEnrolled = true;

            Console.WriteLine("This is an int: " + age);
            Console.WriteLine("This is a string: " + nameAndCourse);
            Console.WriteLine("This is a char: " + grade);
            Console.WriteLine("This is a float: " + score);
            Console.WriteLine("This is a double: " + gradePointAverage);
            Console.WriteLine("This is a long: " + largeNumber);
            Console.WriteLine("This is a bool: " + isEnrolled);
        } 

        public void Activity2()
        {
            // Declaring an integer variable and assigning a value
            int age = 17;

            // Declaring a string variable and assigning a value
            string nameAndCourse = "NAME: BSIT - First Year";

            // Declaring a char variable and assigning a value
            char grade = 'A';

            // Declaring a float variable and assigning a value
            float score = 49.5f;

            // Declaring a double variable and assigning a value
            double gradePointAverage = 10.0f;

            // Declaring a long variable and assigning a value
            long largeNumber = 100000000;

            // Declaring a bool variable and assigning a value
            bool isEnrolled = true;

            // Outputting the values of the variables to the console
            Console.WriteLine("This is an int: " + age);
            Console.WriteLine("This is a string: " + nameAndCourse);
            Console.WriteLine("This is a char: " + grade);
            Console.WriteLine("This is a float: " + score);
            Console.WriteLine("This is a double: " + gradePointAverage);
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
            Console.WriteLine("Strings should be enclosed in quotation marks like so \"this is a string\"");
            // Uses Escape Sequence: "\\" - Used to include a backslash in the path. Inside of its C:\Windows\System32
            Console.WriteLine("You should not delete C:\\Windows\\System32");
            // Uses Escape Sequence: \t - Tab, \n - End
            Console.WriteLine("Hello \t\n\t Classmates!");
        }

        public void Activity5()
        {
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

            // Variables to store the biggest and smallest numbers from each set
            int biggestNumber = 0;
            int smallestNumber = 0;

            // Finding the biggest and smallest numbers for the first set of numbers
            if (FirstSet_1stNumber >= FirstSet_2ndNumber && FirstSet_1stNumber >= FirstSet_3rdNumber)
            {
                // If the first number is the biggest
                biggestNumber = FirstSet_1stNumber;
            }
            else if (FirstSet_2ndNumber >= FirstSet_1stNumber && FirstSet_2ndNumber >= FirstSet_3rdNumber)
            {
                // If the second number is the biggest
                biggestNumber = FirstSet_2ndNumber;
            }
            else
            {
                // If the third number is the biggest
                biggestNumber = FirstSet_3rdNumber;
            }

            if (FirstSet_1stNumber <= FirstSet_2ndNumber && FirstSet_1stNumber <= FirstSet_3rdNumber)
            {
                // If the first number is the smallest
                smallestNumber = FirstSet_1stNumber;
            }
            else if (FirstSet_2ndNumber <= FirstSet_1stNumber && FirstSet_2ndNumber <= FirstSet_3rdNumber)
            {
                // If the second number is the smallest
                smallestNumber = FirstSet_2ndNumber;
            }
            else
            {
                // If the third number is the smallest
                smallestNumber = FirstSet_3rdNumber;
            }

            // Output for the first set
            Console.WriteLine("1st set: " + FirstSet_1stNumber + ", " + FirstSet_2ndNumber + ", " + FirstSet_3rdNumber);
            Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
            Console.WriteLine();

            // Finding the biggest and smallest numbers for the second set of numbers
            if (SecondSet_1stNumber >= SecondSet_2ndNumber && SecondSet_1stNumber >= SecondSet_3rdNumber)
            {
                // If the first number is the biggest
                biggestNumber = SecondSet_1stNumber;
            }
            else if (SecondSet_2ndNumber >= SecondSet_1stNumber && SecondSet_2ndNumber >= SecondSet_3rdNumber)
            {
                // If the second number is the biggest
                biggestNumber = SecondSet_2ndNumber;
            }
            else
            {
                // If the third number is the biggest
                biggestNumber = SecondSet_3rdNumber;
            }

            if (SecondSet_1stNumber <= SecondSet_2ndNumber && SecondSet_1stNumber <= SecondSet_3rdNumber)
            {
                // If the first number is the smallest
                smallestNumber = SecondSet_1stNumber;
            }
            else if (SecondSet_2ndNumber <= SecondSet_1stNumber && SecondSet_2ndNumber <= SecondSet_3rdNumber)
            {
                // If the second number is the smallest
                smallestNumber = SecondSet_2ndNumber;
            }
            else
            {
                // If the third number is the smallest
                smallestNumber = SecondSet_3rdNumber;
            }

            // Output for the second set
            Console.WriteLine("2nd set: " + SecondSet_1stNumber + ", " + SecondSet_2ndNumber + ", " + SecondSet_3rdNumber);
            Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
            Console.WriteLine();

            // Finding the biggest and smallest numbers for the third set of numbers
            if (ThirdSet_1stNumber >= ThirdSet_2ndNumber && ThirdSet_1stNumber >= ThirdSet_3rdNumber)
            {
                // If the first number is the biggest
                biggestNumber = ThirdSet_1stNumber;
            }
            else if (ThirdSet_2ndNumber >= ThirdSet_1stNumber && ThirdSet_2ndNumber >= ThirdSet_3rdNumber)
            {
                // If the second number is the biggest
                biggestNumber = ThirdSet_2ndNumber;
            }
            else
            {
                // If the third number is the biggest
                biggestNumber = ThirdSet_3rdNumber;
            }

            if (ThirdSet_1stNumber <= ThirdSet_2ndNumber && ThirdSet_1stNumber <= ThirdSet_3rdNumber)
            {
                // If the first number is the smallest
                smallestNumber = ThirdSet_1stNumber;
            }
            else if (ThirdSet_2ndNumber <= ThirdSet_1stNumber && ThirdSet_2ndNumber <= ThirdSet_3rdNumber)
            {
                // If the second number is the smallest
                smallestNumber = ThirdSet_2ndNumber;
            }
            else
            {
                // If the third number is the smallest
                smallestNumber = ThirdSet_3rdNumber;
            }

            // Output for the third set
            Console.WriteLine("3rd set: " + ThirdSet_1stNumber + ", " + ThirdSet_2ndNumber + ", " + ThirdSet_3rdNumber);
            Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
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
            // Array of labels for the columns
            string[] labels = { "Name", "Course", "Year" };

            // 2D array of student details
            string[,] students = {
            {"Alex", "BSIT", "1st"},
            {"Michael", "BSCS", "2nd"},
            {"John", "BSIT", "2nd"},
            {"Noel", "BSCS", "1st"}
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

                Console.Write("Do you want to perform another calculation? (yes/no): ");
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
            Console.WriteLine("NAME" + " " + 18 + " " + 'M');
            Console.WriteLine("NAME" + " " + 18 + " " + 'F');
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
            bool isContinueProgram = true; // Initialize the loop control variable

            while (isContinueProgram)
            {
                // Display the menu options
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Right-Angle Triangle");
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
                        int rectangleLength;
                        if (!int.TryParse(Console.ReadLine(), out rectangleLength) || rectangleLength <= 0)
                        {
                            Console.WriteLine("Invalid input. Length must be a positive integer.");
                            break;
                        }

                        Console.Write("Input your width: ");
                        int rectangleWidth;
                        if (!int.TryParse(Console.ReadLine(), out rectangleWidth) || rectangleWidth <= 0)
                        {
                            Console.WriteLine("Invalid input. Width must be a positive integer.");
                            break;
                        }

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
                        int triangleHeight;
                        if (!int.TryParse(Console.ReadLine(), out triangleHeight) || triangleHeight <= 0)
                        {
                            Console.WriteLine("Invalid input. Height must be a positive integer.");
                            break;
                        }

                        // Loop to print the triangle shape
                        for (int i = 1; i <= triangleHeight; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(); // Move to the next line after each row
                        }
                        break;

                    case 3:
                        // Handle pyramid drawing
                        Console.Write("Enter the height of the pyramid: ");
                        int pyramidHeight;
                        if (!int.TryParse(Console.ReadLine(), out pyramidHeight) || pyramidHeight <= 0)
                        {
                            Console.WriteLine("Invalid input. Height must be a positive integer.");
                            break;
                        }

                        // Loop to print the pyramid shape upside down
                        for (int i = pyramidHeight; i > 0; i--)
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
                    Console.WriteLine("Would you like to continue? (Answer yes or no): ");
                    string userResponse = Console.ReadLine().ToLower();
                    isContinueProgram = userResponse == "yes"; // Continue if the user answers "yes"
                    Console.Clear(); // Clear the console for a fresh start
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
                // Display menu
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
                        Console.Write("\nDo you wish to continue? (Answer yes or no): ");
                        isContinueViewing = Console.ReadLine().ToLower() == "yes";
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear(); // Clear the console for invalid selection
                        Console.WriteLine("Invalid Selection. Please select a number between 1 and 11. \n");
                    }
                }
                else
                {
                    Console.Clear(); // Clear the console for invalid input
                    Console.WriteLine("Invalid Input. Please enter a number. \n");
                }
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
