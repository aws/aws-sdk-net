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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScalingPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TargetTrackingConfiguration Marshaller
    /// </summary>       
    public class TargetTrackingConfigurationMarshaller : IRequestMarshaller<TargetTrackingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TargetTrackingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCustomizedScalingMetricSpecification())
            {
                context.Writer.WritePropertyName("CustomizedScalingMetricSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = CustomizedScalingMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomizedScalingMetricSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisableScaleIn())
            {
                context.Writer.WritePropertyName("DisableScaleIn");
                context.Writer.Write(requestObject.DisableScaleIn);
            }

            if(requestObject.IsSetEstimatedInstanceWarmup())
            {
                context.Writer.WritePropertyName("EstimatedInstanceWarmup");
                context.Writer.Write(requestObject.EstimatedInstanceWarmup);
            }

            if(requestObject.IsSetPredefinedScalingMetricSpecification())
            {
                context.Writer.WritePropertyName("PredefinedScalingMetricSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = PredefinedScalingMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PredefinedScalingMetricSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScaleInCooldown())
            {
                context.Writer.WritePropertyName("ScaleInCooldown");
                context.Writer.Write(requestObject.ScaleInCooldown);
            }

            if(requestObject.IsSetScaleOutCooldown())
            {
                context.Writer.WritePropertyName("ScaleOutCooldown");
                context.Writer.Write(requestObject.ScaleOutCooldown);
            }

            if(requestObject.IsSetTargetValue())
            {
                context.Writer.WritePropertyName("TargetValue");
                context.Writer.Write(requestObject.TargetValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TargetTrackingConfigurationMarshaller Instance = new TargetTrackingConfigurationMarshaller();

    }
}