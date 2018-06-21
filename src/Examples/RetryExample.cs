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
        public RetryResult Execute()
        {
            var i = 0;
            return RetryHelper.DoUntil(
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
        }
    }
}
