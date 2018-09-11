using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Examples;

namespace Helpers
{
    public static class Program
    {
        private static void Main()
        {
            new RetryExample().Execute();
            new MapperExample().Execute();
            
            Console.ReadLine();
        }
    }
}
