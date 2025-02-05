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
    /// FlowNode Marshaller
    /// </summary>
    public class FlowNodeMarshaller : IRequestMarshaller<FlowNode, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FlowNode requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStartObject();

                var marshaller = FlowNodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("inputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FlowNodeInputMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOutputs())
            {
                context.Writer.WritePropertyName("outputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputsListValue in requestObject.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FlowNodeOutputMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FlowNodeMarshaller Instance = new FlowNodeMarshaller();

    }
}