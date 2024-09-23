using System;

class Program
{
    static void Main()
    {
        // 00:00 - 23:59
        // 2 int variable 
        // militaryTime around 00:00 - 23:59
        int militaryTime = 5959;
        int hours = militaryTime / 100;
        string period;
        Console.WriteLine("Hours: " + hours);
        Console.WriteLine("Minutes: " + (militaryTime % 100));
        if ((militaryTime % 100 < 59) && (hours > 0) && (militaryTime <= 2359))
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
                else // If hours is greater than 12, it subtracts 12 from hours and appends “PM”.
                {
                    hours -= 12;
                    period = "PM";
                }
                if (militaryTime % 100 < 10)
                { //It is 10:09 PM standard time
                    Console.WriteLine("It is " + hours + ":0" + (militaryTime % 100) + period + " standard time");
                }
                else
                {
                    Console.WriteLine("It is " + hours + ":" + (militaryTime) % 100 + period + " standard time");
                }
        } 
        else if (militaryTime == 0)
        {
            Console.WriteLine("It is 12 AM standard time");
        }
        else if (militaryTime <= 59 && militaryTime > 0)
        {
            Console.WriteLine("It is 12 " +  militaryTime + "AM standard time");
        }
        else { Console.WriteLine("Invalid Time"); }
    }
}
