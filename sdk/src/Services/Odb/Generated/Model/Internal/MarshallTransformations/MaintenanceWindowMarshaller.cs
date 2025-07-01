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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MaintenanceWindow Marshaller
    /// </summary>
    public class MaintenanceWindowMarshaller : IRequestMarshaller<MaintenanceWindow, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MaintenanceWindow requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomActionTimeoutInMins())
            {
                context.Writer.WritePropertyName("customActionTimeoutInMins");
                context.Writer.Write(requestObject.CustomActionTimeoutInMins);
            }

            if(requestObject.IsSetDaysOfWeek())
            {
                context.Writer.WritePropertyName("daysOfWeek");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDaysOfWeekListValue in requestObject.DaysOfWeek)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DayOfWeekMarshaller.Instance;
                    marshaller.Marshall(requestObjectDaysOfWeekListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetHoursOfDay())
            {
                context.Writer.WritePropertyName("hoursOfDay");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHoursOfDayListValue in requestObject.HoursOfDay)
                {
                        context.Writer.Write(requestObjectHoursOfDayListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIsCustomActionTimeoutEnabled())
            {
                context.Writer.WritePropertyName("isCustomActionTimeoutEnabled");
                context.Writer.Write(requestObject.IsCustomActionTimeoutEnabled);
            }

            if(requestObject.IsSetLeadTimeInWeeks())
            {
                context.Writer.WritePropertyName("leadTimeInWeeks");
                context.Writer.Write(requestObject.LeadTimeInWeeks);
            }

            if(requestObject.IsSetMonths())
            {
                context.Writer.WritePropertyName("months");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMonthsListValue in requestObject.Months)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MonthMarshaller.Instance;
                    marshaller.Marshall(requestObjectMonthsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPatchingMode())
            {
                context.Writer.WritePropertyName("patchingMode");
                context.Writer.Write(requestObject.PatchingMode);
            }

            if(requestObject.IsSetPreference())
            {
                context.Writer.WritePropertyName("preference");
                context.Writer.Write(requestObject.Preference);
            }

            if(requestObject.IsSetSkipRu())
            {
                context.Writer.WritePropertyName("skipRu");
                context.Writer.Write(requestObject.SkipRu);
            }

            if(requestObject.IsSetWeeksOfMonth())
            {
                context.Writer.WritePropertyName("weeksOfMonth");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWeeksOfMonthListValue in requestObject.WeeksOfMonth)
                {
                        context.Writer.Write(requestObjectWeeksOfMonthListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MaintenanceWindowMarshaller Instance = new MaintenanceWindowMarshaller();

    }
}