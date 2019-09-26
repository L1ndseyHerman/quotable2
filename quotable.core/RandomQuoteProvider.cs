using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    ///     The interface for both classes. 
    /// </summary>
    public interface RandomQuoteProvider
    {
        //  IEnumerable means there will be a collection (array) with a for-each loop
        IEnumerable<string> showQuotes(long numQuotes);
    }
}
