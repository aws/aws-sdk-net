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
using Amazon.QueryProtocol;
using Amazon.QueryProtocol.Model;
using Amazon.QueryProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.AwsQuery
{
    [TestClass]
    public class XmlEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlEnumsResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlEnumsResponse xmlns=\"https://example.com/\">\n    <XmlEnumsResult>\n        <fooEnum1>Foo</fooEnum1>\n        <fooEnum2>0</fooEnum2>\n        <fooEnum3>1</fooEnum3>\n        <fooEnumList>\n            <member>Foo</member>\n            <member>0</member>\n        </fooEnumList>\n        <fooEnumSet>\n            <member>Foo</member>\n            <member>0</member>\n        </fooEnumSet>\n        <fooEnumMap>\n            <entry>\n                <key>hi</key>\n                <value>Foo</value>\n            </entry>\n            <entry>\n                <key>zero</key>\n                <value>0</value>\n            </entry>\n        </fooEnumMap>\n    </XmlEnumsResult>\n</XmlEnumsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlEnumsAsync(new XmlEnumsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlEnumsResponse
            {
                FooEnum1 = "Foo",
                FooEnum2 = "0",
                FooEnum3 = "1",
                FooEnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                FooEnumSet =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                FooEnumMap = new Dictionary<string, string>()
                {

                    { "hi", "Foo" },
                    { "zero", "0" },
                },
            };

            // Assert
            Comparer.CompareObjects<XmlEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
