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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// DescribeLocationSmbResponse
    /// </summary>
    public partial class DescribeLocationSmbResponse : AmazonWebServiceResponse
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SmbAuthenticationType _authenticationType;
        private CmkSecretConfig _cmkSecretConfig;
        private DateTime? _creationTime;
        private CustomSecretConfig _customSecretConfig;
        private List<string> _dnsIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domain;
        private string _kerberosPrincipal;
        private string _locationArn;
        private string _locationUri;
        private ManagedSecretConfig _managedSecretConfig;
        private SmbMountOptions _mountOptions;
        private string _user;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARNs of the DataSync agents that can connect with your SMB file server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && (this._agentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication protocol that DataSync uses to connect to your SMB file server.
        /// </para>
        /// </summary>
        public SmbAuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as a <c>Password</c>
        /// or <c>KerberosKeytab</c> that DataSync uses to access a specific storage location,
        /// with a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig
        {
            get { return this._cmkSecretConfig; }
            set { this._cmkSecretConfig = value; }
        }

        // Check to see if CmkSecretConfig property is set
        internal bool IsSetCmkSecretConfig()
        {
            return this._cmkSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the SMB location was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Describes configuration information for a customer-managed secret, such as a <c>Password</c>
        /// or <c>KerberosKeytab</c> that DataSync uses to access a specific storage location,
        /// with a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig
        {
            get { return this._customSecretConfig; }
            set { this._customSecretConfig = value; }
        }

        // Check to see if CustomSecretConfig property is set
        internal bool IsSetCustomSecretConfig()
        {
            return this._customSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddresses. 
        /// <para>
        /// The IPv4 or IPv6 addresses for the DNS servers that your SMB file server belongs to.
        /// This element applies only if <c>AuthenticationType</c> is set to <c>KERBEROS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> DnsIpAddresses
        {
            get { return this._dnsIpAddresses; }
            set { this._dnsIpAddresses = value; }
        }

        // Check to see if DnsIpAddresses property is set
        internal bool IsSetDnsIpAddresses()
        {
            return this._dnsIpAddresses != null && (this._dnsIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the Windows domain that the SMB file server belongs to. This element applies
        /// only if <c>AuthenticationType</c> is set to <c>NTLM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=253)]
        public string Domain
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
        /// Gets and sets the property KerberosPrincipal. 
        /// <para>
        /// The Kerberos principal that has permission to access the files, folders, and file
        /// metadata in your SMB file server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string KerberosPrincipal
        {
            get { return this._kerberosPrincipal; }
            set { this._kerberosPrincipal = value; }
        }

        // Check to see if KerberosPrincipal property is set
        internal bool IsSetKerberosPrincipal()
        {
            return this._kerberosPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of the SMB location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI of the SMB location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as a <c>Password</c>
        /// or <c>KerberosKeytab</c> that DataSync uses to access a specific storage location.
        /// DataSync uses the default Amazon Web Services-managed KMS key to encrypt this secret
        /// in Secrets Manager.
        /// </para>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig
        {
            get { return this._managedSecretConfig; }
            set { this._managedSecretConfig = value; }
        }

        // Check to see if ManagedSecretConfig property is set
        internal bool IsSetManagedSecretConfig()
        {
            return this._managedSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MountOptions. 
        /// <para>
        /// The SMB protocol version that DataSync uses to access your SMB file server.
        /// </para>
        /// </summary>
        public SmbMountOptions MountOptions
        {
            get { return this._mountOptions; }
            set { this._mountOptions = value; }
        }

        // Check to see if MountOptions property is set
        internal bool IsSetMountOptions()
        {
            return this._mountOptions != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user that can mount and access the files, folders, and file metadata in your SMB
        /// file server. This element applies only if <c>AuthenticationType</c> is set to <c>NTLM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=104)]
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}