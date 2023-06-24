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
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3Control;
using Amazon.S3Control.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    public class S3ControlArnTestUtils
    {
        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, AmazonS3ControlConfig config)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new AmazonS3ControlEndpointResolver(),
                new Marshaller()
            });

            var requestContext = new RequestContext(config.LogMetrics, new AWS4Signer())
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false
            };
            var executionContext = new ExecutionContext(
                requestContext,
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            return requestContext.Request;
        }

        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

            public void AsyncCallback(IAsyncExecutionContext executionContext)
            {
            }

            public IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
            {
                return null;
            }


            public virtual System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                where T : AmazonWebServiceResponse, new()
            {
                return null;
            }

            public void InvokeSync(IExecutionContext executionContext)
            {
            }
        }
    }
}
