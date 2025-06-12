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
    /// Contains all of the attributes of a specific cluster.
    /// </summary>
    public partial class Cluster
    {
        private string _aclName;
        private string _arn;
        private bool? _autoMinorVersionUpgrade;
        private AZStatus _availabilityMode;
        private Endpoint _clusterEndpoint;
        private DataTieringStatus _dataTiering;
        private string _description;
        private string _engine;
        private string _enginePatchVersion;
        private string _engineVersion;
        private IpDiscovery _ipDiscovery;
        private string _kmsKeyId;
        private string _maintenanceWindow;
        private string _multiRegionClusterName;
        private string _name;
        private NetworkType _networkType;
        private string _nodeType;
        private int? _numberOfShards;
        private string _parameterGroupName;
        private string _parameterGroupStatus;
        private ClusterPendingUpdates _pendingUpdates;
        private List<SecurityGroupMembership> _securityGroups = AWSConfigs.InitializeCollections ? new List<SecurityGroupMembership>() : null;
        private List<Shard> _shards = AWSConfigs.InitializeCollections ? new List<Shard>() : null;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private string _snsTopicArn;
        private string _snsTopicStatus;
        private string _status;
        private string _subnetGroupName;
        private bool? _tlsEnabled;

        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The name of the Access Control List associated with this cluster.
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
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// When set to true, the cluster will automatically receive minor engine version upgrades
        /// after launch.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityMode. 
        /// <para>
        /// Indicates if the cluster has a Multi-AZ configuration (multiaz) or not (singleaz).
        /// </para>
        /// </summary>
        public AZStatus AvailabilityMode
        {
            get { return this._availabilityMode; }
            set { this._availabilityMode = value; }
        }

        // Check to see if AvailabilityMode property is set
        internal bool IsSetAvailabilityMode()
        {
            return this._availabilityMode != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterEndpoint. 
        /// <para>
        /// The cluster's configuration endpoint
        /// </para>
        /// </summary>
        public Endpoint ClusterEndpoint
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
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for clusters using the r6gd node
        /// type. This parameter must be set when using r6gd nodes. For more information, see
        /// <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public DataTieringStatus DataTiering
        {
            get { return this._dataTiering; }
            set { this._dataTiering = value; }
        }

        // Check to see if DataTiering property is set
        internal bool IsSetDataTiering()
        {
            return this._dataTiering != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the cluster
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
        /// The name of the engine used by the cluster.
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
        /// Gets and sets the property EnginePatchVersion. 
        /// <para>
        /// The Redis OSS engine patch version used by the cluster
        /// </para>
        /// </summary>
        public string EnginePatchVersion
        {
            get { return this._enginePatchVersion; }
            set { this._enginePatchVersion = value; }
        }

        // Check to see if EnginePatchVersion property is set
        internal bool IsSetEnginePatchVersion()
        {
            return this._enginePatchVersion != null;
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
        /// Gets and sets the property IpDiscovery. 
        /// <para>
        /// The mechanism that the cluster uses to discover IP addresses. Returns 'ipv4' when
        /// DNS endpoints resolve to IPv4 addresses, or 'ipv6' when DNS endpoints resolve to IPv6
        /// addresses.
        /// </para>
        /// </summary>
        public IpDiscovery IpDiscovery
        {
            get { return this._ipDiscovery; }
            set { this._ipDiscovery = value; }
        }

        // Check to see if IpDiscovery property is set
        internal bool IsSetIpDiscovery()
        {
            return this._ipDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the cluster
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
        /// The name of the multi-Region cluster that this cluster belongs to.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-supplied name of the cluster. This identifier is a unique key that identifies
        /// a cluster.
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The IP address type for the cluster. Returns 'ipv4' for IPv4 only, 'ipv6' for IPv6
        /// only, or 'dual-stack' if the cluster supports both IPv4 and IPv6 addressing.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The cluster's node type
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
        /// Gets and sets the property NumberOfShards. 
        /// <para>
        /// The number of shards in the cluster
        /// </para>
        /// </summary>
        public int? NumberOfShards
        {
            get { return this._numberOfShards; }
            set { this._numberOfShards = value; }
        }

        // Check to see if NumberOfShards property is set
        internal bool IsSetNumberOfShards()
        {
            return this._numberOfShards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group used by the cluster
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
        /// Gets and sets the property ParameterGroupStatus. 
        /// <para>
        /// The status of the parameter group used by the cluster, for example 'active' or 'applying'.
        /// </para>
        /// </summary>
        public string ParameterGroupStatus
        {
            get { return this._parameterGroupStatus; }
            set { this._parameterGroupStatus = value; }
        }

        // Check to see if ParameterGroupStatus property is set
        internal bool IsSetParameterGroupStatus()
        {
            return this._parameterGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PendingUpdates. 
        /// <para>
        /// A group of settings that are currently being applied.
        /// </para>
        /// </summary>
        public ClusterPendingUpdates PendingUpdates
        {
            get { return this._pendingUpdates; }
            set { this._pendingUpdates = value; }
        }

        // Check to see if PendingUpdates property is set
        internal bool IsSetPendingUpdates()
        {
            return this._pendingUpdates != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of security groups used by the cluster
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// A list of shards that are members of the cluster.
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
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which MemoryDB retains automatic snapshots before deleting
        /// them. For example, if you set SnapshotRetentionLimit to 5, a snapshot that was taken
        /// today is retained for 5 days before being deleted.
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
        /// The daily time range (in UTC) during which MemoryDB begins taking a daily snapshot
        /// of your shard. Example: 05:00-09:00 If you do not specify this parameter, MemoryDB
        /// automatically chooses an appropriate time range.
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
        /// The Amazon Resource Name (ARN) of the SNS notification topic
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
        /// The SNS topic must be in Active status to receive notifications
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. For example, Available, Updating, Creating.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// A flag to indicate if In-transit encryption is enabled
        /// </para>
        /// </summary>
        public bool? TLSEnabled
        {
            get { return this._tlsEnabled; }
            set { this._tlsEnabled = value; }
        }

        // Check to see if TLSEnabled property is set
        internal bool IsSetTLSEnabled()
        {
            return this._tlsEnabled.HasValue; 
        }

    }
}