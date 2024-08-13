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
    public class NestedXmlMaps
    {
        /// <summary>
        /// Tests requests with nested maps.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void NestedXmlMapRequestRequest()
        {
            // Arrange
            var request = new NestedXmlMapsRequest
            {
                NestedMap = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "foo", new Dictionary<string, string>()
                    {

                        { "bar", "Bar" },
                    } },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NestedXmlMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<NestedXmlMapsRequest>\n    <nestedMap>\n        <entry>\n            <key>foo</key>\n            <value>\n                <entry>\n                    <key>bar</key>\n                    <value>Bar</value>\n                </entry>\n            </value>\n        </entry>\n    </nestedMap>\n</NestedXmlMapsRequest>";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/NestedXmlMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with nested flat maps. Since maps can only be
        /// flattened when they're structure members, only the outer map is
        /// flat.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void FlatNestedXmlMapRequestRequest()
        {
            // Arrange
            var request = new NestedXmlMapsRequest
            {
                FlatNestedMap = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "foo", new Dictionary<string, string>()
                    {

                        { "bar", "Bar" },
                    } },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NestedXmlMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<NestedXmlMapsRequest>\n    <flatNestedMap>\n        <key>foo</key>\n        <value>\n            <entry>\n                <key>bar</key>\n                <value>Bar</value>\n            </entry>\n        </value>\n    </flatNestedMap>\n</NestedXmlMapsRequest>";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/NestedXmlMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Tests responses with nested maps.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void NestedXmlMapResponseResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<NestedXmlMapsResponse>\n    <nestedMap>\n        <entry>\n            <key>foo</key>\n            <value>\n                <entry>\n                    <key>bar</key>\n                    <value>Bar</value>\n                </entry>\n            </value>\n        </entry>\n    </nestedMap>\n</NestedXmlMapsResponse>");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NestedXmlMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new NestedXmlMapsResponse
            {
                NestedMap = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "foo", new Dictionary<string, string>()
                    {

                        { "bar", "Bar" },
                    } },
                },
            };

            // Assert
            var actualResponse = (NestedXmlMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<NestedXmlMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Tests responses with nested flat maps. Since maps can only be
        /// flattened when they're structure members, only the outer map is
        /// flat.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void FlatNestedXmlMapResponseResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<NestedXmlMapsResponse>\n    <flatNestedMap>\n        <key>foo</key>\n        <value>\n            <entry>\n                <key>bar</key>\n                <value>Bar</value>\n            </entry>\n        </value>\n    </flatNestedMap>\n</NestedXmlMapsResponse>");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NestedXmlMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new NestedXmlMapsResponse
            {
                FlatNestedMap = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "foo", new Dictionary<string, string>()
                    {

                        { "bar", "Bar" },
                    } },
                },
            };

            // Assert
            var actualResponse = (NestedXmlMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<NestedXmlMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
