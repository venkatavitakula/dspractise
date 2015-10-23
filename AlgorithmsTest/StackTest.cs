using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmLibrary;

namespace AlgorithmsTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void Stack_SuccessTests()
        {
            var st = new Stack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            Assert.AreEqual(5, st.Pop());
            Assert.AreEqual(4, st.Pop());
            Assert.AreEqual(3, st.Pop());
            Assert.AreEqual(2, st.Pop());
            Assert.AreEqual(1, st.Pop());
        }



        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StackThrowsException_WhenPopOnEmpty()
        {
            var st = new Stack<int>();
            st.Push(1);
            var item = st.Pop();
            st.Pop();           
        }
    }
}
