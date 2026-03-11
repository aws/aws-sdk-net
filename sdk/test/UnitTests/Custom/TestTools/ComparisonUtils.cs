using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AWSSDK.UnitTests.TestTools
{
    public static class ComparisonUtils
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

        public static bool AreDocumentsEqual(XDocument expectedDoc, XDocument actualDoc)
        {
            return AreElementsEqual(expectedDoc.Root, actualDoc.Root);
        }
        private static bool AreElementsEqual(XElement elem1, XElement elem2)
        {
            if (elem1.Name != elem2.Name)
            {
                return false;
            }
            // Check for value equality (ignoring children values)
            bool haveSameValues = string.Equals(elem1.Value.Trim(), elem2.Value.Trim(), StringComparison.Ordinal);
            if (!haveSameValues && elem1.HasElements == false)
            {
                return false;
            }

            var children1 = elem1.Elements().OrderBy(e => e.Name.LocalName).ThenBy(e => e.Value.Trim()).ToList();
            var children2 = elem2.Elements().OrderBy(e => e.Name.LocalName).ThenBy(e => e.Value.Trim()).ToList();

            if (children1.Count != children2.Count)
            {
                return false;
            }

            for (int i = 0; i < children1.Count; i++)
            {
                if (!AreElementsEqual(children1[i], children2[i]))
                {

                    return false;
                }
            }

            return true;
        }
    }
}
