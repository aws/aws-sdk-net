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
    /// Container for the parameters to the UpdateLocationHdfs operation.
    /// Modifies the following configuration parameters of the Hadoop Distributed File System
    /// (HDFS) transfer location that you're using with DataSync.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html">Configuring
    /// DataSync transfers with an HDFS cluster</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLocationHdfsRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HdfsAuthenticationType _authenticationType;
        private int? _blockSize;
        private MemoryStream _kerberosKeytab;
        private MemoryStream _kerberosKrb5Conf;
        private string _kerberosPrincipal;
        private string _kmsKeyProviderUri;
        private string _locationArn;
        private List<HdfsNameNode> _nameNodes = AWSConfigs.InitializeCollections ? new List<HdfsNameNode>() : null;
        private QopConfiguration _qopConfiguration;
        private int? _replicationFactor;
        private string _simpleUser;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the DataSync agents that can connect to your HDFS
        /// cluster.
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
        /// The type of authentication used to determine the identity of the user. 
        /// </para>
        /// </summary>
        public HdfsAuthenticationType AuthenticationType
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
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of the data blocks to write into the HDFS cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1048576, Max=1073741824)]
        public int? BlockSize
        {
            get { return this._blockSize; }
            set { this._blockSize = value; }
        }

        // Check to see if BlockSize property is set
        internal bool IsSetBlockSize()
        {
            return this._blockSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KerberosKeytab. 
        /// <para>
        /// The Kerberos key table (keytab) that contains mappings between the defined Kerberos
        /// principal and the encrypted keys. You can load the keytab from a file by providing
        /// the file's address.
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
        /// The <c>krb5.conf</c> file that contains the Kerberos configuration information. You
        /// can load the <c>krb5.conf</c> file by providing the file's address. If you're using
        /// the CLI, it performs the base64 encoding for you. Otherwise, provide the base64-encoded
        /// text.
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
        /// The Kerberos principal with access to the files and folders on the HDFS cluster. 
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
        /// Gets and sets the property KmsKeyProviderUri. 
        /// <para>
        /// The URI of the HDFS cluster's Key Management Server (KMS). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string KmsKeyProviderUri
        {
            get { return this._kmsKeyProviderUri; }
            set { this._kmsKeyProviderUri = value; }
        }

        // Check to see if KmsKeyProviderUri property is set
        internal bool IsSetKmsKeyProviderUri()
        {
            return this._kmsKeyProviderUri != null;
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source HDFS cluster location.
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
        /// Gets and sets the property NameNodes. 
        /// <para>
        /// The NameNode that manages the HDFS namespace. The NameNode performs operations such
        /// as opening, closing, and renaming files and directories. The NameNode contains the
        /// information to map blocks of data to the DataNodes. You can use only one NameNode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<HdfsNameNode> NameNodes
        {
            get { return this._nameNodes; }
            set { this._nameNodes = value; }
        }

        // Check to see if NameNodes property is set
        internal bool IsSetNameNodes()
        {
            return this._nameNodes != null && (this._nameNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QopConfiguration. 
        /// <para>
        /// The Quality of Protection (QOP) configuration specifies the Remote Procedure Call
        /// (RPC) and data transfer privacy settings configured on the Hadoop Distributed File
        /// System (HDFS) cluster. 
        /// </para>
        /// </summary>
        public QopConfiguration QopConfiguration
        {
            get { return this._qopConfiguration; }
            set { this._qopConfiguration = value; }
        }

        // Check to see if QopConfiguration property is set
        internal bool IsSetQopConfiguration()
        {
            return this._qopConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationFactor. 
        /// <para>
        /// The number of DataNodes to replicate the data to when writing to the HDFS cluster.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public int? ReplicationFactor
        {
            get { return this._replicationFactor; }
            set { this._replicationFactor = value; }
        }

        // Check to see if ReplicationFactor property is set
        internal bool IsSetReplicationFactor()
        {
            return this._replicationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SimpleUser. 
        /// <para>
        /// The user name used to identify the client on the host operating system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SimpleUser
        {
            get { return this._simpleUser; }
            set { this._simpleUser = value; }
        }

        // Check to see if SimpleUser property is set
        internal bool IsSetSimpleUser()
        {
            return this._simpleUser != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the HDFS cluster. This subdirectory is used to read data from or
        /// write data to the HDFS cluster.
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

    }
}