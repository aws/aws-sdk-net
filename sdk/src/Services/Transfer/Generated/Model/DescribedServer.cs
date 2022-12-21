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
    /// Describes the properties of a file transfer protocol-enabled server that was specified.
    /// </summary>
    public partial class DescribedServer
    {
        private string _arn;
        private string _certificate;
        private Domain _domain;
        private EndpointDetails _endpointDetails;
        private EndpointType _endpointType;
        private string _hostKeyFingerprint;
        private IdentityProviderDetails _identityProviderDetails;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private string _postAuthenticationLoginBanner;
        private string _preAuthenticationLoginBanner;
        private ProtocolDetails _protocolDetails;
        private List<string> _protocols = new List<string>();
        private string _securityPolicyName;
        private string _serverId;
        private State _state;
        private List<Tag> _tags = new List<Tag>();
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
        /// Gets and sets the property Certificate. 
        /// <para>
        /// Specifies the ARN of the Amazon Web ServicesCertificate Manager (ACM) certificate.
        /// Required when <code>Protocols</code> is set to <code>FTPS</code>.
        /// </para>
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
        /// <para>
        /// Specifies the domain of the storage system that is used for file transfers.
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
        /// is equivalent to the output of the <code>ssh-keygen -l -f my-new-server-key</code>
        /// command.
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
        /// not populated when the <code>IdentityProviderType</code> of a server is <code>AWS_DIRECTORY_SERVICE</code>
        /// or <code>SERVICE_MANAGED</code>.
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
        /// The mode of authentication for a server. The default value is <code>SERVICE_MANAGED</code>,
        /// which allows you to store and access user credentials within the Transfer Family service.
        /// </para>
        ///  
        /// <para>
        /// Use <code>AWS_DIRECTORY_SERVICE</code> to provide access to Active Directory groups
        /// in Directory Service for Microsoft Active Directory or Microsoft Active Directory
        /// in your on-premises environment or in Amazon Web Services using AD Connector. This
        /// option also requires you to provide a Directory ID by using the <code>IdentityProviderDetails</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>API_GATEWAY</code> value to integrate with an identity provider of your
        /// choosing. The <code>API_GATEWAY</code> setting requires you to provide an Amazon API
        /// Gateway endpoint URL to call for authentication by using the <code>IdentityProviderDetails</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>AWS_LAMBDA</code> value to directly use an Lambda function as your identity
        /// provider. If you choose this value, you must specify the ARN for the Lambda function
        /// in the <code>Function</code> parameter or the <code>IdentityProviderDetails</code>
        /// data type.
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
        [AWSProperty(Max=512)]
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
        ///  <code>This system is for the use of authorized users only. Individuals using this
        /// computer system without authority, or in excess of their authority, are subject to
        /// having all of their activities on this system monitored and recorded by system personnel.</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        ///  To indicate passive mode (for FTP and FTPS protocols), use the <code>PassiveIp</code>
        /// parameter. Enter a single dotted-quad IPv4 address, such as the external IP address
        /// of a firewall, router, or load balancer. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To ignore the error that is generated when the client attempts to use the <code>SETSTAT</code>
        /// command on a file that you are uploading to an Amazon S3 bucket, use the <code>SetStatOption</code>
        /// parameter. To have the Transfer Family server ignore the <code>SETSTAT</code> command
        /// and upload files without needing to make any changes to your SFTP client, set the
        /// value to <code>ENABLE_NO_OP</code>. If you set the <code>SetStatOption</code> parameter
        /// to <code>ENABLE_NO_OP</code>, Transfer Family generates a log entry to Amazon CloudWatch
        /// Logs, so that you can determine when the client is making a <code>SETSTAT</code> call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To determine whether your Transfer Family server resumes recent, negotiated sessions
        /// through a unique session ID, use the <code>TlsSessionResumptionMode</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>As2Transports</code> indicates the transport method for the AS2 messages. Currently,
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
        ///  </li> <li> 
        /// <para>
        ///  <code>AS2</code> (Applicability Statement 2): used for transporting structured business-to-business
        /// data
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If you select <code>FTPS</code>, you must choose a certificate stored in Certificate
        /// Manager (ACM) which is used to identify your server when clients connect to it over
        /// FTPS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>Protocol</code> includes either <code>FTP</code> or <code>FTPS</code>, then
        /// the <code>EndpointType</code> must be <code>VPC</code> and the <code>IdentityProviderType</code>
        /// must be <code>AWS_DIRECTORY_SERVICE</code> or <code>API_GATEWAY</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>Protocol</code> includes <code>FTP</code>, then <code>AddressAllocationIds</code>
        /// cannot be associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>Protocol</code> is set only to <code>SFTP</code>, the <code>EndpointType</code>
        /// can be set to <code>PUBLIC</code> and the <code>IdentityProviderType</code> can be
        /// set to <code>SERVICE_MANAGED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>Protocol</code> includes <code>AS2</code>, then the <code>EndpointType</code>
        /// must be <code>VPC</code>, and domain must be Amazon S3.
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
        /// The condition of the server that was described. A value of <code>ONLINE</code> indicates
        /// that the server can accept jobs and transfer files. A <code>State</code> value of
        /// <code>OFFLINE</code> means that the server cannot perform file transfer operations.
        /// </para>
        ///  
        /// <para>
        /// The states of <code>STARTING</code> and <code>STOPPING</code> indicate that the server
        /// is in an intermediate state, either not fully able to respond, or not fully offline.
        /// The values of <code>START_FAILED</code> or <code>STOP_FAILED</code> can indicate an
        /// error condition.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs that you can use to search for and group servers that
        /// were assigned to the server that was described.
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

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// Specifies the number of users that are assigned to a server you specified with the
        /// <code>ServerId</code>.
        /// </para>
        /// </summary>
        public int UserCount
        {
            get { return this._userCount.GetValueOrDefault(); }
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
        /// In additon to a workflow to execute when a file is uploaded completely, <code>WorkflowDeatails</code>
        /// can also contain a workflow ID (and execution role) for a workflow to execute on partial
        /// upload. A partial upload occurs when a file is open when the session disconnects.
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