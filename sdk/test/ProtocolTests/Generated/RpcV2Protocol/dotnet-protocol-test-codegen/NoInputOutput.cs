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
using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.RpcV2Protocol;
using Amazon.RpcV2Protocol.Model;
using Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AWSSDK.ProtocolTests.RpcV2Protocol
{
    [TestClass]
    public class NoInputOutput
    {
        /// <summary>
        /// Body is empty and no Content-Type header if no input
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void no_inputRequest()
        {
            // Arrange
            var request = new NoInputOutputRequest
            {
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NoInputOutputRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/NoInputOutput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey("X-Amz-Target"));
        }

        /// <summary>
        /// A `Content-Type` header should not be set if the response body is
        /// empty.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void no_outputResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NoInputOutputResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new NoInputOutputResponse
            {
            };

            // Assert
            var actualResponse = (NoInputOutputResponse)unmarshalledResponse;
            Comparer.CompareObjects<NoInputOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Clients should accept a CBOR empty struct if there is no output.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void NoOutputClientAllowsEmptyCborResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v/8=");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NoInputOutputResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new NoInputOutputResponse
            {
            };

            // Assert
            var actualResponse = (NoInputOutputResponse)unmarshalledResponse;
            Comparer.CompareObjects<NoInputOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Clients should accept an empty body if there is no output and
        /// should not raise an error if the `Content-Type` header is set.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void NoOutputClientAllowsEmptyBodyResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NoInputOutputResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new NoInputOutputResponse
            {
            };

            // Assert
            var actualResponse = (NoInputOutputResponse)unmarshalledResponse;
            Comparer.CompareObjects<NoInputOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
