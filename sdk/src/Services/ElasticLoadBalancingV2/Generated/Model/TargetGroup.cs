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
    /// Information about a target group.
    /// </summary>
    public partial class TargetGroup
    {
        private bool? _healthCheckEnabled;
        private int? _healthCheckIntervalSeconds;
        private string _healthCheckPath;
        private string _healthCheckPort;
        private ProtocolEnum _healthCheckProtocol;
        private int? _healthCheckTimeoutSeconds;
        private int? _healthyThresholdCount;
        private List<string> _loadBalancerArns = new List<string>();
        private Matcher _matcher;
        private int? _port;
        private ProtocolEnum _protocol;
        private string _protocolVersion;
        private string _targetGroupArn;
        private string _targetGroupName;
        private TargetTypeEnum _targetType;
        private int? _unhealthyThresholdCount;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property HealthCheckEnabled. 
        /// <para>
        /// Indicates whether health checks are enabled.
        /// </para>
        /// </summary>
        public bool HealthCheckEnabled
        {
            get { return this._healthCheckEnabled.GetValueOrDefault(); }
            set { this._healthCheckEnabled = value; }
        }

        // Check to see if HealthCheckEnabled property is set
        internal bool IsSetHealthCheckEnabled()
        {
            return this._healthCheckEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, between health checks of an individual
        /// target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
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
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// The destination for health checks on the targets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string HealthCheckPath
        {
            get { return this._healthCheckPath; }
            set { this._healthCheckPath = value; }
        }

        // Check to see if HealthCheckPath property is set
        internal bool IsSetHealthCheckPath()
        {
            return this._healthCheckPath != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port to use to connect with the target.
        /// </para>
        /// </summary>
        public string HealthCheckPort
        {
            get { return this._healthCheckPort; }
            set { this._healthCheckPort = value; }
        }

        // Check to see if HealthCheckPort property is set
        internal bool IsSetHealthCheckPort()
        {
            return this._healthCheckPort != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckProtocol. 
        /// <para>
        /// The protocol to use to connect with the target. The GENEVE, TLS, UDP, and TCP_UDP
        /// protocols are not supported for health checks.
        /// </para>
        /// </summary>
        public ProtocolEnum HealthCheckProtocol
        {
            get { return this._healthCheckProtocol; }
            set { this._healthCheckProtocol = value; }
        }

        // Check to see if HealthCheckProtocol property is set
        internal bool IsSetHealthCheckProtocol()
        {
            return this._healthCheckProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckTimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, during which no response means a failed health check.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=120)]
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
        /// The number of consecutive health checks successes required before considering an unhealthy
        /// target healthy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
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
        /// Gets and sets the property LoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the load balancers that route traffic to this target
        /// group.
        /// </para>
        /// </summary>
        public List<string> LoadBalancerArns
        {
            get { return this._loadBalancerArns; }
            set { this._loadBalancerArns = value; }
        }

        // Check to see if LoadBalancerArns property is set
        internal bool IsSetLoadBalancerArns()
        {
            return this._loadBalancerArns != null && this._loadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// The HTTP or gRPC codes to use when checking for a successful response from a target.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the targets are listening. Not used if the target is a Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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
        /// The protocol to use for routing traffic to the targets.
        /// </para>
        /// </summary>
        public ProtocolEnum Protocol
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
        /// [HTTP/HTTPS protocol] The protocol version. The possible values are <code>GRPC</code>,
        /// <code>HTTP1</code>, and <code>HTTP2</code>.
        /// </para>
        /// </summary>
        public string ProtocolVersion
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
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </para>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The name of the target group.
        /// </para>
        /// </summary>
        public string TargetGroupName
        {
            get { return this._targetGroupName; }
            set { this._targetGroupName = value; }
        }

        // Check to see if TargetGroupName property is set
        internal bool IsSetTargetGroupName()
        {
            return this._targetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of target that you must specify when registering targets with this target
        /// group. The possible values are <code>instance</code> (register targets by instance
        /// ID), <code>ip</code> (register targets by IP address), or <code>lambda</code> (register
        /// a single Lambda function as a target).
        /// </para>
        /// </summary>
        public TargetTypeEnum TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive health check failures required before considering the target
        /// unhealthy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the targets.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}