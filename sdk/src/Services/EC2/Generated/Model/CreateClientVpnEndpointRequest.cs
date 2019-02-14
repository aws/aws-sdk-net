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
    /// Container for the parameters to the CreateClientVpnEndpoint operation.
    /// Creates a Client VPN endpoint. A Client VPN endpoint is the resource you create and
    /// configure to enable and manage client VPN sessions. It is the destination endpoint
    /// at which all client VPN sessions are terminated.
    /// </summary>
    public partial class CreateClientVpnEndpointRequest : AmazonEC2Request
    {
        private List<ClientVpnAuthenticationRequest> _authenticationOptions = new List<ClientVpnAuthenticationRequest>();
        private string _clientCidrBlock;
        private string _clientToken;
        private ConnectionLogOptions _connectionLogOptions;
        private string _description;
        private List<string> _dnsServers = new List<string>();
        private string _serverCertificateArn;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private TransportProtocol _transportProtocol;

        /// <summary>
        /// Gets and sets the property AuthenticationOptions. 
        /// <para>
        /// Information about the authentication method to be used to authenticate clients.
        /// </para>
        /// </summary>
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
        /// changed after the Client VPN endpoint has been created. The CIDR block should be /22
        /// or greater.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">
        /// How to Ensure Idempotency</a>.
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
        /// can have up to two DNS servers. If no DNS server is specified, the DNS address of
        /// the VPC that is to be associated with Client VPN endpoint is used as the DNS server.
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
        /// The ARN of the server certificate. For more information, see the <a href="acm/latest/userguide/acm-overview.html">AWS
        /// Certificate Manager User Guide</a> .
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

    }
}