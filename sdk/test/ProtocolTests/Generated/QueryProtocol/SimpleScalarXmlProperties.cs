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
using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon.QueryProtocol;
using Amazon.QueryProtocol.Model;
using Amazon.QueryProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.AwsQuery
{
    [TestClass]
    public class SimpleScalarXmlProperties
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        // This test requires a breaking change, and will be addressed in V4
        [Ignore]
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void QuerySimpleScalarPropertiesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<SimpleScalarXmlPropertiesResponse xmlns=\"https://example.com/\">\n    <SimpleScalarXmlPropertiesResult>\n        <stringValue>string</stringValue>\n        <emptyStringValue/>\n        <trueBooleanValue>true</trueBooleanValue>\n        <falseBooleanValue>false</falseBooleanValue>\n        <byteValue>1</byteValue>\n        <shortValue>2</shortValue>\n        <integerValue>3</integerValue>\n        <longValue>4</longValue>\n        <floatValue>5.5</floatValue>\n        <DoubleDribble>6.5</DoubleDribble>\n    </SimpleScalarXmlPropertiesResult>\n</SimpleScalarXmlPropertiesResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SimpleScalarXmlPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarXmlPropertiesResponse
            {
                StringValue = "string",
                EmptyStringValue = "",
                TrueBooleanValue = true,
                FalseBooleanValue = false,
                ByteValue = 1,
                ShortValue = 2,
                IntegerValue = 3,
                LongValue = 4,
                FloatValue = 5.5F,
                DoubleValue = 6.5,
            };

            // Assert
            var actualResponse = (SimpleScalarXmlPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarXmlPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Supports handling NaN float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void AwsQuerySupportsNaNFloatOutputsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<SimpleScalarXmlPropertiesResponse xmlns=\"https://example.com/\">\n    <SimpleScalarXmlPropertiesResult>\n        <floatValue>NaN</floatValue>\n        <DoubleDribble>NaN</DoubleDribble>\n    </SimpleScalarXmlPropertiesResult>\n</SimpleScalarXmlPropertiesResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SimpleScalarXmlPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarXmlPropertiesResponse
            {
                FloatValue = float.NaN,
                DoubleValue = double.NaN,
            };

            // Assert
            var actualResponse = (SimpleScalarXmlPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarXmlPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Supports handling Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void AwsQuerySupportsInfinityFloatOutputsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<SimpleScalarXmlPropertiesResponse xmlns=\"https://example.com/\">\n    <SimpleScalarXmlPropertiesResult>\n        <floatValue>Infinity</floatValue>\n        <DoubleDribble>Infinity</DoubleDribble>\n    </SimpleScalarXmlPropertiesResult>\n</SimpleScalarXmlPropertiesResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SimpleScalarXmlPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarXmlPropertiesResponse
            {
                FloatValue = float.PositiveInfinity,
                DoubleValue = double.PositiveInfinity,
            };

            // Assert
            var actualResponse = (SimpleScalarXmlPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarXmlPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Supports handling -Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void AwsQuerySupportsNegativeInfinityFloatOutputsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<SimpleScalarXmlPropertiesResponse xmlns=\"https://example.com/\">\n    <SimpleScalarXmlPropertiesResult>\n        <floatValue>-Infinity</floatValue>\n        <DoubleDribble>-Infinity</DoubleDribble>\n    </SimpleScalarXmlPropertiesResult>\n</SimpleScalarXmlPropertiesResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SimpleScalarXmlPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarXmlPropertiesResponse
            {
                FloatValue = float.NegativeInfinity,
                DoubleValue = double.NegativeInfinity,
            };

            // Assert
            var actualResponse = (SimpleScalarXmlPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarXmlPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
