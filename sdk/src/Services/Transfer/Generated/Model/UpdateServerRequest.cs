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
    /// Container for the parameters to the UpdateServer operation.
    /// Updates the file transfer protocol-enabled server's properties after that server has
    /// been created.
    /// 
    ///  
    /// <para>
    /// The <code>UpdateServer</code> call returns the <code>ServerId</code> of the server
    /// you updated.
    /// </para>
    /// </summary>
    public partial class UpdateServerRequest : AmazonTransferRequest
    {
        private string _certificate;
        private EndpointDetails _endpointDetails;
        private EndpointType _endpointType;
        private string _hostKey;
        private IdentityProviderDetails _identityProviderDetails;
        private string _loggingRole;
        private List<string> _protocols = new List<string>();
        private string _securityPolicyName;
        private string _serverId;

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
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// The virtual private cloud (VPC) endpoint settings that are configured for your server.
        /// With a VPC endpoint, you can restrict access to your server to resources only within
        /// your VPC. To control incoming internet traffic, you will need to associate one or
        /// more Elastic IP addresses with your server's endpoint.
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
        /// The type of endpoint that you want your server to connect to. You can choose to connect
        /// to the public internet or a VPC endpoint. With a VPC endpoint, you can restrict access
        /// to your server and resources only within your VPC.
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
        /// The RSA private key as generated by <code>ssh-keygen -N "" -m PEM -f my-new-server-key</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you aren't planning to migrate existing users from an existing server to a new
        /// server, don't update the host key. Accidentally changing a server's host key can be
        /// disruptive.
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
        /// An array containing all of the information required to call a customer's authentication
        /// API method.
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
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// Changes the AWS Identity and Access Management (IAM) role that allows Amazon S3 events
        /// to be logged in Amazon CloudWatch, turning logging on or off.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Secure Shell (SSH) File Transfer Protocol (SFTP): File transfer over SSH
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File Transfer Protocol Secure (FTPS): File transfer with TLS encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File Transfer Protocol (FTP): Unencrypted file transfer
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
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server instance that the user account is
        /// assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

    }
}