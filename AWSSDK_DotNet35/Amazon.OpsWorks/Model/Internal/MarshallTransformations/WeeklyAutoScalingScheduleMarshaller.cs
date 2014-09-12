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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WeeklyAutoScalingSchedule Marshaller
    /// </summary>       
    public class WeeklyAutoScalingScheduleMarshaller : IRequestMarshaller<WeeklyAutoScalingSchedule, JsonMarshallerContext> 
    {
        public void Marshall(WeeklyAutoScalingSchedule requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFriday())
            {
                context.Writer.WritePropertyName("Friday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectFridayKvp in requestObject.Friday)
                {
                    context.Writer.WritePropertyName(requestObjectFridayKvp.Key);
                    var requestObjectFridayValue = requestObjectFridayKvp.Value;

                        context.Writer.Write(requestObjectFridayValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMonday())
            {
                context.Writer.WritePropertyName("Monday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMondayKvp in requestObject.Monday)
                {
                    context.Writer.WritePropertyName(requestObjectMondayKvp.Key);
                    var requestObjectMondayValue = requestObjectMondayKvp.Value;

                        context.Writer.Write(requestObjectMondayValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSaturday())
            {
                context.Writer.WritePropertyName("Saturday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSaturdayKvp in requestObject.Saturday)
                {
                    context.Writer.WritePropertyName(requestObjectSaturdayKvp.Key);
                    var requestObjectSaturdayValue = requestObjectSaturdayKvp.Value;

                        context.Writer.Write(requestObjectSaturdayValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSunday())
            {
                context.Writer.WritePropertyName("Sunday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSundayKvp in requestObject.Sunday)
                {
                    context.Writer.WritePropertyName(requestObjectSundayKvp.Key);
                    var requestObjectSundayValue = requestObjectSundayKvp.Value;

                        context.Writer.Write(requestObjectSundayValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetThursday())
            {
                context.Writer.WritePropertyName("Thursday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectThursdayKvp in requestObject.Thursday)
                {
                    context.Writer.WritePropertyName(requestObjectThursdayKvp.Key);
                    var requestObjectThursdayValue = requestObjectThursdayKvp.Value;

                        context.Writer.Write(requestObjectThursdayValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTuesday())
            {
                context.Writer.WritePropertyName("Tuesday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTuesdayKvp in requestObject.Tuesday)
                {
                    context.Writer.WritePropertyName(requestObjectTuesdayKvp.Key);
                    var requestObjectTuesdayValue = requestObjectTuesdayKvp.Value;

                        context.Writer.Write(requestObjectTuesdayValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWednesday())
            {
                context.Writer.WritePropertyName("Wednesday");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectWednesdayKvp in requestObject.Wednesday)
                {
                    context.Writer.WritePropertyName(requestObjectWednesdayKvp.Key);
                    var requestObjectWednesdayValue = requestObjectWednesdayKvp.Value;

                        context.Writer.Write(requestObjectWednesdayValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        public readonly static WeeklyAutoScalingScheduleMarshaller Instance = new WeeklyAutoScalingScheduleMarshaller();

    }
}