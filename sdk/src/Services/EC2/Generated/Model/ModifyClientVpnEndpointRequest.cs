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
    /// Container for the parameters to the ModifyClientVpnEndpoint operation.
    /// Modifies the specified Client VPN endpoint. Modifying the DNS server resets existing
    /// client connections.
    /// </summary>
    public partial class ModifyClientVpnEndpointRequest : AmazonEC2Request
    {
        private ClientConnectOptions _clientConnectOptions;
        private string _clientVpnEndpointId;
        private ConnectionLogOptions _connectionLogOptions;
        private string _description;
        private DnsServersOptionsModifyStructure _dnsServers;
        private List<string> _securityGroupIds = new List<string>();
        private SelfServicePortal _selfServicePortal;
        private string _serverCertificateArn;
        private bool? _splitTunnel;
        private string _vpcId;
        private int? _vpnPort;

        /// <summary>
        /// Gets and sets the property ClientConnectOptions. 
        /// <para>
        /// The options for managing connection authorization for new client connections.
        /// </para>
        /// </summary>
        public ClientConnectOptions ClientConnectOptions
        {
            get { return this._clientConnectOptions; }
            set { this._clientConnectOptions = value; }
        }

        // Check to see if ClientConnectOptions property is set
        internal bool IsSetClientConnectOptions()
        {
            return this._clientConnectOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionLogOptions. 
        /// <para>
        /// Information about the client connection logging options.
        /// </para>
        ///  
        /// <para>
        /// If you enable client connection logging, data about client connections is sent to
        /// a Cloudwatch Logs log stream. The following information is logged:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Client connection requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client connection results (successful and unsuccessful)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reasons for unsuccessful client connection requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client connection termination time
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConnectionLogOptions ConnectionLogOptions
        {
            get { return this._connectionLogOptions; }
            set { this._connectionLogOptions = value; }
        }

        // Check to see if ConnectionLogOptions property is set
        internal bool IsSetConnectionLogOptions()
        {
            return this._connectionLogOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// Information about the DNS servers to be used by Client VPN connections. A Client VPN
        /// endpoint can have up to two DNS servers.
        /// </para>
        /// </summary>
        public DnsServersOptionsModifyStructure DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }

        // Check to see if DnsServers property is set
        internal bool IsSetDnsServers()
        {
            return this._dnsServers != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of one or more security groups to apply to the target network.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelfServicePortal. 
        /// <para>
        /// Specify whether to enable the self-service portal for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public SelfServicePortal SelfServicePortal
        {
            get { return this._selfServicePortal; }
            set { this._selfServicePortal = value; }
        }

        // Check to see if SelfServicePortal property is set
        internal bool IsSetSelfServicePortal()
        {
            return this._selfServicePortal != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateArn. 
        /// <para>
        /// The ARN of the server certificate to be used. The server certificate must be provisioned
        /// in AWS Certificate Manager (ACM).
        /// </para>
        /// </summary>
        public string ServerCertificateArn
        {
            get { return this._serverCertificateArn; }
            set { this._serverCertificateArn = value; }
        }

        // Check to see if ServerCertificateArn property is set
        internal bool IsSetServerCertificateArn()
        {
            return this._serverCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property SplitTunnel. 
        /// <para>
        /// Indicates whether the VPN is split-tunnel.
        /// </para>
        ///  
        /// <para>
        /// For information about split-tunnel VPN endpoints, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/split-tunnel-vpn.html">Split-Tunnel
        /// AWS Client VPN Endpoint</a> in the <i>AWS Client VPN Administrator Guide</i>.
        /// </para>
        /// </summary>
        public bool SplitTunnel
        {
            get { return this._splitTunnel.GetValueOrDefault(); }
            set { this._splitTunnel = value; }
        }

        // Check to see if SplitTunnel property is set
        internal bool IsSetSplitTunnel()
        {
            return this._splitTunnel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC to associate with the Client VPN endpoint.
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

        /// <summary>
        /// Gets and sets the property VpnPort. 
        /// <para>
        /// The port number to assign to the Client VPN endpoint for TCP and UDP traffic.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>443</code> | <code>1194</code> 
        /// </para>
        ///  
        /// <para>
        /// Default Value: <code>443</code> 
        /// </para>
        /// </summary>
        public int VpnPort
        {
            get { return this._vpnPort.GetValueOrDefault(); }
            set { this._vpnPort = value; }
        }

        // Check to see if VpnPort property is set
        internal bool IsSetVpnPort()
        {
            return this._vpnPort.HasValue; 
        }

    }
}