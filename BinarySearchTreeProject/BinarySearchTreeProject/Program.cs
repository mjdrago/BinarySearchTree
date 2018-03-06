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
            test.Add(25);
            test.Add(2);
            test.Add(28);
            test.Add(35);
            test.Add(1);
            test.Add(5);
            test.Add(16);
            test.Add(95);
            test.Add(80);
            test.Add(65);
            test.Add(30);
            test.Add(20);
            test.Add(17);
            test.Add(12);
            test.Add(4);
            Console.WriteLine(test.Search(25));
            Console.WriteLine(test.Search(80));
            Console.WriteLine(test.Search(16));
            Console.WriteLine(test.Search(30));
            Console.WriteLine(test.Search(98));
            Console.WriteLine(test.Search(17));
            Console.WriteLine(test.Search(4));
            Console.WriteLine(test.Search(62));
            Console.ReadKey();
        }
    }
}
