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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetActivities())
            {
                context.Writer.WritePropertyName("Activities");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectActivitiesKvp in requestObject.Activities)
                {
                    context.Writer.WritePropertyName(requestObjectActivitiesKvp.Key);
                    var requestObjectActivitiesValue = requestObjectActivitiesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ActivityMarshaller.Instance;
                    marshaller.Marshall(requestObjectActivitiesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClosedDays())
            {
                context.Writer.WritePropertyName("ClosedDays");
                context.Writer.WriteObjectStart();

                var marshaller = ClosedDaysMarshaller.Instance;
                marshaller.Marshall(requestObject.ClosedDays, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreationDate())
            {
                context.Writer.WritePropertyName("CreationDate");
                context.Writer.Write(requestObject.CreationDate);
            }

            if(requestObject.IsSetJourneyChannelSettings())
            {
                context.Writer.WritePropertyName("JourneyChannelSettings");
                context.Writer.WriteObjectStart();

                var marshaller = JourneyChannelSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.JourneyChannelSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLastModifiedDate())
            {
                context.Writer.WritePropertyName("LastModifiedDate");
                context.Writer.Write(requestObject.LastModifiedDate);
            }

            if(requestObject.IsSetLimits())
            {
                context.Writer.WritePropertyName("Limits");
                context.Writer.WriteObjectStart();

                var marshaller = JourneyLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.Limits, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLocalTime())
            {
                context.Writer.WritePropertyName("LocalTime");
                context.Writer.Write(requestObject.LocalTime);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOpenHours())
            {
                context.Writer.WritePropertyName("OpenHours");
                context.Writer.WriteObjectStart();

                var marshaller = OpenHoursMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenHours, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQuietTime())
            {
                context.Writer.WritePropertyName("QuietTime");
                context.Writer.WriteObjectStart();

                var marshaller = QuietTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.QuietTime, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRefreshFrequency())
            {
                context.Writer.WritePropertyName("RefreshFrequency");
                context.Writer.Write(requestObject.RefreshFrequency);
            }

            if(requestObject.IsSetRefreshOnSegmentUpdate())
            {
                context.Writer.WritePropertyName("RefreshOnSegmentUpdate");
                context.Writer.Write(requestObject.RefreshOnSegmentUpdate);
            }

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteObjectStart();

                var marshaller = JourneyScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSendingSchedule())
            {
                context.Writer.WritePropertyName("SendingSchedule");
                context.Writer.Write(requestObject.SendingSchedule);
            }

            if(requestObject.IsSetStartActivity())
            {
                context.Writer.WritePropertyName("StartActivity");
                context.Writer.Write(requestObject.StartActivity);
            }

            if(requestObject.IsSetStartCondition())
            {
                context.Writer.WritePropertyName("StartCondition");
                context.Writer.WriteObjectStart();

                var marshaller = StartConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StartCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

            if(requestObject.IsSetTimezoneEstimationMethods())
            {
                context.Writer.WritePropertyName("TimezoneEstimationMethods");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTimezoneEstimationMethodsListValue in requestObject.TimezoneEstimationMethods)
                {
                        context.Writer.Write(requestObjectTimezoneEstimationMethodsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWaitForQuietTime())
            {
                context.Writer.WritePropertyName("WaitForQuietTime");
                context.Writer.Write(requestObject.WaitForQuietTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WriteJourneyRequestMarshaller Instance = new WriteJourneyRequestMarshaller();

    }
}