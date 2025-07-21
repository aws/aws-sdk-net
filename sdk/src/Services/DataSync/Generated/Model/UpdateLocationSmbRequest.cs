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
    /// Container for the parameters to the UpdateLocationSmb operation.
    /// Modifies the following configuration parameters of the Server Message Block (SMB)
    /// transfer location that you're using with DataSync.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Configuring
    /// DataSync transfers with an SMB file server</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLocationSmbRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SmbAuthenticationType _authenticationType;
        private List<string> _dnsIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domain;
        private MemoryStream _kerberosKeytab;
        private MemoryStream _kerberosKrb5Conf;
        private string _kerberosPrincipal;
        private string _locationArn;
        private SmbMountOptions _mountOptions;
        private string _password;
        private string _serverHostname;
        private string _subdirectory;
        private string _user;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// Specifies the DataSync agent (or agents) that can connect to your SMB file server.
        /// You specify an agent by using its Amazon Resource Name (ARN).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
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
        /// Gets and sets the property DnsIpAddresses. 
        /// <para>
        /// Specifies the IP addresses (IPv4 or IPv6) for the DNS servers that your SMB file server
        /// belongs to. This parameter applies only if <c>AuthenticationType</c> is set to <c>KERBEROS</c>.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple domains in your environment, configuring this parameter makes
        /// sure that DataSync connects to the right SMB file server. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Specifies a Kerberos prinicpal, which is an identity in your Kerberos realm that has
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
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the ARN of the SMB location that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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
        /// Gets and sets the property MountOptions.
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
        [AWSProperty(Max=255)]
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
        /// To copy all data in the specified subdirectory, DataSync must be able to mount the
        /// SMB share and access all of its data. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">Providing
        /// DataSync access to SMB file servers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// Gets and sets the property User. 
        /// <para>
        /// Specifies the user name that can mount your SMB file server and has permission to
        /// access the files and folders involved in your transfer. This parameter applies only
        /// if <c>AuthenticationType</c> is set to <c>NTLM</c>.
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