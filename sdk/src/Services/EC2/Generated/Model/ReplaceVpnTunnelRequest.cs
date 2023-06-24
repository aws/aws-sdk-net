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
    /// Container for the parameters to the ReplaceVpnTunnel operation.
    /// Trigger replacement of specified VPN tunnel.
    /// </summary>
    public partial class ReplaceVpnTunnelRequest : AmazonEC2Request
    {
        private bool? _applyPendingMaintenance;
        private string _vpnConnectionId;
        private string _vpnTunnelOutsideIpAddress;

        /// <summary>
        /// Gets and sets the property ApplyPendingMaintenance. 
        /// <para>
        /// Trigger pending tunnel endpoint maintenance.
        /// </para>
        /// </summary>
        public bool ApplyPendingMaintenance
        {
            get { return this._applyPendingMaintenance.GetValueOrDefault(); }
            set { this._applyPendingMaintenance = value; }
        }

        // Check to see if ApplyPendingMaintenance property is set
        internal bool IsSetApplyPendingMaintenance()
        {
            return this._applyPendingMaintenance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the Site-to-Site VPN connection. 
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