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
    /// Describes a Client VPN endpoint.
    /// </summary>
    public partial class ClientVpnEndpoint
    {
        private List<AssociatedTargetNetwork> _associatedTargetNetworks = AWSConfigs.InitializeCollections ? new List<AssociatedTargetNetwork>() : null;
        private List<ClientVpnAuthentication> _authenticationOptions = AWSConfigs.InitializeCollections ? new List<ClientVpnAuthentication>() : null;
        private string _clientCidrBlock;
        private ClientConnectResponseOptions _clientConnectOptions;
        private ClientLoginBannerResponseOptions _clientLoginBannerOptions;
        private ClientRouteEnforcementResponseOptions _clientRouteEnforcementOptions;
        private string _clientVpnEndpointId;
        private ConnectionLogResponseOptions _connectionLogOptions;
        private string _creationTime;
        private string _deletionTime;
        private string _description;
        private bool? _disconnectOnSessionTimeout;
        private string _dnsName;
        private List<string> _dnsServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EndpointIpAddressType _endpointIpAddressType;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _selfServicePortalUrl;
        private string _serverCertificateArn;
        private int? _sessionTimeoutHours;
        private bool? _splitTunnel;
        private ClientVpnEndpointStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TrafficIpAddressType _trafficIpAddressType;
        private TransportProtocol _transportProtocol;
        private string _vpcId;
        private int? _vpnPort;
        private VpnProtocol _vpnProtocol;

        /// <summary>
        /// Gets and sets the property AssociatedTargetNetworks. 
        /// <para>
        /// Information about the associated target networks. A target network is a subnet in
        /// a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated. To view the target networks associated with a Client VPN endpoint, call DescribeClientVpnTargetNetworks and inspect the clientVpnTargetNetworks response element.")]
        public List<AssociatedTargetNetwork> AssociatedTargetNetworks
        {
            get { return this._associatedTargetNetworks; }
            set { this._associatedTargetNetworks = value; }
        }

        // Check to see if AssociatedTargetNetworks property is set
        internal bool IsSetAssociatedTargetNetworks()
        {
            return this._associatedTargetNetworks != null && (this._associatedTargetNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        /// Information about the authentication method used by the Client VPN endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClientVpnAuthentication> AuthenticationOptions
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
        /// The IPv4 address range, in CIDR notation, from which client IP addresses are assigned.
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
        public ClientConnectResponseOptions ClientConnectOptions
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
        public ClientLoginBannerResponseOptions ClientLoginBannerOptions
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
        public ClientRouteEnforcementResponseOptions ClientRouteEnforcementOptions
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
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint.
        /// </para>
        /// </summary>
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
        /// Information about the client connection logging options for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public ConnectionLogResponseOptions ConnectionLogOptions
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the Client VPN endpoint was created.
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The date and time the Client VPN endpoint was deleted, if applicable.
        /// </para>
        /// </summary>
        public string DeletionTime
        {
            get { return this._deletionTime; }
            set { this._deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this._deletionTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the endpoint.
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
        /// Indicates whether the client VPN session is disconnected after the maximum <c>sessionTimeoutHours</c>
        /// is reached. If <c>true</c>, users are prompted to reconnect client VPN. If <c>false</c>,
        /// client VPN attempts to reconnect automatically. The default value is <c>true</c>.
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
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name to be used by clients when connecting to the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// Information about the DNS servers to be used for DNS resolution. 
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
        /// Gets and sets the property EndpointIpAddressType. 
        /// <para>
        /// The IP address type of the Client VPN endpoint. Possible values are <c>ipv4</c> for
        /// IPv4 addressing only, <c>ipv6</c> for IPv6 addressing only, or <c>dual-stack </c>for
        /// both IPv4 and IPv6 addressing.
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
        /// The IDs of the security groups for the target network.
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
        /// Gets and sets the property SelfServicePortalUrl. 
        /// <para>
        /// The URL of the self-service portal.
        /// </para>
        /// </summary>
        public string SelfServicePortalUrl
        {
            get { return this._selfServicePortalUrl; }
            set { this._selfServicePortalUrl = value; }
        }

        // Check to see if SelfServicePortalUrl property is set
        internal bool IsSetSelfServicePortalUrl()
        {
            return this._selfServicePortalUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateArn. 
        /// <para>
        /// The ARN of the server certificate.
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
        /// Indicates whether split-tunnel is enabled in the Client VPN endpoint.
        /// </para>
        ///  
        /// <para>
        /// For information about split-tunnel VPN endpoints, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/split-tunnel-vpn.html">Split-Tunnel
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public ClientVpnEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Client VPN endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficIpAddressType. 
        /// <para>
        /// The IP address type of the Client VPN endpoint. Possible values are either <c>ipv4</c>
        /// for IPv4 addressing only, <c>ipv6</c> for IPv6 addressing only, or <c>dual-stack</c>
        /// for both IPv4 and IPv6 addressing.
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
        /// The transport protocol used by the Client VPN endpoint.
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
        /// The ID of the VPC.
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
        /// The port number for the Client VPN endpoint.
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

        /// <summary>
        /// Gets and sets the property VpnProtocol. 
        /// <para>
        /// The protocol used by the VPN session.
        /// </para>
        /// </summary>
        public VpnProtocol VpnProtocol
        {
            get { return this._vpnProtocol; }
            set { this._vpnProtocol = value; }
        }

        // Check to see if VpnProtocol property is set
        internal bool IsSetVpnProtocol()
        {
            return this._vpnProtocol != null;
        }

    }
}