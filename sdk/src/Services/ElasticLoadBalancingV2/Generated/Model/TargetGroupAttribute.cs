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
        /// The following attributes are supported by all load balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deregistration_delay.timeout_seconds</code> - The amount of time, in seconds,
        /// for Elastic Load Balancing to wait before changing the state of a deregistering target
        /// from <code>draining</code> to <code>unused</code>. The range is 0-3600 seconds. The
        /// default value is 300 seconds. If the target is a Lambda function, this attribute is
        /// not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.enabled</code> - Indicates whether target stickiness is enabled.
        /// The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.type</code> - Indicates the type of stickiness. The possible values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>lb_cookie</code> and <code>app_cookie</code> for Application Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source_ip</code> for Network Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source_ip_dest_ip</code> and <code>source_ip_dest_ip_proto</code> for Gateway
        /// Load Balancers.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following attributes are supported by Application Load Balancers and Network Load
        /// Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>load_balancing.cross_zone.enabled</code> - Indicates whether cross zone load
        /// balancing is enabled. The value is <code>true</code>, <code>false</code> or <code>use_load_balancer_configuration</code>.
        /// The default is <code>use_load_balancer_configuration</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target_group_health.dns_failover.minimum_healthy_targets.count</code> - The
        /// minimum number of targets that must be healthy. If the number of healthy targets is
        /// below this value, mark the zone as unhealthy in DNS, so that traffic is routed only
        /// to healthy zones. The possible values are <code>off</code> or an integer from 1 to
        /// the maximum number of targets. The default is <code>off</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target_group_health.dns_failover.minimum_healthy_targets.percentage</code>
        /// - The minimum percentage of targets that must be healthy. If the percentage of healthy
        /// targets is below this value, mark the zone as unhealthy in DNS, so that traffic is
        /// routed only to healthy zones. The possible values are <code>off</code> or an integer
        /// from 1 to 100. The default is <code>off</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target_group_health.unhealthy_state_routing.minimum_healthy_targets.count</code>
        /// - The minimum number of targets that must be healthy. If the number of healthy targets
        /// is below this value, send traffic to all targets, including unhealthy targets. The
        /// possible values are 1 to the maximum number of targets. The default is 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target_group_health.unhealthy_state_routing.minimum_healthy_targets.percentage</code>
        /// - The minimum percentage of targets that must be healthy. If the percentage of healthy
        /// targets is below this value, send traffic to all targets, including unhealthy targets.
        /// The possible values are <code>off</code> or an integer from 1 to 100. The default
        /// is <code>off</code>.
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
        ///  <code>stickiness.app_cookie.cookie_name</code> - Indicates the name of the application-based
        /// cookie. Names that start with the following prefixes are not allowed: <code>AWSALB</code>,
        /// <code>AWSALBAPP</code>, and <code>AWSALBTG</code>; they're reserved for use by the
        /// load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.app_cookie.duration_seconds</code> - The time period, in seconds,
        /// during which requests from a client should be routed to the same target. After this
        /// time period expires, the application-based cookie is considered stale. The range is
        /// 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stickiness.lb_cookie.duration_seconds</code> - The time period, in seconds,
        /// during which requests from a client should be routed to the same target. After this
        /// time period expires, the load balancer-generated cookie is considered stale. The range
        /// is 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).
        /// 
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
        ///  <code>preserve_client_ip.enabled</code> - Indicates whether client IP preservation
        /// is enabled. The value is <code>true</code> or <code>false</code>. The default is disabled
        /// if the target group type is IP address and the target group protocol is TCP or TLS.
        /// Otherwise, the default is enabled. Client IP preservation cannot be disabled for UDP
        /// and TCP_UDP target groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>proxy_protocol_v2.enabled</code> - Indicates whether Proxy Protocol version
        /// 2 is enabled. The value is <code>true</code> or <code>false</code>. The default is
        /// <code>false</code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported only by Gateway Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>target_failover.on_deregistration</code> - Indicates how the Gateway Load Balancer
        /// handles existing flows when a target is deregistered. The possible values are <code>rebalance</code>
        /// and <code>no_rebalance</code>. The default is <code>no_rebalance</code>. The two attributes
        /// (<code>target_failover.on_deregistration</code> and <code>target_failover.on_unhealthy</code>)
        /// can't be set independently. The value you set for both attributes must be the same.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target_failover.on_unhealthy</code> - Indicates how the Gateway Load Balancer
        /// handles existing flows when a target is unhealthy. The possible values are <code>rebalance</code>
        /// and <code>no_rebalance</code>. The default is <code>no_rebalance</code>. The two attributes
        /// (<code>target_failover.on_deregistration</code> and <code>target_failover.on_unhealthy</code>)
        /// cannot be set independently. The value you set for both attributes must be the same.
        /// 
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