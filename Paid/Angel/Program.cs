using System;

namespace Finals
{
    class Mathematics
    {
        // This method adds two integers
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        // This method subtracts the second integer from the first
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        // This method multiplies two integers
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // This method divides the first integer by the second
        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }

    class Activities
    {
        public void Activity1()
        {
            int age = 24;
            string fullNameAndCourse = "NAME:TOLENTINO, MARIANE MARIE O - BSIT, 1st Year";
            char gradeLetter = 'A';
            float examScore = 92.7f;
            double gpa = 4.0;
            long studentIdNumber = 1234567890;
            bool enrollmentStatus = true;

            Console.WriteLine("Student age: " + age);
            Console.WriteLine("Student name and course: " + fullNameAndCourse);
            Console.WriteLine("Student grade: " + gradeLetter);
            Console.WriteLine("Exam score: " + examScore);
            Console.WriteLine("Grade point average: " + gpa);
            Console.WriteLine("Student ID number: " + studentIdNumber);
            Console.WriteLine("Enrollment status: " + enrollmentStatus);
        }

        public void Activity2()
        {
            // Declare and initialize student-related variables
            int age = 24; // Student's age
            string fullNameAndCourse = "NAME:TOLENTINO, MARIANE MARIE O - BSIT, 1st Year"; // Student's full name and course
            char gradeLetter = 'A'; // Student's grade letter
            float examScore = 92.7f; // Student's exam score
            double gpa = 4.0; // Student's grade point average
            long studentIdNumber = 1234567890; // Student's ID number
            bool enrollmentStatus = true; // Student's enrollment status

            // Output the values of the student-related variables
            Console.WriteLine("Student age: " + age); // Output student age
            Console.WriteLine("Student name and course: " + fullNameAndCourse); // Output student name and course
            Console.WriteLine("Student grade: " + gradeLetter); // Output student grade letter
            Console.WriteLine("Exam score: " + examScore); // Output student exam score
            Console.WriteLine("Grade point average: " + gpa); // Output student grade point average
            Console.WriteLine("Student ID number: " + studentIdNumber); // Output student ID number
            Console.WriteLine("Enrollment status: " + enrollmentStatus); // Output student enrollment status
        }

