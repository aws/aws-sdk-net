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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Collaborator Marshaller
    /// </summary>
    public class CollaboratorMarshaller : IRequestMarshaller<Collaborator, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Collaborator requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionGroups())
            {
                context.Writer.WritePropertyName("actionGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActionGroupsListValue in requestObject.ActionGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AgentActionGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAgentCollaboration())
            {
                context.Writer.WritePropertyName("agentCollaboration");
                context.Writer.WriteStringValue(requestObject.AgentCollaboration);
            }

            if(requestObject.IsSetAgentName())
            {
                context.Writer.WritePropertyName("agentName");
                context.Writer.WriteStringValue(requestObject.AgentName);
            }

            if(requestObject.IsSetCollaboratorConfigurations())
            {
                context.Writer.WritePropertyName("collaboratorConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCollaboratorConfigurationsListValue in requestObject.CollaboratorConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CollaboratorConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCollaboratorConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomerEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("customerEncryptionKeyArn");
                context.Writer.WriteStringValue(requestObject.CustomerEncryptionKeyArn);
            }

            if(requestObject.IsSetFoundationModel())
            {
                context.Writer.WritePropertyName("foundationModel");
                context.Writer.WriteStringValue(requestObject.FoundationModel);
            }

            if(requestObject.IsSetGuardrailConfiguration())
            {
                context.Writer.WritePropertyName("guardrailConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailConfigurationWithArnMarshaller.Instance;
                marshaller.Marshall(requestObject.GuardrailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIdleSessionTTLInSeconds())
            {
                context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                context.Writer.WriteNumberValue(requestObject.IdleSessionTTLInSeconds.Value);
            }

            if(requestObject.IsSetInstruction())
            {
                context.Writer.WritePropertyName("instruction");
                context.Writer.WriteStringValue(requestObject.Instruction);
            }

            if(requestObject.IsSetKnowledgeBases())
            {
                context.Writer.WritePropertyName("knowledgeBases");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKnowledgeBasesListValue in requestObject.KnowledgeBases)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KnowledgeBaseMarshaller.Instance;
                    marshaller.Marshall(requestObjectKnowledgeBasesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPromptOverrideConfiguration())
            {
                context.Writer.WritePropertyName("promptOverrideConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PromptOverrideConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PromptOverrideConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CollaboratorMarshaller Instance = new CollaboratorMarshaller();

    }
}