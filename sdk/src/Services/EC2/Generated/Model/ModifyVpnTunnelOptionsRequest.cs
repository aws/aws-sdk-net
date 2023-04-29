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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpnTunnelOptions operation.
    /// Modifies the options for a VPN tunnel in an Amazon Web Services Site-to-Site VPN connection.
    /// You can modify multiple options for a tunnel in a single request, but you can only
    /// modify one tunnel at a time. For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPNTunnels.html">Site-to-Site
    /// VPN tunnel options for your Site-to-Site VPN connection</a> in the <i>Amazon Web Services
    /// Site-to-Site VPN User Guide</i>.
    /// </summary>
    public partial class ModifyVpnTunnelOptionsRequest : AmazonEC2Request
    {
        private bool? _skipTunnelReplacement;
        private ModifyVpnTunnelOptionsSpecification _tunnelOptions;
        private string _vpnConnectionId;
        private string _vpnTunnelOutsideIpAddress;

        /// <summary>
        /// Gets and sets the property SkipTunnelReplacement. 
        /// <para>
        /// Choose whether or not to trigger immediate tunnel replacement.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>True</code> | <code>False</code> 
        /// </para>
        /// </summary>
        public bool SkipTunnelReplacement
        {
            get { return this._skipTunnelReplacement.GetValueOrDefault(); }
            set { this._skipTunnelReplacement = value; }
        }

        // Check to see if SkipTunnelReplacement property is set
        internal bool IsSetSkipTunnelReplacement()
        {
            return this._skipTunnelReplacement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TunnelOptions. 
        /// <para>
        /// The tunnel options to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModifyVpnTunnelOptionsSpecification TunnelOptions
        {
            get { return this._tunnelOptions; }
            set { this._tunnelOptions = value; }
        }

        // Check to see if TunnelOptions property is set
        internal bool IsSetTunnelOptions()
        {
            return this._tunnelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the Amazon Web Services Site-to-Site VPN connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpnConnectionId
        {
            get { return this._vpnConnectionId; }
            set { this._vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this._vpnConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property VpnTunnelOutsideIpAddress. 
        /// <para>
        /// The external IP address of the VPN tunnel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpnTunnelOutsideIpAddress
        {
            get { return this._vpnTunnelOutsideIpAddress; }
            set { this._vpnTunnelOutsideIpAddress = value; }
        }

        // Check to see if VpnTunnelOutsideIpAddress property is set
        internal bool IsSetVpnTunnelOutsideIpAddress()
        {
            return this._vpnTunnelOutsideIpAddress != null;
        }

    }
}