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
    /// WriteJourneyRequest Marshaller
    /// </summary>
    public class WriteJourneyRequestMarshaller : IRequestMarshaller<WriteJourneyRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WriteJourneyRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActivities())
            {
                context.Writer.WritePropertyName("Activities");
                context.Writer.WriteStartObject();
                foreach (var requestObjectActivitiesKvp in requestObject.Activities)
                {
                    context.Writer.WritePropertyName(requestObjectActivitiesKvp.Key);
                    var requestObjectActivitiesValue = requestObjectActivitiesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ActivityMarshaller.Instance;
                    marshaller.Marshall(requestObjectActivitiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClosedDays())
            {
                context.Writer.WritePropertyName("ClosedDays");
                context.Writer.WriteStartObject();

                var marshaller = ClosedDaysMarshaller.Instance;
                marshaller.Marshall(requestObject.ClosedDays, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreationDate())
            {
                context.Writer.WritePropertyName("CreationDate");
                context.Writer.WriteStringValue(requestObject.CreationDate);
            }

            if(requestObject.IsSetJourneyChannelSettings())
            {
                context.Writer.WritePropertyName("JourneyChannelSettings");
                context.Writer.WriteStartObject();

                var marshaller = JourneyChannelSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.JourneyChannelSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.WriteStringValue(requestObject.LastModifiedDate);
            }

            if(requestObject.IsSetLimits())
            {
                context.Writer.WritePropertyName("Limits");
                context.Writer.WriteStartObject();

                var marshaller = JourneyLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.Limits, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocalTime())
            {
                context.Writer.WritePropertyName("LocalTime");
                context.Writer.WriteBooleanValue(requestObject.LocalTime.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOpenHours())
            {
                context.Writer.WritePropertyName("OpenHours");
                context.Writer.WriteStartObject();

                var marshaller = OpenHoursMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenHours, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQuietTime())
            {
                context.Writer.WritePropertyName("QuietTime");
                context.Writer.WriteStartObject();

                var marshaller = QuietTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.QuietTime, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRefreshFrequency())
            {
                context.Writer.WritePropertyName("RefreshFrequency");
                context.Writer.WriteStringValue(requestObject.RefreshFrequency);
            }

            if(requestObject.IsSetRefreshOnSegmentUpdate())
            {
                context.Writer.WritePropertyName("RefreshOnSegmentUpdate");
                context.Writer.WriteBooleanValue(requestObject.RefreshOnSegmentUpdate.Value);
            }

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteStartObject();

                var marshaller = JourneyScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSendingSchedule())
            {
                context.Writer.WritePropertyName("SendingSchedule");
                context.Writer.WriteBooleanValue(requestObject.SendingSchedule.Value);
            }

            if(requestObject.IsSetStartActivity())
            {
                context.Writer.WritePropertyName("StartActivity");
                context.Writer.WriteStringValue(requestObject.StartActivity);
            }

            if(requestObject.IsSetStartCondition())
            {
                context.Writer.WritePropertyName("StartCondition");
                context.Writer.WriteStartObject();

                var marshaller = StartConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StartCondition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

            if(requestObject.IsSetTimezoneEstimationMethods())
            {
                context.Writer.WritePropertyName("TimezoneEstimationMethods");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTimezoneEstimationMethodsListValue in requestObject.TimezoneEstimationMethods)
                {
                        context.Writer.WriteStringValue(requestObjectTimezoneEstimationMethodsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWaitForQuietTime())
            {
                context.Writer.WritePropertyName("WaitForQuietTime");
                context.Writer.WriteBooleanValue(requestObject.WaitForQuietTime.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WriteJourneyRequestMarshaller Instance = new WriteJourneyRequestMarshaller();

    }
}