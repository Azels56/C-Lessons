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
        int biggestFirstSet = 0;
        int smallestFirstSet = 0;

        int biggestSecondSet = 0;
        int smallestSecondSet = 0;

        int biggestThirdSet = 0;
        int smallestThirdSet = 0;

        // Finding biggest and smallest for the first set
        // Checks every set of number if they are greater than or equal to their opposing number)
        if (FirstSet_1stNumber >= FirstSet_2ndNumber && FirstSet_1stNumber >= FirstSet_3rdNumber) // Checks if the first number is greater or equal to than 2nd, 3rd number. 
        {
            //Then assign the 1st number (if biggest) to the biggest variable in their set of order
            biggestFirstSet = FirstSet_1stNumber;
        }
        else if (FirstSet_2ndNumber >= FirstSet_1stNumber && FirstSet_2ndNumber >= FirstSet_3rdNumber) // Checks if the second number is greater or equal to than 1st, 3rd number. 
        {
            //Then assign the 2nd number (if biggest) to the biggest variable in their set of order
            biggestFirstSet = FirstSet_2ndNumber;
        }
        else // If 1st Number, 2nd Number are not the biggest, then else the 3rd number is the biggest.
        {
            //Then assign the 3rd number (if biggest) to the biggest variable in their set of order
            biggestFirstSet = FirstSet_3rdNumber;
        }

        // Checks every set of number if they are less than or equal to their opposing number)
        if (FirstSet_1stNumber <= FirstSet_2ndNumber && FirstSet_1stNumber <= FirstSet_3rdNumber) // Same as but if the first number is lesser then or equal to than 2nd, 3rd number.
        {
            //Then assign the 1st number (if smallest) to the smallest variable in their set of order
            smallestFirstSet = FirstSet_1stNumber;
        }
        else if (FirstSet_2ndNumber <= FirstSet_1stNumber && FirstSet_2ndNumber <= FirstSet_3rdNumber) // Same as but if the first number is lesser then or equal to than 1st, 3rd number.
        {
            //Then assign the 2nd number (if smallest) to the smallest variable in their set of order
            smallestFirstSet = FirstSet_2ndNumber;
        }
        else // If 1st Number, 2nd Number are not the smallest, then else the 3rd number is the smallest.
        {
            //Then assign the 3rd number (if smallest) to the smallest variable in their set of order
            smallestFirstSet = FirstSet_3rdNumber;
        }

        // Output for the first set
        Console.WriteLine("1st set: " + FirstSet_1stNumber + ", " + FirstSet_2ndNumber + ", " + FirstSet_3rdNumber);
        Console.WriteLine("The Biggest Number: " + biggestFirstSet + "\nThe Smallest Number: " + smallestFirstSet); // Outputs the biggest and smallest
        Console.WriteLine();

        // Finding biggest and smallest for the 2nd set
        // Second Set of Order (Same explanation as previously stated)
        if (SecondSet_1stNumber >= SecondSet_2ndNumber && SecondSet_1stNumber >= SecondSet_3rdNumber)
        {
            biggestSecondSet = SecondSet_1stNumber;
        }
        else if (SecondSet_2ndNumber >= SecondSet_1stNumber && SecondSet_2ndNumber >= SecondSet_3rdNumber)
        {
            biggestSecondSet = SecondSet_2ndNumber;
        }
        else
        {
            biggestSecondSet = SecondSet_3rdNumber;
        }

        if (SecondSet_1stNumber <= SecondSet_2ndNumber && SecondSet_1stNumber <= SecondSet_3rdNumber)
        {
            smallestSecondSet = SecondSet_1stNumber;
        }
        else if (SecondSet_2ndNumber <= SecondSet_1stNumber && SecondSet_2ndNumber <= SecondSet_3rdNumber)
        {
            smallestSecondSet = SecondSet_2ndNumber;
        }
        else
        {
            smallestSecondSet = SecondSet_3rdNumber;
        }

        // Output for the second set
        Console.WriteLine("2nd set: " + SecondSet_1stNumber + ", " + SecondSet_2ndNumber + ", " + SecondSet_3rdNumber);
        Console.WriteLine("The Biggest Number: " + biggestSecondSet + "\nThe Smallest Number: " + smallestSecondSet); // Outputs the biggest and smallest
        Console.WriteLine();

        // Finding biggest and smallest for the 2nd set
        // Third Set of Order (Same explanation as previously stated)
        if (ThirdSet_1stNumber >= ThirdSet_2ndNumber && ThirdSet_1stNumber >= ThirdSet_3rdNumber)
        {
            biggestThirdSet = ThirdSet_1stNumber;
        }
        else if (ThirdSet_2ndNumber >= ThirdSet_1stNumber && ThirdSet_2ndNumber >= ThirdSet_3rdNumber)
        {
            biggestThirdSet = ThirdSet_2ndNumber;
        }
        else if (ThirdSet_3rdNumber >= ThirdSet_1stNumber & ThirdSet_3rdNumber >= ThirdSet_2ndNumber)
        {
            biggestThirdSet = ThirdSet_3rdNumber;
        }

        if (ThirdSet_1stNumber <= ThirdSet_2ndNumber && ThirdSet_1stNumber <= ThirdSet_3rdNumber)
        {
            smallestThirdSet = ThirdSet_1stNumber;
        }
        else if (ThirdSet_2ndNumber <= ThirdSet_1stNumber && ThirdSet_2ndNumber <= ThirdSet_3rdNumber)
        {
            smallestThirdSet = ThirdSet_2ndNumber;
        }
        else 
        {
            smallestThirdSet = ThirdSet_3rdNumber;
        }

        // Output for the third set
        Console.WriteLine("3rd set: " + ThirdSet_1stNumber + ", " + ThirdSet_2ndNumber + ", " + ThirdSet_3rdNumber);
        Console.WriteLine("The Biggest Number: " + biggestThirdSet + "\nThe Smallest Number: " + smallestThirdSet); // Outputs the biggest and smallest
    }
}
