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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RefreshSchedule Marshaller
    /// </summary>
    public class RefreshScheduleMarshaller : IRequestMarshaller<RefreshSchedule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RefreshSchedule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetRefreshType())
            {
                context.Writer.WritePropertyName("RefreshType");
                context.Writer.WriteStringValue(requestObject.RefreshType);
            }

            if(requestObject.IsSetScheduleFrequency())
            {
                context.Writer.WritePropertyName("ScheduleFrequency");
                context.Writer.WriteStartObject();

                var marshaller = RefreshFrequencyMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduleFrequency, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScheduleId())
            {
                context.Writer.WritePropertyName("ScheduleId");
                context.Writer.WriteStringValue(requestObject.ScheduleId);
            }

            if(requestObject.IsSetStartAfterDateTime())
            {
                context.Writer.WritePropertyName("StartAfterDateTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.StartAfterDateTime.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RefreshScheduleMarshaller Instance = new RefreshScheduleMarshaller();

    }
}