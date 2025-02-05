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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Task Marshaller
    /// </summary>
    public class TaskMarshaller : IRequestMarshaller<Task, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Task requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectorOperator())
            {
                context.Writer.WritePropertyName("connectorOperator");
                context.Writer.WriteStartObject();

                var marshaller = ConnectorOperatorMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectorOperator, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDestinationField())
            {
                context.Writer.WritePropertyName("destinationField");
                context.Writer.WriteStringValue(requestObject.DestinationField);
            }

            if(requestObject.IsSetSourceFields())
            {
                context.Writer.WritePropertyName("sourceFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourceFieldsListValue in requestObject.SourceFields)
                {
                        context.Writer.WriteStringValue(requestObjectSourceFieldsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaskProperties())
            {
                context.Writer.WritePropertyName("taskProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTaskPropertiesKvp in requestObject.TaskProperties)
                {
                    context.Writer.WritePropertyName(requestObjectTaskPropertiesKvp.Key);
                    var requestObjectTaskPropertiesValue = requestObjectTaskPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTaskPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTaskType())
            {
                context.Writer.WritePropertyName("taskType");
                context.Writer.WriteStringValue(requestObject.TaskType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaskMarshaller Instance = new TaskMarshaller();

    }
}