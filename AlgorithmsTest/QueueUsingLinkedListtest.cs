using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmLibrary;

namespace AlgorithmsTest
{
    [TestClass]
    public class QueueUsingLinkedListtest
    {
        [TestMethod]
        public void QueueUsingLinkedList_Basic()
        {
            var q = new QueueUsingLinkedList<int>();
            q.Enqueue(1);
            var data = q.Dequeue();
            Assert.AreEqual(1, data);

            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            data = q.Dequeue();
            Assert.AreEqual(2, data);

            data = q.Dequeue();
            Assert.AreEqual(3, data);

            data = q.Dequeue();
            Assert.AreEqual(4, data);

            data = q.Dequeue();
            Assert.AreEqual(5, data);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void QueueUsingLinkedList_ThrowsException_WhenDequeingFromEmptyQueue()
        {
            var q = new QueueUsingLinkedList<int>();
            q.Dequeue();
        }
    }
}
