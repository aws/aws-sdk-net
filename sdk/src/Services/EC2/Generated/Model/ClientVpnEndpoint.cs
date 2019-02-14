/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Client VPN endpoint.
    /// </summary>
    public partial class ClientVpnEndpoint
    {
        private List<AssociatedTargetNetwork> _associatedTargetNetworks = new List<AssociatedTargetNetwork>();
        private List<ClientVpnAuthentication> _authenticationOptions = new List<ClientVpnAuthentication>();
        private string _clientCidrBlock;
        private string _clientVpnEndpointId;
        private ConnectionLogResponseOptions _connectionLogOptions;
        private string _creationTime;
        private string _deletionTime;
        private string _description;
        private string _dnsName;
        private List<string> _dnsServers = new List<string>();
        private string _serverCertificateArn;
        private bool? _splitTunnel;
        private ClientVpnEndpointStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private TransportProtocol _transportProtocol;
        private VpnProtocol _vpnProtocol;

        /// <summary>
        /// Gets and sets the property AssociatedTargetNetworks. 
        /// <para>
        /// Information about the associated target networks. A target network is a subnet in
        /// a VPC.
        /// </para>
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
            return this._associatedTargetNetworks != null && this._associatedTargetNetworks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        /// Information about the authentication method used by the Client VPN endpoint.
        /// </para>
        /// </summary>
        public List<ClientVpnAuthentication> AuthenticationOptions
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
        /// Gets and sets the property SplitTunnel. 
        /// <para>
        /// Indicates whether VPN split tunneling is supported.
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        ///  <b>The transport protocol used by the Client VPN endpoint.</b> 
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