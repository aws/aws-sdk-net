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
    /// PredictiveScalingMetricSpecification Marshaller
    /// </summary>
    public class PredictiveScalingMetricSpecificationMarshaller : IRequestMarshaller<PredictiveScalingMetricSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PredictiveScalingMetricSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomizedCapacityMetricSpecification())
            {
                context.Writer.WritePropertyName("CustomizedCapacityMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingCustomizedMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomizedCapacityMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomizedLoadMetricSpecification())
            {
                context.Writer.WritePropertyName("CustomizedLoadMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingCustomizedMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomizedLoadMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomizedScalingMetricSpecification())
            {
                context.Writer.WritePropertyName("CustomizedScalingMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingCustomizedMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomizedScalingMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPredefinedLoadMetricSpecification())
            {
                context.Writer.WritePropertyName("PredefinedLoadMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingPredefinedLoadMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PredefinedLoadMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPredefinedMetricPairSpecification())
            {
                context.Writer.WritePropertyName("PredefinedMetricPairSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingPredefinedMetricPairSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PredefinedMetricPairSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPredefinedScalingMetricSpecification())
            {
                context.Writer.WritePropertyName("PredefinedScalingMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredictiveScalingPredefinedScalingMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PredefinedScalingMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetValue())
            {
                context.Writer.WritePropertyName("TargetValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.TargetValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TargetValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TargetValue.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PredictiveScalingMetricSpecificationMarshaller Instance = new PredictiveScalingMetricSpecificationMarshaller();

    }
}