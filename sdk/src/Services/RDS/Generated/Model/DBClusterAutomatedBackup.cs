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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// An automated backup of a DB cluster. It consists of system backups, transaction logs,
    /// and the database cluster properties that existed at the time you deleted the source
    /// cluster.
    /// </summary>
    public partial class DBClusterAutomatedBackup
    {
        private int? _allocatedStorage;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsBackupRecoveryPointArn;
        private int? _backupRetentionPeriod;
        private DateTime? _clusterCreateTime;
        private string _dbClusterArn;
        private string _dbClusterAutomatedBackupsArn;
        private string _dbClusterIdentifier;
        private string _dbClusterResourceId;
        private string _engine;
        private string _engineMode;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private int? _port;
        private string _region;
        private RestoreWindow _restoreWindow;
        private string _status;
        private bool? _storageEncrypted;
        private int? _storageThroughput;
        private string _storageType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// For all database engines except Amazon Aurora, <c>AllocatedStorage</c> specifies the
        /// allocated storage size in gibibytes (GiB). For Aurora, <c>AllocatedStorage</c> always
        /// returns 1, because Aurora DB cluster storage size isn't fixed, but instead automatically
        /// adjusts as needed.
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones where instances in the DB cluster can be created. For information
        /// on Amazon Web Services Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>.
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
        /// Gets and sets the property AwsBackupRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point in Amazon Web Services Backup.
        /// </para>
        /// </summary>
        public string AwsBackupRecoveryPointArn
        {
            get { return this._awsBackupRecoveryPointArn; }
            set { this._awsBackupRecoveryPointArn = value; }
        }

        // Check to see if AwsBackupRecoveryPointArn property is set
        internal bool IsSetAwsBackupRecoveryPointArn()
        {
            return this._awsBackupRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The retention period for the automated backups.
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
        /// The time when the DB cluster was created, in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime
        {
            get { return this._clusterCreateTime; }
            set { this._clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the source DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterArn
        {
            get { return this._dbClusterArn; }
            set { this._dbClusterArn = value; }
        }

        // Check to see if DBClusterArn property is set
        internal bool IsSetDBClusterArn()
        {
            return this._dbClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterAutomatedBackupsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the automated backups.
        /// </para>
        /// </summary>
        public string DBClusterAutomatedBackupsArn
        {
            get { return this._dbClusterAutomatedBackupsArn; }
            set { this._dbClusterAutomatedBackupsArn = value; }
        }

        // Check to see if DBClusterAutomatedBackupsArn property is set
        internal bool IsSetDBClusterAutomatedBackupsArn()
        {
            return this._dbClusterAutomatedBackupsArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The identifier for the source DB cluster, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
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
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The resource ID for the source DB cluster, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine for this automated backup.
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
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The engine mode of the database engine for the automated backup.
        /// </para>
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
        /// The version of the database engine for the automated backup.
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
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// Indicates whether mapping of Amazon Web Services Identity and Access Management (IAM)
        /// accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled
        {
            get { return this._iamDatabaseAuthenticationEnabled; }
            set { this._iamDatabaseAuthenticationEnabled = value; }
        }

        // Check to see if IAMDatabaseAuthenticationEnabled property is set
        internal bool IsSetIAMDatabaseAuthenticationEnabled()
        {
            return this._iamDatabaseAuthenticationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS (I/O operations per second) value for the automated backup.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ID for an automated backup.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model information for this DB cluster automated backup.
        /// </para>
        /// </summary>
        public string LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name of the automated backup.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number that the automated backup used for connections.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits from the source DB cluster
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region associated with the automated backup.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreWindow.
        /// </summary>
        public RestoreWindow RestoreWindow
        {
            get { return this._restoreWindow; }
            set { this._restoreWindow = value; }
        }

        // Check to see if RestoreWindow property is set
        internal bool IsSetRestoreWindow()
        {
            return this._restoreWindow != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A list of status information for an automated backup:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>retained</c> - Automated backups for deleted clusters.
        /// </para>
        ///  </li> </ul>
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
        /// Indicates whether the source DB cluster is encrypted.
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
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput for the automated backup. The throughput is automatically set
        /// based on the IOPS that you provision, and is not configurable.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public int? StorageThroughput
        {
            get { return this._storageThroughput; }
            set { this._storageThroughput = value; }
        }

        // Check to see if StorageThroughput property is set
        internal bool IsSetStorageThroughput()
        {
            return this._storageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID associated with the DB cluster.
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