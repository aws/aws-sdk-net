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
    public class EndpointWithHostLabelHeaderOperation
    {
        /// <summary>
        /// Operations can prepend to the given host if they define the
        /// endpoint trait, and can use the host label trait to define
        /// further customization based on user input. The label must also be
        /// serialized in into any other location it is bound to, such as the
        /// body or in this case an http header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlEndpointTraitWithHostLabelAndHttpBindingRequest()
        {
            // Arrange
            var request = new EndpointWithHostLabelHeaderOperationRequest
            {
                AccountId = "bar",
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://example.com/"
            };

            var marshaller = new EndpointWithHostLabelHeaderOperationRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/EndpointWithHostLabelHeaderOperation", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("bar.example.com", actualUri.Host);
            Assert.AreEqual("bar".Replace(" ",""), marshalledRequest.Headers["X-Amz-Account-Id"].Replace(" ",""));
        }

    }
}
