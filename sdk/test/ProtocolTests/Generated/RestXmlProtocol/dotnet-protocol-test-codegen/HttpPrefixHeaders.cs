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
    public class HttpPrefixHeaders
    {
        /// <summary>
        /// Adds headers by prefix
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void HttpPrefixHeadersArePresentRequest()
        {
            // Arrange
            var request = new HttpPrefixHeadersRequest
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                    { "Abc", "Abc value" },
                    { "Def", "Def value" },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpPrefixHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Foo".Replace(" ",""), marshalledRequest.Headers["X-Foo"].Replace(" ",""));
            Assert.AreEqual("Abc value".Replace(" ",""), marshalledRequest.Headers["X-Foo-Abc"].Replace(" ",""));
            Assert.AreEqual("Def value".Replace(" ",""), marshalledRequest.Headers["X-Foo-Def"].Replace(" ",""));
        }

        /// <summary>
        /// No prefix headers are serialized because the value is empty
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void HttpPrefixHeadersAreNotPresentRequest()
        {
            // Arrange
            var request = new HttpPrefixHeadersRequest
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpPrefixHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpPrefixHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Foo".Replace(" ",""), marshalledRequest.Headers["X-Foo"].Replace(" ",""));
        }

        /// <summary>
        /// Adds headers by prefix
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void HttpPrefixHeadersArePresentResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Foo"] = "Foo";
            webResponseData.Headers["X-Foo-Abc"] = "Abc value";
            webResponseData.Headers["X-Foo-Def"] = "Def value";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new HttpPrefixHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new HttpPrefixHeadersResponse
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                    { "Abc", "Abc value" },
                    { "Def", "Def value" },
                },
            };

            // Assert
            var actualResponse = (HttpPrefixHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<HttpPrefixHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// No prefix headers are serialized because the value is empty
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void HttpPrefixHeadersAreNotPresentResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-Foo"] = "Foo";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new HttpPrefixHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new HttpPrefixHeadersResponse
            {
                Foo = "Foo",
                FooMap = new Dictionary<string, string>()
                {

                },
            };

            // Assert
            var actualResponse = (HttpPrefixHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<HttpPrefixHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
