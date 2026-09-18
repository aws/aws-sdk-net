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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HandoffAgentConfiguration Marshaller
    /// </summary>
    public class HandoffAgentConfigurationMarshaller : IRequestMarshaller<HandoffAgentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HandoffAgentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAgentTarget())
            {
                context.Writer.WritePropertyName("agentTarget");
                context.Writer.WriteStartObject();

                var marshaller = AgentTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.AgentTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioStreamingEnabled())
            {
                context.Writer.WritePropertyName("audioStreamingEnabled");
                context.Writer.WriteBooleanValue(requestObject.AudioStreamingEnabled.Value);
            }

            if(requestObject.IsSetImmediateHandoff())
            {
                context.Writer.WritePropertyName("immediateHandoff");
                context.Writer.WriteBooleanValue(requestObject.ImmediateHandoff.Value);
            }

            if(requestObject.IsSetInstruction())
            {
                context.Writer.WritePropertyName("instruction");
                context.Writer.WriteStartObject();

                var marshaller = MultiAgentInstructionMarshaller.Instance;
                marshaller.Marshall(requestObject.Instruction, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HandoffAgentConfigurationMarshaller Instance = new HandoffAgentConfigurationMarshaller();

    }
}