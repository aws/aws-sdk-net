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
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class XmlUnmarshallerContextTests
    {
        private static XmlUnmarshallerContext CreateContext(string xml)
        {
            return new XmlUnmarshallerContext(new MemoryStream(Encoding.UTF8.GetBytes(xml)), false, null);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_TracksElementsAttributesAndEndElements()
        {
            var xml = "<Root><Item id=\"1\"><Name>foo</Name></Item><Item id=\"2\"><Name>bar</Name></Item><Empty/></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/Item=",
                "A:/Root/Item/@id=1",
                "S:/Root/Item/Name=foo",
                "E:/Root/Item",
                "E:/Root",
                "S:/Root/Item=",
                "A:/Root/Item/@id=2",
                "S:/Root/Item/Name=bar",
                "E:/Root/Item",
                "E:/Root",
                "S:/Root/Empty=",
                "E:/Root"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentDepth_MatchesElementNesting()
        {
            var xml = "<Root><Child><GrandChild>x</GrandChild></Child></Root>";

            using (var context = CreateContext(xml))
            {
                var maxDepth = 0;
                while (context.Read())
                {
                    if (context.IsStartElement && context.CurrentDepth > maxDepth)
                        maxDepth = context.CurrentDepth;

                    if (context.IsStartElement && context.CurrentDepth == 3)
                    {
                        Assert.AreEqual("/Root/Child/GrandChild", context.CurrentPath);
                        Assert.AreEqual("x", context.ReadText());
                    }
                }

                Assert.AreEqual(3, maxDepth);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestExpression_MatchesGeneratedMarshallerPatterns()
        {
            var xml = "<Response><Values><member>a</member><member>b</member></Values></Response>";

            var memberValues = new List<string>();
            using (var context = CreateContext(xml))
            {
                while (context.Read())
                {
                    if (context.IsStartElement)
                    {
                        // Mirrors the pseudo-XPath matching emitted by the generated unmarshallers.
                        if (context.TestExpression("Values/member", 2))
                        {
                            memberValues.Add(StringUnmarshaller.Instance.Unmarshall(context));
                            continue;
                        }
                    }
                }
            }

            CollectionAssert.AreEqual(new[] { "a", "b" }, memberValues);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_EmptyElementsPushAndPopCorrectly()
        {
            var xml = "<Root><A/><B><C/></B></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/A=",
                "E:/Root",
                "S:/Root/B=",
                "S:/Root/B/C=",
                "E:/Root/B",
                "E:/Root"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_EmptyElementWithAttributes()
        {
            // Self-closing element carrying attributes: the path tracking must remain
            // consistent. Note: the context does not surface attributes on empty
            // (self-closing) elements; this documents the current behavior.
            var xml = "<Root><Something id=\"111\" /><After>x</After></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/Something=",
                "E:/Root",
                "S:/Root/After=x",
                "E:/Root"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void EmptyElement_AttributesAreSurfaced()
        {
            // NOTE: THIS IS EXPECTED TO FAIL. Current base version fails this test!
            // TODO: ASK THE TEAM: Should attributes on self-closing elements be surfaced?
            // attributes on a self-closing element are never surfaced because the
            // IsEmptyElement branch in Read() skips ReadElement(). This test asserts the
            // expected behavior; run it against the base commit to confirm the same
            // misbehavior existed prior to this branch.
            var xml = "<Root><Something id=\"111\" /></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/Something=",
                "A:/Root/Something/@id=111",
                "E:/Root"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_SameLengthSiblingNamesAreNotConfused()
        {
            // Sibling elements with equal-length names must not reuse each other's path.
            var xml = "<Root><AB>1</AB><CD>2</CD></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/AB=1",
                "E:/Root",
                "S:/Root/CD=2",
                "E:/Root"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_SameNameAtDifferentDepthIsNotReused()
        {
            // <B/> is first popped at depth 2 (/R/A/B), then /R/A is popped; a new <B>
            // at depth 1 must get /R/B, not a stale reused path.
            var xml = "<R><A><B/></A><B>y</B></R>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/R=",
                "S:/R/A=",
                "S:/R/A/B=",
                "E:/R/A",
                "E:/R",
                "S:/R/B=y",
                "E:/R"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_NestedSameNameElements()
        {
            var xml = "<A><A>x</A></A>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/A=",
                "S:/A/A=x",
                "E:/A"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_MultipleAttributesOnOneElement()
        {
            var xml = "<Root><Item a=\"1\" b=\"2\">t</Item></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/Item=t",
                "A:/Root/Item/@a=1",
                "A:/Root/Item/@b=2",
                "E:/Root"
            }, ReadEvents(xml));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CurrentPath_TextBetweenSiblingElementsIsSkipped()
        {
            // Stray text between siblings exercises the default branch in Read(),
            // which must advance the reader and keep CurrentPath pointing at the parent.
            var xml = "<Root><A>1</A>stray<B>2</B></Root>";

            CollectionAssert.AreEqual(new[]
            {
                "S:/Root=",
                "S:/Root/A=1",
                "E:/Root",
                "S:/Root/B=2",
                "E:/Root"
            }, ReadEvents(xml));
        }

        private static List<string> ReadEvents(string xml)
        {
            var events = new List<string>();
            using (var context = CreateContext(xml))
            {
                while (context.Read())
                {
                    if (context.IsStartElement)
                        events.Add("S:" + context.CurrentPath + "=" + context.ReadText());
                    else if (context.IsAttribute)
                        events.Add("A:" + context.CurrentPath + "=" + context.ReadText());
                    else if (context.IsEndElement)
                        events.Add("E:" + context.CurrentPath);
                }
            }
            return events;
        }
    }
}
