using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace RedPill.Business
{
    public class TrianglesManager
    {
        private static ConcurrentDictionary<string, TriangleType> _cache = new ConcurrentDictionary<string, TriangleType>(); 
    
        /// <summary>
        /// Triangle Type
        /// </summary>
        /// <param name="a">first side length</param>
        /// <param name="b">second side length</param>
        /// <param name="c">third side length</param>
        /// <returns>TriangleType enum value</returns>
        public static TriangleType GetType(int a, int b, int c)
        {
            
            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (a <= 0 || b <= 0 || c <= 0) 
            {
                return TriangleType.Error;
            }
            var key = GenerateCacheKey(a,b,c);
            if(_cache.ContainsKey(key))
            {
                return _cache[key];
            }
            //Placing items in an array for processing 
            int[] values = new int[3] { a, b, c };

            if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                _cache[key] = TriangleType.Equilateral;
                
            }
            else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                _cache[key] = TriangleType.Isosceles;
            }
            else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                _cache[key] = TriangleType.Scalene;
            }
            else
            {
                _cache[key] = TriangleType.Error;
            }
            return _cache[key];
        }
    
        /// <summary>
        /// generates cache string key value from triangle sides lengths variables
        /// </summary>
        /// <param name="a">first side length</param>
        /// <param name="b">second side length</param>
        /// <param name="c">third side length</param>
        /// <returns></returns>
        private static string GenerateCacheKey (int a,int b, int c)
        {
            return string.Format(@"{0}_{1}_{2}",a,b,c);
        }
    }
}
