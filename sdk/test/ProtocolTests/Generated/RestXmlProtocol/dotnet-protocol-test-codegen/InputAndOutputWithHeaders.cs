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
    public class InputAndOutputWithHeaders
    {
        /// <summary>
        /// Tests requests with string header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithStringHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderString = "Hello",
                HeaderStringList =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
                HeaderStringSet =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Hello".Replace(" ",""), marshalledRequest.Headers["X-String"].Replace(" ",""));
            Assert.AreEqual("a, b, c".Replace(" ",""), marshalledRequest.Headers["X-StringList"].Replace(" ",""));
            Assert.AreEqual("a, b, c".Replace(" ",""), marshalledRequest.Headers["X-StringSet"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with numeric header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithNumericHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderByte = 1,
                HeaderShort = 123,
                HeaderInteger = 123,
                HeaderLong = 123,
                HeaderFloat = 1.1F,
                HeaderDouble = 1.1,
                HeaderIntegerList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("1".Replace(" ",""), marshalledRequest.Headers["X-Byte"].Replace(" ",""));
            Assert.AreEqual("1.1".Replace(" ",""), marshalledRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("1.1".Replace(" ",""), marshalledRequest.Headers["X-Float"].Replace(" ",""));
            Assert.AreEqual("123".Replace(" ",""), marshalledRequest.Headers["X-Integer"].Replace(" ",""));
            Assert.AreEqual("1, 2, 3".Replace(" ",""), marshalledRequest.Headers["X-IntegerList"].Replace(" ",""));
            Assert.AreEqual("123".Replace(" ",""), marshalledRequest.Headers["X-Long"].Replace(" ",""));
            Assert.AreEqual("123".Replace(" ",""), marshalledRequest.Headers["X-Short"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with boolean header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithBooleanHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderTrueBool = true,
                HeaderFalseBool = false,
                HeaderBooleanList =  new List<bool>()
                {
                    true,
                    false,
                    true,
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("true".Replace(" ",""), marshalledRequest.Headers["X-Boolean1"].Replace(" ",""));
            Assert.AreEqual("false".Replace(" ",""), marshalledRequest.Headers["X-Boolean2"].Replace(" ",""));
            Assert.AreEqual("true, false, true".Replace(" ",""), marshalledRequest.Headers["X-BooleanList"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with timestamp header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithTimestampHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderTimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT".Replace(" ",""), marshalledRequest.Headers["X-TimestampList"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with enum header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithEnumHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderEnum = "Foo",
                HeaderEnumList =  new List<string>()
                {
                    "Foo",
                    "Bar",
                    "Baz",
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Foo".Replace(" ",""), marshalledRequest.Headers["X-Enum"].Replace(" ",""));
            Assert.AreEqual("Foo, Bar, Baz".Replace(" ",""), marshalledRequest.Headers["X-EnumList"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling NaN float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsNaNFloatHeaderInputsRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderFloat = float.NaN,
                HeaderDouble = double.NaN,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("NaN".Replace(" ",""), marshalledRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("NaN".Replace(" ",""), marshalledRequest.Headers["X-Float"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsInfinityFloatHeaderInputsRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderFloat = float.PositiveInfinity,
                HeaderDouble = double.PositiveInfinity,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Infinity".Replace(" ",""), marshalledRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("Infinity".Replace(" ",""), marshalledRequest.Headers["X-Float"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling -Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsNegativeInfinityFloatHeaderInputsRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderFloat = float.NegativeInfinity,
                HeaderDouble = double.NegativeInfinity,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new InputAndOutputWithHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("-Infinity".Replace(" ",""), marshalledRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("-Infinity".Replace(" ",""), marshalledRequest.Headers["X-Float"].Replace(" ",""));
        }

        /// <summary>
        /// Tests responses with string header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithStringHeadersResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-String"] = "Hello";
            webResponseData.Headers["X-StringList"] = "a, b, c";
            webResponseData.Headers["X-StringSet"] = "a, b, c";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderString = "Hello",
                HeaderStringList =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
                HeaderStringSet =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Tests responses with numeric header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithNumericHeadersResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Byte"] = "1";
            webResponseData.Headers["X-Double"] = "1.1";
            webResponseData.Headers["X-Float"] = "1.1";
            webResponseData.Headers["X-Integer"] = "123";
            webResponseData.Headers["X-IntegerList"] = "1, 2, 3";
            webResponseData.Headers["X-Long"] = "123";
            webResponseData.Headers["X-Short"] = "123";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderByte = 1,
                HeaderShort = 123,
                HeaderInteger = 123,
                HeaderLong = 123,
                HeaderFloat = 1.1F,
                HeaderDouble = 1.1,
                HeaderIntegerList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Tests responses with boolean header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithBooleanHeadersResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Boolean1"] = "true";
            webResponseData.Headers["X-Boolean2"] = "false";
            webResponseData.Headers["X-BooleanList"] = "true, false, true";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderTrueBool = true,
                HeaderFalseBool = false,
                HeaderBooleanList =  new List<bool>()
                {
                    true,
                    false,
                    true,
                },
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Tests responses with timestamp header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithTimestampHeadersResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-TimestampList"] = "Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderTimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                },
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Tests responses with enum header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void InputAndOutputWithEnumHeadersResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Enum"] = "Foo";
            webResponseData.Headers["X-EnumList"] = "Foo, Bar, Baz";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderEnum = "Foo",
                HeaderEnumList =  new List<string>()
                {
                    "Foo",
                    "Bar",
                    "Baz",
                },
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Supports handling NaN float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsNaNFloatHeaderOutputsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Double"] = "NaN";
            webResponseData.Headers["X-Float"] = "NaN";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderFloat = float.NaN,
                HeaderDouble = double.NaN,
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Supports handling Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsInfinityFloatHeaderOutputsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Double"] = "Infinity";
            webResponseData.Headers["X-Float"] = "Infinity";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderFloat = float.PositiveInfinity,
                HeaderDouble = double.PositiveInfinity,
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Supports handling -Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsNegativeInfinityFloatHeaderOutputsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Double"] = "-Infinity";
            webResponseData.Headers["X-Float"] = "-Infinity";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new InputAndOutputWithHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderFloat = float.NegativeInfinity,
                HeaderDouble = double.NegativeInfinity,
            };

            // Assert
            var actualResponse = (InputAndOutputWithHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
