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
    /// Contains the details of an Amazon RDS DB snapshot.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBSnapshots</c> action.
    /// </para>
    /// </summary>
    public partial class DBSnapshot
    {
        private int? _allocatedStorage;
        private string _availabilityZone;
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private string _dbSnapshotArn;
        private string _dbSnapshotIdentifier;
        private string _dbSystemId;
        private bool? _dedicatedLogVolume;
        private bool? _encrypted;
        private string _engine;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private DateTime? _instanceCreateTime;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private bool? _multiTenant;
        private string _optionGroupName;
        private DateTime? _originalSnapshotCreateTime;
        private int? _percentProgress;
        private int? _port;
        private List<ProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;
        private string _snapshotAvailabilityZone;
        private DateTime? _snapshotCreateTime;
        private DateTime? _snapshotDatabaseTime;
        private string _snapshotTarget;
        private string _snapshotType;
        private string _sourceDBSnapshotIdentifier;
        private string _sourceRegion;
        private string _status;
        private int? _storageThroughput;
        private string _storageType;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tdeCredentialArn;
        private string _timezone;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// Specifies the allocated storage size in gibibytes (GiB).
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone the DB instance was located in at the
        /// time of the DB snapshot.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// Specifies the DB instance identifier of the DB instance this DB snapshot was created
        /// from.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The identifier for the source DB instance, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB snapshot.
        /// </para>
        /// </summary>
        public string DBSnapshotArn
        {
            get { return this._dbSnapshotArn; }
            set { this._dbSnapshotArn = value; }
        }

        // Check to see if DBSnapshotArn property is set
        internal bool IsSetDBSnapshotArn()
        {
            return this._dbSnapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// Specifies the identifier for the DB snapshot.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBSystemId. 
        /// <para>
        /// The Oracle system identifier (SID), which is the name of the Oracle database instance
        /// that manages your database files. The Oracle SID is also the name of your CDB.
        /// </para>
        /// </summary>
        public string DBSystemId
        {
            get { return this._dbSystemId; }
            set { this._dbSystemId = value; }
        }

        // Check to see if DBSystemId property is set
        internal bool IsSetDBSystemId()
        {
            return this._dbSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.
        /// </para>
        /// </summary>
        public bool? DedicatedLogVolume
        {
            get { return this._dedicatedLogVolume; }
            set { this._dedicatedLogVolume = value; }
        }

        // Check to see if DedicatedLogVolume property is set
        internal bool IsSetDedicatedLogVolume()
        {
            return this._dedicatedLogVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the DB snapshot is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the name of the database engine.
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
        /// Specifies the version of the database engine.
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
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// Specifies the time in Coordinated Universal Time (UTC) when the DB instance, from
        /// which the snapshot was taken, was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime
        {
            get { return this._instanceCreateTime; }
            set { this._instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this._instanceCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the Provisioned IOPS (I/O operations per second) value of the DB instance
        /// at the time of the snapshot.
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
        /// If <c>Encrypted</c> is true, the Amazon Web Services KMS key identifier for the encrypted
        /// DB snapshot.
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
        /// License model information for the restored DB instance.
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
        /// Provides the master username for the DB snapshot.
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
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Indicates whether the snapshot is of a DB instance using the multi-tenant configuration
        /// (TRUE) or the single-tenant configuration (FALSE).
        /// </para>
        /// </summary>
        public bool? MultiTenant
        {
            get { return this._multiTenant; }
            set { this._multiTenant = value; }
        }

        // Check to see if MultiTenant property is set
        internal bool IsSetMultiTenant()
        {
            return this._multiTenant.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// Provides the option group name for the DB snapshot.
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalSnapshotCreateTime. 
        /// <para>
        /// Specifies the time of the CreateDBSnapshot operation in Coordinated Universal Time
        /// (UTC). Doesn't change when the snapshot is copied.
        /// </para>
        /// </summary>
        public DateTime? OriginalSnapshotCreateTime
        {
            get { return this._originalSnapshotCreateTime; }
            set { this._originalSnapshotCreateTime = value; }
        }

        // Check to see if OriginalSnapshotCreateTime property is set
        internal bool IsSetOriginalSnapshotCreateTime()
        {
            return this._originalSnapshotCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The percentage of the estimated data that has been transferred.
        /// </para>
        /// </summary>
        public int? PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the database engine was listening on at the time of the snapshot.
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
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance when the DB snapshot was created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures
        {
            get { return this._processorFeatures; }
            set { this._processorFeatures = value; }
        }

        // Check to see if ProcessorFeatures property is set
        internal bool IsSetProcessorFeatures()
        {
            return this._processorFeatures != null && (this._processorFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnapshotAvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone where RDS stores the DB snapshot. This
        /// value is valid only for snapshots that RDS stores on a Dedicated Local Zone.
        /// </para>
        /// </summary>
        public string SnapshotAvailabilityZone
        {
            get { return this._snapshotAvailabilityZone; }
            set { this._snapshotAvailabilityZone = value; }
        }

        // Check to see if SnapshotAvailabilityZone property is set
        internal bool IsSetSnapshotAvailabilityZone()
        {
            return this._snapshotAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// Specifies when the snapshot was taken in Coordinated Universal Time (UTC). Changes
        /// for the copy when the snapshot is copied.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime
        {
            get { return this._snapshotCreateTime; }
            set { this._snapshotCreateTime = value; }
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this._snapshotCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotDatabaseTime. 
        /// <para>
        /// The timestamp of the most recent transaction applied to the database that you're backing
        /// up. Thus, if you restore a snapshot, SnapshotDatabaseTime is the most recent transaction
        /// in the restored DB instance. In contrast, originalSnapshotCreateTime specifies the
        /// system time that the snapshot completed.
        /// </para>
        ///  
        /// <para>
        /// If you back up a read replica, you can determine the replica lag by comparing SnapshotDatabaseTime
        /// with originalSnapshotCreateTime. For example, if originalSnapshotCreateTime is two
        /// hours later than SnapshotDatabaseTime, then the replica lag is two hours.
        /// </para>
        /// </summary>
        public DateTime? SnapshotDatabaseTime
        {
            get { return this._snapshotDatabaseTime; }
            set { this._snapshotDatabaseTime = value; }
        }

        // Check to see if SnapshotDatabaseTime property is set
        internal bool IsSetSnapshotDatabaseTime()
        {
            return this._snapshotDatabaseTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotTarget. 
        /// <para>
        /// Specifies where manual snapshots are stored: Dedicated Local Zones, Amazon Web Services
        /// Outposts or the Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string SnapshotTarget
        {
            get { return this._snapshotTarget; }
            set { this._snapshotTarget = value; }
        }

        // Check to see if SnapshotTarget property is set
        internal bool IsSetSnapshotTarget()
        {
            return this._snapshotTarget != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// Provides the type of the DB snapshot.
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBSnapshotIdentifier. 
        /// <para>
        /// The DB snapshot Amazon Resource Name (ARN) that the DB snapshot was copied from. It
        /// only has a value in the case of a cross-account or cross-Region copy.
        /// </para>
        /// </summary>
        public string SourceDBSnapshotIdentifier
        {
            get { return this._sourceDBSnapshotIdentifier; }
            set { this._sourceDBSnapshotIdentifier = value; }
        }

        // Check to see if SourceDBSnapshotIdentifier property is set
        internal bool IsSetSourceDBSnapshotIdentifier()
        {
            return this._sourceDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The Amazon Web Services Region that the DB snapshot was created in or copied from.
        /// </para>
        /// </summary>
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of this DB snapshot.
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
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// Specifies the storage throughput for the DB snapshot.
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
        /// Specifies the storage type associated with DB snapshot.
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
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which to associate the instance for TDE encryption.
        /// </para>
        /// </summary>
        public string TdeCredentialArn
        {
            get { return this._tdeCredentialArn; }
            set { this._tdeCredentialArn = value; }
        }

        // Check to see if TdeCredentialArn property is set
        internal bool IsSetTdeCredentialArn()
        {
            return this._tdeCredentialArn != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone of the DB snapshot. In most cases, the <c>Timezone</c> element is empty.
        /// <c>Timezone</c> content appears only for snapshots taken from Microsoft SQL Server
        /// DB instances that were created with a time zone specified.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VPC ID associated with the DB snapshot.
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