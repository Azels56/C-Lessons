using System;

class Program
{
    static void Main()
    {

        int militaryTime = 2250;
        string period;
        int hours;
        int minutes = militaryTime % 100;
        int militaryHours = militaryTime / 100;

        if (militaryHours == 0)
        {
            hours = 12;  
            period = "AM";
        }
        else if (militaryHours == 1)
        {
            hours = 1;
            period = "AM";
        }
        else if (militaryHours == 2)
        {
            hours = 2;
            period = "AM";
        }
        else if (militaryHours == 3)
        {
            hours = 3;
            period = "AM";
        }
        else if (militaryHours == 4)
        {
            hours = 4;
            period = "AM";
        }
        else if (militaryHours == 5)
        {
            hours = 5;
            period = "AM";
        }
        else if (militaryHours == 6)
        {
            hours = 6;
            period = "AM";
        }
        else if (militaryHours == 7)
        {
            hours = 7;
            period = "AM";
        }
        else if (militaryHours == 8)
        {
            hours = 8;
            period = "AM";
        }
        else if (militaryHours == 9)
        {
            hours = 9;
            period = "AM";
        }
        else if (militaryHours == 10)
        {
            hours = 10;
            period = "AM";
        }
        else if (militaryHours == 11)
        {
            hours = 11;
            period = "AM";
        }
        else if (militaryHours == 12)
        {
            hours = 12;  
            period = "PM";
        }
        else if (militaryHours == 13)
        {
            hours = 1;
            period = "PM";
        }
        else if (militaryHours == 14)
        {
            hours = 2;
            period = "PM";
        }
        else if (militaryHours == 15)
        {
            hours = 3;
            period = "PM";
        }
        else if (militaryHours == 16)
        {
            hours = 4;
            period = "PM";
        }
        else if (militaryHours == 17)
        {
            hours = 5;
            period = "PM";
        }
        else if (militaryHours == 18)
        {
            hours = 6;
            period = "PM";
        }
        else if (militaryHours == 19)
        {
            hours = 7;
            period = "PM";
        }
        else if (militaryHours == 20)
        {
            hours = 8;
            period = "PM";
        }
        else if (militaryHours == 21)
        {
            hours = 9;
            period = "PM";
        }
        else if (militaryHours == 22)
        {
            hours = 10;
            period = "PM";
        }
        else if (militaryHours == 23)
        {
            hours = 11;
            period = "PM";
        }
        else
        {
            Console.WriteLine("Invalid");
            return;
        }
        // When the minutes value is a single digit
        // We add a leading zero to ensure the minutes are always displayed as two digits
        // To correct the time format (e.g, "2:05PM" instead of "3:5PM")
        if (minutes < 10)
        {
            Console.WriteLine(hours + ":0" + minutes + " " + period);  
        }
        else
        {
            Console.WriteLine(hours + ":" + minutes + " " + period);
        }
    }
}
