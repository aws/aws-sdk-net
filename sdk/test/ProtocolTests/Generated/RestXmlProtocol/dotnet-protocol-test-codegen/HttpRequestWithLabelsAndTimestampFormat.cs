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
    public class HttpRequestWithLabelsAndTimestampFormat
    {
        /// <summary>
        /// Serializes different timestamp formats in URI labels
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void HttpRequestWithLabelsAndTimestampFormatRequest()
        {
            // Arrange
            var request = new HttpRequestWithLabelsAndTimestampFormatRequest
            {
                MemberEpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                MemberHttpDate = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                MemberDateTime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                DefaultFormat = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetEpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetHttpDate = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetDateTime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpRequestWithLabelsAndTimestampFormatRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpRequestWithLabelsAndTimestampFormat/1576540098/Mon%2C%2016%20Dec%202019%2023%3A48%3A18%20GMT/2019-12-16T23%3A48%3A18Z/2019-12-16T23%3A48%3A18Z/1576540098/Mon%2C%2016%20Dec%202019%2023%3A48%3A18%20GMT/2019-12-16T23%3A48%3A18Z", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
        }

    }
}
