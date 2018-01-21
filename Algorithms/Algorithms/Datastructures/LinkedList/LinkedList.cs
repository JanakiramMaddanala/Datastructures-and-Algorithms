using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Datastructures
{
    public class LinkedList
    {
        public LinkedListNode Head { get; set; }

        private LinkedListNode current;

        public void InsertBegin(int data)
        {
            if (Head == null)
            {
                CreateHeadNode(data);
                current = Head;
            }
            else
            {
                var newNode = CreateNewNode(data);
                newNode.Next = Head;
                Head = newNode;
            }

        }

        public void InsertEnd(int data)
        {
            var newNode = CreateNewNode(data);
            current.Next = newNode;
        }

        public void InsertAfter(LinkedListNode previousNode, int data)
        {
            var newNode = CreateNewNode(data);
            newNode.Next = previousNode.Next;
            previousNode.Next = newNode;
        }

        public void Append(int data)
        {
            if (Head == null)
            {
                CreateHeadNode(data);
                current = Head;
            }
            else
            {
                var newNode = CreateNewNode(data);
                current.Next = newNode;
                current = newNode;
            }
        }

        public void Delete(int data)
        {
            LinkedListNode previousNode = null;
            LinkedListNode tempNode = Head;

            if (Head == null)
            {
                throw new Exception("Linked list is empty");
            }

            bool isHeadNodeMatches = (Head.Data == data);
            if (isHeadNodeMatches)
            {
                Head = Head.Next;
                return;
            }
            else
            {
                previousNode = Head;
                tempNode = Head.Next;
            }

            while (tempNode != null && tempNode.Data != data)
            {
                previousNode = tempNode;
                tempNode = tempNode.Next;
            }

            bool isAnyNodeMatches = (tempNode != null);
            if (!isAnyNodeMatches)
            {
                throw new Exception("Node not found");
            }

            previousNode.Next = tempNode.Next;
            current = previousNode;
        }

        private static LinkedListNode CreateNewNode(int data)
        {
            return new LinkedListNode()
            {
                Data = data,
                Next = null
            };
        }

        private void CreateHeadNode(int data)
        {
            Head = new LinkedListNode
            {
                Data = data,
                Next = null
            };
        }
    }
}
