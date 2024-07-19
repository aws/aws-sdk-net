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
    public class QueryTimestamps
    {
        /// <summary>
        /// Serializes timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public void QueryTimestampsInputRequest()
        {
            // Arrange
            var request = new QueryTimestampsRequest
            {
                NormalFormat = ProtocolTestConstants.epoch.AddSeconds(1422172800),
                EpochMember = ProtocolTestConstants.epoch.AddSeconds(1422172800),
                EpochTarget = ProtocolTestConstants.epoch.AddSeconds(1422172800),
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=QueryTimestamps&Version=2020-01-08&normalFormat=2015-01-25T08%3A00%3A00Z&epochMember=1422172800&epochTarget=1422172800");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

    }
}
