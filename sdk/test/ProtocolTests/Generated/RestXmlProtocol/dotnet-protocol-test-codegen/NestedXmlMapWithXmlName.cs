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
        public void NestedXmlMapWithXmlNameSerializesRequest()
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
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NestedXmlMapWithXmlNameRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "    <NestedXmlMapWithXmlNameRequest>\n        <nestedXmlMapWithXmlNameMap>\n            <entry>\n                <OuterKey>foo</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>bar</InnerKey>\n                        <InnerValue>Baz</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n            <entry>\n                <OuterKey>qux</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>foobar</InnerKey>\n                        <InnerValue>Bar</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizzbuzz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n        </nestedXmlMapWithXmlNameMap>\n    </NestedXmlMapWithXmlNameRequest>\n";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/NestedXmlMapWithXmlName", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes nested XML maps in responses that have xmlName on
        /// members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void NestedXmlMapWithXmlNameDeserializesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("    <NestedXmlMapWithXmlNameResponse>\n        <nestedXmlMapWithXmlNameMap>\n            <entry>\n                <OuterKey>foo</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>bar</InnerKey>\n                        <InnerValue>Baz</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n            <entry>\n                <OuterKey>qux</OuterKey>\n                <value>\n                    <entry>\n                        <InnerKey>foobar</InnerKey>\n                        <InnerValue>Bar</InnerValue>\n                    </entry>\n                    <entry>\n                        <InnerKey>fizzbuzz</InnerKey>\n                        <InnerValue>Buzz</InnerValue>\n                    </entry>\n                </value>\n            </entry>\n        </nestedXmlMapWithXmlNameMap>\n    </NestedXmlMapWithXmlNameResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NestedXmlMapWithXmlNameResponseUnmarshaller().Unmarshall(context);
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
            var actualResponse = (NestedXmlMapWithXmlNameResponse)unmarshalledResponse;
            Comparer.CompareObjects<NestedXmlMapWithXmlNameResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
