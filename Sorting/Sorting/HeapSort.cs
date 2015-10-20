using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class HeapSort:ISorting
    {
        public IEnumerable<K> Sort<T, K>(T collection)
            where T : IEnumerable<K>
            where K : IComparable<K>
        {
            var list = collection.ToList<K>();

            int i;
            K temp;
            for (i = list.Count / 2 - 1; i >= 0; i--)
            {
                shiftDown(list, i, list.Count);
            }

            for (i = list.Count - 1; i >= 1; i--)
            {
                temp = list[0];
                list[0] = list[i];
                list[i] = temp;
                shiftDown(list, 0, i);
            }
                
            return list.AsEnumerable<K>();
        }

        private void shiftDown<K>(List<K> list, int i, int j)
            where K: IComparable<K>
        {
            bool done = false;
            int maxChild;
            K temp;

            while ((i * 2 + 1 < j) && (!done))
            {
                if (i * 2 + 1 == j - 1)
                    maxChild = i * 2 + 1;
                else if (list[i * 2 + 1].CompareTo(list[i * 2 + 2]) == 1)
                    maxChild = i * 2 + 1;
                else
                    maxChild = i * 2 + 2;

                if (list[i].CompareTo(list[maxChild]) == -1)
                {
                    temp = list[i];
                    list[i] = list[maxChild];
                    list[maxChild] = temp;
                    i = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }
    }
}
