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
    /// Container for the parameters to the CreateLocationHdfs operation. Creates a transfer
    /// <i>location</i> for a Hadoop Distributed File System (HDFS). DataSync can use this
    /// location as a source or destination for transferring data. <para> Before you begin,
    /// make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html#accessing-hdfs">accesses
    /// HDFS clusters</a>. </para>
    /// </summary>
    public partial class CreateLocationHdfsRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the DataSync agents that can connect to your HDFS
        /// cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public List<string> AgentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentArns property is set.
        /// </summary>
        internal bool IsSetAgentArns() => this.AgentArns != null && (this.AgentArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication used to determine the identity of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HdfsAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of data blocks to write into the HDFS cluster. The block size must be a multiple
        /// of 512 bytes. The default block size is 128 mebibytes (MiB).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1048576, Max = 1073741824)]
        public int? BlockSize { get; set; }

        /// <summary>
        /// Checks to see if the BlockSize property is set.
        /// </summary>
        internal bool IsSetBlockSize() => this.BlockSize.HasValue;

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Specifies configuration information for a DataSync-managed secret, which includes
        /// the Kerberos keytab that DataSync uses to access a specific Hadoop Distributed File
        /// System (HDFS) storage location, with a customer-managed KMS key.
        /// </para>
        ///  
        /// <para>
        /// When you include this parameter as part of a <c>CreateLocationHdfs</c> request, you
        /// provide only the KMS key ARN. DataSync uses this KMS key together with the <c>KerberosKeytab</c>
        /// you specify for to create a DataSync-managed secret to store the location access credentials.
        /// </para>
        ///  
        /// <para>
        /// Make sure that DataSync has permission to access the KMS key that you specify. For
        /// more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/location-credentials.html#service-secret-custom-key">
        /// Using a service-managed secret encrypted with a custom KMS key</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with <c>KerberosKeytab</c>) or <c>CustomSecretConfig</c>
        /// (without <c>KerberosKeytab</c>) to provide credentials for a <c>CreateLocationHdfs</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed Secrets Manager secret
        /// where the Kerberos keytab for the HDFS storage location is stored in binary, in Secrets
        /// Manager. This configuration includes the secret ARN, and the ARN for an IAM role that
        /// provides access to the secret. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/location-credentials.html#custom-secret-custom-key">
        /// Using a secret that you manage</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with <c>KerberosKeytab</c>) or <c>CustomSecretConfig</c>
        /// (without <c>KerberosKeytab</c>) to provide credentials for a <c>CreateLocationHdfs</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

        /// <summary>
        /// Gets and sets the property KerberosKeytab. 
        /// <para>
        /// The Kerberos key table (keytab) that contains mappings between the defined Kerberos
        /// principal and the encrypted keys. You can load the keytab from a file by providing
        /// the file's address.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>KERBEROS</c> is specified for <c>AuthenticationType</c>, this parameter is required.
        /// 
        /// </para>
        ///  </note>
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
        /// The <c>krb5.conf</c> file that contains the Kerberos configuration information. You
        /// can load the <c>krb5.conf</c> file by providing the file's address. If you're using
        /// the CLI, it performs the base64 encoding for you. Otherwise, provide the base64-encoded
        /// text. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>KERBEROS</c> is specified for <c>AuthenticationType</c>, this parameter is required.
        /// </para>
        ///  </note>
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
        /// The Kerberos principal with access to the files and folders on the HDFS cluster. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>KERBEROS</c> is specified for <c>AuthenticationType</c>, this parameter is required.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the KerberosPrincipal property is set.
        /// </summary>
        internal bool IsSetKerberosPrincipal() => this.KerberosPrincipal != null;

        /// <summary>
        /// Gets and sets the property KmsKeyProviderUri. 
        /// <para>
        /// The URI of the HDFS cluster's Key Management Server (KMS). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string KmsKeyProviderUri { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyProviderUri property is set.
        /// </summary>
        internal bool IsSetKmsKeyProviderUri() => this.KmsKeyProviderUri != null;

        /// <summary>
        /// Gets and sets the property NameNodes. 
        /// <para>
        /// The NameNode that manages the HDFS namespace. The NameNode performs operations such
        /// as opening, closing, and renaming files and directories. The NameNode contains the
        /// information to map blocks of data to the DataNodes.
        /// </para>
        ///  
        /// <para>
        /// The number of NameNodes you can specify depends on the task mode:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Enhanced mode</b> – You can specify multiple NameNodes for HDFS High Availability
        /// (HA) configurations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Basic mode</b> – You can specify only one NameNode.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<HdfsNameNode> NameNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<HdfsNameNode>() : null;

        /// <summary>
        /// Checks to see if the NameNodes property is set.
        /// </summary>
        internal bool IsSetNameNodes() => this.NameNodes != null && (this.NameNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QopConfiguration. 
        /// <para>
        /// The Quality of Protection (QOP) configuration specifies the Remote Procedure Call
        /// (RPC) and data transfer protection settings configured on the Hadoop Distributed File
        /// System (HDFS) cluster. If <c>QopConfiguration</c> isn't specified, <c>RpcProtection</c>
        /// and <c>DataTransferProtection</c> default to <c>PRIVACY</c>. If you set <c>RpcProtection</c>
        /// or <c>DataTransferProtection</c>, the other parameter assumes the same value. 
        /// </para>
        /// </summary>
        public QopConfiguration QopConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QopConfiguration property is set.
        /// </summary>
        internal bool IsSetQopConfiguration() => this.QopConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReplicationFactor. 
        /// <para>
        /// The number of DataNodes to replicate the data to when writing to the HDFS cluster.
        /// By default, data is replicated to three DataNodes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationFactor property is set.
        /// </summary>
        internal bool IsSetReplicationFactor() => this.ReplicationFactor.HasValue;

        /// <summary>
        /// Gets and sets the property SimpleUser. 
        /// <para>
        /// The user name used to identify the client on the host operating system. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>SIMPLE</c> is specified for <c>AuthenticationType</c>, this parameter is required.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SimpleUser { get; set; }

        /// <summary>
        /// Checks to see if the SimpleUser property is set.
        /// </summary>
        internal bool IsSetSimpleUser() => this.SimpleUser != null;

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the HDFS cluster. This subdirectory is used to read data from or
        /// write data to the HDFS cluster. If the subdirectory isn't specified, it will default
        /// to <c>/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag that you want to add to the location. The
        /// value can be an empty string. We recommend using tags to name your resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TagListEntry> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
