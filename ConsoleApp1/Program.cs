using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindThirdElementFromEnd();
        }

        private static void FindThirdElementFromEnd()
        {
            //How to find the 3rd element from the end, in a single linked, in a single pass?
            LinkedList<int> list = new LinkedList<int>();
            var node = list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);

            int contor = 0;
            while (node != null)
            {
                contor++;

                if (contor == list.Count - 2)
                {
                    break;
                }

                node = node.Next;
            }

            Console.WriteLine(node.Value);

            Console.ReadLine();
        }
    }
}
