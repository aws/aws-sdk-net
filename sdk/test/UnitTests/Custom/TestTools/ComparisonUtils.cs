using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.TestTools
{
    internal static class ComparisonUtils
    {
        internal static bool CompareDictionariesOfDictionaries<TKey, TValue>(Dictionary<TKey, Dictionary<TKey, TValue>> dict1, Dictionary<TKey, Dictionary<TKey, TValue>> dict2)
        {
            if (dict1.Count != dict2.Count)
                return false;

            foreach (var key in dict1.Keys)
            {
                if (!dict2.ContainsKey(key))
                    return false;

                var innerDict1 = dict1[key];
                var innerDict2 = dict2[key];

                if (innerDict1.Count != innerDict2.Count)
                    return false;

                foreach (var innerKey in innerDict1.Keys)
                {
                    if (!innerDict2.ContainsKey(innerKey) || !innerDict1[innerKey].Equals(innerDict2[innerKey]))
                        return false;
                }
            }

            return true;
        }
    }
}
