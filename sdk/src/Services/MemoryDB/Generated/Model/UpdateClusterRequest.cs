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
    /// Container for the parameters to the UpdateCluster operation.
    /// Modifies the settings for a cluster. You can use this operation to change one or more
    /// cluster configuration settings by specifying the settings and the new values.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonMemoryDBRequest
    {
        private string _aclName;
        private string _clusterName;
        private string _description;
        private string _engineVersion;
        private string _maintenanceWindow;
        private string _nodeType;
        private string _parameterGroupName;
        private ReplicaConfigurationRequest _replicaConfiguration;
        private List<string> _securityGroupIds = new List<string>();
        private ShardConfigurationRequest _shardConfiguration;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private string _snsTopicArn;
        private string _snsTopicStatus;

        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The Access Control List that is associated with the cluster
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to update
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster to update
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
        /// The upgraded version of the engine to be run on the nodes. You can upgrade to a newer
        /// engine version, but you cannot downgrade to an earlier engine version. If you want
        /// to use an earlier engine version, you must delete the existing cluster and create
        /// it anew with the earlier engine version.
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
        /// A valid node type that you want to scale this cluster up or down to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group to update
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
        /// Gets and sets the property ReplicaConfiguration. 
        /// <para>
        /// The number of replicas that will reside in each shard
        /// </para>
        /// </summary>
        public ReplicaConfigurationRequest ReplicaConfiguration
        {
            get { return this._replicaConfiguration; }
            set { this._replicaConfiguration = value; }
        }

        // Check to see if ReplicaConfiguration property is set
        internal bool IsSetReplicaConfiguration()
        {
            return this._replicaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The SecurityGroupIds to update
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
        /// Gets and sets the property ShardConfiguration. 
        /// <para>
        /// The number of shards in the cluster
        /// </para>
        /// </summary>
        public ShardConfigurationRequest ShardConfiguration
        {
            get { return this._shardConfiguration; }
            set { this._shardConfiguration = value; }
        }

        // Check to see if ShardConfiguration property is set
        internal bool IsSetShardConfiguration()
        {
            return this._shardConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which MemoryDB retains automatic cluster snapshots before deleting
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
        /// of your cluster.
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
        /// The SNS topic ARN to update
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
        /// Gets and sets the property SnsTopicStatus. 
        /// <para>
        /// The status of the Amazon SNS notification topic. Notifications are sent only if the
        /// status is active.
        /// </para>
        /// </summary>
        public string SnsTopicStatus
        {
            get { return this._snsTopicStatus; }
            set { this._snsTopicStatus = value; }
        }

        // Check to see if SnsTopicStatus property is set
        internal bool IsSetSnsTopicStatus()
        {
            return this._snsTopicStatus != null;
        }

    }
}