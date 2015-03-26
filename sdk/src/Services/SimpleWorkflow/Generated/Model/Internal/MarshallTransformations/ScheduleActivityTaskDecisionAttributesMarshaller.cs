/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScheduleActivityTaskDecisionAttributes Marshaller
    /// </summary>       
    public class ScheduleActivityTaskDecisionAttributesMarshaller : IRequestMarshaller<ScheduleActivityTaskDecisionAttributes, JsonMarshallerContext> 
    {
        public void Marshall(ScheduleActivityTaskDecisionAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActivityId())
            {
                context.Writer.WritePropertyName("activityId");
                context.Writer.Write(requestObject.ActivityId);
            }

            if(requestObject.IsSetActivityType())
            {
                context.Writer.WritePropertyName("activityType");
                context.Writer.WriteObjectStart();

                var marshaller = ActivityTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.ActivityType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetControl())
            {
                context.Writer.WritePropertyName("control");
                context.Writer.Write(requestObject.Control);
            }

            if(requestObject.IsSetHeartbeatTimeout())
            {
                context.Writer.WritePropertyName("heartbeatTimeout");
                context.Writer.Write(requestObject.HeartbeatTimeout);
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.Write(requestObject.Input);
            }

            if(requestObject.IsSetScheduleToCloseTimeout())
            {
                context.Writer.WritePropertyName("scheduleToCloseTimeout");
                context.Writer.Write(requestObject.ScheduleToCloseTimeout);
            }

            if(requestObject.IsSetScheduleToStartTimeout())
            {
                context.Writer.WritePropertyName("scheduleToStartTimeout");
                context.Writer.Write(requestObject.ScheduleToStartTimeout);
            }

            if(requestObject.IsSetStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("startToCloseTimeout");
                context.Writer.Write(requestObject.StartToCloseTimeout);
            }

            if(requestObject.IsSetTaskList())
            {
                context.Writer.WritePropertyName("taskList");
                context.Writer.WriteObjectStart();

                var marshaller = TaskListMarshaller.Instance;
                marshaller.Marshall(requestObject.TaskList, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTaskPriority())
            {
                context.Writer.WritePropertyName("taskPriority");
                context.Writer.Write(requestObject.TaskPriority);
            }

        }

        public readonly static ScheduleActivityTaskDecisionAttributesMarshaller Instance = new ScheduleActivityTaskDecisionAttributesMarshaller();

    }
}