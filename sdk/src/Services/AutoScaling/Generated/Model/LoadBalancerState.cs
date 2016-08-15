/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes the state of a Classic load balancer.
    /// 
    ///  
    /// <para>
    /// If you specify a load balancer when creating the Auto Scaling group, the state of
    /// the load balancer is <code>InService</code>.
    /// </para>
    ///  
    /// <para>
    /// If you attach a load balancer to an existing Auto Scaling group, the initial state
    /// is <code>Adding</code>. The state transitions to <code>Added</code> after all instances
    /// in the group are registered with the load balancer. If ELB health checks are enabled
    /// for the load balancer, the state transitions to <code>InService</code> after at least
    /// one instance in the group passes the health check. If EC2 health checks are enabled
    /// instead, the load balancer remains in the <code>Added</code> state.
    /// </para>
    /// </summary>
    public partial class LoadBalancerState
    {
        private string _loadBalancerName;
        private string _state;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// One of the following load balancer states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Adding</code> - The instances in the group are being registered with the load
        /// balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Added</code> - All instances in the group are registered with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InService</code> - At least one instance in the group passed an ELB health
        /// check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removing</code> - The instances in the group are being deregistered from the
        /// load balancer. If connection draining is enabled, Elastic Load Balancing waits for
        /// in-flight requests to complete before deregistering the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removed</code> - All instances in the group are deregistered from the load
        /// balancer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}