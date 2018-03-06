using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        private Node root;

        public void Add(int value)
        {
            Node nodeToAdd = new Node(value);

            if (root == null)
            {
                root = nodeToAdd;
            }
            else
            {
                Node currentNode = root;
                while (currentNode.Right != null || currentNode.Left != null)
                {
                    if (currentNode.Value == value)
                    {
                        break;
                    }
                    else
                    {
                        Node nextNode = CheckRightOrLeft(value, currentNode);
                        if (nextNode!=null)
                        {
                            currentNode = nextNode;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (value > currentNode.Value)
                {
                    currentNode.Right = nodeToAdd;
                }
                else if (value < currentNode.Value)
                {
                    currentNode.Left = nodeToAdd;
                }
                
            }
        }

        private Node CheckRightOrLeft(int value, Node currentNode)
        {
            if (value > currentNode.Value )
            {
                return currentNode.Right;
            }
            else
            {
                return currentNode.Left;
            }
        }
    }
}
