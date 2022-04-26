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
using Amazon;
using Amazon.EventBridge;
using Amazon.EventBridge.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using AWSSDK.UnitTests.Mocking;

namespace AWSSDK.UnitTests
{
    public class EventBridgeTestUtils
    {
        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller)
        {
            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
            };

            return RunMockRequest(request, marshaller, config);
        }

        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, AmazonEventBridgeConfig config)
        {
            return TestUtils.RunMockRequest(new AmazonEventBridgePostMarshallHandler(), request, marshaller, config, new EventBridgeSigner());
        }
    }
}
