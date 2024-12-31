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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionGroups())
                {
                    context.Writer.WritePropertyName("actionGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionGroupsListValue in publicRequest.ActionGroups)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AgentActionGroupMarshaller.Instance;
                        marshaller.Marshall(publicRequestActionGroupsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBedrockModelConfigurations())
                {
                    context.Writer.WritePropertyName("bedrockModelConfigurations");
                    context.Writer.WriteObjectStart();

                    var marshaller = InlineBedrockModelConfigurationsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BedrockModelConfigurations, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomerEncryptionKeyArn())
                {
                    context.Writer.WritePropertyName("customerEncryptionKeyArn");
                    context.Writer.Write(publicRequest.CustomerEncryptionKeyArn);
                }

                if(publicRequest.IsSetEnableTrace())
                {
                    context.Writer.WritePropertyName("enableTrace");
                    context.Writer.Write(publicRequest.EnableTrace);
                }

                if(publicRequest.IsSetEndSession())
                {
                    context.Writer.WritePropertyName("endSession");
                    context.Writer.Write(publicRequest.EndSession);
                }

                if(publicRequest.IsSetFoundationModel())
                {
                    context.Writer.WritePropertyName("foundationModel");
                    context.Writer.Write(publicRequest.FoundationModel);
                }

                if(publicRequest.IsSetGuardrailConfiguration())
                {
                    context.Writer.WritePropertyName("guardrailConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailConfigurationWithArnMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GuardrailConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdleSessionTTLInSeconds())
                {
                    context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                    context.Writer.Write(publicRequest.IdleSessionTTLInSeconds);
                }

                if(publicRequest.IsSetInlineSessionState())
                {
                    context.Writer.WritePropertyName("inlineSessionState");
                    context.Writer.WriteObjectStart();

                    var marshaller = InlineSessionStateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InlineSessionState, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputText())
                {
                    context.Writer.WritePropertyName("inputText");
                    context.Writer.Write(publicRequest.InputText);
                }

                if(publicRequest.IsSetInstruction())
                {
                    context.Writer.WritePropertyName("instruction");
                    context.Writer.Write(publicRequest.Instruction);
                }

                if(publicRequest.IsSetKnowledgeBases())
                {
                    context.Writer.WritePropertyName("knowledgeBases");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestKnowledgeBasesListValue in publicRequest.KnowledgeBases)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = KnowledgeBaseMarshaller.Instance;
                        marshaller.Marshall(publicRequestKnowledgeBasesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPromptOverrideConfiguration())
                {
                    context.Writer.WritePropertyName("promptOverrideConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = PromptOverrideConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PromptOverrideConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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