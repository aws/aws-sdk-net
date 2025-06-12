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
    /// Provides details about an Amazon RDS DB cluster snapshot.
    /// </summary>
    public partial class AwsRdsDbSnapshotDetails
    {
        private int? _allocatedStorage;
        private string _availabilityZone;
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private string _dbSnapshotIdentifier;
        private bool? _encrypted;
        private string _engine;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private string _instanceCreateTime;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private string _optionGroupName;
        private int? _percentProgress;
        private int? _port;
        private List<AwsRdsDbProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<AwsRdsDbProcessorFeature>() : null;
        private string _snapshotCreateTime;
        private string _snapshotType;
        private string _sourceDbSnapshotIdentifier;
        private string _sourceRegion;
        private string _status;
        private string _storageType;
        private string _tdeCredentialArn;
        private string _timezone;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to be initially allocated for the database instance.
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
        /// Specifies the name of the Availability Zone in which the DB instance was located at
        /// the time of the DB snapshot.
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
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// A name for the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DbInstanceIdentifier property is set
        internal bool IsSetDbInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The identifier for the source DB instance.
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
        /// Gets and sets the property DbSnapshotIdentifier. 
        /// <para>
        /// The name or ARN of the DB snapshot that is used to restore the DB instance.
        /// </para>
        /// </summary>
        public string DbSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DbSnapshotIdentifier property is set
        internal bool IsSetDbSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Whether the DB snapshot is encrypted.
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
        /// The name of the database engine to use for this DB instance. Valid values are as follows:
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
        ///  </li> <li> 
        /// <para>
        ///  <c>c</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web</c> 
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine.
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
        /// Gets and sets the property IamDatabaseAuthenticationEnabled. 
        /// <para>
        /// Whether mapping of IAM accounts to database accounts is enabled.
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
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// Specifies the time in Coordinated Universal Time (UTC) when the DB instance, from
        /// which the snapshot was taken, was created.
        /// </para>
        /// </summary>
        public string InstanceCreateTime
        {
            get { return this._instanceCreateTime; }
            set { this._instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this._instanceCreateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The provisioned IOPS (I/O operations per second) value of the DB instance at the time
        /// of the snapshot.
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
        /// If <c>Encrypted</c> is <c>true</c>, the KMS key identifier for the encrypted DB snapshot.
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
        /// The master user name for the DB snapshot.
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group name for the DB snapshot.
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
        /// The port that the database engine was listening on at the time of the snapshot.
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
        /// of the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbProcessorFeature> ProcessorFeatures
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
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// When the snapshot was taken in Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public string SnapshotCreateTime
        {
            get { return this._snapshotCreateTime; }
            set { this._snapshotCreateTime = value; }
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this._snapshotCreateTime != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of the DB snapshot.
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
        /// Gets and sets the property SourceDbSnapshotIdentifier. 
        /// <para>
        /// The DB snapshot ARN that the DB snapshot was copied from.
        /// </para>
        /// </summary>
        public string SourceDbSnapshotIdentifier
        {
            get { return this._sourceDbSnapshotIdentifier; }
            set { this._sourceDbSnapshotIdentifier = value; }
        }

        // Check to see if SourceDbSnapshotIdentifier property is set
        internal bool IsSetSourceDbSnapshotIdentifier()
        {
            return this._sourceDbSnapshotIdentifier != null;
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
        /// The status of this DB snapshot.
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the DB snapshot. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standard</c> 
        /// </para>
        ///  </li> </ul>
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
        /// The time zone of the DB snapshot.
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
        /// The VPC ID associated with the DB snapshot.
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