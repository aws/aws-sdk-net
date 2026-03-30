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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TaskFilter Marshaller
    /// </summary>
    public class TaskFilterMarshaller : IRequestMarshaller<TaskFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TaskFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreatedAfter())
            {
                context.Writer.WritePropertyName("createdAfter");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CreatedAfter));
            }

            if(requestObject.IsSetCreatedBefore())
            {
                context.Writer.WritePropertyName("createdBefore");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CreatedBefore));
            }

            if(requestObject.IsSetPrimaryTaskId())
            {
                context.Writer.WritePropertyName("primaryTaskId");
                context.Writer.WriteStringValue(requestObject.PrimaryTaskId);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPriorityListValue in requestObject.Priority)
                {
                        context.Writer.WriteStringValue(requestObjectPriorityListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusListValue in requestObject.Status)
                {
                        context.Writer.WriteStringValue(requestObjectStatusListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaskType())
            {
                context.Writer.WritePropertyName("taskType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTaskTypeListValue in requestObject.TaskType)
                {
                        context.Writer.WriteStringValue(requestObjectTaskTypeListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaskFilterMarshaller Instance = new TaskFilterMarshaller();

    }
}