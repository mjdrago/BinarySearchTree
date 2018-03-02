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

            }
        }
    }
}
