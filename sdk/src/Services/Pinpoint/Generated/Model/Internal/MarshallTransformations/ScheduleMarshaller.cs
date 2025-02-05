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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Schedule Marshaller
    /// </summary>
    public class ScheduleMarshaller : IRequestMarshaller<Schedule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Schedule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteStringValue(requestObject.EndTime);
            }

            if(requestObject.IsSetEventFilter())
            {
                context.Writer.WritePropertyName("EventFilter");
                context.Writer.WriteStartObject();

                var marshaller = CampaignEventFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.EventFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("Frequency");
                context.Writer.WriteStringValue(requestObject.Frequency);
            }

            if(requestObject.IsSetIsLocalTime())
            {
                context.Writer.WritePropertyName("IsLocalTime");
                context.Writer.WriteBooleanValue(requestObject.IsLocalTime.Value);
            }

            if(requestObject.IsSetQuietTime())
            {
                context.Writer.WritePropertyName("QuietTime");
                context.Writer.WriteStartObject();

                var marshaller = QuietTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.QuietTime, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteStringValue(requestObject.StartTime);
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.WriteStringValue(requestObject.Timezone);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduleMarshaller Instance = new ScheduleMarshaller();

    }
}