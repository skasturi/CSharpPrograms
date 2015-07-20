namespace DataStructures
{
    public class BinarySearchTree
    {
        public BSTNode root;

        /// <summary>
        /// Create a BinarySearchTree
        /// </summary>
        /// <param name="elements"></param>
        public BinarySearchTree(int[] elements)
        {
            foreach (int element in elements)
            {
                this.insert(element);
            }
        }

        /// <summary>
        /// Get inorder traversal of the given tree
        /// </summary>
        /// <returns>Returns a comma seperated string contains the integers</returns>
        public string getInorderTraversal()
        {
            if (root == null)
            {
                return string.Empty;
            }
            else
            {
                return getInorderTraversal(root);
            }
        }

        private string getInorderTraversal(BSTNode node)
        {
            if (node == null)
            {
                return string.Empty;
            }
            else
            {
                return getInorderTraversal(node.left) + " " + node.value + " " + getInorderTraversal(node.right);
            }
        }

        /// <summary>
        /// Insert into Binary search tree
        /// </summary>
        /// <param name="element">Element</param>
        public void insert(int element)
        {
            if (root == null)
            {
                root = new BSTNode();
                root.value = element;
            }
            else
            {
                insert(element, root);
            }
        }

        /// <summary>
        /// Recursive method to handle insertion
        /// </summary>
        /// <param name="element">Element</param>
        /// <param name="present">Present node to be inserted at</param>
        private void insert(int element, BSTNode present)
        {
            if (present.value == null)
            {
                present.value = element;
            }
            else
            {
                if (element > present.value)
                {
                    if (present.right == null)
                    {
                        present.right = new BSTNode();
                    }

                    insert(element, present.right);
                }
                else if (element < present.value)
                {
                    if (present.left == null)
                    {
                        present.left = new BSTNode();
                    }
                    insert(element, present.left);
                }
            }
        }
    }
}
