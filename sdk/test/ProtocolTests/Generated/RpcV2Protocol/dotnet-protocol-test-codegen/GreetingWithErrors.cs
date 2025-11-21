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
    public class GreetingWithErrors
    {
        /// <summary>
        /// Parses simple RpcV2 Cbor errors
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborInvalidGreetingErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v2ZfX3R5cGV4LnNtaXRoeS5wcm90b2NvbHRlc3RzLnJwY3YyQ2JvciNJbnZhbGlkR3JlZXRpbmdnTWVzc2FnZWJIaf8=");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(InvalidGreetingException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

        /// <summary>
        /// Parses a complex error with no message member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborComplexErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v2ZfX3R5cGV4K3NtaXRoeS5wcm90b2NvbHRlc3RzLnJwY3YyQ2JvciNDb21wbGV4RXJyb3JoVG9wTGV2ZWxpVG9wIGxldmVsZk5lc3RlZL9jRm9vY2Jhcv//");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(ComplexErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborEmptyComplexErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/cbor";
            webResponseData.Headers["smithy-protocol"] = "rpc-v2-cbor";
            byte[] bytes = Convert.FromBase64String("v2ZfX3R5cGV4K3NtaXRoeS5wcm90b2NvbHRlc3RzLnJwY3YyQ2JvciNDb21wbGV4RXJyb3L/");
            var stream = new MemoryStream(bytes);
            var context = new CborUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(ComplexErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

    }
}
