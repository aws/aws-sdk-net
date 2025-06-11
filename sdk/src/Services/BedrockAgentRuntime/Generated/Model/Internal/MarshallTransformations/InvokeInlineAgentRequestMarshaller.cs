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
    /// InvokeInlineAgent Request Marshaller
    /// </summary>       
    public class InvokeInlineAgentRequestMarshaller : IMarshaller<IRequest, InvokeInlineAgentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeInlineAgentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeInlineAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSessionId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/agents/{sessionId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActionGroups())
            {
                context.Writer.WritePropertyName("actionGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestActionGroupsListValue in publicRequest.ActionGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AgentActionGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequestActionGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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

            if(publicRequest.IsSetBedrockModelConfigurations())
            {
                context.Writer.WritePropertyName("bedrockModelConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = InlineBedrockModelConfigurationsMarshaller.Instance;
                marshaller.Marshall(publicRequest.BedrockModelConfigurations, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCollaboratorConfigurations())
            {
                context.Writer.WritePropertyName("collaboratorConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCollaboratorConfigurationsListValue in publicRequest.CollaboratorConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CollaboratorConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCollaboratorConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCollaborators())
            {
                context.Writer.WritePropertyName("collaborators");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCollaboratorsListValue in publicRequest.Collaborators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CollaboratorMarshaller.Instance;
                    marshaller.Marshall(publicRequestCollaboratorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetFoundationModel())
            {
                context.Writer.WritePropertyName("foundationModel");
                context.Writer.WriteStringValue(publicRequest.FoundationModel);
            }

            if(publicRequest.IsSetGuardrailConfiguration())
            {
                context.Writer.WritePropertyName("guardrailConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailConfigurationWithArnMarshaller.Instance;
                marshaller.Marshall(publicRequest.GuardrailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIdleSessionTTLInSeconds())
            {
                context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                context.Writer.WriteNumberValue(publicRequest.IdleSessionTTLInSeconds.Value);
            }

            if(publicRequest.IsSetInlineSessionState())
            {
                context.Writer.WritePropertyName("inlineSessionState");
                context.Writer.WriteStartObject();

                var marshaller = InlineSessionStateMarshaller.Instance;
                marshaller.Marshall(publicRequest.InlineSessionState, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputText())
            {
                context.Writer.WritePropertyName("inputText");
                context.Writer.WriteStringValue(publicRequest.InputText);
            }

            if(publicRequest.IsSetInstruction())
            {
                context.Writer.WritePropertyName("instruction");
                context.Writer.WriteStringValue(publicRequest.Instruction);
            }

            if(publicRequest.IsSetKnowledgeBases())
            {
                context.Writer.WritePropertyName("knowledgeBases");
                context.Writer.WriteStartArray();
                foreach(var publicRequestKnowledgeBasesListValue in publicRequest.KnowledgeBases)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KnowledgeBaseMarshaller.Instance;
                    marshaller.Marshall(publicRequestKnowledgeBasesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrchestrationType())
            {
                context.Writer.WritePropertyName("orchestrationType");
                context.Writer.WriteStringValue(publicRequest.OrchestrationType);
            }

            if(publicRequest.IsSetPromptCreationConfigurations())
            {
                context.Writer.WritePropertyName("promptCreationConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = PromptCreationConfigurationsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PromptCreationConfigurations, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPromptOverrideConfiguration())
            {
                context.Writer.WritePropertyName("promptOverrideConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PromptOverrideConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PromptOverrideConfiguration, context);

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
            


            return request;
        }
        private static InvokeInlineAgentRequestMarshaller _instance = new InvokeInlineAgentRequestMarshaller();        

        internal static InvokeInlineAgentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeInlineAgentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}