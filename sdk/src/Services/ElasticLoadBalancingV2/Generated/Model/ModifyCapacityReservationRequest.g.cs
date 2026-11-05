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

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCapacityReservation operation. Modifies
    /// the capacity reservation of the specified load balancer. <para> When modifying capacity
    /// reservation, you must include at least one <c>MinimumLoadBalancerCapacity</c> or <c>ResetCapacityReservation</c>.
    /// </para>
    /// </summary>
    public partial class ModifyCapacityReservationRequest : AmazonElasticLoadBalancingV2Request
    {
        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LoadBalancerArn { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerArn property is set.
        /// </summary>
        internal bool IsSetLoadBalancerArn() => this.LoadBalancerArn != null;

        /// <summary>
        /// Gets and sets the property MinimumLoadBalancerCapacity. 
        /// <para>
        /// The minimum load balancer capacity reserved.
        /// </para>
        /// </summary>
        public MinimumLoadBalancerCapacity MinimumLoadBalancerCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLoadBalancerCapacity property is set.
        /// </summary>
        internal bool IsSetMinimumLoadBalancerCapacity() => this.MinimumLoadBalancerCapacity != null;

        /// <summary>
        /// Gets and sets the property ResetCapacityReservation. 
        /// <para>
        /// Resets the capacity reservation.
        /// </para>
        /// </summary>
        public bool? ResetCapacityReservation { get; set; }

        /// <summary>
        /// Checks to see if the ResetCapacityReservation property is set.
        /// </summary>
        internal bool IsSetResetCapacityReservation() => this.ResetCapacityReservation.HasValue;
    }
}
