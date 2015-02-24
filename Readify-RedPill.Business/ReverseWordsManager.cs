using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace RedPill.Business
{
    public class ReverseWordsManager
    {
        private static ConcurrentDictionary<string, string> _cache = new ConcurrentDictionary<string, string>();
        /// <summary>
        /// reverses input string
        /// </summary>
        /// <param name="s">string to be reversed</param>
        /// <returns>reversed string</returns>
        public static string Reverse(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            if(_cache.ContainsKey(s))
            {
                return _cache[s];
            }
            char[] array = s.ToCharArray();
            StringBuilder builder = new StringBuilder();
            int len = array.Length;
            for (int index = len -1; index >= 0; index--)
            {
                builder.Append(array[index]);
            }
            var result = builder.ToString();
            _cache[s] = result;
            return result;
        }
    }
}
