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
    public class RecursiveShapes
    {
        /// <summary>
        /// Serializes recursive structures
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborRecursiveShapesRequest()
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
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RecursiveShapesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2ZuZXN0ZWS/Y2Zvb2RGb28xZm5lc3RlZL9jYmFyZEJhcjFvcmVjdXJzaXZlTWVtYmVyv2Nmb29kRm9vMmZuZXN0ZWS/Y2JhcmRCYXIy//////8=";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RecursiveShapes", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes recursive structures
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborRecursiveShapesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v2ZuZXN0ZWS/Y2Zvb2RGb28xZm5lc3RlZL9jYmFyZEJhcjFvcmVjdXJzaXZlTWVtYmVyv2Nmb29kRm9vMmZuZXN0ZWS/Y2JhcmRCYXIy//////8=");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

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

        /// <summary>
        /// Deserializes recursive structures encoded using a map with
        /// definite length
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborRecursiveShapesUsingDefiniteLengthResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWZuZXN0ZWSiY2Zvb2RGb28xZm5lc3RlZKJjYmFyZEJhcjFvcmVjdXJzaXZlTWVtYmVyomNmb29kRm9vMmZuZXN0ZWShY2JhcmRCYXIy");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

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
