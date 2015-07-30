using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /// <summary>
    /// http://www.geeksforgeeks.org/find-the-element-that-appears-once-in-a-sorted-array/
    /// </summary>
    public class ElementAppearingOnceInASortedArray
    {
        private static int[] elements = null;
        public static int GetSingleElement(int[] array)
        {
            elements = array;
            return GetNonRepeatedElement(0, array.Length - 1);
        }

        private static int GetNonRepeatedElement(int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            if (left == right)
            {
                return elements[left];
            }

            var mid = (left + right) / 2;
            if (mid % 2 == 0)
            {
                if (mid + 1 < elements.Length && elements[mid] != elements[mid + 1])
                {
                    return GetNonRepeatedElement(left, mid);
                }
                else
                {
                    return GetNonRepeatedElement(mid + 2, right);
                }
            }
            else
            {
                if (mid - 1 >= 0 && elements[mid - 1] == elements[mid])
                {
                    return GetNonRepeatedElement(mid + 1, right);
                }
                else
                {
                    return GetNonRepeatedElement(left, mid - 1);
                }
            }
        }
    }
}
