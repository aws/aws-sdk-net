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
    /// FlowDefinition Marshaller
    /// </summary>
    public class FlowDefinitionMarshaller : IRequestMarshaller<FlowDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FlowDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnections())
            {
                context.Writer.WritePropertyName("connections");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConnectionsListValue in requestObject.Connections)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FlowConnectionMarshaller.Instance;
                    marshaller.Marshall(requestObjectConnectionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNodes())
            {
                context.Writer.WritePropertyName("nodes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNodesListValue in requestObject.Nodes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FlowNodeMarshaller.Instance;
                    marshaller.Marshall(requestObjectNodesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FlowDefinitionMarshaller Instance = new FlowDefinitionMarshaller();

    }
}