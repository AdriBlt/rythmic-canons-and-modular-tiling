using System;
using System.Collections.Generic;
using System.Text;

namespace RhythmicCanonsAndModularTiling.utils
{
    static class CollectionExtensions
    {
        public static T GetOrDefault<T>(this List<T> list, int index)
        {
            return index < list.Count ? list[index] : default(T);
        }
    }
}
