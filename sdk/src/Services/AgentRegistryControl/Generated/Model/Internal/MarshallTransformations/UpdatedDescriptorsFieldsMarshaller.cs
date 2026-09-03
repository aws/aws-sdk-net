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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AgentRegistryControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AgentRegistryControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatedDescriptorsFields Marshaller
    /// </summary>
    public class UpdatedDescriptorsFieldsMarshaller : IRequestMarshaller<UpdatedDescriptorsFields, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdatedDescriptorsFields requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetA2aAgentCard())
            {
                context.Writer.WritePropertyName("a2aAgentCard");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedA2aAgentCardDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.A2aAgentCard, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAgentSkillsDefinition())
            {
                context.Writer.WritePropertyName("agentSkillsDefinition");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedAgentSkillsDefinitionDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.AgentSkillsDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAgui())
            {
                context.Writer.WritePropertyName("agui");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedAgUiDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.Agui, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustom())
            {
                context.Writer.WritePropertyName("custom");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedCustomDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.Custom, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHttp())
            {
                context.Writer.WritePropertyName("http");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedHttpDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.Http, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpServer())
            {
                context.Writer.WritePropertyName("mcpServer");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedMcpServerDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.McpServer, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdatedDescriptorsFieldsMarshaller Instance = new UpdatedDescriptorsFieldsMarshaller();

    }
}