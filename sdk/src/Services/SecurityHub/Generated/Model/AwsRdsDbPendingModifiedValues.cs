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
    /// Changes to a DB instance that are currently pending.
    /// </summary>
    public partial class AwsRdsDbPendingModifiedValues
    {
        private int? _allocatedStorage;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbSubnetGroupName;
        private string _engineVersion;
        private int? _iops;
        private string _licenseModel;
        private string _masterUserPassword;
        private bool? _multiAZ;
        private AwsRdsPendingCloudWatchLogsExports _pendingCloudWatchLogsExports;
        private int? _port;
        private List<AwsRdsDbProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<AwsRdsDbProcessorFeature>() : null;
        private string _storageType;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The new value of the allocated storage for the DB instance.
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The new backup retention period for the DB instance.
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
        /// Gets and sets the property CaCertificateIdentifier. 
        /// <para>
        /// The new CA certificate identifier for the DB instance.
        /// </para>
        /// </summary>
        public string CaCertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CaCertificateIdentifier property is set
        internal bool IsSetCaCertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceClass. 
        /// <para>
        /// The new DB instance class for the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DbInstanceClass property is set
        internal bool IsSetDbInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// The new DB instance identifier for the DB instance.
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
        /// Gets and sets the property DbSubnetGroupName. 
        /// <para>
        /// The name of the new subnet group for the DB instance.
        /// </para>
        /// </summary>
        public string DbSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DbSubnetGroupName property is set
        internal bool IsSetDbSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The new engine version for the DB instance.
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
        /// Gets and sets the property Iops. 
        /// <para>
        /// The new provisioned IOPS value for the DB instance.
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The new license model value for the DB instance.
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new master user password for the DB instance.
        /// </para>
        /// </summary>
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Indicates that a single Availability Zone DB instance is changing to a multiple Availability
        /// Zone deployment.
        /// </para>
        /// </summary>
        public bool? MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingCloudWatchLogsExports. 
        /// <para>
        /// A list of log types that are being enabled or disabled.
        /// </para>
        /// </summary>
        public AwsRdsPendingCloudWatchLogsExports PendingCloudWatchLogsExports
        {
            get { return this._pendingCloudWatchLogsExports; }
            set { this._pendingCloudWatchLogsExports = value; }
        }

        // Check to see if PendingCloudWatchLogsExports property is set
        internal bool IsSetPendingCloudWatchLogsExports()
        {
            return this._pendingCloudWatchLogsExports != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The new port for the DB instance.
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
        /// Processor features that are being updated.
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The new storage type for the DB instance.
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

    }
}