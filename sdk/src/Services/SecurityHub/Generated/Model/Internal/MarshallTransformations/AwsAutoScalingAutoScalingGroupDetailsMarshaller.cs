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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsAutoScalingAutoScalingGroupDetails Marshaller
    /// </summary>
    public class AwsAutoScalingAutoScalingGroupDetailsMarshaller : IRequestMarshaller<AwsAutoScalingAutoScalingGroupDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsAutoScalingAutoScalingGroupDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsAutoScalingAutoScalingGroupAvailabilityZonesListDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAvailabilityZonesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCapacityRebalance())
            {
                context.Writer.WritePropertyName("CapacityRebalance");
                context.Writer.WriteBooleanValue(requestObject.CapacityRebalance.Value);
            }

            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.WriteStringValue(requestObject.CreatedTime);
            }

            if(requestObject.IsSetHealthCheckGracePeriod())
            {
                context.Writer.WritePropertyName("HealthCheckGracePeriod");
                context.Writer.WriteNumberValue(requestObject.HealthCheckGracePeriod.Value);
            }

            if(requestObject.IsSetHealthCheckType())
            {
                context.Writer.WritePropertyName("HealthCheckType");
                context.Writer.WriteStringValue(requestObject.HealthCheckType);
            }

            if(requestObject.IsSetLaunchConfigurationName())
            {
                context.Writer.WritePropertyName("LaunchConfigurationName");
                context.Writer.WriteStringValue(requestObject.LaunchConfigurationName);
            }

            if(requestObject.IsSetLaunchTemplate())
            {
                context.Writer.WritePropertyName("LaunchTemplate");
                context.Writer.WriteStartObject();

                var marshaller = AwsAutoScalingAutoScalingGroupLaunchTemplateLaunchTemplateSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchTemplate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLoadBalancerNames())
            {
                context.Writer.WritePropertyName("LoadBalancerNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLoadBalancerNamesListValue in requestObject.LoadBalancerNames)
                {
                        context.Writer.WriteStringValue(requestObjectLoadBalancerNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMixedInstancesPolicy())
            {
                context.Writer.WritePropertyName("MixedInstancesPolicy");
                context.Writer.WriteStartObject();

                var marshaller = AwsAutoScalingAutoScalingGroupMixedInstancesPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MixedInstancesPolicy, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsAutoScalingAutoScalingGroupDetailsMarshaller Instance = new AwsAutoScalingAutoScalingGroupDetailsMarshaller();

    }
}