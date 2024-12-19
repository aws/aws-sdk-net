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
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.Custom.Marshalling
{
    [TestClass]
    public class ErrorUnmarshallingTests
    {
        static readonly ServiceModel DynmaoDBServiceModel = AWSSDK_DotNet.UnitTests.Utils.LoadServiceModel("dynamodb");

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
            var reader = new StreamingUtf8JsonReader(stream);
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
