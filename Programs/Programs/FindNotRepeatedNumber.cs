using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /// <summary>
    /// Find the number that has not been repeated in the given array
    /// Note: XOR is both associative and commutative, therefore this works
    /// </summary>
    public class FindNotRepeatedNumber
    {
        /// <summary>
        /// Find the number that has not been repeated in the given array
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns></returns>
        public static int NumberNotRepeated(int[] array)
        {
            int uniqueN = 0;
            foreach (int number in array)
            {
                uniqueN ^= number;
            }
            return uniqueN;
        }
    }
}
