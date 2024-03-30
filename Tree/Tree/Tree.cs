using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Tree
    {
        Node root;
        public class Node
        {
           public int data;
           public Node left;
           public Node right;
               
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }

            public override string ToString()
            {
                return "Node = " + data;
            }
        }

        public void Add(int data)
        {            
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            Node current = root;
            while (true)
            {
                if(data < current.data)
                {
                    if (current.left == null)
                    {
                        current.left = node;
                        break;
                    }
                    current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = node;
                        break;
                    }
                    current = current.right;
                }
            }
     
        }

        public bool Find(int data)
        {
            Node current = root;
            while (current != null)
            {
                if (data == current.data) return true;
                else if (data < current.data)
                {                    
                    current = current.left;
                }
                else
                {                    
                    current = current.right;
                }
            }
            return false;
        }

        public int Height()
        {
           return Height(root);
        }

        private int Height(Node root)
        {
            if (root == null) return -1;
            return 1 + Math.Max(Height(root.left), Height(root.right));
        }

        public int Min()
        {
            return Min(root);
        }

        // min in BST
        private int Min(Node root)
        {
            int min = root.data;
            while (root.left != null)
            {
                min = root.left.data;
                root = root.left;

            }
            return min;

            //int min = root.data;
            //if (root.left == null)
            //{
            //    return min;
            //}
            //min = Min(root.left);
            //return min;
        }

        // min in Binary Tree
        private int MinValue(Node root)
        {
            if (root == null) return -1;

            int left = MinValue(root.left);
            int right = MinValue(root.right);

            return Math.Min(Math.Min(left, right) , root.data);

        }

        public bool Equal(Tree tree)
        {
            return Equal(root, tree.root);
        }

        private bool Equal(Node first , Node second)
        {
            if (first == null && second == null) return true;

            if (first != null && second != null)
                return first.data == second.data
                    && Equal(first.left, second.left)
                    && Equal(first.right, second.right);

            return false;
        }

        public bool IsBST()
        {
            return IsBST(root, int.MinValue, int.MaxValue);        
        }

        public void SwapRoot()
        {
            var temp = root.left;
            root.left = root.right;
            root.right = temp;
        }

        public void PrintNodesAtDistance(int distance)
        {
            PrintNodesAtDistance(root, distance);
        }

        private void PrintNodesAtDistance(Node root, int distance)
        {
            if (root == null) return;

            if (distance == 0) Console.WriteLine(root.data);
            PrintNodesAtDistance(root.left, distance - 1);
            PrintNodesAtDistance(root.right, distance - 1);
        }

        private bool IsBST(Node root , int min , int max)
        {
            if (root == null) return true;

            if (root.data < min || root.data > max) return false;

            return IsBST(root.left, min, root.data - 1)
                && IsBST(root.right, root.data + 1, max);
        }
        public void InOrder()
        {
            InOrder(root);
        }

        private void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.data);
                InOrder(root.right);
            }
           
        }

        private void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                InOrder(root.left);               
                InOrder(root.right);
            }

        }

        private void PostOrder(Node root)
        {
            if (root != null)
            {               
                InOrder(root.left);
                InOrder(root.right);
                Console.WriteLine(root.data);
            }

        }

        public void LevelOrder()
        {
            for (int i = 0; i <= Height(); i++)
            {
                PrintNodesAtDistance(i);
            }
        }
    }
}