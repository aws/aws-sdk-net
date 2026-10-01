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

using Amazon.SecurityHub.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetails Marshaller
    /// </summary>
    public partial class AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetailsMarshaller : IRequestMarshaller<AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetails, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetails requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetOnDemandAllocationStrategy())
            {
                context.Writer.WritePropertyName("OnDemandAllocationStrategy");
                context.Writer.WriteStringValue(requestObject.OnDemandAllocationStrategy);
            }

            if (requestObject.IsSetOnDemandBaseCapacity())
            {
                context.Writer.WritePropertyName("OnDemandBaseCapacity");
                context.Writer.WriteNumberValue(requestObject.OnDemandBaseCapacity.Value);
            }

            if (requestObject.IsSetOnDemandPercentageAboveBaseCapacity())
            {
                context.Writer.WritePropertyName("OnDemandPercentageAboveBaseCapacity");
                context.Writer.WriteNumberValue(requestObject.OnDemandPercentageAboveBaseCapacity.Value);
            }

            if (requestObject.IsSetSpotAllocationStrategy())
            {
                context.Writer.WritePropertyName("SpotAllocationStrategy");
                context.Writer.WriteStringValue(requestObject.SpotAllocationStrategy);
            }

            if (requestObject.IsSetSpotInstancePools())
            {
                context.Writer.WritePropertyName("SpotInstancePools");
                context.Writer.WriteNumberValue(requestObject.SpotInstancePools.Value);
            }

            if (requestObject.IsSetSpotMaxPrice())
            {
                context.Writer.WritePropertyName("SpotMaxPrice");
                context.Writer.WriteStringValue(requestObject.SpotMaxPrice);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetailsMarshaller Instance = new AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetailsMarshaller();
    }
}
