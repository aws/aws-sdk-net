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
    /// Container for the parameters to the CreateClientVpnEndpoint operation.
    /// Creates a Client VPN endpoint. A Client VPN endpoint is the resource you create and
    /// configure to enable and manage client VPN sessions. It is the destination endpoint
    /// at which all client VPN sessions are terminated.
    /// </summary>
    public partial class CreateClientVpnEndpointRequest : AmazonEC2Request
    {
        private List<ClientVpnAuthenticationRequest> _authenticationOptions = new List<ClientVpnAuthenticationRequest>();
        private string _clientCidrBlock;
        private ClientConnectOptions _clientConnectOptions;
        private ClientLoginBannerOptions _clientLoginBannerOptions;
        private string _clientToken;
        private ConnectionLogOptions _connectionLogOptions;
        private string _description;
        private List<string> _dnsServers = new List<string>();
        private List<string> _securityGroupIds = new List<string>();
        private SelfServicePortal _selfServicePortal;
        private string _serverCertificateArn;
        private int? _sessionTimeoutHours;
        private bool? _splitTunnel;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private TransportProtocol _transportProtocol;
        private string _vpcId;
        private int? _vpnPort;

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        /// Information about the authentication method to be used to authenticate clients.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ClientVpnAuthenticationRequest> AuthenticationOptions
        {
            get { return this._authenticationOptions; }
            set { this._authenticationOptions = value; }
        }

        // Check to see if AuthenticationOptions property is set
        internal bool IsSetAuthenticationOptions()
        {
            return this._authenticationOptions != null && this._authenticationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientCidrBlock. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, from which to assign client IP addresses.
        /// The address range cannot overlap with the local CIDR of the VPC in which the associated
        /// subnet is located, or the routes that you add manually. The address range cannot be
        /// changed after the Client VPN endpoint has been created. Client CIDR range must have
        /// a size of at least /22 and must not be greater than /12.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientCidrBlock
        {
            get { return this._clientCidrBlock; }
            set { this._clientCidrBlock = value; }
        }

        // Check to see if ClientCidrBlock property is set
        internal bool IsSetClientCidrBlock()
        {
            return this._clientCidrBlock != null;
        }

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
        /// Gets and sets the property ClientLoginBannerOptions. 
        /// <para>
        /// Options for enabling a customizable text banner that will be displayed on Amazon Web
        /// Services provided clients when a VPN session is established.
        /// </para>
        /// </summary>
        public ClientLoginBannerOptions ClientLoginBannerOptions
        {
            get { return this._clientLoginBannerOptions; }
            set { this._clientLoginBannerOptions = value; }
        }

        // Check to see if ClientLoginBannerOptions property is set
        internal bool IsSetClientLoginBannerOptions()
        {
            return this._clientLoginBannerOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        [AWSProperty(Required=true)]
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
        /// Information about the DNS servers to be used for DNS resolution. A Client VPN endpoint
        /// can have up to two DNS servers. If no DNS server is specified, the DNS address configured
        /// on the device is used for the DNS server.
        /// </para>
        /// </summary>
        public List<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }

        // Check to see if DnsServers property is set
        internal bool IsSetDnsServers()
        {
            return this._dnsServers != null && this._dnsServers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of one or more security groups to apply to the target network. You must also
        /// specify the ID of the VPC that contains the security groups.
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
        ///  
        /// <para>
        /// Default Value: <code>enabled</code> 
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
        /// The ARN of the server certificate. For more information, see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">Certificate
        /// Manager User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SessionTimeoutHours. 
        /// <para>
        /// The maximum VPN session duration time in hours.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>8 | 10 | 12 | 24</code> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>24</code> 
        /// </para>
        /// </summary>
        public int SessionTimeoutHours
        {
            get { return this._sessionTimeoutHours.GetValueOrDefault(); }
            set { this._sessionTimeoutHours = value; }
        }

        // Check to see if SessionTimeoutHours property is set
        internal bool IsSetSessionTimeoutHours()
        {
            return this._sessionTimeoutHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SplitTunnel. 
        /// <para>
        /// Indicates whether split-tunnel is enabled on the Client VPN endpoint.
        /// </para>
        ///  
        /// <para>
        /// By default, split-tunnel on a VPN endpoint is disabled.
        /// </para>
        ///  
        /// <para>
        /// For information about split-tunnel VPN endpoints, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/split-tunnel-vpn.html">Split-tunnel
        /// Client VPN endpoint</a> in the <i>Client VPN Administrator Guide</i>.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Client VPN endpoint during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        /// The transport protocol to be used by the VPN session.
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>udp</code> 
        /// </para>
        /// </summary>
        public TransportProtocol TransportProtocol
        {
            get { return this._transportProtocol; }
            set { this._transportProtocol = value; }
        }

        // Check to see if TransportProtocol property is set
        internal bool IsSetTransportProtocol()
        {
            return this._transportProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC to associate with the Client VPN endpoint. If no security group
        /// IDs are specified in the request, the default security group for the VPC is applied.
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