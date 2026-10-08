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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimeRangeSchedule Marshaller
    /// </summary>
    public partial class TimeRangeScheduleMarshaller : IRequestMarshaller<TimeRangeSchedule, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(TimeRangeSchedule requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetRecurrence())
            {
                context.Writer.WritePropertyName("recurrence");
                context.Writer.WriteStartObject();

                var marshaller = RecurrenceMarshaller.Instance;
                marshaller.Marshall(requestObject.Recurrence, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetStartAfter())
            {
                context.Writer.WritePropertyName("startAfter");
                context.Writer.WriteStringValue(requestObject.StartAfter);
            }

            if (requestObject.IsSetStartBefore())
            {
                context.Writer.WritePropertyName("startBefore");
                context.Writer.WriteStringValue(requestObject.StartBefore);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static TimeRangeScheduleMarshaller Instance = new TimeRangeScheduleMarshaller();
    }
}
