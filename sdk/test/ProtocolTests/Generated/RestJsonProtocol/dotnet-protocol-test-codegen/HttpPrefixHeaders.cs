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
using Amazon.RestJsonProtocol;
using Amazon.RestJsonProtocol.Model;
using Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.RestJson
{
    [TestClass]
    public class HttpPrefixHeaders
    {
        /// <summary>
        /// Adds headers by prefix
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPrefixHeadersArePresentRequest()
        {
            // Arrange
            var request = new HttpPrefixHeadersRequest
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                    { "abc", "Abc value" },
                    { "def", "Def value" },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.HttpPrefixHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("GET", actualRequest.Method);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("Foo".Replace(" ",""), actualRequest.Headers["x-foo"].Replace(" ",""));
            Assert.AreEqual("Abc value".Replace(" ",""), actualRequest.Headers["x-foo-abc"].Replace(" ",""));
            Assert.AreEqual("Def value".Replace(" ",""), actualRequest.Headers["x-foo-def"].Replace(" ",""));
        }

        /// <summary>
        /// No prefix headers are serialized because the value is not present
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPrefixHeadersAreNotPresentRequest()
        {
            // Arrange
            var request = new HttpPrefixHeadersRequest
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.HttpPrefixHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("GET", actualRequest.Method);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("Foo".Replace(" ",""), actualRequest.Headers["x-foo"].Replace(" ",""));
        }

        /// <summary>
        /// Serialize prefix headers were the value is present but empty
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPrefixEmptyHeadersRequest()
        {
            // Arrange
            var request = new HttpPrefixHeadersRequest
            {
                FooMap = new Dictionary<string, string>()
                {

                    { "abc", "" },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.HttpPrefixHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("GET", actualRequest.Method);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("".Replace(" ",""), actualRequest.Headers["x-foo-abc"].Replace(" ",""));
        }

        /// <summary>
        /// Adds headers by prefix
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPrefixHeadersArePresentResponse()
        {
            // Arrange
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["x-foo"] = "Foo";
            mockResponse.Headers["x-foo-abc"] = "Abc value";
            mockResponse.Headers["x-foo-def"] = "Def value";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.HttpPrefixHeadersAsync(new HttpPrefixHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new HttpPrefixHeadersResponse
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                    { "abc", "Abc value" },
                    { "def", "Def value" },
                },
            };

            // Assert
            Comparer.CompareObjects<HttpPrefixHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
