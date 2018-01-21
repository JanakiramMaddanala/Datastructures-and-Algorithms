using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Datastructures
{
    public class StackUsingArraylist
    {
        private ArrayList arrayList;
        private int top = -1;

        public StackUsingArraylist()
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
