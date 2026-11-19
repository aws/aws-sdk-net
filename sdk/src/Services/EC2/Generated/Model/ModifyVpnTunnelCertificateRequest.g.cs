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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpnTunnelCertificate operation. Modifies
    /// the VPN tunnel endpoint certificate.
    /// </summary>
    public partial class ModifyVpnTunnelCertificateRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the Amazon Web Services Site-to-Site VPN connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionId() => this.VpnConnectionId != null;

        /// <summary>
        /// Gets and sets the property VpnTunnelOutsideIpAddress. 
        /// <para>
        /// The external IP address of the VPN tunnel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpnTunnelOutsideIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the VpnTunnelOutsideIpAddress property is set.
        /// </summary>
        internal bool IsSetVpnTunnelOutsideIpAddress() => this.VpnTunnelOutsideIpAddress != null;
    }
}
