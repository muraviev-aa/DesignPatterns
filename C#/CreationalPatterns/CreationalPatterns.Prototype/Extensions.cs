using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns.Prototype
{
    public static class Extensions
    {
        public static string GetString<K, V>(this IDictionary<K, V> namesAndNums)
        {
            var items = from kvp in namesAndNums
                        select kvp.Key + ":" + kvp.Value;
            return "{" + string.Join(", ", items) + "}";
        }
    }
}
