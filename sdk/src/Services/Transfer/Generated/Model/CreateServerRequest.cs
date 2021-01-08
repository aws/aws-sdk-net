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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServer operation.
    /// Instantiates an autoscaling virtual server based on the selected file transfer protocol
    /// in AWS. When you make updates to your file transfer protocol-enabled server or when
    /// you work with users, use the service-generated <code>ServerId</code> property that
    /// is assigned to the newly created server.
    /// </summary>
    public partial class CreateServerRequest : AmazonTransferRequest
    {
        private string _certificate;
        private Domain _domain;
        private EndpointDetails _endpointDetails;
        private EndpointType _endpointType;
        private string _hostKey;
        private IdentityProviderDetails _identityProviderDetails;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private List<string> _protocols = new List<string>();
        private string _securityPolicyName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Certificate Manager (ACM) certificate. Required
        /// when <code>Protocols</code> is set to <code>FTPS</code>.
        /// </para>
        ///  
        /// <para>
        /// To request a new public certificate, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-public.html">Request
        /// a public certificate</a> in the <i> AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import an existing certificate into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// certificates into ACM</a> in the <i> AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To request a private certificate to use FTPS through private IP addresses, see <a
        /// href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-private.html">Request
        /// a private certificate</a> in the <i> AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Certificates with the following cryptographic algorithms and key sizes are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 2048-bit RSA (RSA_2048)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4096-bit RSA (RSA_4096)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elliptic Prime Curve 256 bit (EC_prime256v1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elliptic Prime Curve 384 bit (EC_secp384r1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elliptic Prime Curve 521 bit (EC_secp521r1)
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The certificate must be a valid SSL/TLS X.509 version 3 certificate with FQDN or IP
        /// address specified and information about the issuer.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=1600)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property Domain.
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// The virtual private cloud (VPC) endpoint settings that are configured for your server.
        /// When you host your endpoint within your VPC, you can make it accessible only to resources
        /// within your VPC, or you can attach Elastic IPs and make it accessible to clients over
        /// the internet. Your VPC's default security groups are automatically assigned to your
        /// endpoint.
        /// </para>
        /// </summary>
        public EndpointDetails EndpointDetails
        {
            get { return this._endpointDetails; }
            set { this._endpointDetails = value; }
        }

        // Check to see if EndpointDetails property is set
        internal bool IsSetEndpointDetails()
        {
            return this._endpointDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of VPC endpoint that you want your server to connect to. You can choose to
        /// connect to the public internet or a VPC endpoint. With a VPC endpoint, you can restrict
        /// access to your server and resources only within your VPC.
        /// </para>
        ///  <note> 
        /// <para>
        /// It is recommended that you use <code>VPC</code> as the <code>EndpointType</code>.
        /// With this endpoint type, you have the option to directly associate up to three Elastic
        /// IPv4 addresses (BYO IP included) with your server's endpoint and use VPC security
        /// groups to restrict traffic by the client's public IP address. This is not possible
        /// with <code>EndpointType</code> set to <code>VPC_ENDPOINT</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property HostKey. 
        /// <para>
        /// The RSA private key as generated by the <code>ssh-keygen -N "" -m PEM -f my-new-server-key</code>
        /// command.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you aren't planning to migrate existing users from an existing SFTP-enabled server
        /// to a new server, don't update the host key. Accidentally changing a server's host
        /// key can be disruptive.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/edit-server-config.html#configuring-servers-change-host-key">Change
        /// the host key for your SFTP-enabled server</a> in the <i>AWS Transfer Family User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string HostKey
        {
            get { return this._hostKey; }
            set { this._hostKey = value; }
        }

        // Check to see if HostKey property is set
        internal bool IsSetHostKey()
        {
            return this._hostKey != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// Required when <code>IdentityProviderType</code> is set to <code>API_GATEWAY</code>.
        /// Accepts an array containing all of the information required to call a customer-supplied
        /// authentication API, including the API Gateway URL. Not required when <code>IdentityProviderType</code>
        /// is set to <code>SERVICE_MANAGED</code>.
        /// </para>
        /// </summary>
        public IdentityProviderDetails IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// Specifies the mode of authentication for a server. The default value is <code>SERVICE_MANAGED</code>,
        /// which allows you to store and access user credentials within the AWS Transfer Family
        /// service. Use the <code>API_GATEWAY</code> value to integrate with an identity provider
        /// of your choosing. The <code>API_GATEWAY</code> setting requires you to provide an
        /// API Gateway endpoint URL to call for authentication using the <code>IdentityProviderDetails</code>
        /// parameter.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// Allows the service to write your users' activity to your Amazon CloudWatch logs for
        /// monitoring and auditing purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// Specifies the file transfer protocol or protocols over which your file transfer protocol
        /// client can connect to your server's endpoint. The available protocols are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SFTP</code> (Secure Shell (SSH) File Transfer Protocol): File transfer over
        /// SSH
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FTPS</code> (File Transfer Protocol Secure): File transfer with TLS encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FTP</code> (File Transfer Protocol): Unencrypted file transfer
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you select <code>FTPS</code>, you must choose a certificate stored in AWS Certificate
        /// Manager (ACM) which will be used to identify your server when clients connect to it
        /// over FTPS.
        /// </para>
        ///  
        /// <para>
        /// If <code>Protocol</code> includes either <code>FTP</code> or <code>FTPS</code>, then
        /// the <code>EndpointType</code> must be <code>VPC</code> and the <code>IdentityProviderType</code>
        /// must be <code>API_GATEWAY</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>Protocol</code> includes <code>FTP</code>, then <code>AddressAllocationIds</code>
        /// cannot be associated.
        /// </para>
        ///  
        /// <para>
        /// If <code>Protocol</code> is set only to <code>SFTP</code>, the <code>EndpointType</code>
        /// can be set to <code>PUBLIC</code> and the <code>IdentityProviderType</code> can be
        /// set to <code>SERVICE_MANAGED</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// Specifies the name of the security policy that is attached to the server.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string SecurityPolicyName
        {
            get { return this._securityPolicyName; }
            set { this._securityPolicyName = value; }
        }

        // Check to see if SecurityPolicyName property is set
        internal bool IsSetSecurityPolicyName()
        {
            return this._securityPolicyName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

    }
}