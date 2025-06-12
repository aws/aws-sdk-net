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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a new Amazon DocumentDB elastic cluster and returns its cluster structure.
    /// </summary>
    public partial class CreateClusterRequest : AmazonDocDBElasticRequest
    {
        private string _adminUserName;
        private string _adminUserPassword;
        private Auth _authType;
        private int? _backupRetentionPeriod;
        private string _clientToken;
        private string _clusterName;
        private string _kmsKeyId;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private int? _shardCapacity;
        private int? _shardCount;
        private int? _shardInstanceCount;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdminUserName. 
        /// <para>
        /// The name of the Amazon DocumentDB elastic clusters administrator.
        /// </para>
        ///  
        /// <para>
        ///  <i>Constraints</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be from 1 to 63 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property AdminUserPassword. 
        /// <para>
        /// The password for the Amazon DocumentDB elastic clusters administrator. The password
        /// can contain any printable ASCII characters.
        /// </para>
        ///  
        /// <para>
        ///  <i>Constraints</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 8 to 100 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot contain a forward slash (/), double quote ("), or the "at" symbol (@).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string AdminUserPassword
        {
            get { return this._adminUserPassword; }
            set { this._adminUserPassword = value; }
        }

        // Check to see if AdminUserPassword property is set
        internal bool IsSetAdminUserPassword()
        {
            return this._adminUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authentication type used to determine where to fetch the password used for accessing
        /// the elastic cluster. Valid types are <c>PLAIN_TEXT</c> or <c>SECRET_ARN</c>.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for the elastic cluster.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the new elastic cluster. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        ///  <i>Constraints</i>:
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
        /// <para>
        ///  <i>Example</i>: <c>my-cluster</c> 
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier to use to encrypt the new elastic cluster.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are creating a cluster using the same Amazon account that owns this KMS encryption
        /// key, you can use the KMS key alias instead of the ARN as the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// If an encryption key is not specified, Amazon DocumentDB uses the default encryption
        /// key that KMS creates for your account. Your account has a different default encryption
        /// key for each Amazon Region.
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, as determined by the <c>backupRetentionPeriod</c>.
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
        ///  
        /// <para>
        ///  <i>Default</i>: a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week.
        /// </para>
        ///  
        /// <para>
        ///  <i>Valid days</i>: Mon, Tue, Wed, Thu, Fri, Sat, Sun
        /// </para>
        ///  
        /// <para>
        ///  <i>Constraints</i>: Minimum 30-minute window.
        /// </para>
        /// </summary>
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
        /// The number of replica instances applying to all shards in the elastic cluster. A <c>shardInstanceCount</c>
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The Amazon EC2 subnet IDs for the new elastic cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the new elastic cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with the new elastic cluster.
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