using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.Utils
{
    internal static class XmlTestUtils
    {
        internal static void AssertBody(IRequest actualRequest, string expectedBody)
        {
            string actualBody;
            if(actualRequest.ContentStream != null)
            {
                actualBody = ProtocolTestUtils.GetContentStreamBody(actualRequest.ContentStream);
                Assert.AreEqual(expectedBody,actualBody);
            }
            else 
            {
                actualBody = Encoding.UTF8.GetString(actualRequest.Content);
                XDocument actualDoc = XDocument.Parse(actualBody);
                XDocument expectedDoc = XDocument.Parse(expectedBody);
                Assert.IsTrue(AreDocumentsEqual(expectedDoc, actualDoc));
            }
        }

        internal static bool AreDocumentsEqual(XDocument expectedDoc, XDocument actualDoc)
        {
            return AreElementsEqual(expectedDoc.Root,actualDoc.Root);
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
