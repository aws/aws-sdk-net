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
    public class XmlMapsXmlName
    {
        /// <summary>
        /// Serializes XML maps that have xmlName on members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void XmlMapsXmlNameRequest()
        {
            // Arrange
            var request = new XmlMapsXmlNameRequest
            {
                MyMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new XmlMapsXmlNameRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<XmlMapsXmlNameRequest>\n    <myMap>\n        <entry>\n            <Attribute>foo</Attribute>\n            <Setting>\n                <hi>there</hi>\n            </Setting>\n        </entry>\n        <entry>\n            <Attribute>baz</Attribute>\n            <Setting>\n                <hi>bye</hi>\n            </Setting>\n        </entry>\n    </myMap>\n</XmlMapsXmlNameRequest>\n";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/XmlMapsXmlName", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes XML lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void XmlMapsXmlNameResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlMapsXmlNameResponse>\n    <myMap>\n        <entry>\n            <Attribute>foo</Attribute>\n            <Setting>\n                <hi>there</hi>\n            </Setting>\n        </entry>\n        <entry>\n            <Attribute>baz</Attribute>\n            <Setting>\n                <hi>bye</hi>\n            </Setting>\n        </entry>\n    </myMap>\n</XmlMapsXmlNameResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlMapsXmlNameResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlMapsXmlNameResponse
            {
                MyMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };

            // Assert
            var actualResponse = (XmlMapsXmlNameResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlMapsXmlNameResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
