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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// The health check configuration of a target group. Health check configurations aren't
    /// used for <code>LAMBDA</code> and <code>ALB</code> target groups.
    /// </summary>
    public partial class HealthCheckConfig
    {
        private bool? _enabled;
        private int? _healthCheckIntervalSeconds;
        private int? _healthCheckTimeoutSeconds;
        private int? _healthyThresholdCount;
        private Matcher _matcher;
        private string _path;
        private int? _port;
        private TargetGroupProtocol _protocol;
        private HealthCheckProtocolVersion _protocolVersion;
        private int? _unhealthyThresholdCount;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether health checking is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, between health checks of an individual
        /// target. The range is 5–300 seconds. The default is 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int HealthCheckIntervalSeconds
        {
            get { return this._healthCheckIntervalSeconds.GetValueOrDefault(); }
            set { this._healthCheckIntervalSeconds = value; }
        }

        // Check to see if HealthCheckIntervalSeconds property is set
        internal bool IsSetHealthCheckIntervalSeconds()
        {
            return this._healthCheckIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckTimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, to wait before reporting a target as unhealthy. The
        /// range is 1–120 seconds. The default is 5 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=120)]
        public int HealthCheckTimeoutSeconds
        {
            get { return this._healthCheckTimeoutSeconds.GetValueOrDefault(); }
            set { this._healthCheckTimeoutSeconds = value; }
        }

        // Check to see if HealthCheckTimeoutSeconds property is set
        internal bool IsSetHealthCheckTimeoutSeconds()
        {
            return this._healthCheckTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthyThresholdCount. 
        /// <para>
        /// The number of consecutive successful health checks required before considering an
        /// unhealthy target healthy. The range is 2–10. The default is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int HealthyThresholdCount
        {
            get { return this._healthyThresholdCount.GetValueOrDefault(); }
            set { this._healthyThresholdCount = value; }
        }

        // Check to see if HealthyThresholdCount property is set
        internal bool IsSetHealthyThresholdCount()
        {
            return this._healthyThresholdCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// The codes to use when checking for a successful response from a target. These are
        /// called <i>Success codes</i> in the console.
        /// </para>
        /// </summary>
        public Matcher Matcher
        {
            get { return this._matcher; }
            set { this._matcher = value; }
        }

        // Check to see if Matcher property is set
        internal bool IsSetMatcher()
        {
            return this._matcher != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The destination for health checks on the targets. If the protocol version is <code>HTTP/1.1</code>
        /// or <code>HTTP/2</code>, specify a valid URI (for example, <code>/path?query</code>).
        /// The default path is <code>/</code>. Health checks are not supported if the protocol
        /// version is <code>gRPC</code>, however, you can choose <code>HTTP/1.1</code> or <code>HTTP/2</code>
        /// and specify a valid URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port used when performing health checks on targets. The default setting is the
        /// port that a target receives traffic on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used when performing health checks on targets. The possible protocols
        /// are <code>HTTP</code> and <code>HTTPS</code>. The default is <code>HTTP</code>.
        /// </para>
        /// </summary>
        public TargetGroupProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolVersion. 
        /// <para>
        /// The protocol version used when performing health checks on targets. The possible protocol
        /// versions are <code>HTTP1</code> and <code>HTTP2</code>.
        /// </para>
        /// </summary>
        public HealthCheckProtocolVersion ProtocolVersion
        {
            get { return this._protocolVersion; }
            set { this._protocolVersion = value; }
        }

        // Check to see if ProtocolVersion property is set
        internal bool IsSetProtocolVersion()
        {
            return this._protocolVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive failed health checks required before considering a target
        /// unhealthy. The range is 2–10. The default is 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int UnhealthyThresholdCount
        {
            get { return this._unhealthyThresholdCount.GetValueOrDefault(); }
            set { this._unhealthyThresholdCount = value; }
        }

        // Check to see if UnhealthyThresholdCount property is set
        internal bool IsSetUnhealthyThresholdCount()
        {
            return this._unhealthyThresholdCount.HasValue; 
        }

    }
}