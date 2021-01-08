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
        /// The following attribute is supported by all load balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deregistration_delay.timeout_seconds</code> - The amount of time, in seconds,
        /// for Elastic Load Balancing to wait before changing the state of a deregistering target
        /// from <code>draining</code> to <code>unused</code>. The range is 0-3600 seconds. The
        /// default value is 300 seconds. If the target is a Lambda function, this attribute is
        /// not supported.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by both Application Load Balancers and Network
        /// Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>stickiness.enabled</code> - Indicates whether sticky sessions are enabled.
        /// The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.type</code> - The type of sticky sessions. The possible values are
        /// <code>lb_cookie</code> for Application Load Balancers or <code>source_ip</code> for
        /// Network Load Balancers.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported only if the load balancer is an Application
        /// Load Balancer and the target is an instance or an IP address:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>load_balancing.algorithm.type</code> - The load balancing algorithm determines
        /// how the load balancer selects targets when routing requests. The value is <code>round_robin</code>
        /// or <code>least_outstanding_requests</code>. The default is <code>round_robin</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>slow_start.duration_seconds</code> - The time period, in seconds, during which
        /// a newly registered target receives an increasing share of the traffic to the target
        /// group. After this time period ends, the target receives its full share of traffic.
        /// The range is 30-900 seconds (15 minutes). The default is 0 seconds (disabled).
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
        /// The following attribute is supported only if the load balancer is an Application Load
        /// Balancer and the target is a Lambda function:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>lambda.multi_value_headers.enabled</code> - Indicates whether the request and
        /// response headers that are exchanged between the load balancer and the Lambda function
        /// include arrays of values or strings. The value is <code>true</code> or <code>false</code>.
        /// The default is <code>false</code>. If the value is <code>false</code> and the request
        /// contains a duplicate header field name or query parameter key, the load balancer uses
        /// the last value sent by the client.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported only by Network Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deregistration_delay.connection_termination.enabled</code> - Indicates whether
        /// the load balancer terminates connections at the end of the deregistration timeout.
        /// The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>proxy_protocol_v2.enabled</code> - Indicates whether Proxy Protocol version
        /// 2 is enabled. The value is <code>true</code> or <code>false</code>. The default is
        /// <code>false</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
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