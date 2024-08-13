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
    public class RecursiveShapes
    {
        /// <summary>
        /// Serializes recursive structures
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonRecursiveShapesRequest()
        {
            // Arrange
            var request = new RecursiveShapesRequest
            {
                Nested = new RecursiveShapesInputOutputNested1
                {
                    Foo = "Foo1",
                    Nested = new RecursiveShapesInputOutputNested2
                    {
                        Bar = "Bar1",
                        RecursiveMember = new RecursiveShapesInputOutputNested1
                        {
                            Foo = "Foo2",
                            Nested = new RecursiveShapesInputOutputNested2
                            {
                                Bar = "Bar2",
                            },
                        },
                    },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RecursiveShapesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"nested\": {\n        \"foo\": \"Foo1\",\n        \"nested\": {\n            \"bar\": \"Bar1\",\n            \"recursiveMember\": {\n                \"foo\": \"Foo2\",\n                \"nested\": {\n                    \"bar\": \"Bar2\"\n                }\n            }\n        }\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/RecursiveShapes", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes recursive structures
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonRecursiveShapesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"nested\": {\n        \"foo\": \"Foo1\",\n        \"nested\": {\n            \"bar\": \"Bar1\",\n            \"recursiveMember\": {\n                \"foo\": \"Foo2\",\n                \"nested\": {\n                    \"bar\": \"Bar2\"\n                }\n            }\n        }\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RecursiveShapesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RecursiveShapesResponse
            {
                Nested = new RecursiveShapesInputOutputNested1
                {
                    Foo = "Foo1",
                    Nested = new RecursiveShapesInputOutputNested2
                    {
                        Bar = "Bar1",
                        RecursiveMember = new RecursiveShapesInputOutputNested1
                        {
                            Foo = "Foo2",
                            Nested = new RecursiveShapesInputOutputNested2
                            {
                                Bar = "Bar2",
                            },
                        },
                    },
                },
            };

            // Assert
            var actualResponse = (RecursiveShapesResponse)unmarshalledResponse;
            Comparer.CompareObjects<RecursiveShapesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
