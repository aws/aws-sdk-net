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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTargetGroup operation. Modifies the health
    /// checks used when evaluating the health state of the targets in the specified target
    /// group.
    /// </summary>
    public partial class ModifyTargetGroupRequest : AmazonElasticLoadBalancingV2Request
    {
        /// <summary>
        /// Gets and sets the property HealthCheckEnabled. 
        /// <para>
        /// Indicates whether health checks are enabled. If the target type is <c>lambda</c>,
        /// health checks are disabled by default but can be enabled. If the target type is <c>instance</c>,
        /// <c>ip</c>, or <c>alb</c>, health checks are always enabled and can't be disabled.
        /// </para>
        /// </summary>
        public bool? HealthCheckEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckEnabled property is set.
        /// </summary>
        internal bool IsSetHealthCheckEnabled() => this.HealthCheckEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, between health checks of an individual
        /// target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 300)]
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckIntervalSeconds() => this.HealthCheckIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// [HTTP/HTTPS health checks] The destination for health checks on the targets.
        /// </para>
        ///  
        /// <para>
        /// [HTTP1 or HTTP2 protocol version] The ping path. The default is /.
        /// </para>
        ///  
        /// <para>
        /// [GRPC protocol version] The path of a custom health check method with the format /package.service/method.
        /// The default is /Amazon Web Services.ALB/healthcheck.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port the load balancer uses when performing health checks on targets.
        /// </para>
        /// </summary>
        public string HealthCheckPort { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPort property is set.
        /// </summary>
        internal bool IsSetHealthCheckPort() => this.HealthCheckPort != null;

        /// <summary>
        /// Gets and sets the property HealthCheckProtocol. 
        /// <para>
        /// The protocol the load balancer uses when performing health checks on targets. For
        /// Application Load Balancers, the default is HTTP. For Network Load Balancers and Gateway
        /// Load Balancers, the default is TCP. The TCP protocol is not supported for health checks
        /// if the protocol of the target group is HTTP or HTTPS. It is supported for health checks
        /// only if the protocol of the target group is TCP, TLS, UDP, or TCP_UDP. The GENEVE,
        /// TLS, UDP, TCP_UDP, QUIC, and TCP_QUIC protocols are not supported for health checks.
        /// </para>
        /// </summary>
        public ProtocolEnum HealthCheckProtocol { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckProtocol property is set.
        /// </summary>
        internal bool IsSetHealthCheckProtocol() => this.HealthCheckProtocol != null;

        /// <summary>
        /// Gets and sets the property HealthCheckTimeoutSeconds. 
        /// <para>
        /// [HTTP/HTTPS health checks] The amount of time, in seconds, during which no response
        /// means a failed health check.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 120)]
        public int? HealthCheckTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckTimeoutSeconds() => this.HealthCheckTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyThresholdCount. 
        /// <para>
        /// The number of consecutive health checks successes required before considering an unhealthy
        /// target healthy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public int? HealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the HealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetHealthyThresholdCount() => this.HealthyThresholdCount.HasValue;

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// [HTTP/HTTPS health checks] The HTTP or gRPC codes to use when checking for a successful
        /// response from a target. For target groups with a protocol of TCP, TCP_UDP, UDP or
        /// TLS the range is 200-599. For target groups with a protocol of HTTP or HTTPS, the
        /// range is 200-499. For target groups with a protocol of GENEVE, the range is 200-399.
        /// </para>
        /// </summary>
        public Matcher Matcher { get; set; }

        /// <summary>
        /// Checks to see if the Matcher property is set.
        /// </summary>
        internal bool IsSetMatcher() => this.Matcher != null;

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive health check failures required before considering the target
        /// unhealthy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public int? UnhealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetUnhealthyThresholdCount() => this.UnhealthyThresholdCount.HasValue;
    }
}
