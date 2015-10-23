using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class QueueUsingLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        private Node first = null;
        private Node last = null;

        public void Enqueue(T data)
        {
            Node node = new Node();
            node.Data = data;

            if(IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.Next = node;
                last = node;
            }           
        }


        //public T Dequeue()
        //{
        //    if(IsEmpty())
        //    {
        //        throw
        //    }
        //}

        public bool IsEmpty()
        {
            return first == null;
        }

    }
}
