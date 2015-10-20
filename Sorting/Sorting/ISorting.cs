using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISorting 
    {
            IEnumerable<K> Sort<T, K>(T collection)
            where T : IEnumerable<K>
            where K : IComparable<K>;
    }
}
