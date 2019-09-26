using quotable.core;
using System;

namespace quotable.console
{
    /// <summary>
    ///     This program prints quotes to the console 2 ways: 
    ///         1: Takes in a long from the user and prints the quotes from the SimpleRandomQuoteProvider class, then
    ///         2: Takes the quotes in this method and prints them out in the DefaultRandomQuoteGenerator class.
    ///     Also, the excessive comments are more to remind myself what I was doing than for someone who knows C#.
    /// </summary>
    class Program
    {

        //  For DefaultRandomQuoteGenerator, it seems stuff above the main method needs to say "static", same as Java
        private static string[] theQuotes = new string[3] {"Fear of a name only increases fear of the thing itself. — Hermione Granger",
            "It is our choices, Harry, that show what we truly are, far more than our abilities. — Albus Dumbledore",
        "I solemnly swear I am up to no good. - Harry Potter"};


        static void Main(string[] args)
        {
            SimpleRandomQuoteProvider threeQuotes = new SimpleRandomQuoteProvider();
            Console.WriteLine("Enter a number of quotes to show.");
            Console.WriteLine();
            //  Quickly googled how to cast string to long, it will crash if the input isn't a number though.
            long N = long.Parse(Console.ReadLine());
            threeQuotes.showQuotes(N);


            //  Now time for DefaultRandomQuoteGenerator:
            Console.WriteLine("     Now using DefaultRandomQuoteGenerator, printing all 3 quotes:");
            Console.WriteLine();
            DefaultRandomQuoteGenerator someName = new DefaultRandomQuoteGenerator(theQuotes);
            Console.ReadLine();
        }
    }
}
