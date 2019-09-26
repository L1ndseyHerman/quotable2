using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    ///     This class gets an array of quotes from the main method, then loops through and prints them one at a time.
    /// </summary>
    public sealed class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        public DefaultRandomQuoteGenerator(IEnumerable<string> theQuotes)
        {
            foreach (var x in theQuotes)
            {
                Console.WriteLine(x);
                Console.WriteLine();
            }
        }

        public IEnumerable<string> showQuotes(long numQuotes)
        {
            throw new NotImplementedException();
        }
    }
}
