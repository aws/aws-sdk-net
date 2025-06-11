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
    /// InvokeAgent Request Marshaller
    /// </summary>       
    public class InvokeAgentRequestMarshaller : IMarshaller<IRequest, InvokeAgentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeAgentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAgentAliasId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field AgentAliasId set");
            request.AddPathResource("{agentAliasId}", StringUtils.FromString(publicRequest.AgentAliasId));
            if (!publicRequest.IsSetAgentId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field AgentId set");
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/agents/{agentId}/agentAliases/{agentAliasId}/sessions/{sessionId}/text";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBedrockModelConfigurations())
            {
                context.Writer.WritePropertyName("bedrockModelConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = BedrockModelConfigurationsMarshaller.Instance;
                marshaller.Marshall(publicRequest.BedrockModelConfigurations, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnableTrace())
            {
                context.Writer.WritePropertyName("enableTrace");
                context.Writer.WriteBooleanValue(publicRequest.EnableTrace.Value);
            }

            if(publicRequest.IsSetEndSession())
            {
                context.Writer.WritePropertyName("endSession");
                context.Writer.WriteBooleanValue(publicRequest.EndSession.Value);
            }

            if(publicRequest.IsSetInputText())
            {
                context.Writer.WritePropertyName("inputText");
                context.Writer.WriteStringValue(publicRequest.InputText);
            }

            if(publicRequest.IsSetMemoryId())
            {
                context.Writer.WritePropertyName("memoryId");
                context.Writer.WriteStringValue(publicRequest.MemoryId);
            }

            if(publicRequest.IsSetPromptCreationConfigurations())
            {
                context.Writer.WritePropertyName("promptCreationConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = PromptCreationConfigurationsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PromptCreationConfigurations, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSessionState())
            {
                context.Writer.WritePropertyName("sessionState");
                context.Writer.WriteStartObject();

                var marshaller = SessionStateMarshaller.Instance;
                marshaller.Marshall(publicRequest.SessionState, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStreamingConfigurations())
            {
                context.Writer.WritePropertyName("streamingConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = StreamingConfigurationsMarshaller.Instance;
                marshaller.Marshall(publicRequest.StreamingConfigurations, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetSourceArn()) 
            {
                request.Headers["x-amz-source-arn"] = publicRequest.SourceArn;
            }

            return request;
        }
        private static InvokeAgentRequestMarshaller _instance = new InvokeAgentRequestMarshaller();        

        internal static InvokeAgentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeAgentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}