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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<ClientVpnAuthenticationRequest> _authenticationOptions = AWSConfigs.InitializeCollections ? new List<ClientVpnAuthenticationRequest>() : null;
        private string _clientCidrBlock;
        private ClientConnectOptions _clientConnectOptions;
        private ClientLoginBannerOptions _clientLoginBannerOptions;
        private ClientRouteEnforcementOptions _clientRouteEnforcementOptions;
        private string _clientToken;
        private ConnectionLogOptions _connectionLogOptions;
        private string _description;
        private bool? _disconnectOnSessionTimeout;
        private List<string> _dnsServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private EndpointIpAddressType _endpointIpAddressType;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SelfServicePortal _selfServicePortal;
        private string _serverCertificateArn;
        private int? _sessionTimeoutHours;
        private bool? _splitTunnel;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private TrafficIpAddressType _trafficIpAddressType;
        private TransportProtocol _transportProtocol;
        private string _vpcId;
        private int? _vpnPort;

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        /// Information about the authentication method to be used to authenticate clients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._authenticationOptions != null && (this._authenticationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ClientRouteEnforcementOptions. 
        /// <para>
        /// Client route enforcement is a feature of the Client VPN service that helps enforce
        /// administrator defined routes on devices connected through the VPN. T his feature helps
        /// improve your security posture by ensuring that network traffic originating from a
        /// connected client is not inadvertently sent outside the VPN tunnel.
        /// </para>
        ///  
        /// <para>
        /// Client route enforcement works by monitoring the route table of a connected device
        /// for routing policy changes to the VPN connection. If the feature detects any VPN routing
        /// policy modifications, it will automatically force an update to the route table, reverting
        /// it back to the expected route configurations.
        /// </para>
        /// </summary>
        public ClientRouteEnforcementOptions ClientRouteEnforcementOptions
        {
            get { return this._clientRouteEnforcementOptions; }
            set { this._clientRouteEnforcementOptions = value; }
        }

        // Check to see if ClientRouteEnforcementOptions property is set
        internal bool IsSetClientRouteEnforcementOptions()
        {
            return this._clientRouteEnforcementOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
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
        /// Gets and sets the property DisconnectOnSessionTimeout. 
        /// <para>
        /// Indicates whether the client VPN session is disconnected after the maximum timeout
        /// specified in <c>SessionTimeoutHours</c> is reached. If <c>true</c>, users are prompted
        /// to reconnect client VPN. If <c>false</c>, client VPN attempts to reconnect automatically.
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DisconnectOnSessionTimeout
        {
            get { return this._disconnectOnSessionTimeout; }
            set { this._disconnectOnSessionTimeout = value; }
        }

        // Check to see if DisconnectOnSessionTimeout property is set
        internal bool IsSetDisconnectOnSessionTimeout()
        {
            return this._disconnectOnSessionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// Information about the DNS servers to be used for DNS resolution. A Client VPN endpoint
        /// can have up to two DNS servers. If no DNS server is specified, the DNS address configured
        /// on the device is used for the DNS server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }

        // Check to see if DnsServers property is set
        internal bool IsSetDnsServers()
        {
            return this._dnsServers != null && (this._dnsServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointIpAddressType. 
        /// <para>
        /// The IP address type for the Client VPN endpoint. Valid values are <c>ipv4</c> (default)
        /// for IPv4 addressing only, <c>ipv6</c> for IPv6 addressing only, or <c>dual-stack</c>
        /// for both IPv4 and IPv6 addressing. When set to <c>dual-stack,</c> clients can connect
        /// to the endpoint using either IPv4 or IPv6 addresses..
        /// </para>
        /// </summary>
        public EndpointIpAddressType EndpointIpAddressType
        {
            get { return this._endpointIpAddressType; }
            set { this._endpointIpAddressType = value; }
        }

        // Check to see if EndpointIpAddressType property is set
        internal bool IsSetEndpointIpAddressType()
        {
            return this._endpointIpAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of one or more security groups to apply to the target network. You must also
        /// specify the ID of the VPC that contains the security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelfServicePortal. 
        /// <para>
        /// Specify whether to enable the self-service portal for the Client VPN endpoint.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>enabled</c> 
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
        /// Valid values: <c>8 | 10 | 12 | 24</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>24</c> 
        /// </para>
        /// </summary>
        public int? SessionTimeoutHours
        {
            get { return this._sessionTimeoutHours; }
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
        public bool? SplitTunnel
        {
            get { return this._splitTunnel; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficIpAddressType. 
        /// <para>
        /// The IP address type for traffic within the Client VPN tunnel. Valid values are <c>ipv4</c>
        /// (default) for IPv4 traffic only, <c>ipv6</c> for IPv6 addressing only, or <c>dual-stack</c>
        /// for both IPv4 and IPv6 traffic. When set to <c>dual-stack</c>, clients can access
        /// both IPv4 and IPv6 resources through the VPN .
        /// </para>
        /// </summary>
        public TrafficIpAddressType TrafficIpAddressType
        {
            get { return this._trafficIpAddressType; }
            set { this._trafficIpAddressType = value; }
        }

        // Check to see if TrafficIpAddressType property is set
        internal bool IsSetTrafficIpAddressType()
        {
            return this._trafficIpAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        /// The transport protocol to be used by the VPN session.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>udp</c> 
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
        /// Valid Values: <c>443</c> | <c>1194</c> 
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>443</c> 
        /// </para>
        /// </summary>
        public int? VpnPort
        {
            get { return this._vpnPort; }
            set { this._vpnPort = value; }
        }

        // Check to see if VpnPort property is set
        internal bool IsSetVpnPort()
        {
            return this._vpnPort.HasValue; 
        }

    }
}