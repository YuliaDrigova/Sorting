using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < 100000; i++ )
            {
                list.Add(rand.Next(-500,500));
            }
            
            List<ISorting> sortings = new List<ISorting>();
            HeapSort heapSort = new HeapSort();
            sortings.Add(heapSort);
            CoctailSort coctailSort = new CoctailSort();
            sortings.Add(coctailSort);
            ShellSort shellSort = new ShellSort();
            sortings.Add(shellSort);

            string[] name = new string[] { "heapsort", "coctailsort", "shellsort" };
            int num = 0;
            foreach (ISorting i in sortings)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                i.Sort<List<int>, int>(list);
                stopWatch.Stop();
                Console.WriteLine("Time of {0} sort = {1}", name[num], stopWatch.Elapsed);
                num++;
            }

            Console.ReadKey();
        }
    }
}
