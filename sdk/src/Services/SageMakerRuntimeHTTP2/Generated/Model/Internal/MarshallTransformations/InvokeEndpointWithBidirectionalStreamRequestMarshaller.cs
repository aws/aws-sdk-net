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
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerRuntimeHTTP2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeEndpointWithBidirectionalStream Request Marshaller
    /// </summary>       
    public class InvokeEndpointWithBidirectionalStreamRequestMarshaller : IMarshaller<IRequest, InvokeEndpointWithBidirectionalStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeEndpointWithBidirectionalStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeEndpointWithBidirectionalStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerRuntimeHTTP2");
#if NET8_0_OR_GREATER
            request.HttpProtocolVersion = System.Net.HttpVersion.Version20;
#endif
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            request.EventStreamPublisher = new RequestStreamEventPublisherMarshaller(publicRequest.BodyPublisher);

            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-10-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEndpointName())
                throw new AmazonSageMakerRuntimeHTTP2Exception("Request object does not have required field EndpointName set");
            request.AddPathResource("{EndpointName}", StringUtils.FromString(publicRequest.EndpointName));
            request.ResourcePath = "/endpoints/{EndpointName}/invocations-bidirectional-stream";
        
            if (publicRequest.IsSetModelInvocationPath()) 
            {
                request.Headers["X-Amzn-SageMaker-Model-Invocation-Path"] = publicRequest.ModelInvocationPath;
            }
        
            if (publicRequest.IsSetModelQueryString()) 
            {
                request.Headers["X-Amzn-SageMaker-Model-Query-String"] = publicRequest.ModelQueryString;
            }
        
            if (publicRequest.IsSetTargetVariant()) 
            {
                request.Headers["X-Amzn-SageMaker-Target-Variant"] = publicRequest.TargetVariant;
            }

            return request;
        }
        private static InvokeEndpointWithBidirectionalStreamRequestMarshaller _instance = new InvokeEndpointWithBidirectionalStreamRequestMarshaller();        

        internal static InvokeEndpointWithBidirectionalStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeEndpointWithBidirectionalStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}