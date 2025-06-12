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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// A list of cluster configuration options.
    /// </summary>
    public partial class ClusterConfiguration
    {
        private string _description;
        private string _engine;
        private string _engineVersion;
        private string _maintenanceWindow;
        private string _multiRegionClusterName;
        private string _multiRegionParameterGroupName;
        private string _name;
        private string _nodeType;
        private int? _numShards;
        private string _parameterGroupName;
        private int? _port;
        private List<ShardDetail> _shards = AWSConfigs.InitializeCollections ? new List<ShardDetail>() : null;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private string _subnetGroupName;
        private string _topicArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster configuration
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine used by the cluster configuration.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The Redis OSS engine version used by the cluster
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
        /// The specified maintenance window for the cluster
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
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name for the multi-Region cluster associated with the cluster configuration.
        /// </para>
        /// </summary>
        public string MultiRegionClusterName
        {
            get { return this._multiRegionClusterName; }
            set { this._multiRegionClusterName = value; }
        }

        // Check to see if MultiRegionClusterName property is set
        internal bool IsSetMultiRegionClusterName()
        {
            return this._multiRegionClusterName != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The name of the multi-Region parameter group associated with the cluster configuration.
        /// </para>
        /// </summary>
        public string MultiRegionParameterGroupName
        {
            get { return this._multiRegionParameterGroupName; }
            set { this._multiRegionParameterGroupName = value; }
        }

        // Check to see if MultiRegionParameterGroupName property is set
        internal bool IsSetMultiRegionParameterGroupName()
        {
            return this._multiRegionParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type used for the cluster
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
        /// Gets and sets the property NumShards. 
        /// <para>
        /// The number of shards in the cluster
        /// </para>
        /// </summary>
        public int? NumShards
        {
            get { return this._numShards; }
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
        /// The name of parameter group used by the cluster
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
        /// The port used by the cluster
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
        /// Gets and sets the property Shards. 
        /// <para>
        /// The list of shards in the cluster
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ShardDetail> Shards
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
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The snapshot retention limit set by the cluster
        /// </para>
        /// </summary>
        public int? SnapshotRetentionLimit
        {
            get { return this._snapshotRetentionLimit; }
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
        /// The snapshot window set by the cluster
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
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group used by the cluster
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
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS notification topic for the cluster
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC the cluster belongs to
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}