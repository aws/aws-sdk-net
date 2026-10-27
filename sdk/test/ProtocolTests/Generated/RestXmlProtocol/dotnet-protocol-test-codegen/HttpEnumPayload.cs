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
    public class HttpEnumPayload
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public async Task RestXmlEnumPayloadRequestRequest()
        {
            // Arrange
            var request = new HttpEnumPayloadRequest
            {
                Payload = "enumvalue",
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
            await client.HttpEnumPayloadAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "enumvalue";
            XmlTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/EnumPayload", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("text/plain".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public async Task RestXmlEnumPayloadResponseResponse()
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
                Body = Encoding.ASCII.GetBytes("enumvalue"),
            };
            mockResponse.Headers["Content-Type"] = "text/plain";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.HttpEnumPayloadAsync(new HttpEnumPayloadRequest()).ConfigureAwait(false);
            var expectedResponse = new HttpEnumPayloadResponse
            {
                Payload = "enumvalue",
            };

            // Assert
            Comparer.CompareObjects<HttpEnumPayloadResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
