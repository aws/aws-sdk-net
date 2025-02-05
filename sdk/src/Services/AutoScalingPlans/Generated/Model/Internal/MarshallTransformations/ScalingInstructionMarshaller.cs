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
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScalingInstruction Marshaller
    /// </summary>
    public class ScalingInstructionMarshaller : IRequestMarshaller<ScalingInstruction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScalingInstruction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomizedLoadMetricSpecification())
            {
                context.Writer.WritePropertyName("CustomizedLoadMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CustomizedLoadMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomizedLoadMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDisableDynamicScaling())
            {
                context.Writer.WritePropertyName("DisableDynamicScaling");
                context.Writer.WriteBooleanValue(requestObject.DisableDynamicScaling.Value);
            }

            if(requestObject.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                context.Writer.WriteNumberValue(requestObject.MaxCapacity.Value);
            }

            if(requestObject.IsSetMinCapacity())
            {
                context.Writer.WritePropertyName("MinCapacity");
                context.Writer.WriteNumberValue(requestObject.MinCapacity.Value);
            }

            if(requestObject.IsSetPredefinedLoadMetricSpecification())
            {
                context.Writer.WritePropertyName("PredefinedLoadMetricSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PredefinedLoadMetricSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PredefinedLoadMetricSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPredictiveScalingMaxCapacityBehavior())
            {
                context.Writer.WritePropertyName("PredictiveScalingMaxCapacityBehavior");
                context.Writer.WriteStringValue(requestObject.PredictiveScalingMaxCapacityBehavior);
            }

            if(requestObject.IsSetPredictiveScalingMaxCapacityBuffer())
            {
                context.Writer.WritePropertyName("PredictiveScalingMaxCapacityBuffer");
                context.Writer.WriteNumberValue(requestObject.PredictiveScalingMaxCapacityBuffer.Value);
            }

            if(requestObject.IsSetPredictiveScalingMode())
            {
                context.Writer.WritePropertyName("PredictiveScalingMode");
                context.Writer.WriteStringValue(requestObject.PredictiveScalingMode);
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteStringValue(requestObject.ResourceId);
            }

            if(requestObject.IsSetScalableDimension())
            {
                context.Writer.WritePropertyName("ScalableDimension");
                context.Writer.WriteStringValue(requestObject.ScalableDimension);
            }

            if(requestObject.IsSetScalingPolicyUpdateBehavior())
            {
                context.Writer.WritePropertyName("ScalingPolicyUpdateBehavior");
                context.Writer.WriteStringValue(requestObject.ScalingPolicyUpdateBehavior);
            }

            if(requestObject.IsSetScheduledActionBufferTime())
            {
                context.Writer.WritePropertyName("ScheduledActionBufferTime");
                context.Writer.WriteNumberValue(requestObject.ScheduledActionBufferTime.Value);
            }

            if(requestObject.IsSetServiceNamespace())
            {
                context.Writer.WritePropertyName("ServiceNamespace");
                context.Writer.WriteStringValue(requestObject.ServiceNamespace);
            }

            if(requestObject.IsSetTargetTrackingConfigurations())
            {
                context.Writer.WritePropertyName("TargetTrackingConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetTrackingConfigurationsListValue in requestObject.TargetTrackingConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetTrackingConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetTrackingConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScalingInstructionMarshaller Instance = new ScalingInstructionMarshaller();

    }
}