        public void Activity3()
        {
            // Calculate the sum of 20 and 30
            int additionResult = 20 + 30;

            // Calculate the difference between 25 and 10
            int subtractionResult = 25 - 10;

            // Calculate the product of 9 and 8
            int multiplicationResult = 9 * 8;

            // Calculate the quotient of 50 divided by 4
            float divisionResult = 50f / 4f;

            // Calculate the remainder of 50 divided by 4
            float modulusResult = 50f % 4f;

            // Calculate 5 raised to the power of 3
            double exponentiationResult = Math.Pow(5, 3);

            // Output the results to the console
            Console.WriteLine("Sum of 20 & 30: " + additionResult);
            Console.WriteLine("Difference of 25 & 10: " + subtractionResult);
            Console.WriteLine("Product of 9 & 8: " + multiplicationResult);
            Console.WriteLine("Quotient and Remainder of 50 & 4: " + divisionResult + " r " + modulusResult);
            Console.WriteLine("Result of 5 raised to 3: " + exponentiationResult);

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
            int firstSetNumber1 = 10;
            int firstSetNumber2 = 101;
            int firstSetNumber3 = 11;

            // 2nd set of numbers
            int secondSetNumber1 = 23;
            int secondSetNumber2 = 3;
            int secondSetNumber3 = 12;

            // 3rd set of numbers
            int thirdSetNumber1 = 9;
            int thirdSetNumber2 = 11;
            int thirdSetNumber3 = 24;

            // Variables to store the biggest and smallest numbers from each set
            int biggestNumber = 0;
            int smallestNumber = 0;

            // Finding the biggest and smallest numbers for the first set of numbers
            if (firstSetNumber1 >= firstSetNumber2 && firstSetNumber1 >= firstSetNumber3)
            {
                // If the first number is the biggest
                biggestNumber = firstSetNumber1;
            }
            else if (firstSetNumber2 >= firstSetNumber1 && firstSetNumber2 >= firstSetNumber3)
            {
                // If the second number is the biggest
                biggestNumber = firstSetNumber2;
            }
            else
            {
                // If the third number is the biggest
                biggestNumber = firstSetNumber3;
            }

            if (firstSetNumber1 <= firstSetNumber2 && firstSetNumber1 <= firstSetNumber3)
            {
                // If the first number is the smallest
                smallestNumber = firstSetNumber1;
            }
            else if (firstSetNumber2 <= firstSetNumber1 && firstSetNumber2 <= firstSetNumber3)
            {
                // If the second number is the smallest
                smallestNumber = firstSetNumber2;
            }
            else
            {
                // If the third number is the smallest
                smallestNumber = firstSetNumber3;
            }

            // Output for the first set
            Console.WriteLine("1st set: " + firstSetNumber1 + ", " + firstSetNumber2 + ", " + firstSetNumber3);
            Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
            Console.WriteLine();

            // Finding the biggest and smallest numbers for the second set of numbers
            if (secondSetNumber1 >= secondSetNumber2 && secondSetNumber1 >= secondSetNumber3)
            {
                // If the first number is the biggest
                biggestNumber = secondSetNumber1;
            }
            else if (secondSetNumber2 >= secondSetNumber1 && secondSetNumber2 >= secondSetNumber3)
            {
                // If the second number is the biggest
                biggestNumber = secondSetNumber2;
            }
            else
            {
                // If the third number is the biggest
                biggestNumber = secondSetNumber3;
            }

            if (secondSetNumber1 <= secondSetNumber2 && secondSetNumber1 <= secondSetNumber3)
            {
                // If the first number is the smallest
                smallestNumber = secondSetNumber1;
            }
            else if (secondSetNumber2 <= secondSetNumber1 && secondSetNumber2 <= secondSetNumber3)
            {
                // If the second number is the smallest
                smallestNumber = secondSetNumber2;
            }
            else
            {
                // If the third number is the smallest
                smallestNumber = secondSetNumber3;
            }

            // Output for the second set
            Console.WriteLine("2nd set: " + secondSetNumber1 + ", " + secondSetNumber2 + ", " + secondSetNumber3);
            Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
            Console.WriteLine();

            // Finding the biggest and smallest numbers for the third set of numbers
            if (thirdSetNumber1 >= thirdSetNumber2 && thirdSetNumber1 >= thirdSetNumber3)
            {
                // If the first number is the biggest
                biggestNumber = thirdSetNumber1;
            }
            else if (thirdSetNumber2 >= thirdSetNumber1 && thirdSetNumber2 >= thirdSetNumber3)
            {
                // If the second number is the biggest
                biggestNumber = thirdSetNumber2;
            }
            else
            {
                // If the third number is the biggest
                biggestNumber = thirdSetNumber3;
            }

            if (thirdSetNumber1 <= thirdSetNumber2 && thirdSetNumber1 <= thirdSetNumber3)
            {
                // If the first number is the smallest
                smallestNumber = thirdSetNumber1;
            }
            else if (thirdSetNumber2 <= thirdSetNumber1 && thirdSetNumber2 <= thirdSetNumber3)
            {
                // If the second number is the smallest
                smallestNumber = thirdSetNumber2;
            }
            else
            {
                // If the third number is the smallest
                smallestNumber = thirdSetNumber3;
            }

            // Output for the third set
            Console.WriteLine("3rd set: " + thirdSetNumber1 + ", " + thirdSetNumber2 + ", " + thirdSetNumber3);
            Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber);
        }

        public void Activity6()
        {
            bool continueProgram = true; // Initialize the loop control variable

            do
            {
                Console.Write("Enter age: "); // Prompt the user for input
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
                    continueProgram = Console.ReadLine().ToLower() == "yes";
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (continueProgram); // Continue the loop until continueProgram is false
        }

        public void Activity7()
        {
            // Array of labels for the columns
            string[] labels = { "Name", "Course", "Year" };

            // 2D array
            string[,] students = {
            {"Juan", "BSIT", "1st"},
            {"Pedro", "BSCS", "2nd"},
            {"Cecil", "BSIT", "2nd"},
            {"Martin", "BSCS", "1st"}};

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
            bool continueProgram = true; // Initialize the loop control variable

            while (continueProgram)
            {
                // Input two numbers from the user
                int firstNumber = 0;
                int secondNumber = 0;

                Console.Write("Input 1st number: ");
                string firstInput = Console.ReadLine();
                Console.Write("Input 2nd number: ");
                string secondInput = Console.ReadLine();

                // Validate the first input
                if (!int.TryParse(firstInput, out firstNumber))
                {
                    Console.Clear(); // Clear the console for invalid input
                    Console.WriteLine("Invalid Number. Please Try Again.");
                    continue;
                }

                // Validate the second input
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
                    // Display operation options
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("Add - Addition");
                    Console.WriteLine("Sub - Subtraction");
                    Console.WriteLine("Mul - Multiplication");
                    Console.WriteLine("Div - Division");
                    Console.Write("\nPlease select an option: ");
                    string operationChoice = Console.ReadLine().ToLower();

                    // Validate operation choice
                    if (operationChoice != "add" && operationChoice != "sub" && operationChoice != "mul" && operationChoice != "div")
                    {
                        Console.Clear(); // Clear the console for invalid selection
                        Console.WriteLine("Invalid selection. Please try again.\n");
                        continue;
                    }

                    Console.Clear(); // Clear the console before displaying the result
                    Console.WriteLine("Input 1st number: " + firstNumber);
                    Console.WriteLine("Input 2nd number: " + secondNumber);

                    // Display selected operation and calculate result
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("Add - Addition");
                    Console.WriteLine("Sub - Subtraction");
                    Console.WriteLine("Mul - Multiplication");
                    Console.WriteLine("Div - Division");
                    Console.WriteLine("\nSelected option: " + operationChoice);

                    switch (operationChoice)
                    {
                        case "add":
                            Console.WriteLine("\nResult is: " + Mathematics.Add(firstNumber, secondNumber) + "\n");
                            break;
                        case "sub":
                            Console.WriteLine("\nResult is: " + Mathematics.Subtract(firstNumber, secondNumber) + "\n");
                            break;
                        case "mul":
                            Console.WriteLine("\nResult is: " + Mathematics.Multiply(firstNumber, secondNumber) + "\n");
                            break;
                        case "div":
                            Console.WriteLine("\nResult is: " + Mathematics.Divide(firstNumber, secondNumber) + "\n");
                            break;
                    }

                    break;
                }

                // Ask the user if they want to perform another calculation
                Console.Write("Do you want to perform another calculation? (yes/no): ");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                {
                    Console.Clear();
                    continueProgram = false; // Exit the loop
                }
                else
                {
                    Console.Clear(); // Clear the console before starting a new calculation
                }
            }
        }

