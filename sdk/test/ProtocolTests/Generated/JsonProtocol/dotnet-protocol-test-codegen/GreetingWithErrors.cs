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
using Amazon.JsonProtocol;
using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.JsonProtocol
{
    [TestClass]
    public class GreetingWithErrors
    {
        /// <summary>
        /// Parses simple JSON errors
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11InvalidGreetingErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"InvalidGreeting\",\n    \"Message\": \"Hi\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11ComplexErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"ComplexError\",\n    \"TopLevel\": \"Top level\",\n    \"Nested\": {\n        \"Foo\": \"bar\"\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(ComplexErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11EmptyComplexErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"ComplexError\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(ComplexErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

        /// <summary>
        /// Serializes the X-Amzn-ErrorType header. For an example service,
        /// see Amazon EKS.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorUsingXAmznErrorTypeErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["X-Amzn-Errortype"] = "FooError";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// Some X-Amzn-Errortype headers contain URLs. Clients need to split
        /// the URL on ':' and take only the first half of the string. For
        /// example,
        /// 'ValidationException:http://internal.amazon.com/coral/com.amazon.coral.validate/'
        /// is to be interpreted as 'ValidationException'.  For an example
        /// service see Amazon Polly.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorUsingXAmznErrorTypeWithUriErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["X-Amzn-Errortype"] = "FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// X-Amzn-Errortype might contain a URL and a namespace. Client
        /// should extract only the shape name. This is a pathalogical case
        /// that might not actually happen in any deployed AWS service.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorUsingXAmznErrorTypeWithUriAndNamespaceErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["X-Amzn-Errortype"] = "aws.protocoltests.restjson#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// This example uses the 'code' property in the output rather than
        /// X-Amzn-Errortype. Some services do this though it's preferable to
        /// send the X-Amzn-Errortype. Client implementations must first
        /// check for the X-Amzn-Errortype and then check for a top-level
        /// 'code' property.  For example service see Amazon S3 Glacier.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorUsingCodeErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"code\": \"FooError\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// Some services serialize errors using code, and it might contain a
        /// namespace. Clients should just take the last part of the string
        /// after '#'.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorUsingCodeAndNamespaceErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"code\": \"aws.protocoltests.restjson#FooError\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// Some services serialize errors using code, and it might contain a
        /// namespace. It also might contain a URI. Clients should just take
        /// the last part of the string after '#' and before ":". This is a
        /// pathalogical case that might not occur in any deployed AWS
        /// service.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorUsingCodeUriAndNamespaceErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"code\": \"aws.protocoltests.restjson#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// Some services serialize errors using __type.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorWithDunderTypeErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"FooError\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// Some services serialize errors using __type, and it might contain
        /// a namespace. Clients should just take the last part of the string
        /// after '#'.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorWithDunderTypeAndNamespaceErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"aws.protocoltests.restjson#FooError\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

        /// <summary>
        /// Some services serialize errors using __type, and it might contain
        /// a namespace. It also might contain a URI. Clients should just
        /// take the last part of the string after '#' and before ":". This
        /// is a pathalogical case that might not occur in any deployed AWS
        /// service.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11FooErrorWithDunderTypeUriAndNamespaceErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"__type\": \"aws.protocoltests.restjson#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(FooErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500));
        }

    }
}
