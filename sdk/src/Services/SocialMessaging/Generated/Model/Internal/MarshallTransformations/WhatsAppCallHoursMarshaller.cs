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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WhatsAppCallHours Marshaller
    /// </summary>
    public class WhatsAppCallHoursMarshaller : IRequestMarshaller<WhatsAppCallHours, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WhatsAppCallHours requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetHolidaySchedule())
            {
                context.Writer.WritePropertyName("holidaySchedule");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHolidayScheduleListValue in requestObject.HolidaySchedule)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WhatsAppHolidayScheduleEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectHolidayScheduleListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("timezone");
                context.Writer.WriteStringValue(requestObject.Timezone);
            }

            if(requestObject.IsSetWeeklyOperatingHours())
            {
                context.Writer.WritePropertyName("weeklyOperatingHours");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWeeklyOperatingHoursListValue in requestObject.WeeklyOperatingHours)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WhatsAppWeeklyOperatingHoursEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectWeeklyOperatingHoursListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WhatsAppCallHoursMarshaller Instance = new WhatsAppCallHoursMarshaller();

    }
}