/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the following actions: 
    /// 
    ///  <ul> <li> <a>CreateDBCluster</a> </li> <li> <a>DeleteDBCluster</a> </li> <li> <a>FailoverDBCluster</a>
    /// </li> <li> <a>ModifyDBCluster</a> </li> <li> <a>RestoreDBClusterFromSnapshot</a> </li>
    /// </ul> 
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBClusters</a> action.
    /// </para>
    /// </summary>
    public partial class DBCluster
    {
        private int? _allocatedStorage;
        private List<string> _availabilityZones = new List<string>();
        private int? _backupRetentionPeriod;
        private string _characterSetName;
        private string _databaseName;
        private string _dbClusterIdentifier;
        private List<DBClusterMember> _dbClusterMembers = new List<DBClusterMember>();
        private List<DBClusterOptionGroupStatus> _dbClusterOptionGroupMemberships = new List<DBClusterOptionGroupStatus>();
        private string _dbClusterParameterGroup;
        private string _dbClusterResourceId;
        private string _dbSubnetGroup;
        private DateTime? _earliestRestorableTime;
        private string _endpoint;
        private string _engine;
        private string _engineVersion;
        private string _hostedZoneId;
        private string _kmsKeyId;
        private DateTime? _latestRestorableTime;
        private string _masterUsername;
        private string _percentProgress;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _status;
        private bool? _storageEncrypted;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = new List<VpcSecurityGroupMembership>();

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// Specifies the allocated storage size in gigabytes (GB). 
        /// </para>
        /// </summary>
        public int AllocatedStorage
        {
            get { return this._allocatedStorage.GetValueOrDefault(); }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Provides the list of EC2 Availability Zones that instances in the DB cluster can be
        /// created in.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// Specifies the number of days for which automatic DB snapshots are retained. 
        /// </para>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// If present, specifies the name of the character set that this cluster is associated
        /// with. 
        /// </para>
        /// </summary>
        public string CharacterSetName
        {
            get { return this._characterSetName; }
            set { this._characterSetName = value; }
        }

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this._characterSetName != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Contains the name of the initial database of this DB cluster that was provided at
        /// create time, if one was specified when the DB cluster was created. This same name
        /// is returned for the life of the DB cluster. 
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied DB cluster identifier. This identifier is the unique key
        /// that identifies a DB cluster. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DBClusterMembers. 
        /// <para>
        /// Provides the list of instances that make up the DB cluster.
        /// </para>
        /// </summary>
        public List<DBClusterMember> DBClusterMembers
        {
            get { return this._dbClusterMembers; }
            set { this._dbClusterMembers = value; }
        }

        // Check to see if DBClusterMembers property is set
        internal bool IsSetDBClusterMembers()
        {
            return this._dbClusterMembers != null && this._dbClusterMembers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterOptionGroupMemberships. 
        /// <para>
        ///  Provides the list of option group memberships for this DB cluster. 
        /// </para>
        /// </summary>
        public List<DBClusterOptionGroupStatus> DBClusterOptionGroupMemberships
        {
            get { return this._dbClusterOptionGroupMemberships; }
            set { this._dbClusterOptionGroupMemberships = value; }
        }

        // Check to see if DBClusterOptionGroupMemberships property is set
        internal bool IsSetDBClusterOptionGroupMemberships()
        {
            return this._dbClusterOptionGroupMemberships != null && this._dbClusterOptionGroupMemberships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroup. 
        /// <para>
        /// Specifies the name of the DB cluster parameter group for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroup
        {
            get { return this._dbClusterParameterGroup; }
            set { this._dbClusterParameterGroup = value; }
        }

        // Check to see if DBClusterParameterGroup property is set
        internal bool IsSetDBClusterParameterGroup()
        {
            return this._dbClusterParameterGroup != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The region-unique, immutable identifier for the DB cluster. This identifier is found
        /// in AWS CloudTrail log entries whenever the KMS key for the DB cluster is accessed.
        /// 
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
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Specifies information on the subnet group associated with the DB cluster, including
        /// the name, description, and subnets in the subnet group. 
        /// </para>
        /// </summary>
        public string DBSubnetGroup
        {
            get { return this._dbSubnetGroup; }
            set { this._dbSubnetGroup = value; }
        }

        // Check to see if DBSubnetGroup property is set
        internal bool IsSetDBSubnetGroup()
        {
            return this._dbSubnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property EarliestRestorableTime. 
        /// <para>
        /// Specifies the earliest time to which a database can be restored with point-in-time
        /// restore. 
        /// </para>
        /// </summary>
        public DateTime EarliestRestorableTime
        {
            get { return this._earliestRestorableTime.GetValueOrDefault(); }
            set { this._earliestRestorableTime = value; }
        }

        // Check to see if EarliestRestorableTime property is set
        internal bool IsSetEarliestRestorableTime()
        {
            return this._earliestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Specifies the connection endpoint for the primary instance of the DB cluster. 
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
        /// Provides the name of the database engine to be used for this DB cluster. 
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
        /// Indicates the database engine version. 
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
        /// Specifies the ID that Amazon Route 53 assigns when you create a hosted zone.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <code>StorageEncrypted</code> is true, the KMS key identifier for the encrypted
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
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// Specifies the latest time to which a database can be restored with point-in-time restore.
        /// 
        /// </para>
        /// </summary>
        public DateTime LatestRestorableTime
        {
            get { return this._latestRestorableTime.GetValueOrDefault(); }
            set { this._latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this._latestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// Contains the master username for the DB cluster. 
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
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// Specifies the progress of the operation as a percentage. 
        /// </para>
        /// </summary>
        public string PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the database engine is listening on. 
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// Specifies the daily time range during which automated backups are created if automated
        /// backups are enabled, as determined by the <code>BackupRetentionPeriod</code>. 
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
        /// Specifies the weekly time range during which system maintenance can occur, in Universal
        /// Coordinated Time (UTC). 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current state of this DB cluster. 
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
        /// Specifies whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool StorageEncrypted
        {
            get { return this._storageEncrypted.GetValueOrDefault(); }
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
        ///  Provides a list of VPC security groups that the DB cluster belongs to. 
        /// </para>
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && this._vpcSecurityGroups.Count > 0; 
        }

    }
}