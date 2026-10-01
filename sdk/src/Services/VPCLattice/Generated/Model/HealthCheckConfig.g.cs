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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes the health check configuration of a target group. Health check configurations
    /// aren't used for target groups of type <c>LAMBDA</c> or <c>ALB</c>.
    /// </summary>
    public partial class HealthCheckConfig
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether health checking is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, between health checks of an individual
        /// target. The range is 5–300 seconds. The default is 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckIntervalSeconds() => this.HealthCheckIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckTimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, to wait before reporting a target as unhealthy. The
        /// range is 1–120 seconds. The default is 5 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public int? HealthCheckTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckTimeoutSeconds() => this.HealthCheckTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyThresholdCount. 
        /// <para>
        /// The number of consecutive successful health checks required before considering an
        /// unhealthy target healthy. The range is 2–10. The default is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? HealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the HealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetHealthyThresholdCount() => this.HealthyThresholdCount.HasValue;

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// The codes to use when checking for a successful response from a target.
        /// </para>
        /// </summary>
        public Matcher Matcher { get; set; }

        /// <summary>
        /// Checks to see if the Matcher property is set.
        /// </summary>
        internal bool IsSetMatcher() => this.Matcher != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The destination for health checks on the targets. If the protocol version is <c>HTTP/1.1</c>
        /// or <c>HTTP/2</c>, specify a valid URI (for example, <c>/path?query</c>). The default
        /// path is <c>/</c>. Health checks are not supported if the protocol version is <c>gRPC</c>,
        /// however, you can choose <c>HTTP/1.1</c> or <c>HTTP/2</c> and specify a valid URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port used when performing health checks on targets. The default setting is the
        /// port that a target receives traffic on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used when performing health checks on targets. The possible protocols
        /// are <c>HTTP</c> and <c>HTTPS</c>. The default is <c>HTTP</c>.
        /// </para>
        /// </summary>
        public TargetGroupProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ProtocolVersion. 
        /// <para>
        /// The protocol version used when performing health checks on targets. The possible protocol
        /// versions are <c>HTTP1</c> and <c>HTTP2</c>.
        /// </para>
        /// </summary>
        public HealthCheckProtocolVersion ProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolVersion property is set.
        /// </summary>
        internal bool IsSetProtocolVersion() => this.ProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive failed health checks required before considering a target
        /// unhealthy. The range is 2–10. The default is 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? UnhealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetUnhealthyThresholdCount() => this.UnhealthyThresholdCount.HasValue;
    }
}
