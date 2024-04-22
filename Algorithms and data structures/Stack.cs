using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    internal class Stack<T>
    {
        private List<T> stack;
        public Stack() { 
            stack = new List<T> ();
        }

        public void push(T item)
        {
            stack.Add(item);
        }

        public T pop()
        {
            var item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            return item;
        }

        public int size()
        {
            return stack.Count;
        }
    }
}
