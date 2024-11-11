using System;

namespace FinalProject
{
    class Activies
    {
        public void ActivityNo1()
        {
            Console.WriteLine("Activity 1 coding: \n");
            // Activity 1 code here
            int intValue = 10;
            string stringValue = "EMMANUEL JR D. MISOLA: BSIT - First Year";
            char charValue = 'A';
            double doubleValue = 10.0f;
            long longValue = 100000000;
            bool boolValue = true;

            Console.WriteLine("This is a int: " + intValue);
            Console.Write("This is a int: " + intValue);
            Console.Write("This is a int: " + intValue);
            Console.Write("This is a int: " + intValue);
            Console.Write("This is a int: " + intValue);
        }

        public void ActivityNo2()
        {
            Console.WriteLine("Activity 2 coding:");
            // Activity 2 code here
        }

        public void ActivityNo3()
        {
            Console.WriteLine("Activity 3 coding:");
            // Activity 3 code here
        }

        public void ActivityNo4()
        {
            Console.WriteLine("Activity 4 coding:");
            // Activity 4 code here
        }

        public void ActivityNo5()
        {
            Console.WriteLine("Activity 5 coding:");
            // Activity 5 code here
        }

        public void ActivityNo6()
        {
            Console.WriteLine("Activity 6 coding:");
            // Activity 6 code here
        }

        public void ActivityNo7()
        {
            Console.WriteLine("Activity 7 coding: \n");

            string[] labels = { "Name", "Course", "Year" };
            string[,] students = {
            {"Juan", "BSIT", "1st"},
            {"Pedro", "BSCS", "2nd"},
            {"Cecil", "BSIT", "2nd"},
            {"Martin", "BSCS", "1st"}
            };

            foreach (var label in labels)
            {
                Console.Write(label + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < students.GetLength(1); j++)
                {
                    Console.Write(students[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ActivityNo8()
        {
            Console.WriteLine("Activity 8 coding:");
            // Activity 8 code here
        }

        public void PrelimExam()
        {
            Console.WriteLine("Prelim Exam coding:");
            // Prelim Exam code here
        }

        public void MidtermExam()
        {
            Console.WriteLine("Midterm Exam coding:");
            // Midterm Exam code here
        }

        public void SemiFinalExam()
        {
            Console.WriteLine("Semi Final Exam coding:");
            // Semi Final Exam code here
        }
    }


   public class Program
    {
        static void Main(string[] args)
        {
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

                                    break;
                                case 2:

                                    break;
                                case 3:

                                    break;
                                case 4:

                                    break;
                                case 5:

                                    break;
                                case 6:

                                    break;
                                case 7:

                                    break;
                                case 8:

                                    break;
                                case 9:

                                    break;
                                case 10:

                                    break;
                                case 11:
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
