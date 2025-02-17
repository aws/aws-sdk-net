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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAgent Request Marshaller
    /// </summary>       
    public class CreateAgentRequestMarshaller : IMarshaller<IRequest, CreateAgentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAgentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/agents/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentCollaboration())
                {
                    context.Writer.WritePropertyName("agentCollaboration");
                    context.Writer.Write(publicRequest.AgentCollaboration);
                }

                if(publicRequest.IsSetAgentName())
                {
                    context.Writer.WritePropertyName("agentName");
                    context.Writer.Write(publicRequest.AgentName);
                }

                if(publicRequest.IsSetAgentResourceRoleArn())
                {
                    context.Writer.WritePropertyName("agentResourceRoleArn");
                    context.Writer.Write(publicRequest.AgentResourceRoleArn);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCustomerEncryptionKeyArn())
                {
                    context.Writer.WritePropertyName("customerEncryptionKeyArn");
                    context.Writer.Write(publicRequest.CustomerEncryptionKeyArn);
                }

                if(publicRequest.IsSetCustomOrchestration())
                {
                    context.Writer.WritePropertyName("customOrchestration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomOrchestrationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomOrchestration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
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

                    var marshaller = GuardrailConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GuardrailConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdleSessionTTLInSeconds())
                {
                    context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                    context.Writer.Write(publicRequest.IdleSessionTTLInSeconds);
                }

                if(publicRequest.IsSetInstruction())
                {
                    context.Writer.WritePropertyName("instruction");
                    context.Writer.Write(publicRequest.Instruction);
                }

                if(publicRequest.IsSetMemoryConfiguration())
                {
                    context.Writer.WritePropertyName("memoryConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MemoryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MemoryConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOrchestrationType())
                {
                    context.Writer.WritePropertyName("orchestrationType");
                    context.Writer.Write(publicRequest.OrchestrationType);
                }

                if(publicRequest.IsSetPromptOverrideConfiguration())
                {
                    context.Writer.WritePropertyName("promptOverrideConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = PromptOverrideConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PromptOverrideConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAgentRequestMarshaller _instance = new CreateAgentRequestMarshaller();        

        internal static CreateAgentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAgentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}