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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<AwsEc2ClientVpnEndpointAuthenticationOptionsDetails> _authenticationOptions = AWSConfigs.InitializeCollections ? new List<AwsEc2ClientVpnEndpointAuthenticationOptionsDetails>() : null;
        private string _clientCidrBlock;
        private AwsEc2ClientVpnEndpointClientConnectOptionsDetails _clientConnectOptions;
        private AwsEc2ClientVpnEndpointClientLoginBannerOptionsDetails _clientLoginBannerOptions;
        private string _clientVpnEndpointId;
        private AwsEc2ClientVpnEndpointConnectionLogOptionsDetails _connectionLogOptions;
        private string _description;
        private List<string> _dnsServer = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroupIdSet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _selfServicePortalUrl;
        private string _serverCertificateArn;
        private int? _sessionTimeoutHours;
        private bool? _splitTunnel;
        private string _transportProtocol;
        private string _vpcId;
        private int? _vpnPort;

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        ///  Information about the authentication method used by the Client VPN endpoint. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2ClientVpnEndpointAuthenticationOptionsDetails> AuthenticationOptions
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
        ///  The IPv4 address range, in CIDR notation, from which client IP addresses are assigned.
        /// 
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
        ///  The options for managing connection authorization for new client connections. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointClientConnectOptionsDetails ClientConnectOptions
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
        ///  Options for enabling a customizable text banner that will be displayed on Amazon
        /// Web Services provided clients when a VPN session is established. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointClientLoginBannerOptionsDetails ClientLoginBannerOptions
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
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        ///  The ID of the Client VPN endpoint. 
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
        ///  Information about the client connection logging options for the Client VPN endpoint.
        /// 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointConnectionLogOptionsDetails ConnectionLogOptions
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
        ///  A brief description of the endpoint. 
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
        /// Gets and sets the property DnsServer. 
        /// <para>
        ///  Information about the DNS servers to be used for DNS resolution. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServer
        {
            get { return this._dnsServer; }
            set { this._dnsServer = value; }
        }

        // Check to see if DnsServer property is set
        internal bool IsSetDnsServer()
        {
            return this._dnsServer != null && (this._dnsServer.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIdSet. 
        /// <para>
        ///  The IDs of the security groups for the target network. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIdSet
        {
            get { return this._securityGroupIdSet; }
            set { this._securityGroupIdSet = value; }
        }

        // Check to see if SecurityGroupIdSet property is set
        internal bool IsSetSecurityGroupIdSet()
        {
            return this._securityGroupIdSet != null && (this._securityGroupIdSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelfServicePortalUrl. 
        /// <para>
        ///  The URL of the self-service portal. 
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
        ///  The Amazon Resource Name (ARN) of the server certificate. 
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
        ///  The maximum VPN session duration time in hours. 
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
        ///  Indicates whether split-tunnel is enabled in the Client VPN endpoint. 
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
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        ///  The transport protocol used by the Client VPN endpoint. 
        /// </para>
        /// </summary>
        public string TransportProtocol
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
        ///  The ID of the VPC. 
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
        ///  The port number for the Client VPN endpoint. 
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