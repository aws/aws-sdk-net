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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SyncSchedule Marshaller
    /// </summary>
    public class SyncScheduleMarshaller : IRequestMarshaller<SyncSchedule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SyncSchedule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDaily())
            {
                context.Writer.WritePropertyName("daily");
                context.Writer.WriteStartObject();

                var marshaller = DailyScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Daily, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonthly())
            {
                context.Writer.WritePropertyName("monthly");
                context.Writer.WriteStartObject();

                var marshaller = MonthlyScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Monthly, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWeekly())
            {
                context.Writer.WritePropertyName("weekly");
                context.Writer.WriteStartObject();

                var marshaller = WeeklyScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Weekly, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SyncScheduleMarshaller Instance = new SyncScheduleMarshaller();

    }
}