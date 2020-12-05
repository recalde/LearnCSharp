using System;

// Lesson 2: Countdown to Biden Inauguration
namespace LearnCSharp.Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a variable of type "DateTime" called "today" set 
            // to the current date and time when the code executes
            DateTime today = DateTime.Now;

            // Make another variable of type "DateTime" set to the 
            // value parsed from inside the quotation marks
            DateTime inaugurationDay = DateTime.Parse("1/20/2021 1:00PM");

            // Now if you use the subtraction math operator with two 
            // variables of "DateTime" type you get back a new variable 
            // of type "TimeSpan"
            TimeSpan span = inaugurationDay - today;

            // Span is a complex type that has "properties" such as 
            // "TotalDays" that can be used to access a decimal value
            //  of a new type called "double" - for double-precision 
            // (the total number of decimal points the computer will 
            // compute before it stops - many math operations would 
            // otherwise make the computer go into an infinite loop 
            // to calculate a repeating decimal like 1/3 = 0.33333333)
            double daysFromNow = span.TotalDays;

            // Now you can make a string variable that formats this 
            // value using a new sytax called "string interpolation" 
            // meaning you can put the names of variables inside curley 
            // braces in order to include the variable value in the string
            // Note: the [1] is just so you can keep track of the output.
            string message = $"[1] Inauguration day is {daysFromNow} days from now.";

            // Now write that message out
            Console.WriteLine(message);

            // Now combine the string interpolation into the WriteLine call
            // directly to save the need to make a variable.
            Console.WriteLine($"[2] Inauguration day is {daysFromNow} days from now.");

            // Now if you notice you might see a long decimal value like this:
            // "Inauguration day is 45.81599123857292 days from now."
            // So we can fix that using a "format string" to show it how many
            // decial places you want instead, here :0.00 always show 2 decimal places
            // even if the number rounds to a whole number like 1.00
            Console.WriteLine($"[3] Inauguration day is {daysFromNow:0.00} days from now.");

            // Now use the autocompletion on "span" to find out the other properties
            // that you can get from the "TimeSpan" type by typing . after span, and 
            // using the menu to show you what is there like "TotalDays"
            Console.WriteLine($"[4] Or {span.TotalHours:0.00} hours!!");

            // Or you can use the properties without the word "Total" which is just the 
            // whole number (rounded down)
            Console.WriteLine($"[5] in parts that is {span.Days} days {span.Hours} hours.");


        }
    }
}
