using System;
using Tests;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length!=1)
                throw new ArgumentException();

            switch (args[0])
            {
                case "BinaryTree":
                    BinaryTrees.BinaryTreeTest("21");
                    break;
            }
        }
    }
}
