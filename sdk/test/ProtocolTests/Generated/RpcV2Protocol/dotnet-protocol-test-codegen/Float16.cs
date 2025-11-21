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
    public class Float16
    {
        /// <summary>
        /// Ensures that clients can correctly parse float16 +Inf.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborFloat16InfResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWV2YWx1Zfl8AA==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new Float16ResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new Float16Response
            {
                Value = double.PositiveInfinity,
            };

            // Assert
            var actualResponse = (Float16Response)unmarshalledResponse;
            Comparer.CompareObjects<Float16Response>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that clients can correctly parse float16 -Inf.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborFloat16NegInfResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWV2YWx1Zfn8AA==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new Float16ResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new Float16Response
            {
                Value = double.NegativeInfinity,
            };

            // Assert
            var actualResponse = (Float16Response)unmarshalledResponse;
            Comparer.CompareObjects<Float16Response>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that clients can correctly parse float16 NaN with high
        /// LSB.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborFloat16LSBNaNResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWV2YWx1Zfl8AQ==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new Float16ResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new Float16Response
            {
                Value = double.NaN,
            };

            // Assert
            var actualResponse = (Float16Response)unmarshalledResponse;
            Comparer.CompareObjects<Float16Response>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that clients can correctly parse float16 NaN with high
        /// MSB.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborFloat16MSBNaNResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWV2YWx1Zfl+AA==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new Float16ResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new Float16Response
            {
                Value = double.NaN,
            };

            // Assert
            var actualResponse = (Float16Response)unmarshalledResponse;
            Comparer.CompareObjects<Float16Response>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that clients can correctly parse a subnormal float16.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborFloat16SubnormalResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("oWV2YWx1ZfkAUA==");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new Float16ResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new Float16Response
            {
                Value = 4.76837158203125E-6,
            };

            // Assert
            var actualResponse = (Float16Response)unmarshalledResponse;
            Comparer.CompareObjects<Float16Response>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
