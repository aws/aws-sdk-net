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
    public class XmlIntEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public async Task XmlIntEnumsRequest()
        {
            // Arrange
            var request = new XmlIntEnumsRequest
            {
                IntEnum1 = 1,
                IntEnum2 = 2,
                IntEnum3 = 3,
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumMap = new Dictionary<string, int>()
                {

                    { "a", 1 },
                    { "b", 2 },
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
            await client.XmlIntEnumsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "<XmlIntEnumsRequest>\n    <intEnum1>1</intEnum1>\n    <intEnum2>2</intEnum2>\n    <intEnum3>3</intEnum3>\n    <intEnumList>\n        <member>1</member>\n        <member>2</member>\n    </intEnumList>\n    <intEnumSet>\n        <member>1</member>\n        <member>2</member>\n    </intEnumSet>\n    <intEnumMap>\n        <entry>\n            <key>a</key>\n            <value>1</value>\n        </entry>\n        <entry>\n            <key>b</key>\n            <value>2</value>\n        </entry>\n    </intEnumMap>\n</XmlIntEnumsRequest>\n";
            XmlTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/XmlIntEnums", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/xml".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public async Task XmlIntEnumsResponse()
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
                Body = Encoding.ASCII.GetBytes("<XmlIntEnumsResponse>\n    <intEnum1>1</intEnum1>\n    <intEnum2>2</intEnum2>\n    <intEnum3>3</intEnum3>\n    <intEnumList>\n        <member>1</member>\n        <member>2</member>\n    </intEnumList>\n    <intEnumSet>\n        <member>1</member>\n        <member>2</member>\n    </intEnumSet>\n    <intEnumMap>\n        <entry>\n            <key>a</key>\n            <value>1</value>\n        </entry>\n        <entry>\n            <key>b</key>\n            <value>2</value>\n        </entry>\n    </intEnumMap>\n</XmlIntEnumsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "application/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlIntEnumsAsync(new XmlIntEnumsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlIntEnumsResponse
            {
                IntEnum1 = 1,
                IntEnum2 = 2,
                IntEnum3 = 3,
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumMap = new Dictionary<string, int>()
                {

                    { "a", 1 },
                    { "b", 2 },
                },
            };

            // Assert
            Comparer.CompareObjects<XmlIntEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
