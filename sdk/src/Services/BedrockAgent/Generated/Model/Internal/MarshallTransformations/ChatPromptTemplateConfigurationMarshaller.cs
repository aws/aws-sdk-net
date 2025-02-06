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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChatPromptTemplateConfiguration Marshaller
    /// </summary>
    public class ChatPromptTemplateConfigurationMarshaller : IRequestMarshaller<ChatPromptTemplateConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ChatPromptTemplateConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInputVariables())
            {
                context.Writer.WritePropertyName("inputVariables");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputVariablesListValue in requestObject.InputVariables)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PromptInputVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputVariablesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMessages())
            {
                context.Writer.WritePropertyName("messages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMessagesListValue in requestObject.Messages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSystem())
            {
                context.Writer.WritePropertyName("system");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSystemListValue in requestObject.System)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SystemContentBlockMarshaller.Instance;
                    marshaller.Marshall(requestObjectSystemListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetToolConfiguration())
            {
                context.Writer.WritePropertyName("toolConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ToolConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ToolConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChatPromptTemplateConfigurationMarshaller Instance = new ChatPromptTemplateConfigurationMarshaller();

    }
}