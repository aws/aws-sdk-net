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
    /// Container for the parameters to the CreateLocationSmb operation.
    /// Creates a transfer <i>location</i> for a Server Message Block (SMB) file server. DataSync
    /// can use this location as a source or destination for transferring data.
    /// 
    ///  
    /// <para>
    /// Before you begin, make sure that you understand how DataSync accesses SMB file servers.
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">Providing
    /// DataSync access to SMB file servers</a>.
    /// </para>
    /// </summary>
    public partial class CreateLocationSmbRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SmbAuthenticationType _authenticationType;
        private CmkSecretConfig _cmkSecretConfig;
        private CustomSecretConfig _customSecretConfig;
        private List<string> _dnsIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domain;
        private MemoryStream _kerberosKeytab;
        private MemoryStream _kerberosKrb5Conf;
        private string _kerberosPrincipal;
        private SmbMountOptions _mountOptions;
        private string _password;
        private string _serverHostname;
        private string _subdirectory;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;
        private string _user;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// Specifies the DataSync agent (or agents) that can connect to your SMB file server.
        /// You specify an agent by using its Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
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
        /// Specifies the authentication protocol that DataSync uses to connect to your SMB file
        /// server. DataSync supports <c>NTLM</c> (default) and <c>KERBEROS</c> authentication.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">Providing
        /// DataSync access to SMB file servers</a>.
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
        /// Specifies configuration information for a DataSync-managed secret, either a <c>Password</c>
        /// or <c>KerberosKeytab</c> (for <c>NTLM</c> (default) and <c>KERBEROS</c> authentication
        /// types, respectively) that DataSync uses to access a specific SMB storage location,
        /// with a customer-managed KMS key.
        /// </para>
        ///  
        /// <para>
        /// When you include this parameter as part of a <c>CreateLocationSmbRequest</c> request,
        /// you provide only the KMS key ARN. DataSync uses this KMS key together with either
        /// the <c>Password</c> or <c>KerberosKeytab</c> you specify to create a DataSync-managed
        /// secret to store the location access credentials.
        /// </para>
        ///  
        /// <para>
        /// Make sure that DataSync has permission to access the KMS key that you specify.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with either <c>Password</c> or <c>KerberosKeytab</c>)
        /// or <c>CustomSecretConfig</c> (without any <c>Password</c> and <c>KerberosKeytab</c>)
        /// to provide credentials for a <c>CreateLocationSmbRequest</c> request. Do not provide
        /// both <c>CmkSecretConfig</c> and <c>CustomSecretConfig</c> parameters for the same
        /// request.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed Secrets Manager secret
        /// where the SMB storage location credentials is stored in Secrets Manager as plain text
        /// (for <c>Password</c>) or binary (for <c>KerberosKeytab</c>). This configuration includes
        /// the secret ARN, and the ARN for an IAM role that provides access to the secret.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with <c>SasConfiguration</c>) or <c>CustomSecretConfig</c>
        /// (without <c>SasConfiguration</c>) to provide credentials for a <c>CreateLocationSmbRequest</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
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
        /// Specifies the IPv4 or IPv6 addresses for the DNS servers that your SMB file server
        /// belongs to. This parameter applies only if <c>AuthenticationType</c> is set to <c>KERBEROS</c>.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple domains in your environment, configuring this parameter makes
        /// sure that DataSync connects to the right SMB file server.
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
        /// Specifies the Windows domain name that your SMB file server belongs to. This parameter
        /// applies only if <c>AuthenticationType</c> is set to <c>NTLM</c>.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple domains in your environment, configuring this parameter makes
        /// sure that DataSync connects to the right file server.
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
        /// Gets and sets the property KerberosKeytab. 
        /// <para>
        /// Specifies your Kerberos key table (keytab) file, which includes mappings between your
        /// Kerberos principal and encryption keys.
        /// </para>
        ///  
        /// <para>
        /// To avoid task execution errors, make sure that the Kerberos principal that you use
        /// to create the keytab file matches exactly what you specify for <c>KerberosPrincipal</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=65536)]
        public MemoryStream KerberosKeytab
        {
            get { return this._kerberosKeytab; }
            set { this._kerberosKeytab = value; }
        }

        // Check to see if KerberosKeytab property is set
        internal bool IsSetKerberosKeytab()
        {
            return this._kerberosKeytab != null;
        }

        /// <summary>
        /// Gets and sets the property KerberosKrb5Conf. 
        /// <para>
        /// Specifies a Kerberos configuration file (<c>krb5.conf</c>) that defines your Kerberos
        /// realm configuration.
        /// </para>
        ///  
        /// <para>
        /// The file must be base64 encoded. If you're using the CLI, the encoding is done for
        /// you.
        /// </para>
        /// </summary>
        [AWSProperty(Max=131072)]
        public MemoryStream KerberosKrb5Conf
        {
            get { return this._kerberosKrb5Conf; }
            set { this._kerberosKrb5Conf = value; }
        }

        // Check to see if KerberosKrb5Conf property is set
        internal bool IsSetKerberosKrb5Conf()
        {
            return this._kerberosKrb5Conf != null;
        }

        /// <summary>
        /// Gets and sets the property KerberosPrincipal. 
        /// <para>
        /// Specifies a Kerberos principal, which is an identity in your Kerberos realm that has
        /// permission to access the files, folders, and file metadata in your SMB file server.
        /// </para>
        ///  
        /// <para>
        /// A Kerberos principal might look like <c>HOST/kerberosuser@MYDOMAIN.ORG</c>.
        /// </para>
        ///  
        /// <para>
        /// Principal names are case sensitive. Your DataSync task execution will fail if the
        /// principal that you specify for this parameter doesn’t exactly match the principal
        /// that you use to create the keytab file.
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
        /// Gets and sets the property MountOptions. 
        /// <para>
        /// Specifies the version of the SMB protocol that DataSync uses to access your SMB file
        /// server.
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
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password of the user who can mount your SMB file server and has permission
        /// to access the files and folders involved in your transfer. This parameter applies
        /// only if <c>AuthenticationType</c> is set to <c>NTLM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=104)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property ServerHostname. 
        /// <para>
        /// Specifies the domain name or IP address (IPv4 or IPv6) of the SMB file server that
        /// your DataSync agent connects to.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using Kerberos authentication, you must specify a domain name.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ServerHostname
        {
            get { return this._serverHostname; }
            set { this._serverHostname = value; }
        }

        // Check to see if ServerHostname property is set
        internal bool IsSetServerHostname()
        {
            return this._serverHostname != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies the name of the share exported by your SMB file server where DataSync will
        /// read or write data. You can include a subdirectory in the share path (for example,
        /// <c>/path/to/subdirectory</c>). Make sure that other SMB clients in your network can
        /// also mount this path.
        /// </para>
        ///  
        /// <para>
        /// To copy all data in the subdirectory, DataSync must be able to mount the SMB share
        /// and access all of its data. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">Providing
        /// DataSync access to SMB file servers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least a name tag for your location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
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
        /// Gets and sets the property User. 
        /// <para>
        /// Specifies the user that can mount and access the files, folders, and file metadata
        /// in your SMB file server. This parameter applies only if <c>AuthenticationType</c>
        /// is set to <c>NTLM</c>.
        /// </para>
        ///  
        /// <para>
        /// For information about choosing a user with the right level of access for your transfer,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">Providing
        /// DataSync access to SMB file servers</a>.
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