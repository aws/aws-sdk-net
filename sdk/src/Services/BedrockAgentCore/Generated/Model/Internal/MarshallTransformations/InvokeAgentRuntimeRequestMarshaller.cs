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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
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
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeAgentRuntime Request Marshaller
    /// </summary>       
    public class InvokeAgentRuntimeRequestMarshaller : IMarshaller<IRequest, InvokeAgentRuntimeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeAgentRuntimeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeAgentRuntimeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAgentRuntimeArn())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field AgentRuntimeArn set");
            request.AddPathResource("{agentRuntimeArn}", StringUtils.FromString(publicRequest.AgentRuntimeArn));
            
            if (publicRequest.IsSetQualifier())
                request.Parameters.Add("qualifier", StringUtils.FromString(publicRequest.Qualifier));
            request.ResourcePath = "/runtimes/{agentRuntimeArn}/invocations";
            request.ContentStream =  publicRequest.Payload ?? new MemoryStream();
            if(request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
            if (publicRequest.IsSetAccept()) 
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }
        
            if (publicRequest.IsSetBaggage()) 
            {
                request.Headers["baggage"] = publicRequest.Baggage;
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetMcpProtocolVersion()) 
            {
                request.Headers["Mcp-Protocol-Version"] = publicRequest.McpProtocolVersion;
            }
        
            if (publicRequest.IsSetMcpSessionId()) 
            {
                request.Headers["Mcp-Session-Id"] = publicRequest.McpSessionId;
            }
        
            if (publicRequest.IsSetRuntimeSessionId()) 
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Runtime-Session-Id"] = publicRequest.RuntimeSessionId;
            }
        
            if (publicRequest.IsSetRuntimeUserId()) 
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Runtime-User-Id"] = publicRequest.RuntimeUserId;
            }
        
            if (publicRequest.IsSetTraceId()) 
            {
                request.Headers["X-Amzn-Trace-Id"] = publicRequest.TraceId;
            }
        
            if (publicRequest.IsSetTraceParent()) 
            {
                request.Headers["traceparent"] = publicRequest.TraceParent;
            }
        
            if (publicRequest.IsSetTraceState()) 
            {
                request.Headers["tracestate"] = publicRequest.TraceState;
            }
            request.UseQueryString = true;

            return request;
        }
        private static InvokeAgentRuntimeRequestMarshaller _instance = new InvokeAgentRuntimeRequestMarshaller();        

        internal static InvokeAgentRuntimeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeAgentRuntimeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}