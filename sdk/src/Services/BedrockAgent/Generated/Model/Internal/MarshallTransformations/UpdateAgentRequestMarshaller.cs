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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
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
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAgent Request Marshaller
    /// </summary>       
    public class UpdateAgentRequestMarshaller : IMarshaller<IRequest, UpdateAgentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAgentId())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentId set");
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));
            request.ResourcePath = "/agents/{agentId}/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAgentCollaboration())
            {
                context.Writer.WritePropertyName("agentCollaboration");
                context.Writer.WriteStringValue(publicRequest.AgentCollaboration);
            }

            if(publicRequest.IsSetAgentName())
            {
                context.Writer.WritePropertyName("agentName");
                context.Writer.WriteStringValue(publicRequest.AgentName);
            }

            if(publicRequest.IsSetAgentResourceRoleArn())
            {
                context.Writer.WritePropertyName("agentResourceRoleArn");
                context.Writer.WriteStringValue(publicRequest.AgentResourceRoleArn);
            }

            if(publicRequest.IsSetCustomerEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("customerEncryptionKeyArn");
                context.Writer.WriteStringValue(publicRequest.CustomerEncryptionKeyArn);
            }

            if(publicRequest.IsSetCustomOrchestration())
            {
                context.Writer.WritePropertyName("customOrchestration");
                context.Writer.WriteStartObject();

                var marshaller = CustomOrchestrationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomOrchestration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFoundationModel())
            {
                context.Writer.WritePropertyName("foundationModel");
                context.Writer.WriteStringValue(publicRequest.FoundationModel);
            }

            if(publicRequest.IsSetGuardrailConfiguration())
            {
                context.Writer.WritePropertyName("guardrailConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.GuardrailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIdleSessionTTLInSeconds())
            {
                context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                context.Writer.WriteNumberValue(publicRequest.IdleSessionTTLInSeconds.Value);
            }

            if(publicRequest.IsSetInstruction())
            {
                context.Writer.WritePropertyName("instruction");
                context.Writer.WriteStringValue(publicRequest.Instruction);
            }

            if(publicRequest.IsSetMemoryConfiguration())
            {
                context.Writer.WritePropertyName("memoryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MemoryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MemoryConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOrchestrationType())
            {
                context.Writer.WritePropertyName("orchestrationType");
                context.Writer.WriteStringValue(publicRequest.OrchestrationType);
            }

            if(publicRequest.IsSetPromptOverrideConfiguration())
            {
                context.Writer.WritePropertyName("promptOverrideConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PromptOverrideConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PromptOverrideConfiguration, context);

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
            


            return request;
        }
        private static UpdateAgentRequestMarshaller _instance = new UpdateAgentRequestMarshaller();        

        internal static UpdateAgentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAgentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}