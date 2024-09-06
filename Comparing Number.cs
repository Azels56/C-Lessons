using System;

public class Program
{
    public static void Main(string[] args)
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

        // Biggest, Smallest variables: Used to store the biggest and smallest numbers from the 1st, 2nd and 3rd set of numbers.
        int biggestNumber = 0;
        int smallestNumber = 0;

        // Finding biggest and smallest for the first set
        // Checks every set of number if they are greater than or equal to their opposing number)
        if (FirstSet_1stNumber >= FirstSet_2ndNumber && FirstSet_1stNumber >= FirstSet_3rdNumber) // Checks if the first number is greater or equal to than 2nd, 3rd number. 
        {
            //Then assign the 1st number (if biggest) to the biggest variable in their set of order
            biggestNumber = FirstSet_1stNumber;
        }
        else if (FirstSet_2ndNumber >= FirstSet_1stNumber && FirstSet_2ndNumber >= FirstSet_3rdNumber) // Checks if the second number is greater or equal to than 1st, 3rd number. 
        {
            //Then assign the 2nd number (if biggest) to the biggest variable in their set of order
            biggestNumber = FirstSet_2ndNumber;
        }
        else // If 1st Number, 2nd Number are not the biggest, then else the 3rd number is the biggest.
        {
            //Then assign the 3rd number (if biggest) to the biggest variable in their set of order
            biggestNumber = FirstSet_3rdNumber;
        }

        // Checks every set of number if they are less than or equal to their opposing number)
        if (FirstSet_1stNumber <= FirstSet_2ndNumber && FirstSet_1stNumber <= FirstSet_3rdNumber) // Same as but if the first number is lesser then or equal to than 2nd, 3rd number.
        {
            //Then assign the 1st number (if smallest) to the smallest variable in their set of order
            smallestNumber = FirstSet_1stNumber;
        }
        else if (FirstSet_2ndNumber <= FirstSet_1stNumber && FirstSet_2ndNumber <= FirstSet_3rdNumber) // Same as but if the first number is lesser then or equal to than 1st, 3rd number.
        {
            //Then assign the 2nd number (if smallest) to the smallest variable in their set of order
            smallestNumber = FirstSet_2ndNumber;
        }
        else // If 1st Number, 2nd Number are not the smallest, then else the 3rd number is the smallest.
        {
            //Then assign the 3rd number (if smallest) to the smallest variable in their set of order
            smallestNumber = FirstSet_3rdNumber;
        }

        // Output for the first set
        Console.WriteLine("1st set: " + FirstSet_1stNumber + ", " + FirstSet_2ndNumber + ", " + FirstSet_3rdNumber);
        Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber); // Outputs the biggest and smallest
        Console.WriteLine();

        // Finding biggest and smallest for the 2nd set
        // Second Set of Order (Same explanation as previously stated)
        if (SecondSet_1stNumber >= SecondSet_2ndNumber && SecondSet_1stNumber >= SecondSet_3rdNumber)
        {
            biggestNumber = SecondSet_1stNumber;
        }
        else if (SecondSet_2ndNumber >= SecondSet_1stNumber && SecondSet_2ndNumber >= SecondSet_3rdNumber)
        {
            biggestNumber = SecondSet_2ndNumber;
        }
        else
        {
            biggestNumber = SecondSet_3rdNumber;
        }

        if (SecondSet_1stNumber <= SecondSet_2ndNumber && SecondSet_1stNumber <= SecondSet_3rdNumber)
        {
            smallestNumber = SecondSet_1stNumber;
        }
        else if (SecondSet_2ndNumber <= SecondSet_1stNumber && SecondSet_2ndNumber <= SecondSet_3rdNumber)
        {
            smallestNumber = SecondSet_2ndNumber;
        }
        else
        {
            smallestNumber = SecondSet_3rdNumber;
        }

        // Output for the second set
        Console.WriteLine("2nd set: " + SecondSet_1stNumber + ", " + SecondSet_2ndNumber + ", " + SecondSet_3rdNumber);
        Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber); // Outputs the biggest and smallest
        Console.WriteLine();

        // Finding biggest and smallest for the 2nd set
        // Third Set of Order (Same explanation as previously stated)
        if (ThirdSet_1stNumber >= ThirdSet_2ndNumber && ThirdSet_1stNumber >= ThirdSet_3rdNumber)
        {
            biggestNumber = ThirdSet_1stNumber;
        }
        else if (ThirdSet_2ndNumber >= ThirdSet_1stNumber && ThirdSet_2ndNumber >= ThirdSet_3rdNumber)
        {
            biggestNumber = ThirdSet_2ndNumber;
        }
        else if (ThirdSet_3rdNumber >= ThirdSet_1stNumber & ThirdSet_3rdNumber >= ThirdSet_2ndNumber)
        {
            biggestNumber = ThirdSet_3rdNumber;
        }

        if (ThirdSet_1stNumber <= ThirdSet_2ndNumber && ThirdSet_1stNumber <= ThirdSet_3rdNumber)
        {
            smallestNumber = ThirdSet_1stNumber;
        }
        else if (ThirdSet_2ndNumber <= ThirdSet_1stNumber && ThirdSet_2ndNumber <= ThirdSet_3rdNumber)
        {
            smallestNumber = ThirdSet_2ndNumber;
        }
        else 
        {
            smallestNumber = ThirdSet_3rdNumber;
        }

        // Output for the third set
        Console.WriteLine("3rd set: " + ThirdSet_1stNumber + ", " + ThirdSet_2ndNumber + ", " + ThirdSet_3rdNumber);
        Console.WriteLine("The Biggest Number: " + biggestNumber + "\nThe Smallest Number: " + smallestNumber); // Outputs the biggest and smallest
    }
}
