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
        public void RestJsonHttpPrefixHeadersArePresentRequest()
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
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpPrefixHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Foo".Replace(" ",""), marshalledRequest.Headers["x-foo"].Replace(" ",""));
            Assert.AreEqual("Abc value".Replace(" ",""), marshalledRequest.Headers["x-foo-abc"].Replace(" ",""));
            Assert.AreEqual("Def value".Replace(" ",""), marshalledRequest.Headers["x-foo-def"].Replace(" ",""));
        }

        /// <summary>
        /// No prefix headers are serialized because the value is not present
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonHttpPrefixHeadersAreNotPresentRequest()
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
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpPrefixHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Foo".Replace(" ",""), marshalledRequest.Headers["x-foo"].Replace(" ",""));
        }

        /// <summary>
        /// Serialize prefix headers were the value is present but empty
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonHttpPrefixEmptyHeadersRequest()
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
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpPrefixHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("".Replace(" ",""), marshalledRequest.Headers["x-foo-abc"].Replace(" ",""));
        }

        /// <summary>
        /// Adds headers by prefix
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonHttpPrefixHeadersArePresentResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["x-foo"] = "Foo";
            webResponseData.Headers["x-foo-abc"] = "Abc value";
            webResponseData.Headers["x-foo-def"] = "Def value";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new HttpPrefixHeadersResponseUnmarshaller().Unmarshall(context);
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
            var actualResponse = (HttpPrefixHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<HttpPrefixHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
