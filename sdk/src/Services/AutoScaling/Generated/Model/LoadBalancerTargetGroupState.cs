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
    /// Describes the state of a target group.
    /// 
    ///  
    /// <para>
    /// If you attach a target group to an existing Auto Scaling group, the initial state
    /// is <code>Adding</code>. The state transitions to <code>Added</code> after all Auto
    /// Scaling instances are registered with the target group. If ELB health checks are enabled,
    /// the state transitions to <code>InService</code> after at least one Auto Scaling instance
    /// passes the health check. If EC2 health checks are enabled instead, the target group
    /// remains in the <code>Added</code> state.
    /// </para>
    /// </summary>
    public partial class LoadBalancerTargetGroupState
    {
        private string _loadBalancerTargetGroupARN;
        private string _state;

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </para>
        /// </summary>
        public string LoadBalancerTargetGroupARN
        {
            get { return this._loadBalancerTargetGroupARN; }
            set { this._loadBalancerTargetGroupARN = value; }
        }

        // Check to see if LoadBalancerTargetGroupARN property is set
        internal bool IsSetLoadBalancerTargetGroupARN()
        {
            return this._loadBalancerTargetGroupARN != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the target group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Adding</code> - The Auto Scaling instances are being registered with the target
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Added</code> - All Auto Scaling instances are registered with the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InService</code> - At least one Auto Scaling instance passed an ELB health
        /// check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removing</code> - The Auto Scaling instances are being deregistered from the
        /// target group. If connection draining is enabled, Elastic Load Balancing waits for
        /// in-flight requests to complete before deregistering the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removed</code> - All Auto Scaling instances are deregistered from the target
        /// group.
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