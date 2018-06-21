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
            retryExample.Execute();
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
