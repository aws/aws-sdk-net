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
    /// Describes a Client VPN endpoint.
    /// </summary>
    public partial class ClientVpnEndpoint
    {
        /// <summary>
        /// Gets and sets the property AssociatedTargetNetworks. 
        /// <para>
        /// Information about the associated target networks. A target network is a subnet in
        /// a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated. To view the target networks associated with a Client VPN endpoint, call DescribeClientVpnTargetNetworks and inspect the clientVpnTargetNetworks response element.")]
        public List<AssociatedTargetNetwork> AssociatedTargetNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedTargetNetwork>() : null;

        /// <summary>
        /// Checks to see if the AssociatedTargetNetworks property is set.
        /// </summary>
        internal bool IsSetAssociatedTargetNetworks() => this.AssociatedTargetNetworks != null && (this.AssociatedTargetNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        /// Information about the authentication method used by the Client VPN endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClientVpnAuthentication> AuthenticationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<ClientVpnAuthentication>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationOptions property is set.
        /// </summary>
        internal bool IsSetAuthenticationOptions() => this.AuthenticationOptions != null && (this.AuthenticationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientCidrBlock. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, from which client IP addresses are assigned.
        /// </para>
        /// </summary>
        public string ClientCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the ClientCidrBlock property is set.
        /// </summary>
        internal bool IsSetClientCidrBlock() => this.ClientCidrBlock != null;

        /// <summary>
        /// Gets and sets the property ClientConnectOptions. 
        /// <para>
        /// The options for managing connection authorization for new client connections.
        /// </para>
        /// </summary>
        public ClientConnectResponseOptions ClientConnectOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClientConnectOptions property is set.
        /// </summary>
        internal bool IsSetClientConnectOptions() => this.ClientConnectOptions != null;

        /// <summary>
        /// Gets and sets the property ClientLoginBannerOptions. 
        /// <para>
        /// Options for enabling a customizable text banner that will be displayed on Amazon Web
        /// Services provided clients when a VPN session is established.
        /// </para>
        /// </summary>
        public ClientLoginBannerResponseOptions ClientLoginBannerOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClientLoginBannerOptions property is set.
        /// </summary>
        internal bool IsSetClientLoginBannerOptions() => this.ClientLoginBannerOptions != null;

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
        public ClientRouteEnforcementResponseOptions ClientRouteEnforcementOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClientRouteEnforcementOptions property is set.
        /// </summary>
        internal bool IsSetClientRouteEnforcementOptions() => this.ClientRouteEnforcementOptions != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property ConnectionLogOptions. 
        /// <para>
        /// Information about the client connection logging options for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public ConnectionLogResponseOptions ConnectionLogOptions { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionLogOptions property is set.
        /// </summary>
        internal bool IsSetConnectionLogOptions() => this.ConnectionLogOptions != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the Client VPN endpoint was created.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The date and time the Client VPN endpoint was deleted, if applicable.
        /// </para>
        /// </summary>
        public string DeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionTime() => this.DeletionTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the endpoint.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DevicePostureOptions. 
        /// <para>
        /// The device trust providers configured for the Client VPN endpoint, if applicable.
        /// </para>
        /// </summary>
        public DevicePostureResponseOptions DevicePostureOptions { get; set; }

        /// <summary>
        /// Checks to see if the DevicePostureOptions property is set.
        /// </summary>
        internal bool IsSetDevicePostureOptions() => this.DevicePostureOptions != null;

        /// <summary>
        /// Gets and sets the property DisconnectOnSessionTimeout. 
        /// <para>
        /// Indicates whether the client VPN session is disconnected after the maximum <c>sessionTimeoutHours</c>
        /// is reached. If <c>true</c>, users are prompted to reconnect client VPN. If <c>false</c>,
        /// client VPN attempts to reconnect automatically. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DisconnectOnSessionTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectOnSessionTimeout property is set.
        /// </summary>
        internal bool IsSetDisconnectOnSessionTimeout() => this.DisconnectOnSessionTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name to be used by clients when connecting to the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// Information about the DNS servers to be used for DNS resolution. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsServers property is set.
        /// </summary>
        internal bool IsSetDnsServers() => this.DnsServers != null && (this.DnsServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointIpAddressType. 
        /// <para>
        /// The IP address type of the Client VPN endpoint. Possible values are <c>ipv4</c> for
        /// IPv4 addressing only, <c>ipv6</c> for IPv6 addressing only, or <c>dual-stack </c>for
        /// both IPv4 and IPv6 addressing.
        /// </para>
        /// </summary>
        public EndpointIpAddressType EndpointIpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIpAddressType property is set.
        /// </summary>
        internal bool IsSetEndpointIpAddressType() => this.EndpointIpAddressType != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups for the target network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SelfServicePortalUrl. 
        /// <para>
        /// The URL of the self-service portal.
        /// </para>
        /// </summary>
        public string SelfServicePortalUrl { get; set; }

        /// <summary>
        /// Checks to see if the SelfServicePortalUrl property is set.
        /// </summary>
        internal bool IsSetSelfServicePortalUrl() => this.SelfServicePortalUrl != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateArn. 
        /// <para>
        /// The ARN of the server certificate.
        /// </para>
        /// </summary>
        public string ServerCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateArn property is set.
        /// </summary>
        internal bool IsSetServerCertificateArn() => this.ServerCertificateArn != null;

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
        public int? SessionTimeoutHours { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeoutHours property is set.
        /// </summary>
        internal bool IsSetSessionTimeoutHours() => this.SessionTimeoutHours.HasValue;

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
        public bool? SplitTunnel { get; set; }

        /// <summary>
        /// Checks to see if the SplitTunnel property is set.
        /// </summary>
        internal bool IsSetSplitTunnel() => this.SplitTunnel.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public ClientVpnEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Client VPN endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficIpAddressType. 
        /// <para>
        /// The IP address type of the Client VPN endpoint. Possible values are either <c>ipv4</c>
        /// for IPv4 addressing only, <c>ipv6</c> for IPv6 addressing only, or <c>dual-stack</c>
        /// for both IPv4 and IPv6 addressing.
        /// </para>
        /// </summary>
        public TrafficIpAddressType TrafficIpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficIpAddressType property is set.
        /// </summary>
        internal bool IsSetTrafficIpAddressType() => this.TrafficIpAddressType != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayConfiguration. 
        /// <para>
        /// The Transit Gateway configuration for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public TransitGatewayConfigurationDescribeEndpointStructure TransitGatewayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayConfiguration property is set.
        /// </summary>
        internal bool IsSetTransitGatewayConfiguration() => this.TransitGatewayConfiguration != null;

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        /// The transport protocol used by the Client VPN endpoint.
        /// </para>
        /// </summary>
        public TransportProtocol TransportProtocol { get; set; }

        /// <summary>
        /// Checks to see if the TransportProtocol property is set.
        /// </summary>
        internal bool IsSetTransportProtocol() => this.TransportProtocol != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property VpnPort. 
        /// <para>
        /// The port number for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public int? VpnPort { get; set; }

        /// <summary>
        /// Checks to see if the VpnPort property is set.
        /// </summary>
        internal bool IsSetVpnPort() => this.VpnPort.HasValue;

        /// <summary>
        /// Gets and sets the property VpnProtocol. 
        /// <para>
        /// The protocol used by the VPN session.
        /// </para>
        /// </summary>
        public VpnProtocol VpnProtocol { get; set; }

        /// <summary>
        /// Checks to see if the VpnProtocol property is set.
        /// </summary>
        internal bool IsSetVpnProtocol() => this.VpnProtocol != null;
    }
}
