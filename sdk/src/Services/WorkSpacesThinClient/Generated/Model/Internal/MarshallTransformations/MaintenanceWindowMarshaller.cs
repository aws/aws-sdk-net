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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesThinClient.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesThinClient.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetApplyTimeOf())
            {
                context.Writer.WritePropertyName("applyTimeOf");
                context.Writer.Write(requestObject.ApplyTimeOf);
            }

            if(requestObject.IsSetDaysOfTheWeek())
            {
                context.Writer.WritePropertyName("daysOfTheWeek");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDaysOfTheWeekListValue in requestObject.DaysOfTheWeek)
                {
                        context.Writer.Write(requestObjectDaysOfTheWeekListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEndTimeHour())
            {
                context.Writer.WritePropertyName("endTimeHour");
                context.Writer.Write(requestObject.EndTimeHour);
            }

            if(requestObject.IsSetEndTimeMinute())
            {
                context.Writer.WritePropertyName("endTimeMinute");
                context.Writer.Write(requestObject.EndTimeMinute);
            }

            if(requestObject.IsSetStartTimeHour())
            {
                context.Writer.WritePropertyName("startTimeHour");
                context.Writer.Write(requestObject.StartTimeHour);
            }

            if(requestObject.IsSetStartTimeMinute())
            {
                context.Writer.WritePropertyName("startTimeMinute");
                context.Writer.Write(requestObject.StartTimeMinute);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MaintenanceWindowMarshaller Instance = new MaintenanceWindowMarshaller();

    }
}