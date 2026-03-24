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
    public class RpcV2CborSparseMaps
    {
        /// <summary>
        /// Serializes sparse maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSparseMapsRequest()
        {
            // Arrange
            var request = new RpcV2CborSparseMapsRequest
            {
                SparseStructMap = new Dictionary<string, GreetingStruct>()
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

            var marshaller = new RpcV2CborSparseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v29zcGFyc2VTdHJ1Y3RNYXC/Y2Zvb79iaGlldGhlcmX/Y2Jher9iaGljYnll////";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborSparseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes null map values in sparse maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesNullMapValuesRequest()
        {
            // Arrange
            var request = new RpcV2CborSparseMapsRequest
            {
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", null },
                },
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", null },
                },
                SparseStringMap = new Dictionary<string, string>()
                {

                    { "x", null },
                },
                SparseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "x", null },
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborSparseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v3BzcGFyc2VCb29sZWFuTWFwv2F49v9vc3BhcnNlTnVtYmVyTWFwv2F49v9vc3BhcnNlU3RyaW5nTWFwv2F49v9vc3BhcnNlU3RydWN0TWFwv2F49v//";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborSparseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// A request that contains a sparse map of sets
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesSparseSetMapRequest()
        {
            // Arrange
            var request = new RpcV2CborSparseMapsRequest
            {
                SparseSetMap = new Dictionary<string, List<string>>()
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

            var marshaller = new RpcV2CborSparseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2xzcGFyc2VTZXRNYXC/YXif/2F5n2FhYWL///8=";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborSparseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// A request that contains a sparse map of sets.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSerializesSparseSetMapAndRetainsNullRequest()
        {
            // Arrange
            var request = new RpcV2CborSparseMapsRequest
            {
                SparseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
                    { "z", null },
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborSparseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2xzcGFyc2VTZXRNYXC/YXif/2F5n2FhYWL/YXr2//8=";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborSparseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
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
        public void RpcV2CborSerializesZeroValuesInSparseMapsRequest()
        {
            // Arrange
            var request = new RpcV2CborSparseMapsRequest
            {
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", 0 },
                },
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", false },
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborSparseMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v29zcGFyc2VOdW1iZXJNYXC/YXgA/3BzcGFyc2VCb29sZWFuTWFwv2F49P//";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborSparseMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes sparse maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSparseJsonMapsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v29zcGFyc2VTdHJ1Y3RNYXC/Y2Zvb79iaGlldGhlcmX/Y2Jher9iaGljYnll////");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborSparseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborSparseMapsResponse
            {
                SparseStructMap = new Dictionary<string, GreetingStruct>()
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
            var actualResponse = (RpcV2CborSparseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborSparseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes null map values
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesNullMapValuesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v3BzcGFyc2VCb29sZWFuTWFwv2F49v9vc3BhcnNlTnVtYmVyTWFwv2F49v9vc3BhcnNlU3RyaW5nTWFwv2F49v9vc3BhcnNlU3RydWN0TWFwv2F49v//");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborSparseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborSparseMapsResponse
            {
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", null },
                },
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", null },
                },
                SparseStringMap = new Dictionary<string, string>()
                {

                    { "x", null },
                },
                SparseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "x", null },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborSparseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborSparseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// A response that contains a sparse map of sets
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesSparseSetMapResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v2xzcGFyc2VTZXRNYXC/YXmfYWFhYv9heJ////8=");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborSparseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborSparseMapsResponse
            {
                SparseSetMap = new Dictionary<string, List<string>>()
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
            var actualResponse = (RpcV2CborSparseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborSparseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// A response that contains a sparse map of sets with a null
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborDeserializesSparseSetMapAndRetainsNullResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v2xzcGFyc2VTZXRNYXC/YXif/2F5n2FhYWL/YXr2//8=");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborSparseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborSparseMapsResponse
            {
                SparseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
                    { "z", null },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborSparseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborSparseMapsResponse>(expectedResponse,actualResponse);
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
        public void RpcV2CborDeserializesZeroValuesInSparseMapsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v29zcGFyc2VOdW1iZXJNYXC/YXgA/3BzcGFyc2VCb29sZWFuTWFwv2F49P//");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RpcV2CborSparseMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RpcV2CborSparseMapsResponse
            {
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", 0 },
                },
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", false },
                },
            };

            // Assert
            var actualResponse = (RpcV2CborSparseMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<RpcV2CborSparseMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
