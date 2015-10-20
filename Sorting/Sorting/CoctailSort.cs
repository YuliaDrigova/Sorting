using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class CoctailSort : ISorting
    {
        public IEnumerable<K> Sort<T, K>(T collection)
            where T : IEnumerable<K>
            where K : IComparable<K>
        {
            var list = collection.ToList<K>();
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) == 1)
                    {
                        K temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
                swapped = false;
                for (int i = list.Count - 2; i >= 0; i--)
                {
                    if (list[i].CompareTo(list[i + 1]) == 1)
                    {
                        K temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);

            return list.AsEnumerable<K>();
        }
    }
}
