using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree test = new BinarySearchTree();
            test.Add(5);
            test.Add(7);
            test.Add(15);
            test.Add(7);
            test.Add(2);
        }
    }
}
