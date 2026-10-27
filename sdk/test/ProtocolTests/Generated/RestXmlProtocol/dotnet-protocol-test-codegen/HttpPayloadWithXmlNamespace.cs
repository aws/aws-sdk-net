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
    public class HttpPayloadWithXmlNamespace
    {
        /// <summary>
        /// Serializes a structure in the payload using a wrapper with an XML
        /// namespace
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public async Task HttpPayloadWithXmlNamespaceRequest()
        {
            // Arrange
            var request = new HttpPayloadWithXmlNamespaceRequest
            {
                Nested = new PayloadWithXmlNamespace
                {
                    Name = "Phreddy",
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
            await client.HttpPayloadWithXmlNamespaceAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "<PayloadWithXmlNamespace xmlns=\"http://foo.com\">\n    <name>Phreddy</name>\n</PayloadWithXmlNamespace>";
            XmlTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/HttpPayloadWithXmlNamespace", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/xml".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes a structure in the payload using a wrapper with an XML
        /// namespace
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public async Task HttpPayloadWithXmlNamespaceResponse()
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
                Body = Encoding.ASCII.GetBytes("<PayloadWithXmlNamespace xmlns=\"http://foo.com\">\n    <name>Phreddy</name>\n</PayloadWithXmlNamespace>"),
            };
            mockResponse.Headers["Content-Type"] = "application/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.HttpPayloadWithXmlNamespaceAsync(new HttpPayloadWithXmlNamespaceRequest()).ConfigureAwait(false);
            var expectedResponse = new HttpPayloadWithXmlNamespaceResponse
            {
                Nested = new PayloadWithXmlNamespace
                {
                    Name = "Phreddy",
                },
            };

            // Assert
            Comparer.CompareObjects<HttpPayloadWithXmlNamespaceResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
