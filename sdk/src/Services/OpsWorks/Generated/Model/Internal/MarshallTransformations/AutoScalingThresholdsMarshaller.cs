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
#pragma warning disable CS0612,CS0618
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoScalingThresholds Marshaller
    /// </summary>
    public class AutoScalingThresholdsMarshaller : IRequestMarshaller<AutoScalingThresholds, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoScalingThresholds requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlarms())
            {
                context.Writer.WritePropertyName("Alarms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAlarmsListValue in requestObject.Alarms)
                {
                        context.Writer.WriteStringValue(requestObjectAlarmsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCpuThreshold())
            {
                context.Writer.WritePropertyName("CpuThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.CpuThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.CpuThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.CpuThreshold.Value);
                }
            }

            if(requestObject.IsSetIgnoreMetricsTime())
            {
                context.Writer.WritePropertyName("IgnoreMetricsTime");
                context.Writer.WriteNumberValue(requestObject.IgnoreMetricsTime.Value);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.WriteNumberValue(requestObject.InstanceCount.Value);
            }

            if(requestObject.IsSetLoadThreshold())
            {
                context.Writer.WritePropertyName("LoadThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LoadThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LoadThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LoadThreshold.Value);
                }
            }

            if(requestObject.IsSetMemoryThreshold())
            {
                context.Writer.WritePropertyName("MemoryThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MemoryThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MemoryThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MemoryThreshold.Value);
                }
            }

            if(requestObject.IsSetThresholdsWaitTime())
            {
                context.Writer.WritePropertyName("ThresholdsWaitTime");
                context.Writer.WriteNumberValue(requestObject.ThresholdsWaitTime.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoScalingThresholdsMarshaller Instance = new AutoScalingThresholdsMarshaller();

    }
}