using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //// FindNthMagicNumber
            //TestFindNthMagicNumber();

            //// FindNotRepeatedNumber
            //TestFindNotRepeatedNumber();

            //// FindOnlyOnceRepeatedNumberAllOthersRepeatedThrice
            //TestFindOnlyOnceRepeatedNumberAllOthersRepeatedThrice();

            // CountBSTSubtreesLyingInaGivenRange
            TestCountBSTSubtreesLyingInaGivenRange();
        }

        private static void TestFindNthMagicNumber()
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("{0} th magic number is: {1}", i, FindNthMagicNumber.findNthMagicNumber(i));
            }
        }

        private static void TestFindNotRepeatedNumber()
        {
            Console.WriteLine(FindNotRepeatedNumber.NumberNotRepeated(new int[] { 1, 3, 4, 3, 2, 4, 1 }));   // 2 is expected
            Console.WriteLine(FindNotRepeatedNumber.NumberNotRepeated(new int[] { 1, 3, 4, 3, 4, 1, 15, 45, 53, 124, 45, 53, 124 })); // 15 expected
        }

        private static void TestFindOnlyOnceRepeatedNumberAllOthersRepeatedThrice()
        {
            Console.WriteLine(FindOnlyOnceRepeatedNumberAllOthersRepeatedThrice.Find(new int[] { 1, 3, 4, 1, 3, 4, 1, 3, 4, 2, 11, 4, 4, 2, 2, 4 }));   // 11 is expected            
        }

        private static void TestCountBSTSubtreesLyingInaGivenRange()
        {
            Console.WriteLine(CountBSTSubtreesLyingInaGivenRange.Run(new BinarySearchTree(new int[] { 10, 5, 1, 50, 40, 100 }), 5, 45));
            Console.WriteLine(CountBSTSubtreesLyingInaGivenRange.Run(new BinarySearchTree(new int[] { 10, 5, 1, 50, 40, 100 }), 1, 45));
        }
    }
}
