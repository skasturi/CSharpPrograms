using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Programs
{
    /// <summary>
    /// http://www.geeksforgeeks.org/kth-largest-element-in-bst-when-modification-to-bst-is-not-allowed/
    /// K th largest element in BST
    /// </summary>
    public class KthLargestElementInBST
    {
        private static int? KthLargestElement = null;
        private static int K;
        public static int Run(BinarySearchTree bst, int k)
        {
            if (bst.root == null || k < 1)
            {
                return -1;
            }

            KThLargest(bst.root, 0);
            if (KthLargestElement != null)
            {
                return KthLargestElement;
            }
            else
            {
                return Int32.MinValue;
            }
        }

        private static int KThLargest(BSTNode node, int yourNumber)
        {
            if (yourNumber == 0 && node != null)
            {
                KthLargestElement = node.value;
            }
        }
    }
}
