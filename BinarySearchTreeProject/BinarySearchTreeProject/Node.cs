using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Node
    {
        private int value;
        private Node right;
        private Node left;

        public Node(int data)
        {
            value = data;
        }

        public int Value
        {
            get
            {
                return value;
            }
        }
        public Node Right
        {
            get
            {
                return right;
            }
            set
            {
                if (right == null)
                {
                    right = value;
                }
            }
        }
        public Node Left
        {
            get
            {
                return left;
            }
            set
            {
                if (left == null)
                {
                    left = value;
                }
            }
        }
    }
}
