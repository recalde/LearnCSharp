using System;

// Lesson 1: Using Variables and for loops
namespace LearnCSharp.Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two variables of type "string" with different values,
            // the first variable is named "greeting" and the second variable
            // is named "question", and the initial values are inside the quotes
            // Note that string literal values use "" to begin and end the value
            // so the computer knows where to begin and wheret to end.
            string greeting = "Hello Emily!";
            string question = "How are you today?";

            // Now append the two string variables together to make a new string
            // called "message" seperated by an inline string literal (inside "")
            string message = greeting + " " + question;

            // Write the message to the "Console" where you can see the values
            // printed out on the black window
            Console.WriteLine(message);

            // Declare a variable of type "int" which is an integer or whole number
            // Note that integer literal values can just follow the = assignment
            int quantity = 2;

            // Declare a variable of type "decimal" which is a decimal point number
            // Note that the literal value 1.56 needs to have the letter m following it
            // to tell the computer that this is a decimal value similar to how string variables
            // use quotation marks.
            decimal cost = 1.56m;

            // Set cost to a new value of the old value times quantity
            cost = cost * quantity;

            // Now loop from 0 to 9 in increments of 2 (note that 9 will not be hit)
            // for loop syntax is divided into 3 parts seperated by ;
            // first part initializes the looping variable
            // second part is the condition that we should continue looping
            // and the third part is the action to take at the end of each loop
            // which is simply to add 2 to the variable in this case
            for (var x = 0; x < 10; x = x + 2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
