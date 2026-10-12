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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataQualityTelemetry Marshaller
    /// </summary>
    public class DataQualityTelemetryMarshaller : IRequestMarshaller<DataQualityTelemetry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataQualityTelemetry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(requestObject.Engine);
            }

            if(requestObject.IsSetFlagsEnabled())
            {
                context.Writer.WritePropertyName("FlagsEnabled");
                context.Writer.WriteStartObject();
                foreach (var requestObjectFlagsEnabledKvp in requestObject.FlagsEnabled)
                {
                    context.Writer.WritePropertyName(requestObjectFlagsEnabledKvp.Key);
                    var requestObjectFlagsEnabledValue = requestObjectFlagsEnabledKvp.Value;

                        context.Writer.WriteStringValue(requestObjectFlagsEnabledValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHostRuntimeVersion())
            {
                context.Writer.WritePropertyName("HostRuntimeVersion");
                context.Writer.WriteStringValue(requestObject.HostRuntimeVersion);
            }

            if(requestObject.IsSetLibraryVersion())
            {
                context.Writer.WritePropertyName("LibraryVersion");
                context.Writer.WriteStringValue(requestObject.LibraryVersion);
            }

            if(requestObject.IsSetSparkVersion())
            {
                context.Writer.WritePropertyName("SparkVersion");
                context.Writer.WriteStringValue(requestObject.SparkVersion);
            }

            if(requestObject.IsSetVcpuHours())
            {
                context.Writer.WritePropertyName("VcpuHours");
                if(StringUtils.IsSpecialDoubleValue(requestObject.VcpuHours.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.VcpuHours.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.VcpuHours.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataQualityTelemetryMarshaller Instance = new DataQualityTelemetryMarshaller();

    }
}