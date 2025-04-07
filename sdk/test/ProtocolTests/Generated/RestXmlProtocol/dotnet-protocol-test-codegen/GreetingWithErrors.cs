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
using Amazon.RestXmlProtocol;
using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
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
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class GreetingWithErrors
    {
        /// <summary>
        /// Ensures that operations with errors successfully know how to
        /// deserialize the successful response
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void GreetingWithErrorsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Greeting"] = "Hello";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new GreetingWithErrorsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new GreetingWithErrorsResponse
            {
                Greeting = "Hello",
            };

            // Assert
            var actualResponse = (GreetingWithErrorsResponse)unmarshalledResponse;
            Comparer.CompareObjects<GreetingWithErrorsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Parses simple XML errors
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestXml")]
        public void InvalidGreetingErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<ErrorResponse>\n   <Error>\n      <Type>Sender</Type>\n      <Code>InvalidGreeting</Code>\n      <Message>Hi</Message>\n      <AnotherSetting>setting</AnotherSetting>\n   </Error>\n   <RequestId>foo-id</RequestId>\n</ErrorResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(InvalidGreetingException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestXml")]
        public void ComplexErrorErrorResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403);
            webResponseData.Headers["Content-Type"] = "application/xml";
            webResponseData.Headers["X-Header"] = "Header";
            byte[] bytes = Encoding.ASCII.GetBytes("<ErrorResponse>\n   <Error>\n      <Type>Sender</Type>\n      <Code>ComplexError</Code>\n      <Message>Hi</Message>\n      <TopLevel>Top level</TopLevel>\n      <Nested>\n          <Foo>bar</Foo>\n      </Nested>\n   </Error>\n   <RequestId>foo-id</RequestId>\n</ErrorResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);
            // Act
            var errorResponse = new GreetingWithErrorsResponseUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403));
            // Assert
            Assert.IsInstanceOfType(errorResponse, typeof(ComplexErrorException));
            Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403));
        }

    }
}
