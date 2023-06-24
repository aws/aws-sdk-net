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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a cluster. All nodes in the cluster run the same protocol-compliant engine
    /// software.
    /// </summary>
    public partial class CreateClusterRequest : AmazonMemoryDBRequest
    {
        private string _aclName;
        private bool? _autoMinorVersionUpgrade;
        private string _clusterName;
        private bool? _dataTiering;
        private string _description;
        private string _engineVersion;
        private string _kmsKeyId;
        private string _maintenanceWindow;
        private string _nodeType;
        private int? _numReplicasPerShard;
        private int? _numShards;
        private string _parameterGroupName;
        private int? _port;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _snapshotArns = new List<string>();
        private string _snapshotName;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private string _snsTopicArn;
        private string _subnetGroupName;
        private List<Tag> _tags = new List<Tag>();
        private bool? _tlsEnabled;

        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The name of the Access Control List to associate with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ACLName
        {
            get { return this._aclName; }
            set { this._aclName = value; }
        }

        // Check to see if ACLName property is set
        internal bool IsSetACLName()
        {
            return this._aclName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// When set to true, the cluster will automatically receive minor engine version upgrades
        /// after launch.
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster. This value must be unique as it also serves as the cluster
        /// identifier.
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
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for clusters using the r6gd node
        /// type. This parameter must be set when using r6gd nodes. For more information, see
        /// <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public bool DataTiering
        {
            get { return this._dataTiering.GetValueOrDefault(); }
            set { this._dataTiering = value; }
        }

        // Check to see if DataTiering property is set
        internal bool IsSetDataTiering()
        {
            return this._dataTiering.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the cluster.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the Redis engine to be used for the cluster.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the cluster.
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
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>ddd</code> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>sun</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tue</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>wed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>thu</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fri</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sat</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>sun:23:00-mon:01:30</code> 
        /// </para>
        /// </summary>
        public string MaintenanceWindow
        {
            get { return this._maintenanceWindow; }
            set { this._maintenanceWindow = value; }
        }

        // Check to see if MaintenanceWindow property is set
        internal bool IsSetMaintenanceWindow()
        {
            return this._maintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The compute and memory capacity of the nodes in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property NumReplicasPerShard. 
        /// <para>
        /// The number of replicas to apply to each shard. The default value is 1. The maximum
        /// is 5. 
        /// </para>
        /// </summary>
        public int NumReplicasPerShard
        {
            get { return this._numReplicasPerShard.GetValueOrDefault(); }
            set { this._numReplicasPerShard = value; }
        }

        // Check to see if NumReplicasPerShard property is set
        internal bool IsSetNumReplicasPerShard()
        {
            return this._numReplicasPerShard.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumShards. 
        /// <para>
        /// The number of shards the cluster will contain. The default value is 1. 
        /// </para>
        /// </summary>
        public int NumShards
        {
            get { return this._numShards.GetValueOrDefault(); }
            set { this._numShards = value; }
        }

        // Check to see if NumShards property is set
        internal bool IsSetNumShards()
        {
            return this._numShards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group associated with the cluster.
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each of the nodes accepts connections.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group names to associate with this cluster.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotArns. 
        /// <para>
        /// A list of Amazon Resource Names (ARN) that uniquely identify the RDB snapshot files
        /// stored in Amazon S3. The snapshot files are used to populate the new cluster. The
        /// Amazon S3 object name in the ARN cannot contain any commas.
        /// </para>
        /// </summary>
        public List<string> SnapshotArns
        {
            get { return this._snapshotArns; }
            set { this._snapshotArns = value; }
        }

        // Check to see if SnapshotArns property is set
        internal bool IsSetSnapshotArns()
        {
            return this._snapshotArns != null && this._snapshotArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of a snapshot from which to restore data into the new cluster. The snapshot
        /// status changes to restoring while the new cluster is being created.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which MemoryDB retains automatic snapshots before deleting
        /// them. For example, if you set SnapshotRetentionLimit to 5, a snapshot that was taken
        /// today is retained for 5 days before being deleted.
        /// </para>
        /// </summary>
        public int SnapshotRetentionLimit
        {
            get { return this._snapshotRetentionLimit.GetValueOrDefault(); }
            set { this._snapshotRetentionLimit = value; }
        }

        // Check to see if SnapshotRetentionLimit property is set
        internal bool IsSetSnapshotRetentionLimit()
        {
            return this._snapshotRetentionLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which MemoryDB begins taking a daily snapshot
        /// of your shard.
        /// </para>
        ///  
        /// <para>
        ///  Example: 05:00-09:00
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify this parameter, MemoryDB automatically chooses an appropriate
        /// time range.
        /// </para>
        /// </summary>
        public string SnapshotWindow
        {
            get { return this._snapshotWindow; }
            set { this._snapshotWindow = value; }
        }

        // Check to see if SnapshotWindow property is set
        internal bool IsSetSnapshotWindow()
        {
            return this._snapshotWindow != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic
        /// to which notifications are sent.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group to be used for the cluster.
        /// </para>
        /// </summary>
        public string SubnetGroupName
        {
            get { return this._subnetGroupName; }
            set { this._subnetGroupName = value; }
        }

        // Check to see if SubnetGroupName property is set
        internal bool IsSetSubnetGroupName()
        {
            return this._subnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. Tags are comma-separated key,value pairs
        /// (e.g. Key=myKey, Value=myKeyValue. You can include multiple tags as shown following:
        /// Key=myKey, Value=myKeyValue Key=mySecondKey, Value=mySecondKeyValue.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// A flag to enable in-transit encryption on the cluster.
        /// </para>
        /// </summary>
        public bool TLSEnabled
        {
            get { return this._tlsEnabled.GetValueOrDefault(); }
            set { this._tlsEnabled = value; }
        }

        // Check to see if TLSEnabled property is set
        internal bool IsSetTLSEnabled()
        {
            return this._tlsEnabled.HasValue; 
        }

    }
}