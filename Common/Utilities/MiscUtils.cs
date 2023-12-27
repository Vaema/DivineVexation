using System.Collections.Generic;

namespace DVMod
{
    public static partial class DVUtils
    {
        public static void AddWithCondition<T>(this List<T> list, T type, bool condition)
        {
            if (condition)
                list.Add(type);
        }
    }
}