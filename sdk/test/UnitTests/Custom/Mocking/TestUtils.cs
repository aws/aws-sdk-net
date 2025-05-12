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
using System;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.Mocking
{
    /// <summary>
    /// Generic class for testing utils
    /// </summary>
    public class TestUtils
    {
        /// <summary>
        /// Allows to mock pipeline to run tests using the default pipeline handlers,
        /// no unmarshaller, and the SigV4 signer
        /// </summary>
        /// <param name="request">Request to use</param>
        /// <param name="marshaller">Marshaller to use or null for none</param>
        /// <param name="config">ClientConfig to use</param>
        /// <returns>Marshalled request</returns>
        public static IRequest RunMockRequest(AmazonWebServiceRequest request,
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller,
            ClientConfig config)
        {
            var pipelineHandlers = new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new Signer(),
                new ChecksumHandler(),
                new CompressionHandler(),
                new EndpointResolver(),
                new Marshaller()
            };

            return RunMockRequest(pipelineHandlers, request, marshaller, null, config, new AWS4Signer());
        }
        /// <summary>
        /// Allows to mock pipeline to run tests using the default pipeline handlers
        /// </summary>
        /// <param name="request">Request to use</param>
        /// <param name="marshaller">Marshaller to use or null for none</param>
        /// <param name="unmarshaller">Unmarshaller to use or null for none</param>
        /// <param name="config">ClientConfig to use</param>
        /// <param name="signer">Signer to use</param>
        /// <returns>Marshalled request</returns>
        public static IRequest RunMockRequest(AmazonWebServiceRequest request,
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller,
            ResponseUnmarshaller unmarshaller,
            ClientConfig config,
            ISigner signer)
        {
            var pipelineHandlers = new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new Signer(),
                new ChecksumHandler(),
                new CompressionHandler(),
                new EndpointResolver(),
                new Marshaller()
            };

            return RunMockRequest(pipelineHandlers, request, marshaller, unmarshaller, config, signer);
        }

        /// <summary>
        /// Allows to mock pipeline to run tests for custom pipeline handlers
        /// </summary>
        /// <param name="pipelineHandlers">The custom pipeline handlers to test</param>
        /// <param name="request">Request to use</param>
        /// <param name="marshaller">Marshaller to use or null for none</param>
        /// <param name="unmarshaller">Unmarshaller to use or null for none</param>
        /// <param name="config">ClientConfig to use</param>
        /// <param name="signer">Signer to use</param>
        /// <returns>Marshalled request</returns>
        public static IRequest RunMockRequest(List<IPipelineHandler> pipelineHandlers,
            AmazonWebServiceRequest request, 
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller,
            ResponseUnmarshaller unmarshaller,
            ClientConfig config,
            ISigner signer)
        {
            var pipeline = new RuntimePipeline(pipelineHandlers);

            var requestContext = new RequestContext(config.LogMetrics, signer)
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = unmarshaller,
                IsAsync = false,
            };
            
            var executionContext = new ExecutionContext(
                requestContext,
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            return requestContext.Request;
        }

        /// <summary>
        /// No op PipelineHandler, has to be on top of pipeline chain to enable mocking
        /// </summary>
        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

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
