using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmLibrary;

namespace AlgorithmsTest
{
    [TestClass]
    public class UnionFindTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var uf = new UnionFind(10);

            uf.Union(4, 3);
            uf.Union(3, 8);
            uf.Union(6, 5);            
            uf.Union(9, 4);
            uf.Union(2, 1);
            uf.Union(8, 9);
            uf.Union(5, 0);
            uf.Union(7, 2);
            uf.Union(6, 1);

        }
    }
}
