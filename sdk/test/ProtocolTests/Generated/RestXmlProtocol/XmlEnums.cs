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
    public class XmlEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void XmlEnumsRequest()
        {
            // Arrange
            var request = new XmlEnumsRequest
            {
                FooEnum1 = "Foo",
                FooEnum2 = "0",
                FooEnum3 = "1",
                FooEnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                FooEnumSet =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                FooEnumMap = new Dictionary<string, string>()
                {

                    { "hi", "Foo" },
                    { "zero", "0" },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new XmlEnumsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<XmlEnumsRequest>\n    <fooEnum1>Foo</fooEnum1>\n    <fooEnum2>0</fooEnum2>\n    <fooEnum3>1</fooEnum3>\n    <fooEnumList>\n        <member>Foo</member>\n        <member>0</member>\n    </fooEnumList>\n    <fooEnumSet>\n        <member>Foo</member>\n        <member>0</member>\n    </fooEnumSet>\n    <fooEnumMap>\n        <entry>\n            <key>hi</key>\n            <value>Foo</value>\n        </entry>\n        <entry>\n            <key>zero</key>\n            <value>0</value>\n        </entry>\n    </fooEnumMap>\n</XmlEnumsRequest>\n";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/XmlEnums", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void XmlEnumsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlEnumsResponse>\n    <fooEnum1>Foo</fooEnum1>\n    <fooEnum2>0</fooEnum2>\n    <fooEnum3>1</fooEnum3>\n    <fooEnumList>\n        <member>Foo</member>\n        <member>0</member>\n    </fooEnumList>\n    <fooEnumSet>\n        <member>Foo</member>\n        <member>0</member>\n    </fooEnumSet>\n    <fooEnumMap>\n        <entry>\n            <key>hi</key>\n            <value>Foo</value>\n        </entry>\n        <entry>\n            <key>zero</key>\n            <value>0</value>\n        </entry>\n    </fooEnumMap>\n</XmlEnumsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlEnumsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlEnumsResponse
            {
                FooEnum1 = "Foo",
                FooEnum2 = "0",
                FooEnum3 = "1",
                FooEnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                FooEnumSet =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                FooEnumMap = new Dictionary<string, string>()
                {

                    { "hi", "Foo" },
                    { "zero", "0" },
                },
            };

            // Assert
            var actualResponse = (XmlEnumsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
