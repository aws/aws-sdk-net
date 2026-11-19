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
    /// Container for the parameters to the ModifyClientVpnEndpoint operation. Modifies the
    /// specified Client VPN endpoint. Modifying the DNS server resets existing client connections.
    /// </summary>
    public partial class ModifyClientVpnEndpointRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientConnectOptions. 
        /// <para>
        /// The options for managing connection authorization for new client connections.
        /// </para>
        /// </summary>
        public ClientConnectOptions ClientConnectOptions { get; set; }

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
        public ClientLoginBannerOptions ClientLoginBannerOptions { get; set; }

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
        public ClientRouteEnforcementOptions ClientRouteEnforcementOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClientRouteEnforcementOptions property is set.
        /// </summary>
        internal bool IsSetClientRouteEnforcementOptions() => this.ClientRouteEnforcementOptions != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

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
        public ConnectionLogOptions ConnectionLogOptions { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionLogOptions property is set.
        /// </summary>
        internal bool IsSetConnectionLogOptions() => this.ConnectionLogOptions != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the Client VPN endpoint.
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
        /// The device posture options for the Client VPN endpoint. Specifying this parameter
        /// replaces the entire device posture configuration for the endpoint. To disable device
        /// posture and remove all device trust providers, specify <c>false</c> for <c>Enabled</c>.
        /// </para>
        /// </summary>
        public DevicePostureOptions DevicePostureOptions { get; set; }

        /// <summary>
        /// Checks to see if the DevicePostureOptions property is set.
        /// </summary>
        internal bool IsSetDevicePostureOptions() => this.DevicePostureOptions != null;

        /// <summary>
        /// Gets and sets the property DisconnectOnSessionTimeout. 
        /// <para>
        /// Indicates whether the client VPN session is disconnected after the maximum timeout
        /// specified in <c>sessionTimeoutHours</c> is reached. If <c>true</c>, users are prompted
        /// to reconnect client VPN. If <c>false</c>, client VPN attempts to reconnect automatically.
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DisconnectOnSessionTimeout { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectOnSessionTimeout property is set.
        /// </summary>
        internal bool IsSetDisconnectOnSessionTimeout() => this.DisconnectOnSessionTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// Information about the DNS servers to be used by Client VPN connections. A Client VPN
        /// endpoint can have up to two DNS servers.
        /// </para>
        /// </summary>
        public DnsServersOptionsModifyStructure DnsServers { get; set; }

        /// <summary>
        /// Checks to see if the DnsServers property is set.
        /// </summary>
        internal bool IsSetDnsServers() => this.DnsServers != null;

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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of one or more security groups to apply to the target network.
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
        /// Gets and sets the property SelfServicePortal. 
        /// <para>
        /// Specify whether to enable the self-service portal for the Client VPN endpoint.
        /// </para>
        /// </summary>
        public SelfServicePortal SelfServicePortal { get; set; }

        /// <summary>
        /// Checks to see if the SelfServicePortal property is set.
        /// </summary>
        internal bool IsSetSelfServicePortal() => this.SelfServicePortal != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateArn. 
        /// <para>
        /// The ARN of the server certificate to be used. The server certificate must be provisioned
        /// in Certificate Manager (ACM).
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
        /// Indicates whether the VPN is split-tunnel.
        /// </para>
        ///  
        /// <para>
        /// For information about split-tunnel VPN endpoints, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/split-tunnel-vpn.html">Split-tunnel
        /// Client VPN endpoint</a> in the <i>Client VPN Administrator Guide</i>.
        /// </para>
        /// </summary>
        public bool? SplitTunnel { get; set; }

        /// <summary>
        /// Checks to see if the SplitTunnel property is set.
        /// </summary>
        internal bool IsSetSplitTunnel() => this.SplitTunnel.HasValue;

        /// <summary>
        /// Gets and sets the property TransitGatewayConfiguration. 
        /// <para>
        /// The Transit Gateway configuration for the Client VPN endpoint. This option is currently
        /// not supported.
        /// </para>
        /// </summary>
        public TransitGatewayConfigurationInputStructure TransitGatewayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayConfiguration property is set.
        /// </summary>
        internal bool IsSetTransitGatewayConfiguration() => this.TransitGatewayConfiguration != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC to associate with the Client VPN endpoint.
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
        public int? VpnPort { get; set; }

        /// <summary>
        /// Checks to see if the VpnPort property is set.
        /// </summary>
        internal bool IsSetVpnPort() => this.VpnPort.HasValue;
    }
}
