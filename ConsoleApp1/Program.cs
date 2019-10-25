using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindThirdElementFromEnd();

            //DictionaryExample();


            var lines = File.ReadLines(@"c:\fisier.txt");

            int sum = 0;
            foreach (var line in lines)
            {
                //parse

            }

            File.AppendAllText(@"c:\fisier.txt", "\\n" + sum.ToString());

            string s = "ab";

            s += "c";

            s += "d";

            StringBuilder sb = new StringBuilder();

            sb.Append("ab");
            sb.Append("c");
            sb.Append("d");

            Console.WriteLine(sb.ToString());


            int i = 1;
            var istring = i.ToString();

            int[] arr = new[] {1, 2, 5, 7};
            string s3 = arr.ToString();

            List<string> list = new List<string>();
            list.Add("ab");
            list.Add("bc");

            string s4 = list.ToString();

            Console.WriteLine();

            string s5 = "abcd";

            var chars = s5.ToCharArray();

            LinkedList<int> l = new LinkedList<int>();
            int[] l11 = l.ToArray();
            

        }

        static void RotateArrByAPivot(int[] arr, int nr)
        {
            int[] newArr = new int[arr.Length];
            int i;
            int j = 0;
            for (i = nr + 1; i < arr.Length; i++)
            {
                newArr[j] = arr[i];
                j++;
            }
            for (int k = 0; k < nr; k++)
            {
                if (k == 0)
                {
                    newArr[j] = arr[nr];
                    j++;
                }
                newArr[j] = arr[k];
                j++;
            }
            PrintArrays(newArr);
        }
        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
        }

        private static void DictionaryExample()
        {
            string s = "Ana are mere mere. Ana are pere";

            char[] separatori = new[] {' ', '.', '!'};

            string[] cuvinte = s.Split(separatori, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var cuvant in cuvinte)
            {
                if (dict.ContainsKey(cuvant))
                {
                    dict[cuvant]++;
                }
                else
                {
                    dict.Add(cuvant, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine($"{pair.Key} apare de {pair.Value}");

                //Console.WriteLine(pair.Key + " apare de " + pair.Value);

                //Console.WriteLine("{0} apare de {1}", pair.Key, pair.Value);
            }
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
