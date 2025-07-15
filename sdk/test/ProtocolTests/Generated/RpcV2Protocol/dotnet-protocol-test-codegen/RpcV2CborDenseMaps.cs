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
    public class RpcV2CborDenseMaps
    {
        /// <summary>
        /// Serializes maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborMapsRequest()
        {
            // Arrange
            var request = new RpcV2CborDenseMapsRequest
            {
                DenseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborDenseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "oW5kZW5zZVN0cnVjdE1hcKJjZm9voWJoaWV0aGVyZWNiYXqhYmhpY2J5ZQ==";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborDenseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Ensure that 0 and false are sent over the wire in all maps and
        /// lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesZeroValuesInMapsRequest()
        {
            // Arrange
            var request = new RpcV2CborDenseMapsRequest
            {
                DenseNumberMap = new Dictionary<string, int>()
                {

                    { "x", 0 },
                },
                DenseBooleanMap = new Dictionary<string, bool>()
                {

                    { "x", false },
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborDenseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "om5kZW5zZU51bWJlck1hcKFheABvZGVuc2VCb29sZWFuTWFwoWF49A==";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborDenseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// A request that contains a dense map of sets.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesDenseSetMapRequest()
        {
            // Arrange
            var request = new RpcV2CborDenseMapsRequest
            {
                DenseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborDenseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "oWtkZW5zZVNldE1hcKJheIBheYJhYWFi";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborDenseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborMapsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oW5kZW5zZVN0cnVjdE1hcKJjZm9voWJoaWV0aGVyZWNiYXqhYmhpY2J5ZQ==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborDenseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborDenseMapsResponse
            {
                DenseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborDenseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborDenseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensure that 0 and false are sent over the wire in all maps and
        /// lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesZeroValuesInMapsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("om5kZW5zZU51bWJlck1hcKFheABvZGVuc2VCb29sZWFuTWFwoWF49A==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborDenseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborDenseMapsResponse
            {
                DenseNumberMap = new Dictionary<string, int>()
                {

                    { "x", 0 },
                },
                DenseBooleanMap = new Dictionary<string, bool>()
                {

                    { "x", false },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborDenseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborDenseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// A response that contains a dense map of sets
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesDenseSetMapResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWtkZW5zZVNldE1hcKJheIBheYJhYWFi");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborDenseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborDenseMapsResponse
            {
                DenseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborDenseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborDenseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Clients SHOULD tolerate seeing a null value in a dense map, and
        /// they SHOULD drop the null key-value pair.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesDenseSetMapAndSkipsNullResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWtkZW5zZVNldE1hcKNheIBheYJhYWFiYXr2");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborDenseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborDenseMapsResponse
            {
                DenseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborDenseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborDenseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
