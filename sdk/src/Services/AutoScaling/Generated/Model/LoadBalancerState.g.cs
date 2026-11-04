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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes the state of a Classic Load Balancer.
    /// </summary>
    public partial class LoadBalancerState
    {
        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// One of the following load balancer states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Adding</c> - The Auto Scaling instances are being registered with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Added</c> - All Auto Scaling instances are registered with the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InService</c> - At least one Auto Scaling instance passed an <c>ELB</c> health
        /// check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removing</c> - The Auto Scaling instances are being deregistered from the load
        /// balancer. If connection draining is enabled, Elastic Load Balancing waits for in-flight
        /// requests to complete before deregistering the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removed</c> - All Auto Scaling instances are deregistered from the load balancer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
