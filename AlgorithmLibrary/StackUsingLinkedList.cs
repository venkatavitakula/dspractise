using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class StackUsingLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        private Node first = null;

        public void Push(T data)
        {
            var node = new Node();
            node.Data = data;
            node.Next = first;
            first = node;            
        }

        public T Pop()
        {
            if (first == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var data = first.Data;
            first = first.Next;

            return data;
        }
    }
}
