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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3Control;
using Amazon.S3Control.Internal;
using AWSSDK.UnitTests.Mocking;
using System.Collections.Generic;
using static AWSSDK.UnitTests.Mocking.TestUtils;

namespace AWSSDK.UnitTests
{
    public class S3ControlArnTestUtils
    {
        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, AmazonS3ControlConfig config)
        {
            var pipelineHandlers = new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new Signer(),
                new AmazonS3ControlEndpointResolver(),
                new AmazonS3ControlAuthSchemeHandler(),
                new Marshaller()
            };

            return TestUtils.RunMockRequest(pipelineHandlers, request, marshaller, null, config, signer: null);
        }
    }
}