        public void PrelimExam()
        {
            Console.WriteLine("TOLENTINO, MARIANE MARIE O." + " " + 24 + " " + 'F');
        }

        public void MidtermExam()
        {
            // Military time in the range 00:00 to 23:59
            int militaryTime = 1833; // Military time input
            int hours = militaryTime / 100; // Extract hours from military time
            string period = hours >= 12 ? "PM" : "AM"; // Determine if the time is AM or PM

            // Check if the time input is within the valid range and the minutes part is valid
            if ((militaryTime >= 0 && militaryTime <= 2359) && (militaryTime % 100 < 60))
            {
                if (militaryTime == 0)
                {
                    // Handle special case for midnight (00:00)
                    Console.WriteLine("It is 12:00 AM standard time.");
                }
                else if (militaryTime > 0 && militaryTime <= 59)
                {
                    // Handle special case for times between 00:01 and 00:59
                    Console.WriteLine("It is 12:" + (militaryTime < 10 ? "0" : "") + militaryTime + " AM standard time.");
                }
                else
                {
                    // Adjust hours for 12-hour format
                    if (hours > 12) hours -= 12;
                    if (hours == 0) hours = 12;

                    // Manual formatting of minutes with leading zero if needed
                    Console.WriteLine("It is " + hours + ":" + (militaryTime % 100 < 10 ? "0" : "") + (militaryTime % 100) + " " + period + " standard time.");
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
            // Initialize the Activities instance and array to track viewed activities
            Activities activities = new Activities();
            int[] viewedActivityIds = new int[11]; // Array to track viewed activities (11 total)
            int viewedActivityCount = 0;
            bool continueViewing = true;

            while (continueViewing)
            {
                // Display the menu of activities and exams
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

                // Prompt user for input
                Console.Write("\nPlease select which activity you want to view: ");
                string userInput = Console.ReadLine();
                Console.Clear();
                int selectedActivity;

                // Validate user input
                if (int.TryParse(userInput, out selectedActivity))
                {
                    if (selectedActivity >= 1 && selectedActivity <= 11)
                    {
                        // Check if the selected activity has already been viewed
                        bool alreadyViewed = false;
                        for (int i = 0; i < viewedActivityCount; i++)
                        {
                            if (viewedActivityIds[i] == selectedActivity)
                            {
                                alreadyViewed = true;
                                break;
                            }
                        }

                        // Add to viewed list if not already viewed
                        if (!alreadyViewed)
                        {
                            viewedActivityIds[viewedActivityCount] = selectedActivity;
                            viewedActivityCount++;
                        }

                        // Display the selected activity or exam
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

                        // Prompt to continue viewing
                        Console.Write("\nDo you wish to continue? (yes/no): ");
                        continueViewing = Console.ReadLine().ToLower() == "yes";
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear(); // Clear the console for invalid selection
                        Console.WriteLine("Invalid Selection...\n");
                    }
                }
                else
                {
                    Console.Clear(); // Clear the console for invalid input
                    Console.WriteLine("Invalid Input... \n");
                }
            }

            // Display the list of viewed activities
            Console.WriteLine("You viewed activities...\n");
            for (int i = 0; i < viewedActivityCount; i++)
            {
                Console.WriteLine("Activity " + viewedActivityIds[i] + "\n");
            }

            Console.WriteLine("Program ends...");
        }
    }
}
