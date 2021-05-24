
namespace ProcessKiller.Core
{
    using System.Collections.Generic;

    public static class StringExtensions
    {
        public static string Join<T>(this IEnumerable<T> values, string separator)
        {
            return string.Join(separator, values);
        }
    }
}
