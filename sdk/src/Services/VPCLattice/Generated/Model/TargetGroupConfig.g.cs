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
        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The health check configuration. Not supported if the target group type is <c>LAMBDA</c>
        /// or <c>ALB</c>.
        /// </para>
        /// </summary>
        public HealthCheckConfig HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The type of IP address used for the target group. Supported only if the target group
        /// type is <c>IP</c>. The default is <c>IPV4</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property LambdaEventStructureVersion. 
        /// <para>
        /// The version of the event structure that your Lambda function receives. Supported only
        /// if the target group type is <c>LAMBDA</c>. The default is <c>V1</c>.
        /// </para>
        /// </summary>
        public LambdaEventStructureVersion LambdaEventStructureVersion { get; set; }

        /// <summary>
        /// Checks to see if the LambdaEventStructureVersion property is set.
        /// </summary>
        internal bool IsSetLambdaEventStructureVersion() => this.LambdaEventStructureVersion != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the targets are listening. For HTTP, the default is 80. For HTTPS,
        /// the default is 443. Not supported if the target group type is <c>LAMBDA</c>.
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
        /// The protocol to use for routing traffic to the targets. The default is the protocol
        /// of the target group. Not supported if the target group type is <c>LAMBDA</c>.
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
        /// The protocol version. The default is <c>HTTP1</c>. Not supported if the target group
        /// type is <c>LAMBDA</c>.
        /// </para>
        /// </summary>
        public TargetGroupProtocolVersion ProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolVersion property is set.
        /// </summary>
        internal bool IsSetProtocolVersion() => this.ProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The ID of the VPC. Not supported if the target group type is <c>LAMBDA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 50)]
        public string VpcIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VpcIdentifier property is set.
        /// </summary>
        internal bool IsSetVpcIdentifier() => this.VpcIdentifier != null;
    }
}
