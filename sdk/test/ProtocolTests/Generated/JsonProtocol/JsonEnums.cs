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
using AWSSDK_DotNet35.UnitTests.TestTools;
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
    public class JsonEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11EnumsRequest()
        {
            // Arrange
            var request = new JsonEnumsRequest
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
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonEnumsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"fooEnum1\": \"Foo\",\n    \"fooEnum2\": \"0\",\n    \"fooEnum3\": \"1\",\n    \"fooEnumList\": [\n        \"Foo\",\n        \"0\"\n    ],\n    \"fooEnumSet\": [\n        \"Foo\",\n        \"0\"\n    ],\n    \"fooEnumMap\": {\n        \"hi\": \"Foo\",\n        \"zero\": \"0\"\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonEnums".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11EnumsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"fooEnum1\": \"Foo\",\n    \"fooEnum2\": \"0\",\n    \"fooEnum3\": \"1\",\n    \"fooEnumList\": [\n        \"Foo\",\n        \"0\"\n    ],\n    \"fooEnumSet\": [\n        \"Foo\",\n        \"0\"\n    ],\n    \"fooEnumMap\": {\n        \"hi\": \"Foo\",\n        \"zero\": \"0\"\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonEnumsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonEnumsResponse
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
            var actualResponse = (JsonEnumsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
