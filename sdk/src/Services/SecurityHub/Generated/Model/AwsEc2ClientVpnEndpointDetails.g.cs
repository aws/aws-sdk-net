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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Describes an Client VPN endpoint. A Client VPN endpoint is the resource that you
    /// create and configure to enable and manage client VPN sessions. It's the termination
    /// point for all client VPN sessions.
    /// </summary>
    public partial class AwsEc2ClientVpnEndpointDetails
    {
        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        ///  Information about the authentication method used by the Client VPN endpoint. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2ClientVpnEndpointAuthenticationOptionsDetails> AuthenticationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2ClientVpnEndpointAuthenticationOptionsDetails>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationOptions property is set.
        /// </summary>
        internal bool IsSetAuthenticationOptions() => this.AuthenticationOptions != null && (this.AuthenticationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientCidrBlock. 
        /// <para>
        ///  The IPv4 address range, in CIDR notation, from which client IP addresses are assigned.
        /// 
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
        ///  The options for managing connection authorization for new client connections. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointClientConnectOptionsDetails ClientConnectOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClientConnectOptions property is set.
        /// </summary>
        internal bool IsSetClientConnectOptions() => this.ClientConnectOptions != null;

        /// <summary>
        /// Gets and sets the property ClientLoginBannerOptions. 
        /// <para>
        ///  Options for enabling a customizable text banner that will be displayed on Amazon
        /// Web Services provided clients when a VPN session is established. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointClientLoginBannerOptionsDetails ClientLoginBannerOptions { get; set; }

        /// <summary>
        /// Checks to see if the ClientLoginBannerOptions property is set.
        /// </summary>
        internal bool IsSetClientLoginBannerOptions() => this.ClientLoginBannerOptions != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        ///  The ID of the Client VPN endpoint. 
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
        ///  Information about the client connection logging options for the Client VPN endpoint.
        /// 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointConnectionLogOptionsDetails ConnectionLogOptions { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionLogOptions property is set.
        /// </summary>
        internal bool IsSetConnectionLogOptions() => this.ConnectionLogOptions != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the endpoint. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnsServer. 
        /// <para>
        ///  Information about the DNS servers to be used for DNS resolution. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServer { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsServer property is set.
        /// </summary>
        internal bool IsSetDnsServer() => this.DnsServer != null && (this.DnsServer.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupIdSet. 
        /// <para>
        ///  The IDs of the security groups for the target network. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIdSet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIdSet property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIdSet() => this.SecurityGroupIdSet != null && (this.SecurityGroupIdSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SelfServicePortalUrl. 
        /// <para>
        ///  The URL of the self-service portal. 
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
        ///  The Amazon Resource Name (ARN) of the server certificate. 
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
        ///  The maximum VPN session duration time in hours. 
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
        ///  Indicates whether split-tunnel is enabled in the Client VPN endpoint. 
        /// </para>
        /// </summary>
        public bool? SplitTunnel { get; set; }

        /// <summary>
        /// Checks to see if the SplitTunnel property is set.
        /// </summary>
        internal bool IsSetSplitTunnel() => this.SplitTunnel.HasValue;

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        ///  The transport protocol used by the Client VPN endpoint. 
        /// </para>
        /// </summary>
        public string TransportProtocol { get; set; }

        /// <summary>
        /// Checks to see if the TransportProtocol property is set.
        /// </summary>
        internal bool IsSetTransportProtocol() => this.TransportProtocol != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        ///  The ID of the VPC. 
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
        ///  The port number for the Client VPN endpoint. 
        /// </para>
        /// </summary>
        public int? VpnPort { get; set; }

        /// <summary>
        /// Checks to see if the VpnPort property is set.
        /// </summary>
        internal bool IsSetVpnPort() => this.VpnPort.HasValue;
    }
}
