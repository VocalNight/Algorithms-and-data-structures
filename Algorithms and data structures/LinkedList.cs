using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    public class LinkedList
    {
        public LinkedListNode FirstNode { get; set; }

        public LinkedListNode FindNode(int index)
        {
            LinkedListNode node = FirstNode;
            var currentIndex = 0;

            while(currentIndex < index)
            {
                node = node.Next;
                currentIndex++;

                if (node == null)
                {
                    return null;
                }
            }

            if (currentIndex == index)
            {
                return node;
            }

            return null;
        }

        public int? Search(int value)
        {
            LinkedListNode node = FirstNode;
            var currentIndex = 0;

            while (node.Next != null)
            {
                if (node.Value == value)
                {
                    return node.Value;
                }
            }

            return null;
        }

        public void Add(int index, int value)
        {
            LinkedListNode node = FirstNode;
            var currentIndex = 0;
            var newNode = new LinkedListNode();

            if (index == 0)
            {
                newNode.Value = value;
                newNode.Next = FirstNode;
                FirstNode = newNode;
                return;
            }

            while (currentIndex < index - 1)
            {
                node = node.Next;
                currentIndex++;
            }

            if (currentIndex == index - 1)
            {
                newNode.Value = value;
                newNode.Next = node.Next;

                node.Next = newNode;
            }
        }

        public void Remove(int index)
        {
            LinkedListNode node = FirstNode;
            var currentIndex = 0;

            if (index == 0)
            {
                FirstNode = node.Next;
            }

            while (currentIndex < index - 1)
            {
                if (node.Next == null)
                {
                    return;
                }

                node = node.Next;
                currentIndex++;
            }

            if (currentIndex == index - 1)
            {
                var currentNode = node;
                var deletedNode = node.Next;

                currentNode.Next = deletedNode.Next;
            }
        }
    }
}
