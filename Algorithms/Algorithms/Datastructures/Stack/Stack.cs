using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Datastructures
{
    public class Stack
    {
        private ArrayList arrayList;
        private int top = -1;

        public Stack()
        {
            arrayList = new ArrayList();
        }

        public void Push(int value)
        {
            arrayList.Insert(++top,value);
        }

        public void Pop()
        {
            arrayList.RemoveAt(top--);
        }

        public int Peek()
        {
           return (int)arrayList[top];
        }
    }
}
