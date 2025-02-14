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
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class NullAndEmptyHeadersClient
    {
        /// <summary>
        /// Do not send null values, but do send empty strings and empty
        /// lists over the wire in headers
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void NullAndEmptyHeadersRequest()
        {
            // Arrange
            var request = new NullAndEmptyHeadersClientRequest
            {
                A = null,
                B = "",
                C =  new List<string>()
                {
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NullAndEmptyHeadersClientRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/NullAndEmptyHeadersClient", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("".Replace(" ",""), marshalledRequest.Headers["X-B"].Replace(" ",""));
            Assert.AreEqual("".Replace(" ",""), marshalledRequest.Headers["X-C"].Replace(" ",""));
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey("X-A"));
        }

    }
}
