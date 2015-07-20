using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /// <summary>
    /// http://www.interviewbit.com/courses/programming/topics/arrays/problems/wave/
    /// </summary>
    public class WaveArray
    {
        public static int[] Run(int[] array)
        {
            int arrayLength = array.Length;
            if (arrayLength == 1)
            {
                return array;
            }

            Array.Sort(array);
            for (int i = 0; i < arrayLength && i + 1 < arrayLength; i += 2)
            {
                // swap i, i+1 elements
                var temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            return array;
        }
    }
}
