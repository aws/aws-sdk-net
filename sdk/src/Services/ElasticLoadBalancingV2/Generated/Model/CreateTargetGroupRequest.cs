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
    /// Container for the parameters to the CreateTargetGroup operation.
    /// Creates a target group.
    /// 
    ///  
    /// <para>
    /// To register targets with the target group, use <a>RegisterTargets</a>. To update the
    /// health check settings for the target group, use <a>ModifyTargetGroup</a>. To monitor
    /// the health of targets in the target group, use <a>DescribeTargetHealth</a>.
    /// </para>
    ///  
    /// <para>
    /// To route traffic to the targets in a target group, specify the target group in an
    /// action using <a>CreateListener</a> or <a>CreateRule</a>.
    /// </para>
    ///  
    /// <para>
    /// To delete a target group, use <a>DeleteTargetGroup</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent, which means that it completes at most one time. If you
    /// attempt to create multiple target groups with the same settings, each call succeeds.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html">Target
    /// Groups for Your Application Load Balancers</a> in the <i>Application Load Balancers
    /// Guide</i> or <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html">Target
    /// Groups for Your Network Load Balancers</a> in the <i>Network Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateTargetGroupRequest : AmazonElasticLoadBalancingV2Request
    {
        private bool? _healthCheckEnabled;
        private int? _healthCheckIntervalSeconds;
        private string _healthCheckPath;
        private string _healthCheckPort;
        private ProtocolEnum _healthCheckProtocol;
        private int? _healthCheckTimeoutSeconds;
        private int? _healthyThresholdCount;
        private Matcher _matcher;
        private string _name;
        private int? _port;
        private ProtocolEnum _protocol;
        private TargetTypeEnum _targetType;
        private int? _unhealthyThresholdCount;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property HealthCheckEnabled. 
        /// <para>
        /// Indicates whether health checks are enabled. If the target type is <code>instance</code>
        /// or <code>ip</code>, the default is <code>true</code>. If the target type is <code>lambda</code>,
        /// the default is <code>false</code>.
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
        /// target. For Application Load Balancers, the range is 5–300 seconds. For Network Load
        /// Balancers, the supported values are 10 or 30 seconds. If the target type is <code>instance</code>
        /// or <code>ip</code>, the default is 30 seconds. If the target type is <code>lambda</code>,
        /// the default is 35 seconds.
        /// </para>
        /// </summary>
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
        /// [HTTP/HTTPS health checks] The ping path that is the destination on the targets for
        /// health checks. The default is /.
        /// </para>
        /// </summary>
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
        /// The port the load balancer uses when performing health checks on targets. The default
        /// is <code>traffic-port</code>, which is the port on which each target receives traffic
        /// from the load balancer.
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
        /// The protocol the load balancer uses when performing health checks on targets. For
        /// Application Load Balancers, the default is HTTP. For Network Load Balancers, the default
        /// is TCP. The TCP protocol is supported for health checks only if the protocol of the
        /// target group is TCP or TLS. The TLS protocol is not supported for health checks.
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
        /// The amount of time, in seconds, during which no response from a target means a failed
        /// health check. For Application Load Balancers, the range is 2–120 seconds and the default
        /// is 5 seconds if the target type is <code>instance</code> or <code>ip</code> and 30
        /// seconds if the target type is <code>lambda</code>. For Network Load Balancers, this
        /// is 10 seconds for TCP and HTTPS health checks and 6 seconds for HTTP health checks.
        /// </para>
        /// </summary>
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
        /// target healthy. For Application Load Balancers, the default is 5. For Network Load
        /// Balancers, the default is 3.
        /// </para>
        /// </summary>
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
        /// [HTTP/HTTPS health checks] The HTTP codes to use when checking for a successful response
        /// from a target.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the target group.
        /// </para>
        ///  
        /// <para>
        /// This name must be unique per region per account, can have a maximum of 32 characters,
        /// must contain only alphanumeric characters or hyphens, and must not begin or end with
        /// a hyphen.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the targets receive traffic. This port is used unless you specify
        /// a port override when registering the target. If the target is a Lambda function, this
        /// parameter does not apply.
        /// </para>
        /// </summary>
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
        /// The protocol to use for routing traffic to the targets. For Application Load Balancers,
        /// the supported protocols are HTTP and HTTPS. For Network Load Balancers, the supported
        /// protocols are TCP and TLS. If the target is a Lambda function, this parameter does
        /// not apply.
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
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of target that you must specify when registering targets with this target
        /// group. You can't specify targets for a target group using more than one target type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>instance</code> - Targets are specified by instance ID. This is the default
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip</code> - Targets are specified by IP address. You can specify IP addresses
        /// from the subnets of the virtual private cloud (VPC) for the target group, the RFC
        /// 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range
        /// (100.64.0.0/10). You can't specify publicly routable IP addresses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>lambda</code> - The target groups contains a single Lambda function.
        /// </para>
        ///  </li> </ul>
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
        /// The number of consecutive health check failures required before considering a target
        /// unhealthy. For Application Load Balancers, the default is 2. For Network Load Balancers,
        /// this value must be the same as the healthy threshold count.
        /// </para>
        /// </summary>
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
        /// The identifier of the virtual private cloud (VPC). If the target is a Lambda function,
        /// this parameter does not apply.
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