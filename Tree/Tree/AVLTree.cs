using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class AVLTree
    {
        public class Node
        {
           public int value;
           public int height;
           public Node left;
           public Node right;

            public Node(int value)
            {
                this.value = value;
                height = 0;
                left = right = null;
            }
        }

        Node root;

        public void Add(int value)
        {
           root = Add(root, value);
                      
        }

        private Node Add(Node root , int value)
        {
            if (root == null) return new Node(value);

            if (value < root.value)
                root.left = Add(root.left, value);
            else
                root.right = Add(root.right, value);

            root.height = Math.Max(height(root.left), height(root.right)) + 1;


            return balance(root); 
        }

        private Node balance(Node root)
        {
            if (IsLeftHeavy(root))
            {
                if (BalanceFactor(root.left) < 0)
                {
                   root.left = RotateLeft(root.left);
                    return RotateRight(root);
                }
            }
            else if (IsRightHeavy(root))
            {
                if (BalanceFactor(root.right) > 0)
                {
                   root.right = RotateRight(root.right);
                    return RotateLeft(root);
                }
            }
            return root;
        }

        private Node RotateLeft(Node root)
        {
            var newRoot = root.right;
            root.right = newRoot.left;
            newRoot.left = root;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private Node RotateRight(Node root)
        {
            var newRoot = root.left;
            root.left = newRoot.right;
            newRoot.right = root;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private void SetHeight(Node root)
        {
            root.height = Math.Max(height(root.left), height(root.right)) + 1;
        }

        private bool IsLeftHeavy(Node root)
        {
            return BalanceFactor(root) > 1;
        }

        private bool IsRightHeavy(Node root)
        {
            return BalanceFactor(root) < -1;
        }

        private int BalanceFactor(Node root)
        {
            return (root == null) ? 0 : height(root.left) - height(root.right);
        }

        private int height(Node node)
        {
            return (node == null) ? -1 : node.height;
        }

    }
}
