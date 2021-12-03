using System;

namespace lesson2._4._2
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }
    class Program
    {
        public static void PreOrderTravers<T>(Node<T> root, string space = "")
        {
            if (root != null)
            {
                PreOrderTravers(root.Left, space + "\t");
                Console.WriteLine($"{space}{root.Data}");
                PreOrderTravers(root.Right, space + "\t");
            }
        }
        private static Random rnd = new();
        public static Node<int> Tree(int n)
        {
            Node<int> newNode = null;
            if (n == 0)
                return null;
            else
            {
                var nl = n / 2;
                var nr = n - nl - 1;
                newNode = new Node<int>();
                newNode.Data = rnd.Next();
                newNode.Left = Tree(nl);
                newNode.Right = Tree(nr);
            }
            return newNode;
        }
        static void Main(string[] args)
        {
            var Head = Tree(7);
            PreOrderTravers(Head);
        }
    }
}
