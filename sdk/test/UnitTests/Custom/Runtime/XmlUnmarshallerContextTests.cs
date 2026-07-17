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

using System.Collections.Generic;
using System.IO;
using System.Text;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class XmlUnmarshallerContextTests
    {
        [TestMethod]
        public void StartElements_ReportExactPathAndDepth()
        {
            var byPath = CollectStartElementDepths(
                "<ListBucketResult xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">" +
                  "<Name>bucket</Name>" +
                  "<Contents><Key>1.txt</Key><Size>0</Size></Contents>" +
                "</ListBucketResult>");

            Assert.AreEqual(1, byPath["/ListBucketResult"]);
            Assert.AreEqual(2, byPath["/ListBucketResult/Name"]);
            Assert.AreEqual(2, byPath["/ListBucketResult/Contents"]);
            Assert.AreEqual(3, byPath["/ListBucketResult/Contents/Key"]);
            Assert.AreEqual(3, byPath["/ListBucketResult/Contents/Size"]);
        }

        [TestMethod]
        public void RepeatedSegmentNames_PushAndPopIndependently()
        {
            var byPath = CollectStartElementDepths(
                "<Root><nested><foo>Foo1</foo><nested><bar>Bar1</bar>" +
                "<inner><nested><bar>Bar2</bar></nested></inner></nested></nested></Root>");

            Assert.AreEqual(1, byPath["/Root"]);
            Assert.AreEqual(2, byPath["/Root/nested"]);
            Assert.AreEqual(3, byPath["/Root/nested/nested"]);
            Assert.AreEqual(4, byPath["/Root/nested/nested/inner"]);
            Assert.AreEqual(5, byPath["/Root/nested/nested/inner/nested"]);
            Assert.AreEqual(6, byPath["/Root/nested/nested/inner/nested/bar"]);
        }

        [TestMethod]
        public void IsStartOfDocument_TrueOnlyBeforeFirstRead()
        {
            using (var context = CreateContext("<R><A>v</A></R>"))
            {
                Assert.IsTrue(context.IsStartOfDocument, "IsStartOfDocument must be true before the first Read().");
                context.Read();
                Assert.IsFalse(context.IsStartOfDocument, "IsStartOfDocument must be false once reading has begun.");
            }
        }

        [TestMethod]
        public void AttributeNode_ReportsAttributePathWithoutAddingDepth()
        {
            using (var context = CreateContext("<XmlAttributesResponse test=\"v\"><foo>hi</foo></XmlAttributesResponse>"))
            {
                var attrPaths = new List<string>();
                while (context.Read())
                {
                    if (context.IsAttribute)
                    {
                        attrPaths.Add(context.CurrentPath);
                        Assert.AreEqual(1, context.CurrentDepth);
                    }
                }

                CollectionAssert.Contains(attrPaths, "/XmlAttributesResponse/@test");
            }
        }

        [TestMethod]
        public void AttributeEnumeration_DoesNotCorruptFollowingElementPaths()
        {
            var byPath = CollectStartElementDepths(
                "<Payload test=\"attributeValue\"><foo>Foo</foo><baz>Baz</baz></Payload>");

            Assert.AreEqual(1, byPath["/Payload"]);
            Assert.AreEqual(2, byPath["/Payload/foo"]);
            Assert.AreEqual(2, byPath["/Payload/baz"]);
        }

        [TestMethod]
        public void CurrentElementName_IsTopSegment_EmptyAtRootBoundaries()
        {
            using (var context = CreateContext("<Resp><ResponseMetadata><RequestId>x</RequestId></ResponseMetadata></Resp>"))
            {
                var byPath = new Dictionary<string, string>();
                while (context.Read())
                {
                    if (context.IsStartElement)
                        byPath[context.CurrentPath] = context.CurrentElementName;
                }

                Assert.AreEqual("Resp", byPath["/Resp"]);
                Assert.AreEqual("ResponseMetadata", byPath["/Resp/ResponseMetadata"]);
                Assert.AreEqual("RequestId", byPath["/Resp/ResponseMetadata/RequestId"]);

                Assert.AreEqual(0, context.CurrentDepth);
                Assert.AreEqual(string.Empty, context.CurrentElementName,
                    "At the empty-stack (post-EOF) state CurrentElementName must be an empty string.");
            }
        }

        [TestMethod]
        public void SelfClosingAndEmptyElements_ProduceStartThenEndWithBalancedDepth()
        {
            using (var context = CreateContext("<R><A/><B></B><C><D/></C></R>"))
            {
                int starts = 0, ends = 0, maxDepth = 0;
                while (context.Read())
                {
                    if (context.IsStartElement) starts++;
                    if (context.IsEndElement) ends++;
                    if (context.CurrentDepth > maxDepth) maxDepth = context.CurrentDepth;
                }

                Assert.AreEqual(5, starts, "Every element (incl. self-closing) must report a start.");
                // Only 4 ends are OBSERVABLE via the loop body: the Read() that processes the root's
                // </R> EndElement is the same call that reaches EOF and returns false, so the loop exits
                // before the body observes it. The buffer still pops R (final depth 0 below).
                Assert.AreEqual(4, ends, "All non-root ends are observable; the root end coincides with EOF.");
                Assert.AreEqual(3, maxDepth, "/R/C/D is the deepest path (depth 3).");
                Assert.AreEqual(0, context.CurrentDepth, "Depth must return to 0 after all elements close.");
            }
        }

        [TestMethod]
        public void IsAttribute_TrueOnlyOnAttributeNodes()
        {
            using (var context = CreateContext("<R a=\"1\"><B>v</B></R>"))
            {
                while (context.Read())
                {
                    if (context.IsAttribute)
                    {
                        Assert.IsFalse(context.IsStartElement, "A node cannot be both an attribute and a start element.");
                        Assert.IsFalse(context.IsEndElement, "A node cannot be both an attribute and an end element.");
                    }
                }
            }
        }

        [TestMethod]
        public void ReadText_ReturnsElementText()
        {
            using (var context = CreateContext("<R><A>hello world</A></R>"))
            {
                string text = null;
                while (context.Read())
                {
                    if (context.IsStartElement && context.CurrentPath == "/R/A")
                        text = context.ReadText();
                }
                Assert.AreEqual("hello world", text);
            }
        }

        [TestMethod]
        public void ReadText_OnAttributeNode_ReturnsAttributeValue()
        {
            using (var context = CreateContext("<R><A attr1=\"the-value\">body</A></R>"))
            {
                string attrValue = null;
                while (context.Read())
                {
                    if (context.IsAttribute && context.CurrentPath == "/R/A/@attr1")
                        attrValue = context.ReadText();
                }
                Assert.AreEqual("the-value", attrValue);
            }
        }

        [TestMethod]
        public void ReadText_ReadsS3ObjectKeyVerbatim_IncludingSpecialChars()
        {
            using (var context = CreateContext(
                "<ListBucketResult><Contents><Key>a &amp; b/c+d .txt</Key></Contents></ListBucketResult>"))
            {
                string key = null;
                while (context.Read())
                {
                    if (context.IsStartElement && context.CurrentPath == "/ListBucketResult/Contents/Key")
                    {
                        Assert.AreEqual(3, context.CurrentDepth, "'/' inside the key text must not create depth.");
                        key = context.ReadText();
                    }
                }
                Assert.AreEqual("a & b/c+d .txt", key);
            }
        }

        [TestMethod]
        public void TestExpression_DotAlwaysMatches()
        {
            using (var context = CreateContext("<R><A><B>v</B></A></R>"))
            {
                while (context.Read())
                {
                    Assert.IsTrue(context.TestExpression("."), "\".\" must always match, at every node.");
                    Assert.IsTrue(context.TestExpression(".", 0), "\".\" must always match regardless of depth arg.");
                }
            }
        }

        [TestMethod]
        public void TestExpression_BoundaryGuard_RejectsPartialSegmentSuffix()
        {
            using (var context = CreateContext("<R><List><member>a</member></List></R>"))
            {
                bool checkedMember = false;
                while (context.Read())
                {
                    if (context.IsStartElement && context.CurrentPath == "/R/List/member")
                    {
                        checkedMember = true;
                        Assert.IsTrue(context.TestExpression("member", 3), "Full segment matches at depth 3.");
                        Assert.IsFalse(context.TestExpression("ember", 3),
                            "Partial-segment suffix must be rejected by the '/'-boundary guard.");
                    }
                }
                Assert.IsTrue(checkedMember, "Expected to visit /R/List/member.");
            }
        }

        /// <summary>
        /// Reads the whole document and returns a map of every start element's exact CurrentPath to its
        /// CurrentDepth. Assumes distinct paths.
        /// </summary>
        private static Dictionary<string, int> CollectStartElementDepths(string xml)
        {
            var byPath = new Dictionary<string, int>();
            using (var context = CreateContext(xml))
            {
                while (context.Read())
                {
                    if (context.IsStartElement)
                        byPath[context.CurrentPath] = context.CurrentDepth;
                }
            }
            return byPath;
        }

        private static XmlUnmarshallerContext CreateContext(string xml)
        {
            var bytes = Encoding.UTF8.GetBytes(xml);
            var stream = new MemoryStream(bytes);
            return new XmlUnmarshallerContext(stream, false, null);
        }
    }
}
