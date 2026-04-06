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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Text;

namespace AWSSDK.UnitTests.Custom.Marshalling
{
    [TestClass]
    public class ErrorUnmarshallingTests
    {
        private const string UnstructuredText = "not valid json or xml";
        private const string ValidJson = "{\"__type\":\"type\",\"message\":\"message\",\"code\":\"code\",\"ignore\":\"ignore\"}";
        private const string InvalidJson = "{\"__type\":\"type\",[[[break parsing before all properties can be read]]]\"message\":\"message\",\"code\":\"code\",\"ignore\":\"ignore\"}";
        private const string ValidJsonNoCodeOrType = "{\"message\":\"message\"}";
        private const string ValidXml = "<Response><RequestId>xmlRequestId</RequestId><Error><Code>ServiceUnavailable</Code><Type>Receiver</Type>" +
            "<Message>xmlMessage</Message></Error></Response>";
        private const string InvalidXmlMissesTypeAndMessage = "<Response><RequestId>xmlRequestId</RequestId><Error><Code>ServiceUnavailable</Code><Type>Receiver" +
            "</Type[[[break parsing before all properties can be read]]]><Message>xmlMessage</Message></Error></Response>";
        private const string InvalidXmlMissesCodeAndTypeAndMessage = "<Response><RequestId>xmlRequestId</RequestId><Error><Code>ServiceUnavailable</Code[[[break parsing before all properties can be read]]]><Type>Receiver" +
            "</Type><Message>xmlMessage</Message></Error></Response>";
        private const string HtmlProxyErrorPage = "<html><body>test<div>test</div>test</body></html>";

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorValidJson()
        {
            RunJsonErrorUnmarshallingTest(ValidJson, null, null, "message", "type", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorInvalidJson()
        {
            RunJsonErrorUnmarshallingTest(InvalidJson, null, null, "The service returned an error with Error Code type and HTTP Body: " + InvalidJson, "type", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorDetectsXmlBody()
        {
            RunJsonErrorUnmarshallingTest(ValidXml, null, null, "xmlMessage", "ServiceUnavailable", ErrorType.Receiver);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorValidJsonHeaderMessageTakesPrecedence()
        {
            RunJsonErrorUnmarshallingTest(ValidJson, null, "header_message", "header_message", "type", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorValidJsonHeaderCodeIfNoJsonCodeOrType()
        {
            RunJsonErrorUnmarshallingTest(ValidJsonNoCodeOrType, "header_type", null, "message", "header_type", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorInvalidJsonNoBodyNoType()
        {
            RunJsonErrorUnmarshallingTest(null, null, null, "The service returned an error. See inner exception for details.", null, ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorInvalidJsonWithBodyNoType()
        {
            RunJsonErrorUnmarshallingTest(UnstructuredText, null, null, "The service returned an error with HTTP Body: " + UnstructuredText, null, ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorInvalidJsonNoBodyWithType()
        {
            RunJsonErrorUnmarshallingTest(null, "type", null, "The service returned an error with Error Code type.", "type", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorInvalidJsonWithBodyAndType()
        {
            RunJsonErrorUnmarshallingTest(UnstructuredText, "type", null, "The service returned an error with Error Code type and HTTP Body: " + UnstructuredText, "type", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalXmlErrorValidXml()
        {
            RunXmlErrorUnmarshallingTest(ValidXml, "xmlMessage", "ServiceUnavailable", ErrorType.Receiver);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalXmlErrorInvalidXmlNoTypeNoMessage()
        {
            RunXmlErrorUnmarshallingTest(InvalidXmlMissesTypeAndMessage, "The service returned an error with Error Code ServiceUnavailable and HTTP Body: " + InvalidXmlMissesTypeAndMessage, "ServiceUnavailable", ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalXmlErrorInvalidXmlNoCodeNoTypeNoMessage()
        {
            RunXmlErrorUnmarshallingTest(InvalidXmlMissesCodeAndTypeAndMessage, "The service returned an error with HTTP Body: " + InvalidXmlMissesCodeAndTypeAndMessage, null, ErrorType.Unknown);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalXmlErrorNoBody()
        {
            RunXmlErrorUnmarshallingTest(null, "The service returned an error. See inner exception for details.", null, ErrorType.Unknown);
        }

        /// <summary>
        /// Regression test for https://github.com/aws/aws-sdk-net/issues/4346
        /// Previously this caused an infinite loop in XmlUnmarshallerContext.Read() because the 
        /// switch had no default case to advance past XmlNodeType.Text nodes.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalXmlErrorHtmlProxyResponseDoesNotInfiniteLoop()
        {
            // The test simply asserts it completes (no infinite loop) and returns a fallback message.
            var response = GetXmlErrorResponse(HtmlProxyErrorPage);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Message);
            Assert.AreEqual(ErrorType.Unknown, response.Type);
        }

        /// <summary>
        /// Regression test for https://github.com/aws/aws-sdk-net/issues/4346 via the JSON path.
        /// JsonErrorResponseUnmarshaller detects the leading '&lt;' and delegates to XmlErrorResponseUnmarshaller.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        public void UnmarshalJsonErrorHtmlProxyResponseDoesNotInfiniteLoop()
        {
            // The test simply asserts it completes (no infinite loop) and returns a fallback message.
            var response = GetJsonErrorResponse(HtmlProxyErrorPage, null, null);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Message);
            Assert.AreEqual(ErrorType.Unknown, response.Type);
        }

        private void RunJsonErrorUnmarshallingTest(string body, string xAmzErrorTypeValue, string xAmznErrorMessageValue,
            string expectedMessage, string expectedCode, ErrorType expectedType)
        {
            var response = GetJsonErrorResponse(body, xAmzErrorTypeValue, xAmznErrorMessageValue);
            Assert.AreEqual(expectedMessage, response.Message);
            Assert.AreEqual(expectedCode, response.Code);
            Assert.AreEqual(expectedType, response.Type);
        }

        private ErrorResponse GetJsonErrorResponse(string body, string xAmzErrorTypeValue, string xAmznErrorMessageValue)
        {
            body = body ?? string.Empty;
            var webResponse = new WebResponseData
            {
                StatusCode = HttpStatusCode.ServiceUnavailable,
            };

            if (xAmzErrorTypeValue != null)
                webResponse.Headers.Add(HeaderKeys.XAmzErrorType, xAmzErrorTypeValue);

            if (xAmznErrorMessageValue != null)
                webResponse.Headers.Add(HeaderKeys.XAmznErrorMessage, xAmznErrorMessageValue);

            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(body).Length.ToString());

            var stream = AWSSDK_DotNet.UnitTests.Utils.CreateStreamFromString(body);
            var context = new JsonUnmarshallerContext(stream, true, webResponse);
            var reader = new StreamingUtf8JsonReader(context.Stream);
            return new JsonErrorResponseUnmarshaller().Unmarshall(context, ref reader);
        }

        private void RunXmlErrorUnmarshallingTest(string body, string expectedMessage, string expectedCode, ErrorType expectedType)
        {
            var response = GetXmlErrorResponse(body);
            Assert.AreEqual(expectedMessage, response.Message);
            Assert.AreEqual(expectedCode, response.Code);
            Assert.AreEqual(expectedType, response.Type);
        }

        private ErrorResponse GetXmlErrorResponse(string body)
        {
            body = body == null ? string.Empty : body;
            var webResponse = new WebResponseData
            {
                StatusCode = HttpStatusCode.ServiceUnavailable,
            };

            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(body).Length.ToString());

            var context = new XmlUnmarshallerContext(AWSSDK_DotNet.UnitTests.Utils.CreateStreamFromString(body), true, webResponse);
            return new XmlErrorResponseUnmarshaller().Unmarshall(context);
        }
    }
}
