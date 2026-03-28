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
    /// InvokeAgentRuntimeCommand Request Marshaller
    /// </summary>       
    public class InvokeAgentRuntimeCommandRequestMarshaller : IMarshaller<IRequest, InvokeAgentRuntimeCommandRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeAgentRuntimeCommandRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeAgentRuntimeCommandRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAgentRuntimeArn())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field AgentRuntimeArn set");
            request.AddPathResource("{agentRuntimeArn}", StringUtils.FromString(publicRequest.AgentRuntimeArn));
            
            if (publicRequest.IsSetAccountId())
                request.Parameters.Add("accountId", StringUtils.FromString(publicRequest.AccountId));
            
            if (publicRequest.IsSetQualifier())
                request.Parameters.Add("qualifier", StringUtils.FromString(publicRequest.Qualifier));
            request.ResourcePath = "/runtimes/{agentRuntimeArn}/commands";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            var context = new JsonMarshallerContext(request, writer);
            context.Writer.WriteStartObject();

            var marshaller = InvokeAgentRuntimeCommandRequestBodyMarshaller.Instance;
            marshaller.Marshall(publicRequest.Body, context);

            context.Writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
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
        
            if (publicRequest.IsSetRuntimeSessionId()) 
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Runtime-Session-Id"] = publicRequest.RuntimeSessionId;
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
        private static InvokeAgentRuntimeCommandRequestMarshaller _instance = new InvokeAgentRuntimeCommandRequestMarshaller();        

        internal static InvokeAgentRuntimeCommandRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeAgentRuntimeCommandRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}