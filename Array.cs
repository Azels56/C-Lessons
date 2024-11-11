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
