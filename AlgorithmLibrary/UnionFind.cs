using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class UnionFind
    {
        private readonly int _capacity;
        private int[] _nodes;

        /// <summary>
        /// Constrcutor
        /// </summary>
        /// <param name="capacity"></param>
        public UnionFind(int capacity)
        {
            _capacity = capacity;
            _nodes = new int[_capacity];

            for(int i = 0; i < _capacity; i++)
            {
                _nodes[i] = i;
            }
        }

        /// <summary>
        /// Checks if these nodes are connected.
        /// Constant time
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return _nodes[p] == _nodes[q];
        }

        /// <summary>
        /// Connects node P to node Q (p => q)
        /// Each union o(n). 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            if(p >= _capacity)
            {
                throw new Exception("Invalid Node");
            }


            if (q >= _capacity)
            {
                throw new Exception("Invalid Node");
            }

            int pValue = _nodes[p];
            int qValue = _nodes[q];
            
            //Already Connected return.
            if (Connected(p,q))
            {
                return;
            }           

            for(int i = 0; i < _nodes.Length; i++)
            {
                if(_nodes[i] == pValue)
                {
                    _nodes[i] = qValue;
                }
            }
        }


        

    }
}
