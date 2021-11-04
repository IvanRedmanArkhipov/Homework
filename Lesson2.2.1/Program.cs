using System;

namespace Lesson2._2._1
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    public interface ILinkedList
    {
        int GetCount();
        void AddNode(int value);
        void AddNodeAfter(Node node, int value);
        void AddNodePrev(Node PrevNode, int value);
        void RemoveNode(int index);
        void RemoveNode(Node node);
        Node FindNode(int searchValue);
    }
}

