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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes the state of a target group.
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
        [AWSProperty(Min=1, Max=511)]
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
        ///  <c>Adding</c> - The Auto Scaling instances are being registered with the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Added</c> - All Auto Scaling instances are registered with the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InService</c> - At least one Auto Scaling instance passed an <c>ELB</c> health
        /// check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removing</c> - The Auto Scaling instances are being deregistered from the target
        /// group. If connection draining is enabled, Elastic Load Balancing waits for in-flight
        /// requests to complete before deregistering the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removed</c> - All Auto Scaling instances are deregistered from the target group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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