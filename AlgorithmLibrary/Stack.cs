using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class Stack<T>
    {
        public T[] _items;
        public int _size;
        

        public Stack()
        {
            _items = new T[1];
            _size = 0;
        }


        public void Push(T item)
        {
            if(_size == _items.Length)
            {
                Resize(_size * 2);
            }

            _items[_size++] = item;
        }


        public T Pop()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Stack empty");
            }

            var item = _items[--_size];
            //Prevent Loitering.
            _items[_size] = default(T);

            if(_size == _items.Length/4)
            {
                Resize(_items.Length / 2);
            }

            return item;
        }


        private void Resize(int size)
        {
            T[] items = new T[size];

            for(int i = 0;  i  < _size; i++)
            {
                items[i] = _items[i];
            }

            _items = items;
        }
    }
}
