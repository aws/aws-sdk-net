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
using AWSSDK.Extensions.CborProtocol.Internal;
using AWSSDK.ProtocolTests;
using AWSSDK.ProtocolTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
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
using System.Text;

namespace AWSSDK.ProtocolTests.RpcV2Protocol
{
    [TestClass]
    public class SimpleScalarProperties
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSimpleScalarPropertiesRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                ByteValue = 5,
                DoubleValue = 1.889,
                FalseBooleanValue = false,
                FloatValue = 7.625F,
                IntegerValue = 256,
                LongValue = 9873,
                ShortValue = 9898,
                StringValue = "simple",
                TrueBooleanValue = true,
                BlobValue = new MemoryStream(Encoding.UTF8.GetBytes("foo")),
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2lieXRlVmFsdWUFa2RvdWJsZVZhbHVl+z/+OVgQYk3TcWZhbHNlQm9vbGVhblZhbHVl9GpmbG9hdFZhbHVl+kD0AABsaW50ZWdlclZhbHVlGQEAaWxvbmdWYWx1ZRkmkWpzaG9ydFZhbHVlGSaqa3N0cmluZ1ZhbHVlZnNpbXBsZXB0cnVlQm9vbGVhblZhbHVl9WlibG9iVmFsdWVDZm9v/w==";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// RpcV2 Cbor should not serialize null structure values
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborClientDoesntSerializeNullStructureValuesRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                StringValue = null,
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v/8=";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling NaN float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSupportsNaNFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                DoubleValue = double.NaN,
                FloatValue = float.NaN,
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2tkb3VibGVWYWx1Zft/+AAAAAAAAGpmbG9hdFZhbHVl+n/AAAD/";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSupportsInfinityFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                DoubleValue = double.PositiveInfinity,
                FloatValue = float.PositiveInfinity,
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2tkb3VibGVWYWx1Zft/8AAAAAAAAGpmbG9hdFZhbHVl+n+AAAD/";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborSupportsNegativeInfinityFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                DoubleValue = double.NegativeInfinity,
                FloatValue = float.NegativeInfinity,
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2tkb3VibGVWYWx1Zfv/8AAAAAAAAGpmbG9hdFZhbHVl+v+AAAD/";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

    }
}
