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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes the configuration of a target group.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/target-groups.html">Target
    /// groups</a> in the <i>Amazon VPC Lattice User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetGroupConfig
    {
        private HealthCheckConfig _healthCheck;
        private IpAddressType _ipAddressType;
        private LambdaEventStructureVersion _lambdaEventStructureVersion;
        private int? _port;
        private TargetGroupProtocol _protocol;
        private TargetGroupProtocolVersion _protocolVersion;
        private string _vpcIdentifier;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The health check configuration. Not supported if the target group type is <c>LAMBDA</c>
        /// or <c>ALB</c>.
        /// </para>
        /// </summary>
        public HealthCheckConfig HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The type of IP address used for the target group. Supported only if the target group
        /// type is <c>IP</c>. The default is <c>IPV4</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
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
        /// Gets and sets the property LambdaEventStructureVersion. 
        /// <para>
        /// The version of the event structure that your Lambda function receives. Supported only
        /// if the target group type is <c>LAMBDA</c>. The default is <c>V1</c>.
        /// </para>
        /// </summary>
        public LambdaEventStructureVersion LambdaEventStructureVersion
        {
            get { return this._lambdaEventStructureVersion; }
            set { this._lambdaEventStructureVersion = value; }
        }

        // Check to see if LambdaEventStructureVersion property is set
        internal bool IsSetLambdaEventStructureVersion()
        {
            return this._lambdaEventStructureVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the targets are listening. For HTTP, the default is 80. For HTTPS,
        /// the default is 443. Not supported if the target group type is <c>LAMBDA</c>.
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
        /// The protocol to use for routing traffic to the targets. The default is the protocol
        /// of the target group. Not supported if the target group type is <c>LAMBDA</c>.
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
        /// The protocol version. The default is <c>HTTP1</c>. Not supported if the target group
        /// type is <c>LAMBDA</c>.
        /// </para>
        /// </summary>
        public TargetGroupProtocolVersion ProtocolVersion
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
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The ID of the VPC. Not supported if the target group type is <c>LAMBDA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
        public string VpcIdentifier
        {
            get { return this._vpcIdentifier; }
            set { this._vpcIdentifier = value; }
        }

        // Check to see if VpcIdentifier property is set
        internal bool IsSetVpcIdentifier()
        {
            return this._vpcIdentifier != null;
        }

    }
}