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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScheduledTriggerProperties Marshaller
    /// </summary>
    public class ScheduledTriggerPropertiesMarshaller : IRequestMarshaller<ScheduledTriggerProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduledTriggerProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataPullMode())
            {
                context.Writer.WritePropertyName("DataPullMode");
                context.Writer.WriteStringValue(requestObject.DataPullMode);
            }

            if(requestObject.IsSetFirstExecutionFrom())
            {
                context.Writer.WritePropertyName("FirstExecutionFrom");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.FirstExecutionFrom.Value)));
            }

            if(requestObject.IsSetScheduleEndTime())
            {
                context.Writer.WritePropertyName("ScheduleEndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.ScheduleEndTime.Value)));
            }

            if(requestObject.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(requestObject.ScheduleExpression);
            }

            if(requestObject.IsSetScheduleOffset())
            {
                context.Writer.WritePropertyName("ScheduleOffset");
                context.Writer.WriteNumberValue(requestObject.ScheduleOffset.Value);
            }

            if(requestObject.IsSetScheduleStartTime())
            {
                context.Writer.WritePropertyName("ScheduleStartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.ScheduleStartTime.Value)));
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
        public readonly static ScheduledTriggerPropertiesMarshaller Instance = new ScheduledTriggerPropertiesMarshaller();

    }
}