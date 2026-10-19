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
using Amazon.RestXmlProtocolNamespace;
using Amazon.RestXmlProtocolNamespace.Model;
using Amazon.RestXmlProtocolNamespace.Model.Internal.MarshallTransformations;
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
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXmlWithNamespace
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
        [TestCategory("RestXmlWithNamespace")]
        public async Task XmlNamespaceSimpleScalarPropertiesRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                Foo = "Foo",
                StringValue = "string",
                TrueBooleanValue = true,
                FalseBooleanValue = false,
                ByteValue = 1,
                ShortValue = 2,
                IntegerValue = 3,
                LongValue = 4,
                FloatValue = 5.5F,
                DoubleValue = 6.5,
                Nested = new NestedWithNamespace
                {
                    AttrField = "nestedAttrValue",
                },
            };
            var config = new AmazonRestXmlProtocolNamespaceConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestXmlProtocolNamespaceClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.SimpleScalarPropertiesAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "<SimpleScalarPropertiesRequest xmlns=\"https://example.com\">\n    <stringValue>string</stringValue>\n    <trueBooleanValue>true</trueBooleanValue>\n    <falseBooleanValue>false</falseBooleanValue>\n    <byteValue>1</byteValue>\n    <shortValue>2</shortValue>\n    <integerValue>3</integerValue>\n    <longValue>4</longValue>\n    <floatValue>5.5</floatValue>\n    <DoubleDribble>6.5</DoubleDribble>\n    <Nested xmlns:xsi=\"https://example.com\" xsi:someName=\"nestedAttrValue\"></Nested>\n</SimpleScalarPropertiesRequest>\n";
            XmlTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/xml".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("Foo".Replace(" ",""), actualRequest.Headers["X-Foo"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXmlWithNamespace")]
        public async Task XmlNamespaceSimpleScalarPropertiesResponse()
        {
            // Arrange
            var config = new AmazonRestXmlProtocolNamespaceConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestXmlProtocolNamespaceClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<SimpleScalarPropertiesResponse xmlns=\"https://example.com\">\n    <stringValue>string</stringValue>\n    <trueBooleanValue>true</trueBooleanValue>\n    <falseBooleanValue>false</falseBooleanValue>\n    <byteValue>1</byteValue>\n    <shortValue>2</shortValue>\n    <integerValue>3</integerValue>\n    <longValue>4</longValue>\n    <floatValue>5.5</floatValue>\n    <DoubleDribble>6.5</DoubleDribble>\n    <Nested xmlns:xsi=\"https://example.com\" xsi:someName=\"nestedAttrValue\"></Nested>\n</SimpleScalarPropertiesResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "application/xml";
            mockResponse.Headers["X-Foo"] = "Foo";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.SimpleScalarPropertiesAsync(new SimpleScalarPropertiesRequest()).ConfigureAwait(false);
            var expectedResponse = new SimpleScalarPropertiesResponse
            {
                Foo = "Foo",
                StringValue = "string",
                TrueBooleanValue = true,
                FalseBooleanValue = false,
                ByteValue = 1,
                ShortValue = 2,
                IntegerValue = 3,
                LongValue = 4,
                FloatValue = 5.5F,
                DoubleValue = 6.5,
                Nested = new NestedWithNamespace
                {
                    AttrField = "nestedAttrValue",
                },
            };

            // Assert
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
