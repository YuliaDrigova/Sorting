using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class ShellSort:ISorting
    {

        public IEnumerable<K> Sort<T, K>(T collection)
            where T : IEnumerable<K>
            where K : IComparable<K>
        {
            var list = collection.ToList<K>();

            int step = list.Count / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < list.Count; i++)
                {
                    K value = list[i];
                    for (j = i - step; (j >= 0) && (list[j].CompareTo(value)) == 1; j -= step)
                        list[j + step] = list[j];
                    list[j + step] = value;
                }
                step /= 2;
            }
            return list.AsEnumerable<K>();
        }
    }
}
