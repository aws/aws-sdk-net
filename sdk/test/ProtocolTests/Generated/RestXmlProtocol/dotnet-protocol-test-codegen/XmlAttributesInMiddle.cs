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
    public class XmlAttributesInMiddle
    {
        /// <summary>
        /// Serializes XML attributes on a payload when the xmlAttribute
        /// trait targets a member in the middle of the member list
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void XmlAttributesInMiddleRequest()
        {
            // Arrange
            var request = new XmlAttributesInMiddleRequest
            {
                Payload = new XmlAttributesInMiddlePayloadRequest
                {
                    Foo = "Foo",
                    Attr = "attributeValue",
                    Baz = "Baz",
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new XmlAttributesInMiddleRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<XmlAttributesInMiddlePayloadRequest test=\"attributeValue\">\n    <foo>Foo</foo>\n    <baz>Baz</baz>\n</XmlAttributesInMiddlePayloadRequest>\n";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/XmlAttributesInMiddle", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes XML attributes on a payload when the xmlAttribute
        /// trait targets a member in the middle of the member list
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void XmlAttributesInMiddleResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlAttributesInMiddlePayloadResponse test=\"attributeValue\">\n    <foo>Foo</foo>\n    <baz>Baz</baz>\n</XmlAttributesInMiddlePayloadResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlAttributesInMiddleResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlAttributesInMiddleResponse
            {
                Payload = new XmlAttributesInMiddlePayloadResponse
                {
                    Foo = "Foo",
                    Attr = "attributeValue",
                    Baz = "Baz",
                },
            };

            // Assert
            var actualResponse = (XmlAttributesInMiddleResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlAttributesInMiddleResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
