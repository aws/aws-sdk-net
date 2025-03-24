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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OtaTaskSchedulingConfig Marshaller
    /// </summary>
    public class OtaTaskSchedulingConfigMarshaller : IRequestMarshaller<OtaTaskSchedulingConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OtaTaskSchedulingConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndBehavior())
            {
                context.Writer.WritePropertyName("EndBehavior");
                context.Writer.WriteStringValue(requestObject.EndBehavior);
            }

            if(requestObject.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteStringValue(requestObject.EndTime);
            }

            if(requestObject.IsSetMaintenanceWindows())
            {
                context.Writer.WritePropertyName("MaintenanceWindows");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMaintenanceWindowsListValue in requestObject.MaintenanceWindows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ScheduleMaintenanceWindowMarshaller.Instance;
                    marshaller.Marshall(requestObjectMaintenanceWindowsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteStringValue(requestObject.StartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OtaTaskSchedulingConfigMarshaller Instance = new OtaTaskSchedulingConfigMarshaller();

    }
}