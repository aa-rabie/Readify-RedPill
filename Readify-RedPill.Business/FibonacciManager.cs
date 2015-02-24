using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPill.Business
{
    public class FibonacciManager
    {
        private static ConcurrentDictionary<long, long> _cache = new ConcurrentDictionary<long, long>();

        /// <summary>
        /// calculate Fibonacci for number N
        /// </summary>
        /// <param name="n">integer value</param>
        /// <returns>Fibonacci(n)</returns>
        public static long Calculate(long n)
        {
            

            if (n == 0 || n == 1) { return n; }

            if (_cache.ContainsKey(n))
            {
                return _cache[n];
            }

            if (n < 0)
            {
                var pow = Convert.ToDouble(Math.Abs(n) + 1);
                var result = Convert.ToInt64(Math.Pow(-1, pow)) * Calculate(Math.Abs(n));
                _cache[n] = result;
                return result;
            }

            long f1 = 0, f2 = 1, f3 = f1 + f2;
            for (long index = 1; index < n; index++)
            {
                if (index > 1)
                {
                    f1 = f2;
                    f2 = f3;
                }
                f3 = f1 + f2;
            }
            _cache[n] = f3;
            return f3;
        }
    }
}
