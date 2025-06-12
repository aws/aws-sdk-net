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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Amazon RDS DB cluster.
    /// </summary>
    public partial class AwsRdsDbClusterDetails
    {
        private string _activityStreamStatus;
        private int? _allocatedStorage;
        private List<AwsRdsDbClusterAssociatedRole> _associatedRoles = AWSConfigs.InitializeCollections ? new List<AwsRdsDbClusterAssociatedRole>() : null;
        private bool? _autoMinorVersionUpgrade;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _backupRetentionPeriod;
        private string _clusterCreateTime;
        private bool? _copyTagsToSnapshot;
        private bool? _crossAccountClone;
        private List<string> _customEndpoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _databaseName;
        private string _dbClusterIdentifier;
        private List<AwsRdsDbClusterMember> _dbClusterMembers = AWSConfigs.InitializeCollections ? new List<AwsRdsDbClusterMember>() : null;
        private List<AwsRdsDbClusterOptionGroupMembership> _dbClusterOptionGroupMemberships = AWSConfigs.InitializeCollections ? new List<AwsRdsDbClusterOptionGroupMembership>() : null;
        private string _dbClusterParameterGroup;
        private string _dbClusterResourceId;
        private string _dbSubnetGroup;
        private bool? _deletionProtection;
        private List<AwsRdsDbDomainMembership> _domainMemberships = AWSConfigs.InitializeCollections ? new List<AwsRdsDbDomainMembership>() : null;
        private List<string> _enabledCloudWatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _endpoint;
        private string _engine;
        private string _engineMode;
        private string _engineVersion;
        private string _hostedZoneId;
        private bool? _httpEndpointEnabled;
        private bool? _iamDatabaseAuthenticationEnabled;
        private string _kmsKeyId;
        private string _masterUsername;
        private bool? _multiAz;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _readerEndpoint;
        private List<string> _readReplicaIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _status;
        private bool? _storageEncrypted;
        private List<AwsRdsDbInstanceVpcSecurityGroup> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<AwsRdsDbInstanceVpcSecurityGroup>() : null;

        /// <summary>
        /// Gets and sets the property ActivityStreamStatus. 
        /// <para>
        /// The status of the database activity stream. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>started</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>starting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stopped</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stopping</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ActivityStreamStatus
        {
            get { return this._activityStreamStatus; }
            set { this._activityStreamStatus = value; }
        }

        // Check to see if ActivityStreamStatus property is set
        internal bool IsSetActivityStreamStatus()
        {
            return this._activityStreamStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// For all database engines except Aurora, specifies the allocated storage size in gibibytes
        /// (GiB).
        /// </para>
        /// </summary>
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociatedRoles. 
        /// <para>
        /// A list of the IAM roles that are associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbClusterAssociatedRole> AssociatedRoles
        {
            get { return this._associatedRoles; }
            set { this._associatedRoles = value; }
        }

        // Check to see if AssociatedRoles property is set
        internal bool IsSetAssociatedRoles()
        {
            return this._associatedRoles != null && (this._associatedRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  Indicates if minor version upgrades are automatically applied to the cluster.
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones (AZs) where instances in the DB cluster can be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained.
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
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// Indicates when the DB cluster was created, in Universal Coordinated Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ClusterCreateTime
        {
            get { return this._clusterCreateTime; }
            set { this._clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Whether tags are copied from the DB cluster to snapshots of the DB cluster.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot; }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrossAccountClone. 
        /// <para>
        /// Whether the DB cluster is a clone of a DB cluster owned by a different Amazon Web
        /// Services account.
        /// </para>
        /// </summary>
        public bool? CrossAccountClone
        {
            get { return this._crossAccountClone; }
            set { this._crossAccountClone = value; }
        }

        // Check to see if CrossAccountClone property is set
        internal bool IsSetCrossAccountClone()
        {
            return this._crossAccountClone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomEndpoints. 
        /// <para>
        /// A list of custom endpoints for the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomEndpoints
        {
            get { return this._customEndpoints; }
            set { this._customEndpoints = value; }
        }

        // Check to see if CustomEndpoints property is set
        internal bool IsSetCustomEndpoints()
        {
            return this._customEndpoints != null && (this._customEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier that the user assigned to the cluster. This identifier is
        /// the unique key that identifies a DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DbClusterIdentifier property is set
        internal bool IsSetDbClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterMembers. 
        /// <para>
        /// The list of instances that make up the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbClusterMember> DbClusterMembers
        {
            get { return this._dbClusterMembers; }
            set { this._dbClusterMembers = value; }
        }

        // Check to see if DbClusterMembers property is set
        internal bool IsSetDbClusterMembers()
        {
            return this._dbClusterMembers != null && (this._dbClusterMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DbClusterOptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbClusterOptionGroupMembership> DbClusterOptionGroupMemberships
        {
            get { return this._dbClusterOptionGroupMemberships; }
            set { this._dbClusterOptionGroupMemberships = value; }
        }

        // Check to see if DbClusterOptionGroupMemberships property is set
        internal bool IsSetDbClusterOptionGroupMemberships()
        {
            return this._dbClusterOptionGroupMemberships != null && (this._dbClusterOptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DbClusterParameterGroup. 
        /// <para>
        /// The name of the DB cluster parameter group for the DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterParameterGroup
        {
            get { return this._dbClusterParameterGroup; }
            set { this._dbClusterParameterGroup = value; }
        }

        // Check to see if DbClusterParameterGroup property is set
        internal bool IsSetDbClusterParameterGroup()
        {
            return this._dbClusterParameterGroup != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The identifier of the DB cluster. The identifier must be unique within each Amazon
        /// Web Services Region and is immutable.
        /// </para>
        /// </summary>
        public string DbClusterResourceId
        {
            get { return this._dbClusterResourceId; }
            set { this._dbClusterResourceId = value; }
        }

        // Check to see if DbClusterResourceId property is set
        internal bool IsSetDbClusterResourceId()
        {
            return this._dbClusterResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DbSubnetGroup. 
        /// <para>
        /// The subnet group that is associated with the DB cluster, including the name, description,
        /// and subnets in the subnet group.
        /// </para>
        /// </summary>
        public string DbSubnetGroup
        {
            get { return this._dbSubnetGroup; }
            set { this._dbSubnetGroup = value; }
        }

        // Check to see if DbSubnetGroup property is set
        internal bool IsSetDbSubnetGroup()
        {
            return this._dbSubnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Whether the DB cluster has deletion protection enabled.
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
        /// Gets and sets the property DomainMemberships. 
        /// <para>
        /// The Active Directory domain membership records that are associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbDomainMembership> DomainMemberships
        {
            get { return this._domainMemberships; }
            set { this._domainMemberships = value; }
        }

        // Check to see if DomainMemberships property is set
        internal bool IsSetDomainMemberships()
        {
            return this._domainMemberships != null && (this._domainMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnabledCloudWatchLogsExports. 
        /// <para>
        /// A list of log types that this DB cluster is configured to export to CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledCloudWatchLogsExports
        {
            get { return this._enabledCloudWatchLogsExports; }
            set { this._enabledCloudWatchLogsExports = value; }
        }

        // Check to see if EnabledCloudWatchLogsExports property is set
        internal bool IsSetEnabledCloudWatchLogsExports()
        {
            return this._enabledCloudWatchLogsExports != null && (this._enabledCloudWatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the primary instance of the DB cluster.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine to use for this DB cluster. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aurora</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The database engine mode of the DB cluster.Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>global</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>multimaster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>parallelquery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>serverless</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EngineMode
        {
            get { return this._engineMode; }
            set { this._engineMode = value; }
        }

        // Check to see if EngineMode property is set
        internal bool IsSetEngineMode()
        {
            return this._engineMode != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to use.
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
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// Specifies the identifier that Amazon Route 53 assigns when you create a hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property HttpEndpointEnabled. 
        /// <para>
        /// Whether the HTTP endpoint for an Aurora Serverless DB cluster is enabled.
        /// </para>
        /// </summary>
        public bool? HttpEndpointEnabled
        {
            get { return this._httpEndpointEnabled; }
            set { this._httpEndpointEnabled = value; }
        }

        // Check to see if HttpEndpointEnabled property is set
        internal bool IsSetHttpEndpointEnabled()
        {
            return this._httpEndpointEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamDatabaseAuthenticationEnabled. 
        /// <para>
        /// Whether the mapping of IAM accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IamDatabaseAuthenticationEnabled
        {
            get { return this._iamDatabaseAuthenticationEnabled; }
            set { this._iamDatabaseAuthenticationEnabled = value; }
        }

        // Check to see if IamDatabaseAuthenticationEnabled property is set
        internal bool IsSetIamDatabaseAuthenticationEnabled()
        {
            return this._iamDatabaseAuthenticationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS master key that is used to encrypt the database instances in the
        /// DB cluster.
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
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The name of the master user for the DB cluster.
        /// </para>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// Whether the DB cluster has instances in multiple Availability Zones.
        /// </para>
        /// </summary>
        public bool? MultiAz
        {
            get { return this._multiAz; }
            set { this._multiAz = value; }
        }

        // Check to see if MultiAz property is set
        internal bool IsSetMultiAz()
        {
            return this._multiAz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the DB instances in the DB cluster accept connections.
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The range of time each day when automated backups are created, if automated backups
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// Uses the format <c>HH:MM-HH:MM</c>. For example, <c>04:52-05:22</c>.
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
        /// Uses the format <c>&lt;day&gt;:HH:MM-&lt;day&gt;:HH:MM</c>.
        /// </para>
        ///  
        /// <para>
        /// For the day values, use <c>mon</c>|<c>tue</c>|<c>wed</c>|<c>thu</c>|<c>fri</c>|<c>sat</c>|<c>sun</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>sun:09:32-sun:10:02</c>.
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
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The reader endpoint for the DB cluster.
        /// </para>
        /// </summary>
        public string ReaderEndpoint
        {
            get { return this._readerEndpoint; }
            set { this._readerEndpoint = value; }
        }

        // Check to see if ReaderEndpoint property is set
        internal bool IsSetReaderEndpoint()
        {
            return this._readerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaIdentifiers. 
        /// <para>
        /// The identifiers of the read replicas that are associated with this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaIdentifiers
        {
            get { return this._readReplicaIdentifiers; }
            set { this._readReplicaIdentifiers = value; }
        }

        // Check to see if ReadReplicaIdentifiers property is set
        internal bool IsSetReadReplicaIdentifiers()
        {
            return this._readReplicaIdentifiers != null && (this._readReplicaIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this DB cluster.
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
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted
        {
            get { return this._storageEncrypted; }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// A list of VPC security groups that the DB cluster belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbInstanceVpcSecurityGroup> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}