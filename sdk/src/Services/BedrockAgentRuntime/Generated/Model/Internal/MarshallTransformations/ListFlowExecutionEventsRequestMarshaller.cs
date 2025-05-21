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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
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
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListFlowExecutionEvents Request Marshaller
    /// </summary>       
    public class ListFlowExecutionEventsRequestMarshaller : IMarshaller<IRequest, ListFlowExecutionEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFlowExecutionEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListFlowExecutionEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetExecutionIdentifier())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field ExecutionIdentifier set");
            request.AddPathResource("{executionIdentifier}", StringUtils.FromString(publicRequest.ExecutionIdentifier));
            if (!publicRequest.IsSetFlowAliasIdentifier())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field FlowAliasIdentifier set");
            request.AddPathResource("{flowAliasIdentifier}", StringUtils.FromString(publicRequest.FlowAliasIdentifier));
            if (!publicRequest.IsSetFlowIdentifier())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field FlowIdentifier set");
            request.AddPathResource("{flowIdentifier}", StringUtils.FromString(publicRequest.FlowIdentifier));
            
            if (publicRequest.IsSetEventType())
                request.Parameters.Add("eventType", StringUtils.FromString(publicRequest.EventType));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/flows/{flowIdentifier}/aliases/{flowAliasIdentifier}/executions/{executionIdentifier}/events";
            request.UseQueryString = true;

            return request;
        }
        private static ListFlowExecutionEventsRequestMarshaller _instance = new ListFlowExecutionEventsRequestMarshaller();        

        internal static ListFlowExecutionEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListFlowExecutionEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}