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
    public class EmptyInputAndEmptyOutput
    {
        /// <summary>
        /// Clients should not serialize a JSON payload when no parameters
        /// are given that are sent in the body. A service will tolerate
        /// clients that omit a payload or that send a JSON object.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonEmptyInputAndEmptyOutputRequest()
        {
            // Arrange
            var request = new EmptyInputAndEmptyOutputRequest
            {
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new EmptyInputAndEmptyOutputRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/EmptyInputAndEmptyOutput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
        }

        /// <summary>
        /// As of January 2021, server implementations are expected to
        /// respond with a JSON object regardless of if the output parameters
        /// are empty.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonEmptyInputAndEmptyOutputResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new EmptyInputAndEmptyOutputResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new EmptyInputAndEmptyOutputResponse
            {
            };

            // Assert
            var actualResponse = (EmptyInputAndEmptyOutputResponse)unmarshalledResponse;
            Comparer.CompareObjects<EmptyInputAndEmptyOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// This test ensures that clients can gracefully handle situations
        /// where a service omits a JSON payload entirely.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonEmptyInputAndEmptyOutputJsonObjectOutputResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new EmptyInputAndEmptyOutputResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new EmptyInputAndEmptyOutputResponse
            {
            };

            // Assert
            var actualResponse = (EmptyInputAndEmptyOutputResponse)unmarshalledResponse;
            Comparer.CompareObjects<EmptyInputAndEmptyOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
