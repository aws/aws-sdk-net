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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
    /// Container for the parameters to the ModifyCapacityReservation operation.
    /// Modifies the capacity reservation of the specified load balancer.
    /// 
    ///  
    /// <para>
    /// When modifying capacity reservation, you must include at least one <c>MinimumLoadBalancerCapacity</c>
    /// or <c>ResetCapacityReservation</c>.
    /// </para>
    /// </summary>
    public partial class ModifyCapacityReservationRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _loadBalancerArn;
        private MinimumLoadBalancerCapacity _minimumLoadBalancerCapacity;
        private bool? _resetCapacityReservation;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumLoadBalancerCapacity. 
        /// <para>
        /// The minimum load balancer capacity reserved.
        /// </para>
        /// </summary>
        public MinimumLoadBalancerCapacity MinimumLoadBalancerCapacity
        {
            get { return this._minimumLoadBalancerCapacity; }
            set { this._minimumLoadBalancerCapacity = value; }
        }

        // Check to see if MinimumLoadBalancerCapacity property is set
        internal bool IsSetMinimumLoadBalancerCapacity()
        {
            return this._minimumLoadBalancerCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ResetCapacityReservation. 
        /// <para>
        /// Resets the capacity reservation.
        /// </para>
        /// </summary>
        public bool? ResetCapacityReservation
        {
            get { return this._resetCapacityReservation; }
            set { this._resetCapacityReservation = value; }
        }

        // Check to see if ResetCapacityReservation property is set
        internal bool IsSetResetCapacityReservation()
        {
            return this._resetCapacityReservation.HasValue; 
        }

    }
}