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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                var context = new JsonMarshallerContext(request, writer);
                context.Writer.WriteObjectStart();

                var marshaller = InvokeAgentRuntimeCommandRequestBodyMarshaller.Instance;
                marshaller.Marshall(publicRequest.Body, context);

                context.Writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
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