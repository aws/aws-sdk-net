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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the details for an Amazon Neptune DB cluster snapshot
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBClusterSnapshots</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBClusterSnapshot
    {
        private int? _allocatedStorage;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _clusterCreateTime;
        private string _dbClusterIdentifier;
        private string _dbClusterSnapshotArn;
        private string _dbClusterSnapshotIdentifier;
        private string _engine;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private int? _percentProgress;
        private int? _port;
        private DateTime? _snapshotCreateTime;
        private string _snapshotType;
        private string _sourceDBClusterSnapshotArn;
        private string _status;
        private bool? _storageEncrypted;
        private string _storageType;
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Provides the list of EC2 Availability Zones that instances in the DB cluster snapshot
        /// can be restored in.
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
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// Specifies the time when the DB cluster was created, in Universal Coordinated Time
        /// (UTC).
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// Specifies the DB cluster identifier of the DB cluster that this DB cluster snapshot
        /// was created from.
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
        /// Gets and sets the property DBClusterSnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB cluster snapshot.
        /// </para>
        /// </summary>
        public string DBClusterSnapshotArn
        {
            get { return this._dbClusterSnapshotArn; }
            set { this._dbClusterSnapshotArn = value; }
        }

        // Check to see if DBClusterSnapshotArn property is set
        internal bool IsSetDBClusterSnapshotArn()
        {
            return this._dbClusterSnapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// Specifies the identifier for a DB cluster snapshot. Must match the identifier of an
        /// existing snapshot.
        /// </para>
        ///  
        /// <para>
        /// After you restore a DB cluster using a <c>DBClusterSnapshotIdentifier</c>, you must
        /// specify the same <c>DBClusterSnapshotIdentifier</c> for any future updates to the
        /// DB cluster. When you specify this property for an update, the DB cluster is not restored
        /// from the snapshot again, and the data in the database is not changed.
        /// </para>
        ///  
        /// <para>
        /// However, if you don't specify the <c>DBClusterSnapshotIdentifier</c>, an empty DB
        /// cluster is created, and the original DB cluster is deleted. If you specify a property
        /// that is different from the previous snapshot restore property, the DB cluster is restored
        /// from the snapshot specified by the <c>DBClusterSnapshotIdentifier</c>, and the original
        /// DB cluster is deleted.
        /// </para>
        /// </summary>
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
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
        /// Provides the version of the database engine for this DB cluster snapshot.
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
        /// True if mapping of Amazon Identity and Access Management (IAM) accounts to database
        /// accounts is enabled, and otherwise false.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <c>StorageEncrypted</c> is true, the Amazon KMS key identifier for the encrypted
        /// DB cluster snapshot.
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
        /// Provides the license model information for this DB cluster snapshot.
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
        /// Not supported by Neptune.
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
        /// Specifies the percentage of the estimated data that has been transferred.
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
        /// Specifies the port that the DB cluster was listening on at the time of the snapshot.
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
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// Provides the time when the snapshot was taken, in Universal Coordinated Time (UTC).
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
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// Provides the type of the DB cluster snapshot.
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
        /// Gets and sets the property SourceDBClusterSnapshotArn. 
        /// <para>
        /// If the DB cluster snapshot was copied from a source DB cluster snapshot, the Amazon
        /// Resource Name (ARN) for the source DB cluster snapshot, otherwise, a null value.
        /// </para>
        /// </summary>
        public string SourceDBClusterSnapshotArn
        {
            get { return this._sourceDBClusterSnapshotArn; }
            set { this._sourceDBClusterSnapshotArn = value; }
        }

        // Check to see if SourceDBClusterSnapshotArn property is set
        internal bool IsSetSourceDBClusterSnapshotArn()
        {
            return this._sourceDBClusterSnapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of this DB cluster snapshot.
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
        /// Specifies whether the DB cluster snapshot is encrypted.
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the DB cluster snapshot.
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
        /// Provides the VPC ID associated with the DB cluster snapshot.
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