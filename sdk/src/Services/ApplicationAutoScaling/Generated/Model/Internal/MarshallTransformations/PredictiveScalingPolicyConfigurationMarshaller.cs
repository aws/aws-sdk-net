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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PredictiveScalingPolicyConfiguration Marshaller
    /// </summary>
    public class PredictiveScalingPolicyConfigurationMarshaller : IRequestMarshaller<PredictiveScalingPolicyConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PredictiveScalingPolicyConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxCapacityBreachBehavior())
            {
                context.Writer.WritePropertyName("MaxCapacityBreachBehavior");
                context.Writer.WriteStringValue(requestObject.MaxCapacityBreachBehavior);
            }

            if(requestObject.IsSetMaxCapacityBuffer())
            {
                context.Writer.WritePropertyName("MaxCapacityBuffer");
                context.Writer.WriteNumberValue(requestObject.MaxCapacityBuffer.Value);
            }

            if(requestObject.IsSetMetricSpecifications())
            {
                context.Writer.WritePropertyName("MetricSpecifications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMetricSpecificationsListValue in requestObject.MetricSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PredictiveScalingMetricSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("Mode");
                context.Writer.WriteStringValue(requestObject.Mode);
            }

            if(requestObject.IsSetSchedulingBufferTime())
            {
                context.Writer.WritePropertyName("SchedulingBufferTime");
                context.Writer.WriteNumberValue(requestObject.SchedulingBufferTime.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PredictiveScalingPolicyConfigurationMarshaller Instance = new PredictiveScalingPolicyConfigurationMarshaller();

    }
}