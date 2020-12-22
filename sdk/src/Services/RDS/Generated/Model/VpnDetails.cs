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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information about the virtual private network (VPN) between the VMware vSphere cluster
    /// and the AWS website.
    /// 
    ///  
    /// <para>
    /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
    /// RDS on VMware User Guide.</a> 
    /// </para>
    /// </summary>
    public partial class VpnDetails
    {
        private string _vpnGatewayIp;
        private string _vpnId;
        private string _vpnName;
        private string _vpnPSK;
        private string _vpnState;
        private string _vpnTunnelOriginatorIP;

        /// <summary>
        /// Gets and sets the property VpnGatewayIp. 
        /// <para>
        /// The IP address of network traffic from AWS to your on-premises data center.
        /// </para>
        /// </summary>
        public string VpnGatewayIp
        {
            get { return this._vpnGatewayIp; }
            set { this._vpnGatewayIp = value; }
        }

        // Check to see if VpnGatewayIp property is set
        internal bool IsSetVpnGatewayIp()
        {
            return this._vpnGatewayIp != null;
        }

        /// <summary>
        /// Gets and sets the property VpnId. 
        /// <para>
        /// The ID of the VPN.
        /// </para>
        /// </summary>
        public string VpnId
        {
            get { return this._vpnId; }
            set { this._vpnId = value; }
        }

        // Check to see if VpnId property is set
        internal bool IsSetVpnId()
        {
            return this._vpnId != null;
        }

        /// <summary>
        /// Gets and sets the property VpnName. 
        /// <para>
        /// The name of the VPN.
        /// </para>
        /// </summary>
        public string VpnName
        {
            get { return this._vpnName; }
            set { this._vpnName = value; }
        }

        // Check to see if VpnName property is set
        internal bool IsSetVpnName()
        {
            return this._vpnName != null;
        }

        /// <summary>
        /// Gets and sets the property VpnPSK. 
        /// <para>
        /// The preshared key (PSK) for the VPN.
        /// </para>
        /// </summary>
        public string VpnPSK
        {
            get { return this._vpnPSK; }
            set { this._vpnPSK = value; }
        }

        // Check to see if VpnPSK property is set
        internal bool IsSetVpnPSK()
        {
            return this._vpnPSK != null;
        }

        /// <summary>
        /// Gets and sets the property VpnState. 
        /// <para>
        /// The state of the VPN.
        /// </para>
        /// </summary>
        public string VpnState
        {
            get { return this._vpnState; }
            set { this._vpnState = value; }
        }

        // Check to see if VpnState property is set
        internal bool IsSetVpnState()
        {
            return this._vpnState != null;
        }

        /// <summary>
        /// Gets and sets the property VpnTunnelOriginatorIP. 
        /// <para>
        /// The IP address of network traffic from your on-premises data center. A custom AZ receives
        /// the network traffic.
        /// </para>
        /// </summary>
        public string VpnTunnelOriginatorIP
        {
            get { return this._vpnTunnelOriginatorIP; }
            set { this._vpnTunnelOriginatorIP = value; }
        }

        // Check to see if VpnTunnelOriginatorIP property is set
        internal bool IsSetVpnTunnelOriginatorIP()
        {
            return this._vpnTunnelOriginatorIP != null;
        }

    }
}