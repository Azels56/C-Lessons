using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Uses Escape Sequence: "\" - Used to include double quotes within the string.
        Console.WriteLine("Strings should be enclosed in quotation marks like so \"this is a string\"");
        // Uses Escape Sequence: "\" - Used to include a backslash in the path. Inside of its C:\Windows\System32
        Console.WriteLine("You should not delete C:\\Windows\\System32");
        // Uses Escape Sequence: \t - Tab, \n - End
        Console.WriteLine("Hello \t\n\t Classmates!"); 
    }
}
