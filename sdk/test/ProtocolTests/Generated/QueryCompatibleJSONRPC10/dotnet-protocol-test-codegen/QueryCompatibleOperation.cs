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
using Amazon.QueryCompatibleJSONRPC10;
using Amazon.QueryCompatibleJSONRPC10.Model;
using Amazon.QueryCompatibleJSONRPC10.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.QueryCompatibleJsonRpc10
{
    [TestClass]
    public class QueryCompatibleOperation
    {
        /// <summary>
        /// Clients for query-compatible services MUST send the
        /// x-amzn-query-mode header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("QueryCompatibleJsonRpc10")]
        public void QueryCompatibleAwsJson10CborSendsQueryModeHeaderRequest()
        {
            // Arrange
            var request = new QueryCompatibleOperationRequest
            {
            };
            var config = new AmazonQueryCompatibleJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryCompatibleOperationRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("QueryCompatibleJsonRpc10.QueryCompatibleOperation".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.AreEqual("true".Replace(" ",""), marshalledRequest.Headers["x-amzn-query-mode"].Replace(" ",""));
        }

        /// <summary>
        /// Parses simple errors with no query error code
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("QueryCompatibleJsonRpc10")]
        public void QueryCompatibleAwsJson10NoCustomCodeErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"aws.protocoltests.json10#NoCustomCodeError\",\n    \"message\": \"Hi\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new QueryCompatibleOperationResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(NoCustomCodeErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

    }
}
