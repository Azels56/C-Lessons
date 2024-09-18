using System;

class Program
{
    static void Main()
    {
        int militaryTime = 2400; 
        int hours = militaryTime / 100; 
        int minutes = militaryTime % 100;
        string period;

        if (minutes > 59)
        {
            Console.WriteLine("Invalid");
        }
        else
        {
            if (hours == 0)
            {
                hours = 12;
                period = "AM";
            }
            else if (hours < 12)
            {
                period = "AM";
            }
            else if (hours == 12)
            {
                period = "PM";
            }
            else
            {
                hours -= 12;
                period = "PM";
            }
            if (minutes < 10)
            {
                Console.WriteLine("It is " + hours + ":0" + minutes + period + " standard time");
            }
            else
            {
                Console.WriteLine("It is " + hours + ":" + minutes + period + " standard time");
            }
        }

    }
}
