using System;
using DataStructures;

namespace Programs
{
    /// <summary>
    /// http://www.geeksforgeeks.org/count-bst-subtrees-that-lie-in-given-range/
    /// Given a Binary Search Tree (BST) of integer values and a range [low, high], 
    /// return count of nodes where all the nodes under that node (or subtree rooted with that node) lie in the given range.
    /// </summary>
    public class CountBSTSubtreesLyingInaGivenRange
    {
        public static int Run(BinarySearchTree bst, int low, int high)
        {
            if (bst == null || bst.root == null)
            {
                return 0;
            }

            return IsSubTreeRange(bst.root, low, high).Item1;
        }

        private static Tuple<int, bool> IsSubTreeRange(BSTNode node, int low, int high)
        {
            if (node == null)
            {
                return new Tuple<int, bool>(0, true);
            }
            else
            {
                var left = IsSubTreeRange(node.left, low, high);
                var right = IsSubTreeRange(node.right, low, high);
                if (left.Item2 && right.Item2 && node.value >= low && node.value <= high)
                {
                    return new Tuple<int, bool>(left.Item1 + right.Item1 + 1, true);
                }
                else
                {
                    return new Tuple<int, bool>(left.Item1 + right.Item1, false);
                }

            }
        }
    }
}
