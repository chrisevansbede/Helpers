using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Examples;

namespace Helpers
{
    public class Program
    {
        private static void Main()
        {
            var retryExample = new RetryExample();
            var result = retryExample.Execute();
            Console.WriteLine(result.Success
                ? $"Succeeded in {result.Tries} attempts."
                : $"Failed, tried {result.Tries} times.");
            Console.ReadLine();
        }
    }
}
