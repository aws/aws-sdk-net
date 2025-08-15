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
using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.NonQueryCompatibleRpcV2Protocol;
using Amazon.NonQueryCompatibleRpcV2Protocol.Model;
using Amazon.NonQueryCompatibleRpcV2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWSSDK.ProtocolTests.NonQueryCompatibleRpcV2Protocol
{
    [TestClass]
    public class NonQueryCompatibleOperation
    {
        /// <summary>
        /// The query mode header MUST NOT be set on non-query-compatible
        /// services.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("NonQueryCompatibleRpcV2Protocol")]
        public void NonQueryCompatibleRpcV2CborForbidsQueryModeHeaderRequest()
        {
            // Arrange
            var request = new NonQueryCompatibleOperationRequest
            {
            };
            var config = new AmazonNonQueryCompatibleRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NonQueryCompatibleOperationRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/NonQueryCompatibleRpcV2Protocol/operation/NonQueryCompatibleOperation", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey("x-amzn-query-mode"));
        }

    }
}
