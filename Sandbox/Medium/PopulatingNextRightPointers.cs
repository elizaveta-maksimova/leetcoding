namespace Sandbox
{
    //#BFS
    public class PopulatingNextRightPointers
    {
        public Node Connect(Node root)
        {
            if (root?.left == null || root.right == null)
            {
                return root;
            }

            root.left.next = root.right;

            if (root.next != null)
            {
                root.right.next = root.next.left;
            }

            Connect(root.left);
            Connect(root.right);

            return root;
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;
    }
}