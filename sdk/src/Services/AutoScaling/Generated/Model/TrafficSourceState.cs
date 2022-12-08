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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes the state of a traffic source.
    /// </summary>
    public partial class TrafficSourceState
    {
        private string _state;
        private string _trafficSource;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The following are the possible states for a VPC Lattice target group:
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
        ///  <code>InService</code> - At least one Auto Scaling instance passed the <code>VPC_LATTICE</code>
        /// health check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removing</code> - The Auto Scaling instances are being deregistered from the
        /// target group. If connection draining is enabled, VPC Lattice waits for in-flight requests
        /// to complete before deregistering the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Removed</code> - All Auto Scaling instances are deregistered from the target
        /// group.
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

        /// <summary>
        /// Gets and sets the property TrafficSource. 
        /// <para>
        /// The unique identifier of the traffic source. Currently, this is the Amazon Resource
        /// Name (ARN) for a VPC Lattice target group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=511)]
        public string TrafficSource
        {
            get { return this._trafficSource; }
            set { this._trafficSource = value; }
        }

        // Check to see if TrafficSource property is set
        internal bool IsSetTrafficSource()
        {
            return this._trafficSource != null;
        }

    }
}