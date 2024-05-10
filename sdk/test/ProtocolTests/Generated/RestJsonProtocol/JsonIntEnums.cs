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
    public class JsonIntEnums
    {
        /// <summary>
        /// Serializes intEnums as integers
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonIntEnumsRequest()
        {
            // Arrange
            var request = new JsonIntEnumsRequest
            {
                IntegerEnum1 = 1,
                IntegerEnum2 = 2,
                IntegerEnum3 = 3,
                IntegerEnumList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
                IntegerEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntegerEnumMap = new Dictionary<string, int>()
                {

                    { "abc", 1 },
                    { "def", 2 },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonIntEnumsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"integerEnum1\": 1,\n    \"integerEnum2\": 2,\n    \"integerEnum3\": 3,\n    \"integerEnumList\": [\n        1,\n        2,\n        3\n    ],\n    \"integerEnumSet\": [\n        1,\n        2\n    ],\n    \"integerEnumMap\": {\n        \"abc\": 1,\n        \"def\": 2\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonIntEnums", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes intEnums as integers
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonIntEnumsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"integerEnum1\": 1,\n    \"integerEnum2\": 2,\n    \"integerEnum3\": 3,\n    \"integerEnumList\": [\n        1,\n        2,\n        3\n    ],\n    \"integerEnumSet\": [\n        1,\n        2\n    ],\n    \"integerEnumMap\": {\n        \"abc\": 1,\n        \"def\": 2\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonIntEnumsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonIntEnumsResponse
            {
                IntegerEnum1 = 1,
                IntegerEnum2 = 2,
                IntegerEnum3 = 3,
                IntegerEnumList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
                IntegerEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntegerEnumMap = new Dictionary<string, int>()
                {

                    { "abc", 1 },
                    { "def", 2 },
                },
            };

            // Assert
            var actualResponse = (JsonIntEnumsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonIntEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
