using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++) list.Add(Int32.Parse(Console.ReadLine()));

            list = Sort(list);
            Output(list);
            Console.ReadLine();
        }
        static List<int> Sort(List<int> list)
        {
            for(int j = 1; j < list.Count; j++)
            {
                int key = list[j];
                int i = j - 1;
                while(i >= 0 && list[i] > key)
                {
                    list[i + 1] = list[i];
                    i--;
                }
                list[i + 1] = key;
            }
            return list;
        }
        static void Output(List<int> list)
        {
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
