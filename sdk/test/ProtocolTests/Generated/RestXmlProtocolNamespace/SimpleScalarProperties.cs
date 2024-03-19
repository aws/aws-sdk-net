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
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXmlWithNamespace
{
    [TestClass]
    public class SimpleScalarProperties
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXmlWithNamespace")]
        public void XmlNamespaceSimpleScalarPropertiesRequest()
        {
            var request = new SimpleScalarPropertiesRequest{
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
                Nested = new NestedWithNamespace{
                    AttrField = "nestedAttrValue",
                },
            };
            var config = new AmazonRestXmlProtocolNamespaceConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);
            var expectedBody = "<SimpleScalarPropertiesInputOutput xmlns=\"https://example.com\">\n    <stringValue>string</stringValue>\n    <trueBooleanValue>true</trueBooleanValue>\n    <falseBooleanValue>false</falseBooleanValue>\n    <byteValue>1</byteValue>\n    <shortValue>2</shortValue>\n    <integerValue>3</integerValue>\n    <longValue>4</longValue>\n    <floatValue>5.5</floatValue>\n    <DoubleDribble>6.5</DoubleDribble>\n    <Nested xmlns:xsi=\"https://example.com\" xsi:someName=\"nestedAttrValue\"></Nested>\n</SimpleScalarPropertiesInputOutput>\n";
            XDocument actualDoc = XDocument.Parse(actualBody);
            XDocument expectedDoc = XDocument.Parse(expectedBody);
            Assert.IsTrue(XmlTestUtils.AreDocumentsEqual(expectedDoc, actualDoc));
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SimpleScalarProperties", actualUri.AbsolutePath);
            Assert.AreEqual( "application/xml", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "Foo", marshalledRequest.Headers["X-Foo"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXmlWithNamespace")]
        public void XmlNamespaceSimpleScalarPropertiesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("<SimpleScalarPropertiesInputOutput xmlns=\"https://example.com\">\n    <stringValue>string</stringValue>\n    <trueBooleanValue>true</trueBooleanValue>\n    <falseBooleanValue>false</falseBooleanValue>\n    <byteValue>1</byteValue>\n    <shortValue>2</shortValue>\n    <integerValue>3</integerValue>\n    <longValue>4</longValue>\n    <floatValue>5.5</floatValue>\n    <DoubleDribble>6.5</DoubleDribble>\n    <Nested xmlns:xsi=\"https://example.com\" xsi:someName=\"nestedAttrValue\"></Nested>\n</SimpleScalarPropertiesInputOutput>\n");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/xml";
            webResponseData.Headers["X-Foo"] = "Foo";
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new SimpleScalarPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarPropertiesResponse{
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
                Nested = new NestedWithNamespace{
                    AttrField = "nestedAttrValue",
                },
            };
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
            var actualResponse = (SimpleScalarPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
        }
    }
}
