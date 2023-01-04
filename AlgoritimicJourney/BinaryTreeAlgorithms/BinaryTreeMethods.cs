using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.BinaryTreeAlgorithms
{
    public class BinaryTreeMethods
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if(root == null)
                {
                    root = new Node();
                    root.Data = value;
                }else
                {
                    if(value < root.Data)
                    {
                        Insert(root.Left, value);
                    }else if (value > root.Data)
                    {
                        Insert(root.Right, value);
                    }
                }
                return root;
            }

            public void PreOrderTraversal(Node root)
            {
                if (root == null) return;
                Console.WriteLine(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }

            public void InOrderTraversal(Node root)
            {
                if (root == null) return;
                InOrderTraversal(root.Left);
                Console.WriteLine(root.Data + " ");
                InOrderTraversal(root.Right);
            }

            public void PostOrderTraversal(Node root)
            {
                if (root == null) return;
                PostOrderTraversal(root.Left);
                Console.WriteLine(root.Data + " ");
                PostOrderTraversal(root.Right);
            }


        }
    }
}
