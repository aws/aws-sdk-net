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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.AutoScalingPlans.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TargetTrackingConfiguration Marshaller
    /// </summary>
    public partial class TargetTrackingConfigurationMarshaller : IRequestMarshaller<TargetTrackingConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(TargetTrackingConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCustomizedScalingMetricSpecification())
            {
                context.Writer.WritePropertyName("CustomizedScalingMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CustomizedScalingMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomizedScalingMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDisableScaleIn())
            {
                context.Writer.WritePropertyName("DisableScaleIn");
                context.Writer.WriteBooleanValue(requestObject.DisableScaleIn.Value);
            }

            if (requestObject.IsSetEstimatedInstanceWarmup())
            {
                context.Writer.WritePropertyName("EstimatedInstanceWarmup");
                context.Writer.WriteNumberValue(requestObject.EstimatedInstanceWarmup.Value);
            }

            if (requestObject.IsSetPredefinedScalingMetricSpecification())
            {
                context.Writer.WritePropertyName("PredefinedScalingMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredefinedScalingMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PredefinedScalingMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetScaleInCooldown())
            {
                context.Writer.WritePropertyName("ScaleInCooldown");
                context.Writer.WriteNumberValue(requestObject.ScaleInCooldown.Value);
            }

            if (requestObject.IsSetScaleOutCooldown())
            {
                context.Writer.WritePropertyName("ScaleOutCooldown");
                context.Writer.WriteNumberValue(requestObject.ScaleOutCooldown.Value);
            }

            if (requestObject.IsSetTargetValue())
            {
                context.Writer.WritePropertyName("TargetValue");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TargetValue.Value))
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
        /// Singleton Marshaller
        /// </summary>
        public readonly static TargetTrackingConfigurationMarshaller Instance = new TargetTrackingConfigurationMarshaller();
    }
}
