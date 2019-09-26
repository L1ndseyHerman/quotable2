using System;
using System.Collections.Generic;

namespace quotable.core
{
    /// <summary>
    ///     Contains an array of 3 quotes. Users can type in the console how many quotes they want.
    ///     Numbers greater than three will still return 3 quotes.
    /// </summary>
    //  The ":" is like an "implements" in Java
    public sealed class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        //  Variables up top like Java
        private string[] theQuotes = new string[3];
        //  Need something to keep track of how many times the foreach loop runs:
        private int loopsSoFar = 0;


        //  Constructor like Java:
        public SimpleRandomQuoteProvider()
        {
            //  Hard-coding three quotes
            theQuotes[0] = "Fear of a name only increases fear of the thing itself. — Hermione Granger";
            theQuotes[1] = "It is our choices, Harry, that show what we truly are, far more than our abilities. — Albus Dumbledore";
            theQuotes[2] = "I solemnly swear I am up to no good. - Harry Potter";
        }
        /// <summary>
        ///     Returns the number of quotes requested
        /// </summary>
        /// <param name="numQuotes"></param>
        /// <returns></returns>
        public IEnumerable<string> showQuotes(long numQuotes)
        {
            foreach( var x in theQuotes )
            {
                if (loopsSoFar < numQuotes)
                {
                    Console.WriteLine(x);
                    Console.WriteLine();
                    loopsSoFar++;
                }
            }
            return theQuotes;
        }
    }

}
