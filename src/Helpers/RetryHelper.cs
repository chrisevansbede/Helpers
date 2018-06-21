using System;
using System.Threading;
using System.Threading.Tasks;

namespace Helpers.Helpers
{
    public class RetryHelper
    {
        public static RetryResult DoUntil<T>(Func<T> action, Func<T, bool> predicate, int maxTries = 10, int waitTime = 1000)
        {
            for (int tryCount = 1; tryCount <= maxTries; tryCount++)
            {
                var result = action();
                if (predicate(result))
                {
                    return new RetryResult
                    {
                        Success = true,
                        Tries = tryCount
                    };
                }
                Thread.Sleep(waitTime);
            }

            return new RetryResult
            {
                Success = false,
                Tries = maxTries
            };
        }

        public static async Task<RetryResult> DoUntilAsync<T>(Func<T> action, Func<T, bool> predicate, int maxTries = 10, int waitTime = 1000)
            => await Task.Run(() => DoUntil(action, predicate, maxTries, waitTime));
    }

    public class RetryResult
    {
        public bool Success { get; set; }
        public int Tries { get; set; }
    }
}
