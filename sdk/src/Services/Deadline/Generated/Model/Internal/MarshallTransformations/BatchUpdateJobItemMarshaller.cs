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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateJobItem Marshaller
    /// </summary>
    public class BatchUpdateJobItemMarshaller : IRequestMarshaller<BatchUpdateJobItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchUpdateJobItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFarmId())
            {
                context.Writer.WritePropertyName("farmId");
                context.Writer.WriteStringValue(requestObject.FarmId);
            }

            if(requestObject.IsSetJobId())
            {
                context.Writer.WritePropertyName("jobId");
                context.Writer.WriteStringValue(requestObject.JobId);
            }

            if(requestObject.IsSetLifecycleStatus())
            {
                context.Writer.WritePropertyName("lifecycleStatus");
                context.Writer.WriteStringValue(requestObject.LifecycleStatus);
            }

            if(requestObject.IsSetMaxFailedTasksCount())
            {
                context.Writer.WritePropertyName("maxFailedTasksCount");
                context.Writer.WriteNumberValue(requestObject.MaxFailedTasksCount.Value);
            }

            if(requestObject.IsSetMaxRetriesPerTask())
            {
                context.Writer.WritePropertyName("maxRetriesPerTask");
                context.Writer.WriteNumberValue(requestObject.MaxRetriesPerTask.Value);
            }

            if(requestObject.IsSetMaxWorkerCount())
            {
                context.Writer.WritePropertyName("maxWorkerCount");
                context.Writer.WriteNumberValue(requestObject.MaxWorkerCount.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetQueueId())
            {
                context.Writer.WritePropertyName("queueId");
                context.Writer.WriteStringValue(requestObject.QueueId);
            }

            if(requestObject.IsSetTargetTaskRunStatus())
            {
                context.Writer.WritePropertyName("targetTaskRunStatus");
                context.Writer.WriteStringValue(requestObject.TargetTaskRunStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchUpdateJobItemMarshaller Instance = new BatchUpdateJobItemMarshaller();

    }
}