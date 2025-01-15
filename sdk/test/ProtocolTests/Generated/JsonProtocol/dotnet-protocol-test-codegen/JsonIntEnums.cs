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
using Amazon.JsonProtocol;
using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.JsonProtocol
{
    [TestClass]
    public class JsonIntEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11IntEnumsRequest()
        {
            // Arrange
            var request = new JsonIntEnumsRequest
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
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonIntEnumsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"intEnum1\": 1,\n    \"intEnum2\": 2,\n    \"intEnum3\": 3,\n    \"intEnumList\": [\n        1,\n        2\n    ],\n    \"intEnumSet\": [\n        1,\n        2\n    ],\n    \"intEnumMap\": {\n        \"a\": 1,\n        \"b\": 2\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonIntEnums".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11IntEnumsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            webResponseData.Headers["X-Amz-Target"] = "JsonProtocol.JsonIntEnums";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"intEnum1\": 1,\n    \"intEnum2\": 2,\n    \"intEnum3\": 3,\n    \"intEnumList\": [\n        1,\n        2\n    ],\n    \"intEnumSet\": [\n        1,\n        2\n    ],\n    \"intEnumMap\": {\n        \"a\": 1,\n        \"b\": 2\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonIntEnumsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonIntEnumsResponse
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
            var actualResponse = (JsonIntEnumsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonIntEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
