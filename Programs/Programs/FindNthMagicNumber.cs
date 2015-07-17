using System;

namespace Programs
{
    /**
     * Soure: http://www.geeksforgeeks.org/find-nth-magic-number/
     * 
     * Find n’th Magic Number
     * A magic number is defined as a number which can be expressed as a 
     * power of 5 or sum of unique powers of 5. 
     * First few magic numbers are 5, 25, 30(5 + 25), 125, 130(125 + 5), ….
     * Write a function to find the n’th Magic number.
     **/

    public class FindNthMagicNumber
    {
        /// <summary>
        /// Given n find the nthe magic number. See the class for problem statement
        /// </summary>
        /// <param name="n">Nth number</param>
        /// <returns></returns>
        public static int findNthMagicNumber(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            int pow = 1;
            int nThMagicNumber = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    try
                    {
                        nThMagicNumber = checked(nThMagicNumber + (int)Math.Pow(5, pow));
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Overflow caught");
                    }
                }
                ++pow;
                n = n >> 1;
            }
            return nThMagicNumber;
        }
    }
}
