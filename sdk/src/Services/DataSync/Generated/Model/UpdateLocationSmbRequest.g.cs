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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateLocationSmb operation. Modifies the following
    /// configuration parameters of the Server Message Block (SMB) transfer location that
    /// you're using with DataSync. <para> For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Configuring
    /// DataSync transfers with an SMB file server</a>. </para>
    /// </summary>
    public partial class UpdateLocationSmbRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// Specifies the DataSync agent (or agents) that can connect to your SMB file server.
        /// You specify an agent by using its Amazon Resource Name (ARN).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<string> AgentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentArns property is set.
        /// </summary>
        internal bool IsSetAgentArns() => this.AgentArns != null && (this.AgentArns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public SmbAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Specifies configuration information for a DataSync-managed secret, such as a <c>Password</c>
        /// or <c>KerberosKeytab</c> or set of credentials that DataSync uses to access a specific
        /// transfer location, and a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed secret, such as a <c>Password</c>
        /// or <c>KerberosKeytab</c> or set of credentials that DataSync uses to access a specific
        /// transfer location, and a customer-managed Identity and Access Management (IAM) role
        /// that provides access to the secret.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> DnsIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpAddresses property is set.
        /// </summary>
        internal bool IsSetDnsIpAddresses() => this.DnsIpAddresses != null && (this.DnsIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 0, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

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
        [AWSProperty(Min = 0, Max = 65536)]
        public MemoryStream KerberosKeytab { get; set; }

        /// <summary>
        /// Checks to see if the KerberosKeytab property is set.
        /// </summary>
        internal bool IsSetKerberosKeytab() => this.KerberosKeytab != null;

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
        [AWSProperty(Min = 0, Max = 131072)]
        public MemoryStream KerberosKrb5Conf { get; set; }

        /// <summary>
        /// Checks to see if the KerberosKrb5Conf property is set.
        /// </summary>
        internal bool IsSetKerberosKrb5Conf() => this.KerberosKrb5Conf != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the KerberosPrincipal property is set.
        /// </summary>
        internal bool IsSetKerberosPrincipal() => this.KerberosPrincipal != null;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the ARN of the SMB location that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property MountOptions.
        /// </summary>
        public SmbMountOptions MountOptions { get; set; }

        /// <summary>
        /// Checks to see if the MountOptions property is set.
        /// </summary>
        internal bool IsSetMountOptions() => this.MountOptions != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password of the user who can mount your SMB file server and has permission
        /// to access the files and folders involved in your transfer. This parameter applies
        /// only if <c>AuthenticationType</c> is set to <c>NTLM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 104)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

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
        [AWSProperty(Min = 0, Max = 255)]
        public string ServerHostname { get; set; }

        /// <summary>
        /// Checks to see if the ServerHostname property is set.
        /// </summary>
        internal bool IsSetServerHostname() => this.ServerHostname != null;

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
        [AWSProperty(Min = 0, Max = 4096)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;

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
        [AWSProperty(Min = 0, Max = 104)]
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
