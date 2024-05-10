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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServer operation.
    /// Instantiates an auto-scaling virtual server based on the selected file transfer protocol
    /// in Amazon Web Services. When you make updates to your file transfer protocol-enabled
    /// server or when you work with users, use the service-generated <c>ServerId</c> property
    /// that is assigned to the newly created server.
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
        private string _postAuthenticationLoginBanner;
        private string _preAuthenticationLoginBanner;
        private ProtocolDetails _protocolDetails;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3StorageOptions _s3StorageOptions;
        private string _securityPolicyName;
        private List<string> _structuredLogDestinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private WorkflowDetails _workflowDetails;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Certificate Manager (ACM) certificate. Required
        /// when <c>Protocols</c> is set to <c>FTPS</c>.
        /// </para>
        ///  
        /// <para>
        /// To request a new public certificate, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-public.html">Request
        /// a public certificate</a> in the <i>Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import an existing certificate into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// certificates into ACM</a> in the <i>Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To request a private certificate to use FTPS through private IP addresses, see <a
        /// href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-private.html">Request
        /// a private certificate</a> in the <i>Certificate Manager User Guide</i>.
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
        [AWSProperty(Min=0, Max=1600)]
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
        /// <para>
        /// The domain of the storage system that is used for file transfers. There are two domains
        /// available: Amazon Simple Storage Service (Amazon S3) and Amazon Elastic File System
        /// (Amazon EFS). The default value is S3.
        /// </para>
        ///  <note> 
        /// <para>
        /// After the server is created, the domain cannot be changed.
        /// </para>
        ///  </note>
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
        /// When you host your endpoint within your VPC, you can make your endpoint accessible
        /// only to resources within your VPC, or you can attach Elastic IP addresses and make
        /// your endpoint accessible to clients over the internet. Your VPC's default security
        /// groups are automatically assigned to your endpoint.
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
        /// The type of endpoint that you want your server to use. You can choose to make your
        /// server's endpoint publicly accessible (PUBLIC) or host it inside your VPC. With an
        /// endpoint that is hosted in a VPC, you can restrict access to your server and resources
        /// only within your VPC or choose to make it internet facing by attaching Elastic IP
        /// addresses directly to it.
        /// </para>
        ///  <note> 
        /// <para>
        ///  After May 19, 2021, you won't be able to create a server using <c>EndpointType=VPC_ENDPOINT</c>
        /// in your Amazon Web Services account if your account hasn't already done so before
        /// May 19, 2021. If you have already created servers with <c>EndpointType=VPC_ENDPOINT</c>
        /// in your Amazon Web Services account on or before May 19, 2021, you will not be affected.
        /// After this date, use <c>EndpointType</c>=<c>VPC</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see https://docs.aws.amazon.com/transfer/latest/userguide/create-server-in-vpc.html#deprecate-vpc-endpoint.
        /// </para>
        ///  
        /// <para>
        /// It is recommended that you use <c>VPC</c> as the <c>EndpointType</c>. With this endpoint
        /// type, you have the option to directly associate up to three Elastic IPv4 addresses
        /// (BYO IP included) with your server's endpoint and use VPC security groups to restrict
        /// traffic by the client's public IP address. This is not possible with <c>EndpointType</c>
        /// set to <c>VPC_ENDPOINT</c>.
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
        /// The RSA, ECDSA, or ED25519 private key to use for your SFTP-enabled server. You can
        /// add multiple host keys, in case you want to rotate keys, or have a set of active keys
        /// that use different algorithms.
        /// </para>
        ///  
        /// <para>
        /// Use the following command to generate an RSA 2048 bit key with no passphrase:
        /// </para>
        ///  
        /// <para>
        ///  <c>ssh-keygen -t rsa -b 2048 -N "" -m PEM -f my-new-server-key</c>.
        /// </para>
        ///  
        /// <para>
        /// Use a minimum value of 2048 for the <c>-b</c> option. You can create a stronger key
        /// by using 3072 or 4096.
        /// </para>
        ///  
        /// <para>
        /// Use the following command to generate an ECDSA 256 bit key with no passphrase:
        /// </para>
        ///  
        /// <para>
        ///  <c>ssh-keygen -t ecdsa -b 256 -N "" -m PEM -f my-new-server-key</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for the <c>-b</c> option for ECDSA are 256, 384, and 521.
        /// </para>
        ///  
        /// <para>
        /// Use the following command to generate an ED25519 key with no passphrase:
        /// </para>
        ///  
        /// <para>
        ///  <c>ssh-keygen -t ed25519 -N "" -f my-new-server-key</c>.
        /// </para>
        ///  
        /// <para>
        /// For all of these commands, you can replace <i>my-new-server-key</i> with a string
        /// of your choice.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you aren't planning to migrate existing users from an existing SFTP-enabled server
        /// to a new server, don't update the host key. Accidentally changing a server's host
        /// key can be disruptive.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/edit-server-config.html#configuring-servers-change-host-key">Manage
        /// host keys for your SFTP-enabled server</a> in the <i>Transfer Family User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
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
        /// Required when <c>IdentityProviderType</c> is set to <c>AWS_DIRECTORY_SERVICE</c>,
        /// <c>Amazon Web Services_LAMBDA</c> or <c>API_GATEWAY</c>. Accepts an array containing
        /// all of the information required to use a directory in <c>AWS_DIRECTORY_SERVICE</c>
        /// or invoke a customer-supplied authentication API, including the API Gateway URL. Not
        /// required when <c>IdentityProviderType</c> is set to <c>SERVICE_MANAGED</c>.
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
        /// The mode of authentication for a server. The default value is <c>SERVICE_MANAGED</c>,
        /// which allows you to store and access user credentials within the Transfer Family service.
        /// </para>
        ///  
        /// <para>
        /// Use <c>AWS_DIRECTORY_SERVICE</c> to provide access to Active Directory groups in Directory
        /// Service for Microsoft Active Directory or Microsoft Active Directory in your on-premises
        /// environment or in Amazon Web Services using AD Connector. This option also requires
        /// you to provide a Directory ID by using the <c>IdentityProviderDetails</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>API_GATEWAY</c> value to integrate with an identity provider of your choosing.
        /// The <c>API_GATEWAY</c> setting requires you to provide an Amazon API Gateway endpoint
        /// URL to call for authentication by using the <c>IdentityProviderDetails</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>AWS_LAMBDA</c> value to directly use an Lambda function as your identity
        /// provider. If you choose this value, you must specify the ARN for the Lambda function
        /// in the <c>Function</c> parameter for the <c>IdentityProviderDetails</c> data type.
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
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// allows a server to turn on Amazon CloudWatch logging for Amazon S3 or Amazon EFSevents.
        /// When set, you can view user activity in your CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property PostAuthenticationLoginBanner. 
        /// <para>
        /// Specifies a string to display when users connect to a server. This string is displayed
        /// after the user authenticates.
        /// </para>
        ///  <note> 
        /// <para>
        /// The SFTP protocol does not support post-authentication display banners.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string PostAuthenticationLoginBanner
        {
            get { return this._postAuthenticationLoginBanner; }
            set { this._postAuthenticationLoginBanner = value; }
        }

        // Check to see if PostAuthenticationLoginBanner property is set
        internal bool IsSetPostAuthenticationLoginBanner()
        {
            return this._postAuthenticationLoginBanner != null;
        }

        /// <summary>
        /// Gets and sets the property PreAuthenticationLoginBanner. 
        /// <para>
        /// Specifies a string to display when users connect to a server. This string is displayed
        /// before the user authenticates. For example, the following banner displays details
        /// about using the system:
        /// </para>
        ///  
        /// <para>
        ///  <c>This system is for the use of authorized users only. Individuals using this computer
        /// system without authority, or in excess of their authority, are subject to having all
        /// of their activities on this system monitored and recorded by system personnel.</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string PreAuthenticationLoginBanner
        {
            get { return this._preAuthenticationLoginBanner; }
            set { this._preAuthenticationLoginBanner = value; }
        }

        // Check to see if PreAuthenticationLoginBanner property is set
        internal bool IsSetPreAuthenticationLoginBanner()
        {
            return this._preAuthenticationLoginBanner != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolDetails. 
        /// <para>
        /// The protocol settings that are configured for your server.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  To indicate passive mode (for FTP and FTPS protocols), use the <c>PassiveIp</c> parameter.
        /// Enter a single dotted-quad IPv4 address, such as the external IP address of a firewall,
        /// router, or load balancer. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To ignore the error that is generated when the client attempts to use the <c>SETSTAT</c>
        /// command on a file that you are uploading to an Amazon S3 bucket, use the <c>SetStatOption</c>
        /// parameter. To have the Transfer Family server ignore the <c>SETSTAT</c> command and
        /// upload files without needing to make any changes to your SFTP client, set the value
        /// to <c>ENABLE_NO_OP</c>. If you set the <c>SetStatOption</c> parameter to <c>ENABLE_NO_OP</c>,
        /// Transfer Family generates a log entry to Amazon CloudWatch Logs, so that you can determine
        /// when the client is making a <c>SETSTAT</c> call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To determine whether your Transfer Family server resumes recent, negotiated sessions
        /// through a unique session ID, use the <c>TlsSessionResumptionMode</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>As2Transports</c> indicates the transport method for the AS2 messages. Currently,
        /// only HTTP is supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtocolDetails ProtocolDetails
        {
            get { return this._protocolDetails; }
            set { this._protocolDetails = value; }
        }

        // Check to see if ProtocolDetails property is set
        internal bool IsSetProtocolDetails()
        {
            return this._protocolDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// Specifies the file transfer protocol or protocols over which your file transfer protocol
        /// client can connect to your server's endpoint. The available protocols are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SFTP</c> (Secure Shell (SSH) File Transfer Protocol): File transfer over SSH
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FTPS</c> (File Transfer Protocol Secure): File transfer with TLS encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FTP</c> (File Transfer Protocol): Unencrypted file transfer
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AS2</c> (Applicability Statement 2): used for transporting structured business-to-business
        /// data
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If you select <c>FTPS</c>, you must choose a certificate stored in Certificate Manager
        /// (ACM) which is used to identify your server when clients connect to it over FTPS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Protocol</c> includes either <c>FTP</c> or <c>FTPS</c>, then the <c>EndpointType</c>
        /// must be <c>VPC</c> and the <c>IdentityProviderType</c> must be either <c>AWS_DIRECTORY_SERVICE</c>,
        /// <c>AWS_LAMBDA</c>, or <c>API_GATEWAY</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Protocol</c> includes <c>FTP</c>, then <c>AddressAllocationIds</c> cannot be
        /// associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Protocol</c> is set only to <c>SFTP</c>, the <c>EndpointType</c> can be set
        /// to <c>PUBLIC</c> and the <c>IdentityProviderType</c> can be set any of the supported
        /// identity types: <c>SERVICE_MANAGED</c>, <c>AWS_DIRECTORY_SERVICE</c>, <c>AWS_LAMBDA</c>,
        /// or <c>API_GATEWAY</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Protocol</c> includes <c>AS2</c>, then the <c>EndpointType</c> must be <c>VPC</c>,
        /// and domain must be Amazon S3.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3StorageOptions. 
        /// <para>
        /// Specifies whether or not performance for your Amazon S3 directories is optimized.
        /// This is disabled by default.
        /// </para>
        ///  
        /// <para>
        /// By default, home directory mappings have a <c>TYPE</c> of <c>DIRECTORY</c>. If you
        /// enable this option, you would then need to explicitly set the <c>HomeDirectoryMapEntry</c>
        /// <c>Type</c> to <c>FILE</c> if you want a mapping to have a file target.
        /// </para>
        /// </summary>
        public S3StorageOptions S3StorageOptions
        {
            get { return this._s3StorageOptions; }
            set { this._s3StorageOptions = value; }
        }

        // Check to see if S3StorageOptions property is set
        internal bool IsSetS3StorageOptions()
        {
            return this._s3StorageOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// Specifies the name of the security policy for the server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property StructuredLogDestinations. 
        /// <para>
        /// Specifies the log groups to which your server logs are sent.
        /// </para>
        ///  
        /// <para>
        /// To specify a log group, you must provide the ARN for an existing log group. In this
        /// case, the format of the log group is as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:region-name:amazon-account-id:log-group:log-group-name:*</c> 
        /// </para>
        ///  
        /// <para>
        /// For example, <c>arn:aws:logs:us-east-1:111122223333:log-group:mytestgroup:*</c> 
        /// </para>
        ///  
        /// <para>
        /// If you have previously specified a log group for a server, you can clear it, and in
        /// effect turn off structured logging, by providing an empty value for this parameter
        /// in an <c>update-server</c> call. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>update-server --server-id s-1234567890abcdef0 --structured-log-destinations</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> StructuredLogDestinations
        {
            get { return this._structuredLogDestinations; }
            set { this._structuredLogDestinations = value; }
        }

        // Check to see if StructuredLogDestinations property is set
        internal bool IsSetStructuredLogDestinations()
        {
            return this._structuredLogDestinations != null && (this._structuredLogDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowDetails. 
        /// <para>
        /// Specifies the workflow ID for the workflow to assign and the execution role that's
        /// used for executing the workflow.
        /// </para>
        ///  
        /// <para>
        /// In addition to a workflow to execute when a file is uploaded completely, <c>WorkflowDetails</c>
        /// can also contain a workflow ID (and execution role) for a workflow to execute on partial
        /// upload. A partial upload occurs when the server session disconnects while the file
        /// is still being uploaded.
        /// </para>
        /// </summary>
        public WorkflowDetails WorkflowDetails
        {
            get { return this._workflowDetails; }
            set { this._workflowDetails = value; }
        }

        // Check to see if WorkflowDetails property is set
        internal bool IsSetWorkflowDetails()
        {
            return this._workflowDetails != null;
        }

    }
}