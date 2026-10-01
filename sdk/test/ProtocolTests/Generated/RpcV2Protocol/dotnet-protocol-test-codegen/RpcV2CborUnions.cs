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
    public class RpcV2CborUnions
    {
        /// <summary>
        /// Serializes a union followed by another structure member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesUnionValueRequest()
        {
            // Arrange
            var request = new RpcV2CborUnionsRequest
            {
                Contents = new RpcV2CborUnion{
                    StringValue = "foo"
                },
                OtherValue = "bar",
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "omhjb250ZW50c6Frc3RyaW5nVmFsdWVjZm9vam90aGVyVmFsdWVjYmFy";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborUnions", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a nested union followed by another structure member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesNestedUnionValueRequest()
        {
            // Arrange
            var request = new RpcV2CborUnionsRequest
            {
                Contents = new RpcV2CborUnion{
                    UnionValue = new RpcV2CborNestedUnion{
                        StringValue = "foo"
                    }
                },
                OtherValue = "bar",
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "omhjb250ZW50c6FqdW5pb25WYWx1ZaFrc3RyaW5nVmFsdWVjZm9vam90aGVyVmFsdWVjYmFy";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborUnions", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes a tagged union followed by another structure member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("omhjb250ZW50c6Frc3RyaW5nVmFsdWVjZm9vam90aGVyVmFsdWVjYmFy");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborUnionsResponse
            {
                Contents = new RpcV2CborUnion{
                    StringValue = "foo"
                },
                OtherValue = "bar",
            };

            // Assert
            var actualResponse = (RpcV2CborUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a nested union followed by another structure member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesNestedUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("omhjb250ZW50c6FqdW5pb25WYWx1ZaFrc3RyaW5nVmFsdWVjZm9vam90aGVyVmFsdWVjYmFy");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborUnionsResponse
            {
                Contents = new RpcV2CborUnion{
                    UnionValue = new RpcV2CborNestedUnion{
                        StringValue = "foo"
                    }
                },
                OtherValue = "bar",
            };

            // Assert
            var actualResponse = (RpcV2CborUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
