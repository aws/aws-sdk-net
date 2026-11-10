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
    /// Container for the parameters to the ModifyVpnTunnelOptions operation. Modifies the
    /// options for a VPN tunnel in an Amazon Web Services Site-to-Site VPN connection. You
    /// can modify multiple options for a tunnel in a single request, but you can only modify
    /// one tunnel at a time. For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPNTunnels.html">Site-to-Site
    /// VPN tunnel options for your Site-to-Site VPN connection</a> in the <i>Amazon Web Services
    /// Site-to-Site VPN User Guide</i>.
    /// </summary>
    public partial class ModifyVpnTunnelOptionsRequest : AmazonEC2Request
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
        /// Gets and sets the property PreSharedKeyStorage. 
        /// <para>
        /// Specifies the storage mode for the pre-shared key (PSK). Valid values are <c>Standard</c>
        /// (stored in Site-to-Site VPN service) or <c>SecretsManager</c> (stored in Amazon Web
        /// Services Secrets Manager).
        /// </para>
        /// </summary>
        public string PreSharedKeyStorage { get; set; }

        /// <summary>
        /// Checks to see if the PreSharedKeyStorage property is set.
        /// </summary>
        internal bool IsSetPreSharedKeyStorage() => this.PreSharedKeyStorage != null;

        /// <summary>
        /// Gets and sets the property SkipTunnelReplacement. 
        /// <para>
        /// Choose whether or not to trigger immediate tunnel replacement. This is only applicable
        /// when turning on or off <c>EnableTunnelLifecycleControl</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>True</c> | <c>False</c> 
        /// </para>
        /// </summary>
        public bool? SkipTunnelReplacement { get; set; }

        /// <summary>
        /// Checks to see if the SkipTunnelReplacement property is set.
        /// </summary>
        internal bool IsSetSkipTunnelReplacement() => this.SkipTunnelReplacement.HasValue;

        /// <summary>
        /// Gets and sets the property TunnelOptions. 
        /// <para>
        /// The tunnel options to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ModifyVpnTunnelOptionsSpecification TunnelOptions { get; set; }

        /// <summary>
        /// Checks to see if the TunnelOptions property is set.
        /// </summary>
        internal bool IsSetTunnelOptions() => this.TunnelOptions != null;

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
