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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDashboards.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDashboards.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScheduledReportInput Marshaller
    /// </summary>
    public class ScheduledReportInputMarshaller : IRequestMarshaller<ScheduledReportInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduledReportInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDashboardArn())
            {
                context.Writer.WritePropertyName("dashboardArn");
                context.Writer.WriteStringValue(requestObject.DashboardArn);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetScheduleConfig())
            {
                context.Writer.WritePropertyName("scheduleConfig");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduleConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScheduledReportExecutionRoleArn())
            {
                context.Writer.WritePropertyName("scheduledReportExecutionRoleArn");
                context.Writer.WriteStringValue(requestObject.ScheduledReportExecutionRoleArn);
            }

            if(requestObject.IsSetWidgetDateRangeOverride())
            {
                context.Writer.WritePropertyName("widgetDateRangeOverride");
                context.Writer.WriteStartObject();

                var marshaller = DateTimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.WidgetDateRangeOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWidgetIds())
            {
                context.Writer.WritePropertyName("widgetIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWidgetIdsListValue in requestObject.WidgetIds)
                {
                        context.Writer.WriteStringValue(requestObjectWidgetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduledReportInputMarshaller Instance = new ScheduledReportInputMarshaller();

    }
}