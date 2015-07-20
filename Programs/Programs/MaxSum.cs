using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /// <summary>
    /// http://www.interviewbit.com/courses/programming/topics/arrays/problems/maxsum/
    /// </summary>
    public class MaxSum
    {
        public static int Run(int[] array)
        {
            int size = array.Length;
            if (size == 1)
            {
                return array[0];
            }

            int[][] sum = new int[size][];
            int maxSum = Int32.MinValue;
            for (int i = 0; i < size; ++i)
            {
                sum[i] = new int[size];
                for (int j = i; j < size; ++j)
                {
                    if (i == j)
                    {
                        sum[i][j] = array[i];
                        if (sum[i][j] > maxSum)
                        {
                            maxSum = sum[i][j];
                        }
                        continue;
                    }
                    sum[i][j] = sum[i][j - 1] + array[j];
                    if (sum[i][j] > maxSum)
                    {
                        maxSum = sum[i][j];
                    }
                }
            }

            return maxSum;
        }
    }
}
