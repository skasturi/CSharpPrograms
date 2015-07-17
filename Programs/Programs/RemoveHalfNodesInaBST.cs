using DataStructures;

namespace Programs
{
    /// <summary>
    /// http://www.geeksforgeeks.org/given-a-binary-tree-how-do-you-remove-all-the-half-nodes/
    /// Remove all half nodes - i.e; the ones that have only a left child or a right child but not both, or none
    /// </summary>
    public class RemoveHalfNodesInaBST
    {
        public static string Run(BinarySearchTree bst)
        {
            if (bst.root != null)
            {
                replaceHalfNodes(bst.root);
            }
            return bst.getInorderTraversal();
        }

        private static void replaceHalfNodes(BSTNode node)
        {
            if (node == null)
            {
                return;
            }

            replaceHalfNodes(node.left);
            replaceHalfNodes(node.right);

            if (IsHalfNode(node.left))
            {
                node.left = FindNonHalfNode(node.left);
            }

            if (IsHalfNode(node.right))
            {
                node.right = FindNonHalfNode(node.right);
            }

        }

        private static bool IsHalfNode(BSTNode node)
        {
            if (node == null)
            {
                return false;
            }

            if ((node.left == null && node.right != null) || (node.left != null && node.right == null))
            {
                return true;
            }

            return false;
        }

        private static BSTNode FindNonHalfNode(BSTNode node)
        {
            if (node == null)
            {
                return null;
            }

            bool isHalfNode = IsHalfNode(node);
            if (!isHalfNode)
            {
                return node;
            }
            else
            {
                return node.left == null ? FindNonHalfNode(node.right) : FindNonHalfNode(node.left);
            }
        }
    }
}
