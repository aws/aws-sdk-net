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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a target group attribute.
    /// </summary>
    public partial class TargetGroupAttribute
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        ///  
        /// <para>
        /// The following attributes are supported by both Application Load Balancers and Network
        /// Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deregistration_delay.timeout_seconds</code> - The amount of time, in seconds,
        /// for Elastic Load Balancing to wait before changing the state of a deregistering target
        /// from <code>draining</code> to <code>unused</code>. The range is 0-3600 seconds. The
        /// default value is 300 seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by only Application Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>slow_start.duration_seconds</code> - The time period, in seconds, during which
        /// a newly registered target receives a linearly increasing share of the traffic to the
        /// target group. After this time period ends, the target receives its full share of traffic.
        /// The range is 30-900 seconds (15 minutes). Slow start mode is disabled by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.enabled</code> - Indicates whether sticky sessions are enabled.
        /// The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.type</code> - The type of sticky sessions. The possible value is
        /// <code>lb_cookie</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.lb_cookie.duration_seconds</code> - The time period, in seconds,
        /// during which requests from a client should be routed to the same target. After this
        /// time period expires, the load balancer-generated cookie is considered stale. The range
        /// is 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by only Network Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>proxy_protocol_v2.enabled</code> - Indicates whether Proxy Protocol version
        /// 2 is enabled. The value is <code>true</code> or <code>false</code>. The default is
        /// <code>false</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}