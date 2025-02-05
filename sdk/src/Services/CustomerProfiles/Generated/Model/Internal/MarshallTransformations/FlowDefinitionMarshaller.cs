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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFlowName())
            {
                context.Writer.WritePropertyName("FlowName");
                context.Writer.WriteStringValue(requestObject.FlowName);
            }

            if(requestObject.IsSetKmsArn())
            {
                context.Writer.WritePropertyName("KmsArn");
                context.Writer.WriteStringValue(requestObject.KmsArn);
            }

            if(requestObject.IsSetSourceFlowConfig())
            {
                context.Writer.WritePropertyName("SourceFlowConfig");
                context.Writer.WriteStartObject();

                var marshaller = SourceFlowConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceFlowConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTasks())
            {
                context.Writer.WritePropertyName("Tasks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTasksListValue in requestObject.Tasks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskMarshaller.Instance;
                    marshaller.Marshall(requestObjectTasksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTriggerConfig())
            {
                context.Writer.WritePropertyName("TriggerConfig");
                context.Writer.WriteStartObject();

                var marshaller = TriggerConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TriggerConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FlowDefinitionMarshaller Instance = new FlowDefinitionMarshaller();

    }
}