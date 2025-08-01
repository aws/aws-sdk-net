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
    public class HttpEmptyPrefixHeaders
    {
        /// <summary>
        /// Serializes all request headers, using specific when present
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonHttpEmptyPrefixHeadersRequestClientRequest()
        {
            // Arrange
            var request = new HttpEmptyPrefixHeadersRequest
            {
                PrefixHeaders = new Dictionary<string, string>()
                {

                    { "x-foo", "Foo" },
                    { "hello", "Hello" },
                },
                SpecificHeader = "There",
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpEmptyPrefixHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpEmptyPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("There".Replace(" ",""), marshalledRequest.Headers["hello"].Replace(" ",""));
            Assert.AreEqual("Foo".Replace(" ",""), marshalledRequest.Headers["x-foo"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes all response headers with the same for prefix and
        /// specific
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonHttpEmptyPrefixHeadersResponseClientResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["hello"] = "There";
            webResponseData.Headers["x-foo"] = "Foo";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new HttpEmptyPrefixHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new HttpEmptyPrefixHeadersResponse
            {
                PrefixHeaders = new Dictionary<string, string>()
                {

                    { "x-foo", "Foo" },
                    { "hello", "There" },
                },
                SpecificHeader = "There",
            };

            // Assert
            var actualResponse = (HttpEmptyPrefixHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<HttpEmptyPrefixHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
