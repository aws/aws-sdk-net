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
    /// Container for the parameters to the CreateTargetGroup operation.
    /// Creates a target group.
    /// 
    ///  
    /// <para>
    /// For more information, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html">Target
    /// groups for your Application Load Balancers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html">Target
    /// groups for your Network Load Balancers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/target-groups.html">Target
    /// groups for your Gateway Load Balancers</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation is idempotent, which means that it completes at most one time. If you
    /// attempt to create multiple target groups with the same settings, each call succeeds.
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
        private TargetGroupIpAddressTypeEnum _ipAddressType;
        private Matcher _matcher;
        private string _name;
        private int? _port;
        private ProtocolEnum _protocol;
        private string _protocolVersion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TargetTypeEnum _targetType;
        private int? _unhealthyThresholdCount;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property HealthCheckEnabled. 
        /// <para>
        /// Indicates whether health checks are enabled. If the target type is <c>lambda</c>,
        /// health checks are disabled by default but can be enabled. If the target type is <c>instance</c>,
        /// <c>ip</c>, or <c>alb</c>, health checks are always enabled and can't be disabled.
        /// </para>
        /// </summary>
        public bool? HealthCheckEnabled
        {
            get { return this._healthCheckEnabled; }
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
        /// target. The range is 5-300. If the target group protocol is TCP, TLS, UDP, TCP_UDP,
        /// HTTP or HTTPS, the default is 30 seconds. If the target group protocol is GENEVE,
        /// the default is 10 seconds. If the target type is <c>lambda</c>, the default is 35
        /// seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
        public int? HealthCheckIntervalSeconds
        {
            get { return this._healthCheckIntervalSeconds; }
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
        /// The port the load balancer uses when performing health checks on targets. If the protocol
        /// is HTTP, HTTPS, TCP, TLS, UDP, or TCP_UDP, the default is <c>traffic-port</c>, which
        /// is the port on which each target receives traffic from the load balancer. If the protocol
        /// is GENEVE, the default is port 80.
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
        /// Application Load Balancers, the default is HTTP. For Network Load Balancers and Gateway
        /// Load Balancers, the default is TCP. The TCP protocol is not supported for health checks
        /// if the protocol of the target group is HTTP or HTTPS. The GENEVE, TLS, UDP, and TCP_UDP
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
        /// The amount of time, in seconds, during which no response from a target means a failed
        /// health check. The range is 2–120 seconds. For target groups with a protocol of HTTP,
        /// the default is 6 seconds. For target groups with a protocol of TCP, TLS or HTTPS,
        /// the default is 10 seconds. For target groups with a protocol of GENEVE, the default
        /// is 5 seconds. If the target type is <c>lambda</c>, the default is 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=120)]
        public int? HealthCheckTimeoutSeconds
        {
            get { return this._healthCheckTimeoutSeconds; }
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
        /// The number of consecutive health check successes required before considering a target
        /// healthy. The range is 2-10. If the target group protocol is TCP, TCP_UDP, UDP, TLS,
        /// HTTP or HTTPS, the default is 5. For target groups with a protocol of GENEVE, the
        /// default is 5. If the target type is <c>lambda</c>, the default is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int? HealthyThresholdCount
        {
            get { return this._healthyThresholdCount; }
            set { this._healthyThresholdCount = value; }
        }

        // Check to see if HealthyThresholdCount property is set
        internal bool IsSetHealthyThresholdCount()
        {
            return this._healthyThresholdCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type. The default value is <c>ipv4</c>.
        /// </para>
        /// </summary>
        public TargetGroupIpAddressTypeEnum IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// [HTTP/HTTPS health checks] The HTTP or gRPC codes to use when checking for a successful
        /// response from a target. For target groups with a protocol of TCP, TCP_UDP, UDP or
        /// TLS the range is 200-599. For target groups with a protocol of HTTP or HTTPS, the
        /// range is 200-499. For target groups with a protocol of GENEVE, the range is 200-399.
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
        [AWSProperty(Required=true)]
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
        /// parameter does not apply. If the protocol is GENEVE, the supported port is 6081.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
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
        /// protocols are TCP, TLS, UDP, or TCP_UDP. For Gateway Load Balancers, the supported
        /// protocol is GENEVE. A TCP_UDP listener must be associated with a TCP_UDP target group.
        /// If the target is a Lambda function, this parameter does not apply.
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
        /// [HTTP/HTTPS protocol] The protocol version. Specify <c>GRPC</c> to send requests to
        /// targets using gRPC. Specify <c>HTTP2</c> to send requests to targets using HTTP/2.
        /// The default is <c>HTTP1</c>, which sends requests to targets using HTTP/1.1.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the target group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of target that you must specify when registering targets with this target
        /// group. You can't specify targets for a target group using more than one target type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>instance</c> - Register targets by instance ID. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip</c> - Register targets by IP address. You can specify IP addresses from the
        /// subnets of the virtual private cloud (VPC) for the target group, the RFC 1918 range
        /// (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
        /// You can't specify publicly routable IP addresses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lambda</c> - Register a single Lambda function as a target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>alb</c> - Register a single Application Load Balancer as a target.
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
        /// unhealthy. The range is 2-10. If the target group protocol is TCP, TCP_UDP, UDP, TLS,
        /// HTTP or HTTPS, the default is 2. For target groups with a protocol of GENEVE, the
        /// default is 2. If the target type is <c>lambda</c>, the default is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int? UnhealthyThresholdCount
        {
            get { return this._unhealthyThresholdCount; }
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
        /// this parameter does not apply. Otherwise, this parameter is required.
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