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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BehaviorCriteria Marshaller
    /// </summary>
    public class BehaviorCriteriaMarshaller : IRequestMarshaller<BehaviorCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BehaviorCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("comparisonOperator");
                context.Writer.WriteStringValue(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetConsecutiveDatapointsToAlarm())
            {
                context.Writer.WritePropertyName("consecutiveDatapointsToAlarm");
                context.Writer.WriteNumberValue(requestObject.ConsecutiveDatapointsToAlarm.Value);
            }

            if(requestObject.IsSetConsecutiveDatapointsToClear())
            {
                context.Writer.WritePropertyName("consecutiveDatapointsToClear");
                context.Writer.WriteNumberValue(requestObject.ConsecutiveDatapointsToClear.Value);
            }

            if(requestObject.IsSetDurationSeconds())
            {
                context.Writer.WritePropertyName("durationSeconds");
                context.Writer.WriteNumberValue(requestObject.DurationSeconds.Value);
            }

            if(requestObject.IsSetMlDetectionConfig())
            {
                context.Writer.WritePropertyName("mlDetectionConfig");
                context.Writer.WriteStartObject();

                var marshaller = MachineLearningDetectionConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.MlDetectionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatisticalThreshold())
            {
                context.Writer.WritePropertyName("statisticalThreshold");
                context.Writer.WriteStartObject();

                var marshaller = StatisticalThresholdMarshaller.Instance;
                marshaller.Marshall(requestObject.StatisticalThreshold, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.WriteStartObject();

                var marshaller = MetricValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BehaviorCriteriaMarshaller Instance = new BehaviorCriteriaMarshaller();

    }
}