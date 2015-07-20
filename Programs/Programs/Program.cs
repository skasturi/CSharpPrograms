using System;
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
            //TestCountBSTSubtreesLyingInaGivenRange();

            // RemoveHalfNodesInaBST
            //TestRemoveHalfNodesInaBST();

            // MaxSet
            //TestMaxSet();

            //Wave
            //TestWave();

            //MaxSum
            TestMaxSum();
        }

        private static void TestMaxSum()
        {
            Console.WriteLine(MaxSum.Run(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        private static void TestWave()
        {
            Console.WriteLine(string.Join(",", WaveArray.Run(new int[] { 1, 2, 3, 4 })));
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

        private static void TestRemoveHalfNodesInaBST()
        {
            Console.WriteLine(RemoveHalfNodesInaBST.Run(new BinarySearchTree(new int[] { 10, 5, 1, 50, 40, 100, 120, 150 })));
        }

        private static void TestMaxSet()
        {
            //Console.WriteLine(string.Join(",", MaxSet.Run(new int[] { 1, 2, 2, -7, 2, 3, 2 })));
            //Console.WriteLine(string.Join(",", MaxSet.Run(new int[] { 0, 0, -1, 0 })));
            Console.WriteLine(string.Join(",", MaxSet.Run(new int[] { 1967513926, 1540383426, -1303455736, -521595368 })));
        }
    }
}

