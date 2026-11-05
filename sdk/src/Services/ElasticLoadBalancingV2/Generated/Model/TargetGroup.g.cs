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
    /// Information about a target group.
    /// </summary>
    public partial class TargetGroup
    {
        /// <summary>
        /// Gets and sets the property HealthCheckEnabled. 
        /// <para>
        /// Indicates whether health checks are enabled.
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
        /// The destination for health checks on the targets.
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
        /// The port to use to connect with the target.
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
        /// The protocol to use to connect with the target. The GENEVE, TLS, UDP, and TCP_UDP
        /// protocols are not supported for health checks.
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
        /// The amount of time, in seconds, during which no response means a failed health check.
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
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type. The default value is <c>ipv4</c>.
        /// </para>
        /// </summary>
        public TargetGroupIpAddressTypeEnum IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer that routes traffic to this target
        /// group. You can use each target group with only one load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetLoadBalancerArns() => this.LoadBalancerArns != null && (this.LoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// The HTTP or gRPC codes to use when checking for a successful response from a target.
        /// </para>
        /// </summary>
        public Matcher Matcher { get; set; }

        /// <summary>
        /// Checks to see if the Matcher property is set.
        /// </summary>
        internal bool IsSetMatcher() => this.Matcher != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the targets are listening. This parameter is not used if the target
        /// is a Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use for routing traffic to the targets.
        /// </para>
        /// </summary>
        public ProtocolEnum Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ProtocolVersion. 
        /// <para>
        /// [HTTP/HTTPS protocol] The protocol version. The possible values are <c>GRPC</c>, <c>HTTP1</c>,
        /// and <c>HTTP2</c>.
        /// </para>
        /// </summary>
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolVersion property is set.
        /// </summary>
        internal bool IsSetProtocolVersion() => this.ProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property TargetControlPort. 
        /// <para>
        /// The port on which the target control agent and application load balancer exchange
        /// management traffic for the target optimizer feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? TargetControlPort { get; set; }

        /// <summary>
        /// Checks to see if the TargetControlPort property is set.
        /// </summary>
        internal bool IsSetTargetControlPort() => this.TargetControlPort.HasValue;

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </para>
        /// </summary>
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The name of the target group.
        /// </para>
        /// </summary>
        public string TargetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupName property is set.
        /// </summary>
        internal bool IsSetTargetGroupName() => this.TargetGroupName != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of target that you must specify when registering targets with this target
        /// group. The possible values are <c>instance</c> (register targets by instance ID),
        /// <c>ip</c> (register targets by IP address), <c>lambda</c> (register a single Lambda
        /// function as a target), or <c>alb</c> (register a single Application Load Balancer
        /// as a target).
        /// </para>
        /// </summary>
        public TargetTypeEnum TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the targets.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
