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
    public class XmlNamespaces
    {
        /// <summary>
        /// Serializes XML namespaces
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void QueryXmlNamespacesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlNamespacesResponse xmlns=\"https://example.com/\">\n    <XmlNamespacesResult>\n        <nested>\n            <foo xmlns:baz=\"http://baz.com\">Foo</foo>\n            <values xmlns=\"http://qux.com\">\n                <member xmlns=\"http://bux.com\">Bar</member>\n                <member xmlns=\"http://bux.com\">Baz</member>\n            </values>\n        </nested>\n    </XmlNamespacesResult>\n</XmlNamespacesResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlNamespacesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlNamespacesResponse
            {
                Nested = new XmlNamespaceNested
                {
                    Foo = "Foo",
                    Values =  new List<string>()
                    {
                        "Bar",
                        "Baz",
                    },
                },
            };

            // Assert
            var actualResponse = (XmlNamespacesResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlNamespacesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
