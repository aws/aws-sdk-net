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

using System;
using System.IO;
using System.Text;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class XmlUnmarshallerContextPathTests
    {
        [TestMethod]
        public void MetricDataResponse_MatcherMatchesHistoricalLogic()
        {
            var sb = new StringBuilder();
            sb.Append("<GetMetricDataResponse xmlns=\"https://awsquerydataplane.amazonaws.com\">");
            sb.Append("<GetMetricDataResult><MetricDataResults>");
            for (int r = 0; r < 5; r++)
            {
                sb.Append($"<member><Id>q{r}</Id><Label>Metric_{r}</Label><StatusCode>Complete</StatusCode><Timestamps>");
                for (int v = 0; v < 8; v++) sb.Append($"<member>2024-01-01T00:{v:D2}:00Z</member>");
                sb.Append("</Timestamps><Values>");
                for (int v = 0; v < 8; v++) sb.Append($"<member>{42.0 + v}</member>");
                sb.Append("</Values></member>");
            }
            sb.Append("</MetricDataResults></GetMetricDataResult></GetMetricDataResponse>");

            AssertMatcherParity(sb.ToString());
        }

        [TestMethod]
        public void NestedAndAttributes_MatcherMatchesHistoricalLogic()
        {
            AssertMatcherParity(
                "<Root xmlns=\"https://example.com\" id=\"r1\">" +
                  "<A attr1=\"x\" attr2=\"y\"><B><C>v</C></B></A>" +
                  "<Self closed=\"1\" />" +
                  "<Empty></Empty>" +
                  "<List><member>a</member><member>b</member></List>" +
                "</Root>");
        }

        [TestMethod]
        public void ResponseMetadataShape_MatcherMatchesHistoricalLogic()
        {
            AssertMatcherParity(
                "<Resp><Result><Foo>1</Foo></Result>" +
                "<ResponseMetadata><RequestId>abc-123</RequestId><Extra>e</Extra></ResponseMetadata></Resp>");
        }

        [TestMethod]
        public void SelfClosingAndEmptyElements_MatcherMatchesHistoricalLogic()
        {
            AssertMatcherParity("<R><A/><B/><C><D/></C><E></E></R>");
        }

        [TestMethod]
        public void ErrorEnvelope_MatcherMatchesHistoricalLogic()
        {
            AssertMatcherParity(
                "<ErrorResponse><Error><Type>Sender</Type><Code>Throttling</Code>" +
                "<Message>Rate exceeded</Message></Error><RequestId>r-1</RequestId></ErrorResponse>");
        }

        [TestMethod]
        public void DeeplyNestedAttributes_MatcherMatchesHistoricalLogic()
        {
            AssertMatcherParity(
                "<R><A attr1=\"1\"><B><C deep=\"2\"><D leaf=\"3\">v</D></C></B></A></R>");
        }

        [TestMethod]
        public void LongPath_ForcesBufferGrowth_MatcherMatchesHistoricalLogic()
        {
            var sb = new StringBuilder();
            sb.Append("<Root>");
            const int depth = 40;
            for (int i = 0; i < depth; i++)
                sb.Append("<ElementWithAFairlyLongLocalName").Append(i).Append('>');
            sb.Append("leaf");
            for (int i = depth - 1; i >= 0; i--)
                sb.Append("</ElementWithAFairlyLongLocalName").Append(i).Append('>');
            sb.Append("</Root>");
            AssertMatcherParity(sb.ToString());
        }

        [TestMethod]
        public void EmptyStackPath_IsSlash()
        {
            using (var context = CreateContext("<R><A>v</A></R>"))
            {
                while (context.Read())
                {
                }
                Assert.AreEqual(0, context.CurrentDepth, "Depth after EOF must be 0.");
                Assert.AreEqual("/", context.CurrentPath, "Empty-stack CurrentPath must be \"/\".");
            }
        }

        /// <summary>
        /// At every Read(), compares the context's new TestExpression against the ORIGINAL string
        /// algorithm evaluated on the context's own reported CurrentPath/CurrentDepth.
        /// </summary>
        private static void AssertMatcherParity(string xml)
        {
            int[] Depths = { 0, 1, 2, 3, 4, 5, 6, 7 };
            string[] Expressions =
            {
                ".",
                "member", "Id", "Label", "StatusCode", "Value", "Code", "Message", "Type",
                "MetricDataResults/member", "Timestamps/member", "Values/member",
                "Messages/member", "ResponseMetadata/RequestId",
                "Error/Type", "Error/Code", "Error/Message",
                "valueSet/item/value",
                "@name", "@xmlns", "@id", "@attr1", "@closed",
                "A/@attr1", "C/@deep", "Root/@id",
                "ember", "ults/member", "esults/member", "d", "ode", "ata/RequestId",
            };

            using (var context = CreateContext(xml))
            {
                int step = 0;
                while (context.Read())
                {
                    var path = context.CurrentPath;
                    var depth = context.CurrentDepth;

                    foreach (var expr in Expressions)
                    {
                        Assert.AreEqual(
                            HistoricalTestExpression(expr, path),
                            context.TestExpression(expr),
                            $"TestExpression(\"{expr}\") diverged at path '{path}' (step {step})");

                        foreach (var startDepth in Depths)
                        {
                            Assert.AreEqual(
                                HistoricalTestExpression(expr, startDepth, path, depth),
                                context.TestExpression(expr, startDepth),
                                $"TestExpression(\"{expr}\", {startDepth}) diverged at path '{path}', depth {depth} (step {step})");
                        }
                    }
                    step++;
                }

                Assert.IsTrue(step > 0, "Expected at least one Read().");
            }
        }


        private static bool HistoricalTestExpression(string expression, string currentPath)
        {
            if (expression.Equals("."))
                return true;
            return currentPath.EndsWith(expression, StringComparison.OrdinalIgnoreCase);
        }

        private static bool HistoricalTestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
        {
            if (expression.Equals("."))
                return true;

            int index = -1;
            while ((index = expression.IndexOf("/", index + 1, StringComparison.Ordinal)) > -1)
            {
                if (expression[0] != '@')
                    startingStackDepth++;
            }
            return startingStackDepth == currentDepth
                   && currentPath.Length > expression.Length
                   && currentPath[currentPath.Length - expression.Length - 1] == '/'
                   && currentPath.EndsWith(expression, StringComparison.OrdinalIgnoreCase);
        }

        private static XmlUnmarshallerContext CreateContext(string xml)
        {
            var bytes = Encoding.UTF8.GetBytes(xml);
            var stream = new MemoryStream(bytes);
            return new XmlUnmarshallerContext(stream, false, null);
        }
    }
}
