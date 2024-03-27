/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

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
        public static void AssertBody(IRequest actualRequest, string expectedBody)
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
                //if it's a raw string, just compare raw string values
                if (!actualBody.StartsWith("<"))
                {
                    Assert.AreEqual(expectedBody,actualBody);
                    return;
                }
                XDocument actualDoc = XDocument.Parse(actualBody);
                XDocument expectedDoc = XDocument.Parse(expectedBody);
                Assert.IsTrue(AreDocumentsEqual(expectedDoc, actualDoc));
            }
        }

        private static bool AreDocumentsEqual(XDocument expectedDoc, XDocument actualDoc)
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
