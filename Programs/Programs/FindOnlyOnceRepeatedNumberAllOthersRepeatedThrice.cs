namespace Programs
{
    /// <summary>
    /// Source: http://www.careercup.com/question?id=7902674
    /// A array of numbers is given with all the numbers repeated thrice except one
    /// Find that unique number
    /// </summary>
    public class FindOnlyOnceRepeatedNumberAllOthersRepeatedThrice
    {
        /// <summary>
        /// All numbers repeated thrice except one, finds the unique number
        /// </summary>
        /// <param name="array">Array of numbers</param>
        public static int Find(int[] array)
        {
            int ones = 0;
            int twos = 0;
            int not_threes = 0;
            foreach (int number in array)
            {
                twos |= ones & number;
                ones ^= number;
                not_threes = ~(ones & twos);
                ones &= not_threes;
                twos &= not_threes;
            }
            return ones;
        }
    }
}
