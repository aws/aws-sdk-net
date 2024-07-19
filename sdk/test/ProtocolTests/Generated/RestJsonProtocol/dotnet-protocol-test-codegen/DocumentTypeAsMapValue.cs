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
using Amazon.Runtime.Documents;
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
    public class DocumentTypeAsMapValue
    {
        /// <summary>
        /// Serializes a map that uses documents as the value.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void DocumentTypeAsMapValueInputRequest()
        {
            // Arrange
            var request = new DocumentTypeAsMapValueRequest
            {
                DocValuedMap = new Dictionary<string, Document>()
                {

                    { "foo", new Document(new Dictionary<string,Document>
                    {
                        {"f", 1},
                        {"o", 2},
                    }) },
                    { "bar", new Document
                    {
                        "b",
                        "a",
                        "r",
                    } },
                    { "baz", "BAZ" },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new DocumentTypeAsMapValueRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"docValuedMap\": {\n        \"foo\": { \"f\": 1, \"o\": 2 },\n        \"bar\": [ \"b\", \"a\", \"r\" ],\n        \"baz\": \"BAZ\"\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/DocumentTypeAsMapValue", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a map that uses documents as the value.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void DocumentTypeAsMapValueOutputResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"docValuedMap\": {\n        \"foo\": { \"f\": 1, \"o\": 2 },\n        \"bar\": [ \"b\", \"a\", \"r\" ],\n        \"baz\": \"BAZ\"\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new DocumentTypeAsMapValueResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new DocumentTypeAsMapValueResponse
            {
                DocValuedMap = new Dictionary<string, Document>()
                {

                    { "foo", new Document(new Dictionary<string,Document>
                    {
                        {"f", 1},
                        {"o", 2},
                    }) },
                    { "bar", new Document
                    {
                        "b",
                        "a",
                        "r",
                    } },
                    { "baz", "BAZ" },
                },
            };

            // Assert
            var actualResponse = (DocumentTypeAsMapValueResponse)unmarshalledResponse;
            Comparer.CompareObjects<DocumentTypeAsMapValueResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
