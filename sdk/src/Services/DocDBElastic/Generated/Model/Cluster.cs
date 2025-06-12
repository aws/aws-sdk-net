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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Returns information about a specific elastic cluster.
    /// </summary>
    public partial class Cluster
    {
        private string _adminUserName;
        private Auth _authType;
        private int? _backupRetentionPeriod;
        private string _clusterArn;
        private string _clusterEndpoint;
        private string _clusterName;
        private string _createTime;
        private string _kmsKeyId;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private int? _shardCapacity;
        private int? _shardCount;
        private int? _shardInstanceCount;
        private List<Shard> _shards = AWSConfigs.InitializeCollections ? new List<Shard>() : null;
        private Status _status;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdminUserName. 
        /// <para>
        /// The name of the elastic cluster administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdminUserName
        {
            get { return this._adminUserName; }
            set { this._adminUserName = value; }
        }

        // Check to see if AdminUserName property is set
        internal bool IsSetAdminUserName()
        {
            return this._adminUserName != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authentication type for the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Auth AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automatic snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod; }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN identifier of the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterEndpoint. 
        /// <para>
        /// The URL used to connect to the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterEndpoint
        {
            get { return this._clusterEndpoint; }
            set { this._clusterEndpoint = value; }
        }

        // Check to see if ClusterEndpoint property is set
        internal bool IsSetClusterEndpoint()
        {
            return this._clusterEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the elastic cluster was created in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier to use to encrypt the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, as determined by <c>backupRetentionPeriod</c>.
        /// </para>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        ///  <i>Format</i>: <c>ddd:hh24:mi-ddd:hh24:mi</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property ShardCapacity. 
        /// <para>
        /// The number of vCPUs assigned to each elastic cluster shard. Maximum is 64. Allowed
        /// values are 2, 4, 8, 16, 32, 64.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ShardCapacity
        {
            get { return this._shardCapacity; }
            set { this._shardCapacity = value; }
        }

        // Check to see if ShardCapacity property is set
        internal bool IsSetShardCapacity()
        {
            return this._shardCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShardCount. 
        /// <para>
        /// The number of shards assigned to the elastic cluster. Maximum is 32.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ShardCount
        {
            get { return this._shardCount; }
            set { this._shardCount = value; }
        }

        // Check to see if ShardCount property is set
        internal bool IsSetShardCount()
        {
            return this._shardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShardInstanceCount. 
        /// <para>
        /// The number of replica instances applying to all shards in the cluster. A <c>shardInstanceCount</c>
        /// value of 1 means there is one writer instance, and any additional instances are replicas
        /// that can be used for reads and to improve availability.
        /// </para>
        /// </summary>
        public int? ShardInstanceCount
        {
            get { return this._shardInstanceCount; }
            set { this._shardInstanceCount = value; }
        }

        // Check to see if ShardInstanceCount property is set
        internal bool IsSetShardInstanceCount()
        {
            return this._shardInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// The total number of shards in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Shard> Shards
        {
            get { return this._shards; }
            set { this._shards = value; }
        }

        // Check to see if Shards property is set
        internal bool IsSetShards()
        {
            return this._shards != null && (this._shards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The Amazon EC2 subnet IDs for the elastic cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups associated with thie elastic cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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