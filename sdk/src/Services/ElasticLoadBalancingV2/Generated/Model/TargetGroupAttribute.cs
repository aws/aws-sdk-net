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
        ///  <c>deregistration_delay.timeout_seconds</c> - The amount of time, in seconds, for
        /// Elastic Load Balancing to wait before changing the state of a deregistering target
        /// from <c>draining</c> to <c>unused</c>. The range is 0-3600 seconds. The default value
        /// is 300 seconds. If the target is a Lambda function, this attribute is not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stickiness.enabled</c> - Indicates whether target stickiness is enabled. The value
        /// is <c>true</c> or <c>false</c>. The default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stickiness.type</c> - Indicates the type of stickiness. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>lb_cookie</c> and <c>app_cookie</c> for Application Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source_ip</c> for Network Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source_ip_dest_ip</c> and <c>source_ip_dest_ip_proto</c> for Gateway Load Balancers.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following attributes are supported by Application Load Balancers and Network Load
        /// Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>load_balancing.cross_zone.enabled</c> - Indicates whether cross zone load balancing
        /// is enabled. The value is <c>true</c>, <c>false</c> or <c>use_load_balancer_configuration</c>.
        /// The default is <c>use_load_balancer_configuration</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_group_health.dns_failover.minimum_healthy_targets.count</c> - The minimum
        /// number of targets that must be healthy. If the number of healthy targets is below
        /// this value, mark the zone as unhealthy in DNS, so that traffic is routed only to healthy
        /// zones. The possible values are <c>off</c> or an integer from 1 to the maximum number
        /// of targets. The default is 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_group_health.dns_failover.minimum_healthy_targets.percentage</c> - The
        /// minimum percentage of targets that must be healthy. If the percentage of healthy targets
        /// is below this value, mark the zone as unhealthy in DNS, so that traffic is routed
        /// only to healthy zones. The possible values are <c>off</c> or an integer from 1 to
        /// 100. The default is <c>off</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_group_health.unhealthy_state_routing.minimum_healthy_targets.count</c>
        /// - The minimum number of targets that must be healthy. If the number of healthy targets
        /// is below this value, send traffic to all targets, including unhealthy targets. The
        /// possible values are 1 to the maximum number of targets. The default is 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_group_health.unhealthy_state_routing.minimum_healthy_targets.percentage</c>
        /// - The minimum percentage of targets that must be healthy. If the percentage of healthy
        /// targets is below this value, send traffic to all targets, including unhealthy targets.
        /// The possible values are <c>off</c> or an integer from 1 to 100. The default is <c>off</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported only if the load balancer is an Application
        /// Load Balancer and the target is an instance or an IP address:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>load_balancing.algorithm.type</c> - The load balancing algorithm determines how
        /// the load balancer selects targets when routing requests. The value is <c>round_robin</c>,
        /// <c>least_outstanding_requests</c>, or <c>weighted_random</c>. The default is <c>round_robin</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>load_balancing.algorithm.anomaly_mitigation</c> - Only available when <c>load_balancing.algorithm.type</c>
        /// is <c>weighted_random</c>. Indicates whether anomaly mitigation is enabled. The value
        /// is <c>on</c> or <c>off</c>. The default is <c>off</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>slow_start.duration_seconds</c> - The time period, in seconds, during which a
        /// newly registered target receives an increasing share of the traffic to the target
        /// group. After this time period ends, the target receives its full share of traffic.
        /// The range is 30-900 seconds (15 minutes). The default is 0 seconds (disabled).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stickiness.app_cookie.cookie_name</c> - Indicates the name of the application-based
        /// cookie. Names that start with the following prefixes are not allowed: <c>AWSALB</c>,
        /// <c>AWSALBAPP</c>, and <c>AWSALBTG</c>; they're reserved for use by the load balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stickiness.app_cookie.duration_seconds</c> - The time period, in seconds, during
        /// which requests from a client should be routed to the same target. After this time
        /// period expires, the application-based cookie is considered stale. The range is 1 second
        /// to 1 week (604800 seconds). The default value is 1 day (86400 seconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stickiness.lb_cookie.duration_seconds</c> - The time period, in seconds, during
        /// which requests from a client should be routed to the same target. After this time
        /// period expires, the load balancer-generated cookie is considered stale. The range
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
        ///  <c>lambda.multi_value_headers.enabled</c> - Indicates whether the request and response
        /// headers that are exchanged between the load balancer and the Lambda function include
        /// arrays of values or strings. The value is <c>true</c> or <c>false</c>. The default
        /// is <c>false</c>. If the value is <c>false</c> and the request contains a duplicate
        /// header field name or query parameter key, the load balancer uses the last value sent
        /// by the client.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported only by Network Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>deregistration_delay.connection_termination.enabled</c> - Indicates whether the
        /// load balancer terminates connections at the end of the deregistration timeout. The
        /// value is <c>true</c> or <c>false</c>. For new UDP/TCP_UDP target groups the default
        /// is <c>true</c>. Otherwise, the default is <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>preserve_client_ip.enabled</c> - Indicates whether client IP preservation is enabled.
        /// The value is <c>true</c> or <c>false</c>. The default is disabled if the target group
        /// type is IP address and the target group protocol is TCP or TLS. Otherwise, the default
        /// is enabled. Client IP preservation can't be disabled for UDP and TCP_UDP target groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>proxy_protocol_v2.enabled</c> - Indicates whether Proxy Protocol version 2 is
        /// enabled. The value is <c>true</c> or <c>false</c>. The default is <c>false</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_health_state.unhealthy.connection_termination.enabled</c> - Indicates whether
        /// the load balancer terminates connections to unhealthy targets. The value is <c>true</c>
        /// or <c>false</c>. The default is <c>true</c>. This attribute can't be enabled for UDP
        /// and TCP_UDP target groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_health_state.unhealthy.draining_interval_seconds</c> - The amount of time
        /// for Elastic Load Balancing to wait before changing the state of an unhealthy target
        /// from <c>unhealthy.draining</c> to <c>unhealthy</c>. The range is 0-360000 seconds.
        /// The default value is 0 seconds.
        /// </para>
        ///  
        /// <para>
        /// Note: This attribute can only be configured when <c>target_health_state.unhealthy.connection_termination.enabled</c>
        /// is <c>false</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported only by Gateway Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>target_failover.on_deregistration</c> - Indicates how the Gateway Load Balancer
        /// handles existing flows when a target is deregistered. The possible values are <c>rebalance</c>
        /// and <c>no_rebalance</c>. The default is <c>no_rebalance</c>. The two attributes (<c>target_failover.on_deregistration</c>
        /// and <c>target_failover.on_unhealthy</c>) can't be set independently. The value you
        /// set for both attributes must be the same. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target_failover.on_unhealthy</c> - Indicates how the Gateway Load Balancer handles
        /// existing flows when a target is unhealthy. The possible values are <c>rebalance</c>
        /// and <c>no_rebalance</c>. The default is <c>no_rebalance</c>. The two attributes (<c>target_failover.on_deregistration</c>
        /// and <c>target_failover.on_unhealthy</c>) can't be set independently. The value you
        /// set for both attributes must be the same. 
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