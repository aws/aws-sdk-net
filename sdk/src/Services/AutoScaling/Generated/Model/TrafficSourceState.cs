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
    /// Describes the state of a traffic source.
    /// </summary>
    public partial class TrafficSourceState
    {
        private string _identifier;
        private string _state;
        private string _trafficSource;
        private string _type;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the traffic source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=511)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Describes the current state of a traffic source.
        /// </para>
        ///  
        /// <para>
        /// The state values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Adding</c> - The Auto Scaling instances are being registered with the load balancer
        /// or target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Added</c> - All Auto Scaling instances are registered with the load balancer or
        /// target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InService</c> - For an Elastic Load Balancing load balancer or target group, at
        /// least one Auto Scaling instance passed an <c>ELB</c> health check. For VPC Lattice,
        /// at least one Auto Scaling instance passed an <c>VPC_LATTICE</c> health check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removing</c> - The Auto Scaling instances are being deregistered from the load
        /// balancer or target group. If connection draining (deregistration delay) is enabled,
        /// Elastic Load Balancing or VPC Lattice waits for in-flight requests to complete before
        /// deregistering the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Removed</c> - All Auto Scaling instances are deregistered from the load balancer
        /// or target group.
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
        /// This is replaced by <c>Identifier</c>.
        /// </para>
        /// </summary>
        [Obsolete("TrafficSource has been replaced by Identifier")]
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Provides additional context for the value of <c>Identifier</c>.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>elb</c> if <c>Identifier</c> is the name of a Classic Load Balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elbv2</c> if <c>Identifier</c> is the ARN of an Application Load Balancer, Gateway
        /// Load Balancer, or Network Load Balancer target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-lattice</c> if <c>Identifier</c> is the ARN of a VPC Lattice target group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Required if the identifier is the name of a Classic Load Balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=511)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}