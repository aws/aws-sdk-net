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

/*
 * Do not modify this file. This file is generated.
 */
using AWSSDK.ProtocolTests;
using AWSSDK.ProtocolTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.RestXmlProtocol;
using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class NestedXmlMapWithXmlName
    {
        /// <summary>
        /// Serializes nested XML Maps in requests that have xmlName on
        /// members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public async Task NestedXmlMapWithXmlNameSerializesRequest()
        {
            // Arrange
            var request = new NestedXmlMapWithXmlNameRequest
            {
                NestedXmlMapWithXmlNameMap = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "foo", new Dictionary<string, string>()
                    {

                        { "bar", "Baz" },
                        { "fizz", "Buzz" },
                    } },
                    { "qux", new Dictionary<string, string>()
                    {

                        { "foobar", "Bar" },
                        { "fizzbuzz", "Buzz" },
                    } },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestXmlProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.NestedXmlMapWithXmlNameAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "    <NestedXmlMapWithXmlNameRequest>\n        <nestedXmlMapWithXmlNameMap>\n            <entry>\n                <OuterKey>foo</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>bar</InnerKey>\n                        <InnerValue>Baz</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n            <entry>\n                <OuterKey>qux</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>foobar</InnerKey>\n                        <InnerValue>Bar</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizzbuzz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n        </nestedXmlMapWithXmlNameMap>\n    </NestedXmlMapWithXmlNameRequest>\n";
            XmlTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/NestedXmlMapWithXmlName", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/xml".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes nested XML maps in responses that have xmlName on
        /// members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public async Task NestedXmlMapWithXmlNameDeserializesResponse()
        {
            // Arrange
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestXmlProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("    <NestedXmlMapWithXmlNameResponse>\n        <nestedXmlMapWithXmlNameMap>\n            <entry>\n                <OuterKey>foo</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>bar</InnerKey>\n                        <InnerValue>Baz</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n            <entry>\n                <OuterKey>qux</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>foobar</InnerKey>\n                        <InnerValue>Bar</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizzbuzz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n        </nestedXmlMapWithXmlNameMap>\n    </NestedXmlMapWithXmlNameResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "application/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.NestedXmlMapWithXmlNameAsync(new NestedXmlMapWithXmlNameRequest()).ConfigureAwait(false);
            var expectedResponse = new NestedXmlMapWithXmlNameResponse
            {
                NestedXmlMapWithXmlNameMap = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "foo", new Dictionary<string, string>()
                    {

                        { "bar", "Baz" },
                        { "fizz", "Buzz" },
                    } },
                    { "qux", new Dictionary<string, string>()
                    {

                        { "foobar", "Bar" },
                        { "fizzbuzz", "Buzz" },
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<NestedXmlMapWithXmlNameResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
