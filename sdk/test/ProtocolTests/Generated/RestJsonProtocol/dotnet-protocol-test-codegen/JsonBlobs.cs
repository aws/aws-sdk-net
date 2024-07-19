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
    public class JsonBlobs
    {
        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonBlobsRequest()
        {
            // Arrange
            var request = new JsonBlobsRequest
            {
                Data = new MemoryStream(Encoding.UTF8.GetBytes("value")),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonBlobsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"data\": \"dmFsdWU=\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonBlobs", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonBlobsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"data\": \"dmFsdWU=\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonBlobsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonBlobsResponse
            {
                Data = new MemoryStream(Encoding.UTF8.GetBytes("value")),
            };

            // Assert
            var actualResponse = (JsonBlobsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonBlobsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
