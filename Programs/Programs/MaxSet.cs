using System;
using System.Xml;

namespace Programs
{
    /// <summary>
    /// http://www.interviewbit.com/courses/programming/topics/arrays/problems/maxset/?ref=success-next-suggestion
    /// </summary>
    public class MaxSet
    {
        public static int[] Run(int[] array)
        {
            int maxSum = -1, startIndex = -1, endIndex = -1;
            int presentSum = 0, presentStartIndex = -1, presentEndIndex = -1;
            bool reset = true;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    reset = true;
                    if ((maxSum < presentSum && presentSum != 0 && presentStartIndex != -1) || (maxSum == presentSum && (endIndex - startIndex) > (presentEndIndex - presentStartIndex)))
                    {
                        maxSum = presentSum;
                        startIndex = presentStartIndex;
                        endIndex = presentEndIndex;
                    }
                }
                else
                {
                    if (reset)
                    {
                        reset = false;
                        presentStartIndex = i;
                        presentSum = 0;
                        presentEndIndex = i;
                    }
                    presentSum += array[i];
                    presentEndIndex = i;
                }
            }

            if ((maxSum < presentSum && presentSum != 0 && presentStartIndex != -1) || (maxSum == presentSum && (endIndex - startIndex) > (presentEndIndex - presentStartIndex)))
            {
                maxSum = presentSum;
                startIndex = presentStartIndex;
                endIndex = presentEndIndex;
            }

            if (maxSum != -1 && startIndex != -1 && endIndex != -1)
            {
                int[] result = new int[endIndex - startIndex + 1];
                for (int i = startIndex; i <= endIndex; ++i)
                {
                    result[i - startIndex] = array[i];
                }
                return result;
            }
            return null;
        }
    }
}
