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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBClusterToPointInTime operation.
    /// Restores a cluster to an arbitrary point in time. Users can restore to any point in
    /// time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c> days.
    /// The target cluster is created from the source cluster with the same configuration
    /// as the original cluster, except that the new cluster is created with the default security
    /// group.
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequest : AmazonDocDBRequest
    {
        private string _dbClusterIdentifier;
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private List<string> _enableCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyId;
        private int? _port;
        private DateTime? _restoreToTime;
        private string _restoreType;
        private ServerlessV2ScalingConfiguration _serverlessV2ScalingConfiguration;
        private string _sourceDBClusterIdentifier;
        private string _storageType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _useLatestRestorableTime;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The name of the new cluster to be created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The subnet group name to use for the new cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If provided, must match the name of an existing <c>DBSubnetGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>mySubnetgroup</c> 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether this cluster can be deleted. If <c>DeletionProtection</c> is enabled,
        /// the cluster cannot be deleted unless it is modified and <c>DeletionProtection</c>
        /// is disabled. <c>DeletionProtection</c> protects clusters from being accidentally deleted.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// A list of log types that must be enabled for exporting to Amazon CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableCloudwatchLogsExports
        {
            get { return this._enableCloudwatchLogsExports; }
            set { this._enableCloudwatchLogsExports = value; }
        }

        // Check to see if EnableCloudwatchLogsExports property is set
        internal bool IsSetEnableCloudwatchLogsExports()
        {
            return this._enableCloudwatchLogsExports != null && (this._enableCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier to use when restoring an encrypted cluster from an encrypted
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are restoring a cluster with the same Amazon Web Services account that owns
        /// the KMS encryption key used to encrypt the new cluster, then you can use the KMS key
        /// alias instead of the ARN for the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// You can restore to a new cluster and encrypt the new cluster with an KMS key that
        /// is different from the KMS key used to encrypt the source cluster. The new DB cluster
        /// is encrypted with the KMS key identified by the <c>KmsKeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for the <c>KmsKeyId</c> parameter, then the following
        /// occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the cluster is encrypted, then the restored cluster is encrypted using the KMS
        /// key that was used to encrypt the source cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the cluster is not encrypted, then the restored cluster is not encrypted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBClusterIdentifier</c> refers to a cluster that is not encrypted, then the
        /// restore request is rejected.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the new cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a value from <c>1150</c> to <c>65535</c>. 
        /// </para>
        ///  
        /// <para>
        /// Default: The default port for the engine.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreToTime. 
        /// <para>
        /// The date and time to restore the cluster to.
        /// </para>
        ///  
        /// <para>
        /// Valid values: A time in Universal Coordinated Time (UTC) format.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be before the latest restorable time for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified if the <c>UseLatestRestorableTime</c> parameter is not provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if the <c>UseLatestRestorableTime</c> parameter is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if the <c>RestoreType</c> parameter is <c>copy-on-write</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2015-03-07T23:45:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? RestoreToTime
        {
            get { return this._restoreToTime; }
            set { this._restoreToTime = value; }
        }

        // Check to see if RestoreToTime property is set
        internal bool IsSetRestoreToTime()
        {
            return this._restoreToTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreType. 
        /// <para>
        /// The type of restore to be performed. You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>full-copy</c> - The new DB cluster is restored as a full copy of the source DB
        /// cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>copy-on-write</c> - The new DB cluster is restored as a clone of the source DB
        /// cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraints: You can't specify <c>copy-on-write</c> if the engine version of the source
        /// DB cluster is earlier than 1.11.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a <c>RestoreType</c> value, then the new DB cluster is restored
        /// as a full copy of the source DB cluster.
        /// </para>
        /// </summary>
        public string RestoreType
        {
            get { return this._restoreType; }
            set { this._restoreType = value; }
        }

        // Check to see if RestoreType property is set
        internal bool IsSetRestoreType()
        {
            return this._restoreType != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration. 
        /// <para>
        /// Contains the scaling configuration of an Amazon DocumentDB Serverless cluster.
        /// </para>
        /// </summary>
        public ServerlessV2ScalingConfiguration ServerlessV2ScalingConfiguration
        {
            get { return this._serverlessV2ScalingConfiguration; }
            set { this._serverlessV2ScalingConfiguration = value; }
        }

        // Check to see if ServerlessV2ScalingConfiguration property is set
        internal bool IsSetServerlessV2ScalingConfiguration()
        {
            return this._serverlessV2ScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the source cluster from which to restore.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <c>DBCluster</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBClusterIdentifier
        {
            get { return this._sourceDBClusterIdentifier; }
            set { this._sourceDBClusterIdentifier = value; }
        }

        // Check to see if SourceDBClusterIdentifier property is set
        internal bool IsSetSourceDBClusterIdentifier()
        {
            return this._sourceDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type to associate with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information on storage types for Amazon DocumentDB clusters, see Cluster storage
        /// configurations in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for storage type - <c>standard | iopt1</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>standard </c> 
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the restored cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        /// A value that is set to <c>true</c> to restore the cluster to the latest restorable
        /// backup time, and <c>false</c> otherwise. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if the <c>RestoreToTime</c> parameter is provided.
        /// </para>
        /// </summary>
        public bool? UseLatestRestorableTime
        {
            get { return this._useLatestRestorableTime; }
            set { this._useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this._useLatestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security groups that the new cluster belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}