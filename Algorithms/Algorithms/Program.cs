using Algorithms.Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Begin---");

            var linkedList = new LinkedList();

            for (int i = 0; i < 10; i++)
            {
                linkedList.Append(i);
                if (i % 2 == 0)
                {
                    linkedList.Delete(i);
                }
            }

            linkedList.InsertBegin(10);
            linkedList.InsertEnd(-1);

            var current = linkedList.Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

            Console.WriteLine("---END---");
            Console.ReadLine();
        }
    }
}
