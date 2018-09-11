using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Helpers;

namespace Helpers.Examples
{
    public class RetryExample
    {
        public void Execute()
        {
            var i = 0;
            var retryResult = RetryHelper.DoUntil(
                waitTime: 200,
                action: () =>
                {
                    // Code to retry
                    i++;
                    Console.WriteLine(i);

                    // Response to watch
                    return i;
                },

                // Response gets passed here to assert on
                predicate: result => result > 5);
            
            Console.WriteLine(retryResult.Success
                ? $"Succeeded in {retryResult.Tries} attempts."
                : $"Failed, attempted {retryResult.Tries} times.");
        }
    }
}
