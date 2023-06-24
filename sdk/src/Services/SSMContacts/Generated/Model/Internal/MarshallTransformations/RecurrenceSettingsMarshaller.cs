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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecurrenceSettings Marshaller
    /// </summary>
    public class RecurrenceSettingsMarshaller : IRequestMarshaller<RecurrenceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecurrenceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDailySettings())
            {
                context.Writer.WritePropertyName("DailySettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDailySettingsListValue in requestObject.DailySettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HandOffTimeMarshaller.Instance;
                    marshaller.Marshall(requestObjectDailySettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMonthlySettings())
            {
                context.Writer.WritePropertyName("MonthlySettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMonthlySettingsListValue in requestObject.MonthlySettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MonthlySettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectMonthlySettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNumberOfOnCalls())
            {
                context.Writer.WritePropertyName("NumberOfOnCalls");
                context.Writer.Write(requestObject.NumberOfOnCalls);
            }

            if(requestObject.IsSetRecurrenceMultiplier())
            {
                context.Writer.WritePropertyName("RecurrenceMultiplier");
                context.Writer.Write(requestObject.RecurrenceMultiplier);
            }

            if(requestObject.IsSetShiftCoverages())
            {
                context.Writer.WritePropertyName("ShiftCoverages");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectShiftCoveragesKvp in requestObject.ShiftCoverages)
                {
                    context.Writer.WritePropertyName(requestObjectShiftCoveragesKvp.Key);
                    var requestObjectShiftCoveragesValue = requestObjectShiftCoveragesKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectShiftCoveragesValueListValue in requestObjectShiftCoveragesValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CoverageTimeMarshaller.Instance;
                        marshaller.Marshall(requestObjectShiftCoveragesValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWeeklySettings())
            {
                context.Writer.WritePropertyName("WeeklySettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWeeklySettingsListValue in requestObject.WeeklySettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WeeklySettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectWeeklySettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecurrenceSettingsMarshaller Instance = new RecurrenceSettingsMarshaller();

    }
}