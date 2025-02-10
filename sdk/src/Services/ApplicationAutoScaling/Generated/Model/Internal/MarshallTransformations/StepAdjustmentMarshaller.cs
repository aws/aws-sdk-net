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
    /// StepAdjustment Marshaller
    /// </summary>
    public class StepAdjustmentMarshaller : IRequestMarshaller<StepAdjustment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StepAdjustment requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMetricIntervalLowerBound())
            {
                context.Writer.WritePropertyName("MetricIntervalLowerBound");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MetricIntervalLowerBound.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MetricIntervalLowerBound.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MetricIntervalLowerBound.Value);
                }
            }

            if(requestObject.IsSetMetricIntervalUpperBound())
            {
                context.Writer.WritePropertyName("MetricIntervalUpperBound");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MetricIntervalUpperBound.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MetricIntervalUpperBound.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MetricIntervalUpperBound.Value);
                }
            }

            if(requestObject.IsSetScalingAdjustment())
            {
                context.Writer.WritePropertyName("ScalingAdjustment");
                context.Writer.WriteNumberValue(requestObject.ScalingAdjustment.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StepAdjustmentMarshaller Instance = new StepAdjustmentMarshaller();

    }
}