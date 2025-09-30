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
    /// This data type is used as a response element in the <c>ModifyDBInstance</c> operation
    /// and contains changes that will be applied during the next maintenance window.
    /// </summary>
    public partial class PendingModifiedValues
    {
        private int? _allocatedStorage;
        private AutomationMode _automationMode;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbSubnetGroupName;
        private bool? _dedicatedLogVolume;
        private string _engine;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private int? _iops;
        private string _licenseModel;
        private string _masterUserPassword;
        private bool? _multiAZ;
        private bool? _multiTenant;
        private PendingCloudwatchLogsExports _pendingCloudwatchLogsExports;
        private int? _port;
        private List<ProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;
        private DateTime? _resumeFullAutomationModeTime;
        private int? _storageThroughput;
        private string _storageType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PendingModifiedValues() { }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage size for the DB instance specified in gibibytes (GiB).
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
        /// Gets and sets the property AutomationMode. 
        /// <para>
        /// The automation mode of the RDS Custom DB instance: <c>full</c> or <c>all-paused</c>.
        /// If <c>full</c>, the DB instance automates monitoring and instance recovery. If <c>all-paused</c>,
        /// the instance pauses automation for the duration set by <c>--resume-full-automation-mode-minutes</c>.
        /// </para>
        /// </summary>
        public AutomationMode AutomationMode
        {
            get { return this._automationMode; }
            set { this._automationMode = value; }
        }

        // Check to see if AutomationMode property is set
        internal bool IsSetAutomationMode()
        {
            return this._automationMode != null;
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
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The identifier of the CA certificate for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CACertificateIdentifier property is set
        internal bool IsSetCACertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The name of the compute and memory capacity class for the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The database identifier for the DB instance.
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
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The DB subnet group for the DB instance.
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.&gt;
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine of the DB instance.
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
        /// The database engine version.
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
        /// The Provisioned IOPS value for the DB instance.
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
        /// The license model for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>license-included</c> | <c>bring-your-own-license</c> | <c>general-public-license</c>
        /// 
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
        /// The master credentials for the DB instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Indicates whether the Single-AZ DB instance will change to a Multi-AZ deployment.
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
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Indicates whether the DB instance will change to the multi-tenant configuration (TRUE)
        /// or the single-tenant configuration (FALSE). 
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
        /// Gets and sets the property PendingCloudwatchLogsExports.
        /// </summary>
        public PendingCloudwatchLogsExports PendingCloudwatchLogsExports
        {
            get { return this._pendingCloudwatchLogsExports; }
            set { this._pendingCloudwatchLogsExports = value; }
        }

        // Check to see if PendingCloudwatchLogsExports property is set
        internal bool IsSetPendingCloudwatchLogsExports()
        {
            return this._pendingCloudwatchLogsExports != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port for the DB instance.
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
        /// Gets and sets the property ResumeFullAutomationModeTime. 
        /// <para>
        /// The number of minutes to pause the automation. When the time period ends, RDS Custom
        /// resumes full automation. The minimum value is 60 (default). The maximum value is 1,440.
        /// </para>
        /// </summary>
        public DateTime? ResumeFullAutomationModeTime
        {
            get { return this._resumeFullAutomationModeTime; }
            set { this._resumeFullAutomationModeTime = value; }
        }

        // Check to see if ResumeFullAutomationModeTime property is set
        internal bool IsSetResumeFullAutomationModeTime()
        {
            return this._resumeFullAutomationModeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput of the DB instance.
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
        /// The storage type of the DB instance.
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