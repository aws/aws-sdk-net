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
    /// Describes the properties of a file transfer protocol-enabled server that was specified.
    /// </summary>
    public partial class DescribedServer
    {
        private string _arn;
        private List<string> _as2ServiceManagedEgressIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _certificate;
        private Domain _domain;
        private EndpointDetails _endpointDetails;
        private EndpointType _endpointType;
        private string _hostKeyFingerprint;
        private IdentityProviderDetails _identityProviderDetails;
        private IdentityProviderType _identityProviderType;
        private IpAddressType _ipAddressType;
        private string _loggingRole;
        private string _postAuthenticationLoginBanner;
        private string _preAuthenticationLoginBanner;
        private ProtocolDetails _protocolDetails;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3StorageOptions _s3StorageOptions;
        private string _securityPolicyName;
        private string _serverId;
        private State _state;
        private List<string> _structuredLogDestinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _userCount;
        private WorkflowDetails _workflowDetails;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) of the server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property As2ServiceManagedEgressIpAddresses. 
        /// <para>
        /// The list of egress IP addresses of this server. These IP addresses are only relevant
        /// for servers that use the AS2 protocol. They are used for sending asynchronous MDNs.
        /// </para>
        ///  
        /// <para>
        /// These IP addresses are assigned automatically when you create an AS2 server. Additionally,
        /// if you update an existing server and add the AS2 protocol, static IP addresses are
        /// assigned as well.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> As2ServiceManagedEgressIpAddresses
        {
            get { return this._as2ServiceManagedEgressIpAddresses; }
            set { this._as2ServiceManagedEgressIpAddresses = value; }
        }

        // Check to see if As2ServiceManagedEgressIpAddresses property is set
        internal bool IsSetAs2ServiceManagedEgressIpAddresses()
        {
            return this._as2ServiceManagedEgressIpAddresses != null && (this._as2ServiceManagedEgressIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// Specifies the ARN of the Amazon Web ServicesCertificate Manager (ACM) certificate.
        /// Required when <c>Protocols</c> is set to <c>FTPS</c>.
        /// </para>
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
        /// Specifies the domain of the storage system that is used for file transfers. There
        /// are two domains available: Amazon Simple Storage Service (Amazon S3) and Amazon Elastic
        /// File System (Amazon EFS). The default value is S3.
        /// </para>
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
        /// Defines the type of endpoint that your server is connected to. If your server is connected
        /// to a VPC endpoint, your server isn't accessible over the public internet.
        /// </para>
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
        /// Gets and sets the property HostKeyFingerprint. 
        /// <para>
        /// Specifies the Base64-encoded SHA256 fingerprint of the server's host key. This value
        /// is equivalent to the output of the <c>ssh-keygen -l -f my-new-server-key</c> command.
        /// </para>
        /// </summary>
        public string HostKeyFingerprint
        {
            get { return this._hostKeyFingerprint; }
            set { this._hostKeyFingerprint = value; }
        }

        // Check to see if HostKeyFingerprint property is set
        internal bool IsSetHostKeyFingerprint()
        {
            return this._hostKeyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// Specifies information to call a customer-supplied authentication API. This field is
        /// not populated when the <c>IdentityProviderType</c> of a server is <c>AWS_DIRECTORY_SERVICE</c>
        /// or <c>SERVICE_MANAGED</c>.
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
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// Specifies whether to use IPv4 only, or to use dual-stack (IPv4 and IPv6) for your
        /// Transfer Family endpoint. The default value is <c>IPV4</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>IpAddressType</c> parameter has the following limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It cannot be changed while the server is online. You must stop the server before modifying
        /// this parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It cannot be updated to <c>DUALSTACK</c> if the server has <c>AddressAllocationIds</c>
        /// specified.
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// When using <c>DUALSTACK</c> as the <c>IpAddressType</c>, you cannot set the <c>AddressAllocationIds</c>
        /// parameter for the <a href="https://docs.aws.amazon.com/transfer/latest/APIReference/API_EndpointDetails.html">EndpointDetails</a>
        /// for the server.
        /// </para>
        ///  </note>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// allows a server to turn on Amazon CloudWatch logging for Amazon S3 or Amazon EFS events.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, this is enabled by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the API or CLI, this is disabled by default.
        /// </para>
        ///  </li> </ul> 
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
        /// Gets and sets the property ServerId. 
        /// <para>
        /// Specifies the unique system-assigned identifier for a server that you instantiate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The condition of the server that was described. A value of <c>ONLINE</c> indicates
        /// that the server can accept jobs and transfer files. A <c>State</c> value of <c>OFFLINE</c>
        /// means that the server cannot perform file transfer operations.
        /// </para>
        ///  
        /// <para>
        /// The states of <c>STARTING</c> and <c>STOPPING</c> indicate that the server is in an
        /// intermediate state, either not fully able to respond, or not fully offline. The values
        /// of <c>START_FAILED</c> or <c>STOP_FAILED</c> can indicate an error condition.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Specifies the key-value pairs that you can use to search for and group servers that
        /// were assigned to the server that was described.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property UserCount. 
        /// <para>
        /// Specifies the number of users that are assigned to a server you specified with the
        /// <c>ServerId</c>.
        /// </para>
        /// </summary>
        public int? UserCount
        {
            get { return this._userCount; }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
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