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
    /// Container for the parameters to the ModifyDBInstance operation.
    /// Modifies settings for a DB instance. You can change one or more database configuration
    /// parameters by specifying these parameters and the new values in the request. To learn
    /// what modifications you can make to your DB instance, call <c>DescribeValidDBInstanceModifications</c>
    /// before you call <c>ModifyDBInstance</c>.
    /// </summary>
    public partial class ModifyDBInstanceRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private AutomationMode _automationMode;
        private bool? _autoMinorVersionUpgrade;
        private string _awsBackupRecoveryPointArn;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private bool? _certificateRotationRestart;
        private CloudwatchLogsExportConfiguration _cloudwatchLogsExportConfiguration;
        private bool? _copyTagsToSnapshot;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbParameterGroupName;
        private int? _dbPortNumber;
        private List<string> _dbSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dbSubnetGroupName;
        private bool? _dedicatedLogVolume;
        private bool? _deletionProtection;
        private bool? _disableDomain;
        private string _domain;
        private string _domainAuthSecretArn;
        private List<string> _domainDnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainFqdn;
        private string _domainIAMRoleName;
        private string _domainOu;
        private bool? _enableCustomerOwnedIp;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private string _engine;
        private string _engineVersion;
        private int? _iops;
        private string _licenseModel;
        private bool? _manageMasterUserPassword;
        private MasterUserAuthenticationType _masterUserAuthenticationType;
        private string _masterUserPassword;
        private string _masterUserSecretKmsKeyId;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private bool? _multiTenant;
        private string _networkType;
        private string _newDBInstanceIdentifier;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<ProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private ReplicaMode _replicaMode;
        private int? _resumeFullAutomationModeMinutes;
        private bool? _rotateMasterUserPassword;
        private int? _storageThroughput;
        private string _storageType;
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private bool? _useDefaultProcessorFeatures;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyDBInstanceRequest() { }

        /// <summary>
        /// Instantiates ModifyDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The identifier of DB instance to modify. This value is stored as a lowercase string. Constraints: <ul> <li> Must match the identifier of an existing DB instance. </li> </ul></param>
        public ModifyDBInstanceRequest(string dbInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The new amount of storage in gibibytes (GiB) to allocate for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For RDS for Db2, MariaDB, RDS for MySQL, RDS for Oracle, and RDS for PostgreSQL, the
        /// value supplied must be at least 10% greater than the current value. Values that are
        /// not at least 10% greater than the existing value are rounded up so that they are 10%
        /// greater than the current value.
        /// </para>
        ///  
        /// <para>
        /// For the valid values for allocated storage for each engine, see <c>CreateDBInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you increase the allocated storage for a DB instance that uses Provisioned IOPS
        /// (<c>gp3</c>, <c>io1</c>, or <c>io2</c> storage type), you must also specify the <c>Iops</c>
        /// parameter. You can use the current value for <c>Iops</c>.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// Specifies whether major version upgrades are allowed. Changing this parameter doesn't
        /// result in an outage and the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Major version upgrades must be allowed when specifying a value for the <c>EngineVersion</c>
        /// parameter that's a different major version than the DB instance's current version.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? AllowMajorVersionUpgrade
        {
            get { return this._allowMajorVersionUpgrade; }
            set { this._allowMajorVersionUpgrade = value; }
        }

        // Check to see if AllowMajorVersionUpgrade property is set
        internal bool IsSetAllowMajorVersionUpgrade()
        {
            return this._allowMajorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Specifies whether the modifications in this request and any pending modifications
        /// are asynchronously applied as soon as possible, regardless of the <c>PreferredMaintenanceWindow</c>
        /// setting for the DB instance. By default, this parameter is disabled.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is disabled, changes to the DB instance are applied during the next
        /// maintenance window. Some parameter changes can cause an outage and are applied on
        /// the next call to <a>RebootDBInstance</a>, or the next failure reboot. Review the table
        /// of parameters in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.DBInstance.Modifying.html">Modifying
        /// a DB Instance</a> in the <i>Amazon RDS User Guide</i> to see the impact of enabling
        /// or disabling <c>ApplyImmediately</c> for each modified parameter and to determine
        /// when the changes are applied.
        /// </para>
        /// </summary>
        public bool? ApplyImmediately
        {
            get { return this._applyImmediately; }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutomationMode. 
        /// <para>
        /// The automation mode of the RDS Custom DB instance. If <c>full</c>, the DB instance
        /// automates monitoring and instance recovery. If <c>all paused</c>, the instance pauses
        /// automation for the duration set by <c>ResumeFullAutomationModeMinutes</c>.
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
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Specifies whether minor version upgrades are applied automatically to the DB instance
        /// during the maintenance window. An outage occurs when all the following conditions
        /// are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The automatic upgrade is enabled for the maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A newer minor version is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS has enabled automatic patching for the engine version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If any of the preceding conditions isn't met, Amazon RDS applies the change as soon
        /// as possible and doesn't cause an outage.
        /// </para>
        ///  
        /// <para>
        /// For an RDS Custom DB instance, don't enable this setting. Otherwise, the operation
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// For more information about automatic minor version upgrades, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Upgrading.html#USER_UpgradeDBInstance.Upgrading.AutoMinorVersionUpgrades">Automatically
        /// upgrading the minor engine version</a>.
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
        /// Gets and sets the property AwsBackupRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point in Amazon Web Services Backup.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=43, Max=350)]
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
        /// The number of days to retain automated backups. Setting this parameter to a positive
        /// number enables backups. Setting this parameter to 0 disables automated backups.
        /// </para>
        ///  <note> 
        /// <para>
        /// Enabling and disabling backups can result in a brief I/O suspension that lasts from
        /// a few seconds to a few minutes, depending on the size and class of your DB instance.
        /// </para>
        ///  </note> 
        /// <para>
        /// These changes are applied during the next maintenance window unless the <c>ApplyImmediately</c>
        /// parameter is enabled for this request. If you change the parameter from one non-zero
        /// value to another non-zero value, the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The retention period for
        /// automated backups is managed by the DB cluster. For more information, see <c>ModifyDBCluster</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a value from 0 to 35.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to 0 if the DB instance is a source to read replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to 0 for an RDS Custom for Oracle DB instance.
        /// </para>
        ///  </li> </ul>
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
        /// The CA certificate identifier to use for the DB instance's server certificate.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Gets and sets the property CertificateRotationRestart. 
        /// <para>
        /// Specifies whether the DB instance is restarted when you rotate your SSL/TLS certificate.
        /// </para>
        ///  
        /// <para>
        /// By default, the DB instance is restarted when you rotate your SSL/TLS certificate.
        /// The certificate is not updated until the DB instance is restarted.
        /// </para>
        ///  <important> 
        /// <para>
        /// Set this parameter only if you are <i>not</i> using SSL/TLS to connect to the DB instance.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you are using SSL/TLS to connect to the DB instance, follow the appropriate instructions
        /// for your DB engine to rotate your SSL/TLS certificate:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For more information about rotating your SSL/TLS certificate for RDS DB engines, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL-certificate-rotation.html">
        /// Rotating Your SSL/TLS Certificate.</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For more information about rotating your SSL/TLS certificate for Aurora DB engines,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL-certificate-rotation.html">
        /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? CertificateRotationRestart
        {
            get { return this._certificateRotationRestart; }
            set { this._certificateRotationRestart = value; }
        }

        // Check to see if CertificateRotationRestart property is set
        internal bool IsSetCertificateRotationRestart()
        {
            return this._certificateRotationRestart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudwatchLogsExportConfiguration. 
        /// <para>
        /// The log types to be enabled for export to CloudWatch Logs for a specific DB instance.
        /// </para>
        ///  
        /// <para>
        /// A change to the <c>CloudwatchLogsExportConfiguration</c> parameter is always applied
        /// to the DB instance immediately. Therefore, the <c>ApplyImmediately</c> parameter has
        /// no effect.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// The following values are valid for each DB engine:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora MySQL - <c>audit | error | general | slowquery | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora PostgreSQL - <c>postgresql | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - <c>error | general | slowquery | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - <c>postgresql | upgrade | iam-db-auth-error</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon RDS, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">
        /// Publishing Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public CloudwatchLogsExportConfiguration CloudwatchLogsExportConfiguration
        {
            get { return this._cloudwatchLogsExportConfiguration; }
            set { this._cloudwatchLogsExportConfiguration = value; }
        }

        // Check to see if CloudwatchLogsExportConfiguration property is set
        internal bool IsSetCloudwatchLogsExportConfiguration()
        {
            return this._cloudwatchLogsExportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the DB instance to snapshots of the DB instance.
        /// By default, tags aren't copied.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. Copying tags to snapshots
        /// is managed by the DB cluster. Setting this value for an Aurora DB instance has no
        /// effect on the DB cluster setting. For more information, see <c>ModifyDBCluster</c>.
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
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// Specifies the mode of Database Insights to enable for the DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Aurora DB instances inherit this value from the DB cluster, so you can't change this
        /// value.
        /// </para>
        ///  </note>
        /// </summary>
        public DatabaseInsightsMode DatabaseInsightsMode
        {
            get { return this._databaseInsightsMode; }
            set { this._databaseInsightsMode = value; }
        }

        // Check to see if DatabaseInsightsMode property is set
        internal bool IsSetDatabaseInsightsMode()
        {
            return this._databaseInsightsMode != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The new compute and memory capacity of the DB instance, for example <c>db.m4.large</c>.
        /// Not all DB instance classes are available in all Amazon Web Services Regions, or for
        /// all database engines. For the full list of DB instance classes, and availability for
        /// your engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.DBInstanceClass.html">Aurora
        /// DB instance classes</a> in the <i>Amazon Aurora User Guide</i>. For RDS Custom, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-reqs-limits.html#custom-reqs-limits.instances">DB
        /// instance class support for RDS Custom for Oracle</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-reqs-limits-MS.html#custom-reqs-limits.instancesMS">
        /// DB instance class support for RDS Custom for SQL Server</a>.
        /// </para>
        ///  
        /// <para>
        /// If you modify the DB instance class, an outage occurs during the change. The change
        /// is applied during the next maintenance window, unless you specify <c>ApplyImmediately</c>
        /// in your request. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are modifying the DB instance class and upgrading the engine version at the
        /// same time, the currently running engine version must be supported on the specified
        /// DB instance class. Otherwise, the operation returns an error. In this case, first
        /// run the operation to upgrade the engine version, and then run it again to modify the
        /// DB instance class.
        /// </para>
        ///  </li> </ul>
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
        /// The identifier of DB instance to modify. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to apply to the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Changing this setting doesn't result in an outage. The parameter group name itself
        /// is changed immediately, but the actual parameter changes are not applied until you
        /// reboot the instance without failover. In this case, the DB instance isn't rebooted
        /// automatically, and the parameter changes aren't applied during the next maintenance
        /// window. However, if you modify dynamic parameters in the newly associated DB parameter
        /// group, these changes are applied immediately without a reboot.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the same DB parameter group family as the DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBPortNumber. 
        /// <para>
        /// The port number on which the database accepts connections.
        /// </para>
        ///  
        /// <para>
        /// The value of the <c>DBPortNumber</c> parameter must not match any of the port values
        /// specified for options in the option group for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// If you change the <c>DBPortNumber</c> value, your database restarts regardless of
        /// the value of the <c>ApplyImmediately</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
        /// </para>
        ///  
        /// <para>
        /// Default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora - <c>3306</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Db2 - <c>50000</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MariaDB - <c>3306</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server - <c>1433</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - <c>3306</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle - <c>1521</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - <c>5432</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RDS for Microsoft SQL Server, the value can't be <c>1234</c>, <c>1434</c>, <c>3260</c>,
        /// <c>3343</c>, <c>3389</c>, <c>47001</c>, or <c>49152-49156</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? DBPortNumber
        {
            get { return this._dbPortNumber; }
            set { this._dbPortNumber = value; }
        }

        // Check to see if DBPortNumber property is set
        internal bool IsSetDBPortNumber()
        {
            return this._dbPortNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroups. 
        /// <para>
        /// A list of DB security groups to authorize on this DB instance. Changing this setting
        /// doesn't result in an outage and the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match existing DB security groups.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DBSecurityGroups
        {
            get { return this._dbSecurityGroups; }
            set { this._dbSecurityGroups = value; }
        }

        // Check to see if DBSecurityGroups property is set
        internal bool IsSetDBSecurityGroups()
        {
            return this._dbSecurityGroups != null && (this._dbSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The new DB subnet group for the DB instance. You can use this parameter to move your
        /// DB instance to a different VPC. If your DB instance isn't in a VPC, you can also use
        /// this parameter to move your DB instance into a VPC. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html#USER_VPC.Non-VPC2VPC">Working
        /// with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Changing the subnet group causes an outage during the change. The change is applied
        /// during the next maintenance window, unless you enable <c>ApplyImmediately</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match existing DB subnet group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mydbsubnetgroup</c> 
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the DB instance has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled. By default, deletion protection isn't
        /// enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. You can enable or disable
        /// deletion protection for the DB cluster. For more information, see <c>ModifyDBCluster</c>.
        /// DB instances in a DB cluster can be deleted even when deletion protection is enabled
        /// for the DB cluster.
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
        /// Gets and sets the property DisableDomain. 
        /// <para>
        /// Specifies whether to remove the DB instance from the Active Directory domain.
        /// </para>
        /// </summary>
        public bool? DisableDomain
        {
            get { return this._disableDomain; }
            set { this._disableDomain = value; }
        }

        // Check to see if DisableDomain property is set
        internal bool IsSetDisableDomain()
        {
            return this._disableDomain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Active Directory directory ID to move the DB instance to. Specify <c>none</c>
        /// to remove the instance from its current domain. You must create the domain before
        /// this operation. Currently, you can create only Db2, MySQL, Microsoft SQL Server, Oracle,
        /// and PostgreSQL DB instances in an Active Directory Domain.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/kerberos-authentication.html">
        /// Kerberos Authentication</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainAuthSecretArn. 
        /// <para>
        /// The ARN for the Secrets Manager secret with the credentials for the user joining the
        /// domain.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>arn:aws:secretsmanager:region:account-number:secret:myselfmanagedADtestsecret-123456</c>
        /// 
        /// </para>
        /// </summary>
        public string DomainAuthSecretArn
        {
            get { return this._domainAuthSecretArn; }
            set { this._domainAuthSecretArn = value; }
        }

        // Check to see if DomainAuthSecretArn property is set
        internal bool IsSetDomainAuthSecretArn()
        {
            return this._domainAuthSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainDnsIps. 
        /// <para>
        /// The IPv4 DNS IP addresses of your primary and secondary Active Directory domain controllers.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Two IP addresses must be provided. If there isn't a secondary domain controller, use
        /// the IP address of the primary domain controller for both entries in the list.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>123.124.125.126,234.235.236.237</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DomainDnsIps
        {
            get { return this._domainDnsIps; }
            set { this._domainDnsIps = value; }
        }

        // Check to see if DomainDnsIps property is set
        internal bool IsSetDomainDnsIps()
        {
            return this._domainDnsIps != null && (this._domainDnsIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of an Active Directory domain.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mymanagedADtest.mymanagedAD.mydomain</c> 
        /// </para>
        /// </summary>
        public string DomainFqdn
        {
            get { return this._domainFqdn; }
            set { this._domainFqdn = value; }
        }

        // Check to see if DomainFqdn property is set
        internal bool IsSetDomainFqdn()
        {
            return this._domainFqdn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// The name of the IAM role to use when making API calls to the Directory Service.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string DomainIAMRoleName
        {
            get { return this._domainIAMRoleName; }
            set { this._domainIAMRoleName = value; }
        }

        // Check to see if DomainIAMRoleName property is set
        internal bool IsSetDomainIAMRoleName()
        {
            return this._domainIAMRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOu. 
        /// <para>
        /// The Active Directory organizational unit for your DB instance to join.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the distinguished name format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>OU=mymanagedADtestOU,DC=mymanagedADtest,DC=mymanagedAD,DC=mydomain</c>
        /// 
        /// </para>
        /// </summary>
        public string DomainOu
        {
            get { return this._domainOu; }
            set { this._domainOu = value; }
        }

        // Check to see if DomainOu property is set
        internal bool IsSetDomainOu()
        {
            return this._domainOu != null;
        }

        /// <summary>
        /// Gets and sets the property EnableCustomerOwnedIp. 
        /// <para>
        /// Specifies whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// A <i>CoIP</i> provides local or external connectivity to resources in your Outpost
        /// subnets through your on-premises network. For some use cases, a CoIP can provide lower
        /// latency for connections to the DB instance from outside of its virtual private cloud
        /// (VPC) on your local network.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on Outposts, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Working
        /// with Amazon RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about CoIPs, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/routing.html#ip-addressing">Customer-owned
        /// IP addresses</a> in the <i>Amazon Web Services Outposts User Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableCustomerOwnedIp
        {
            get { return this._enableCustomerOwnedIp; }
            set { this._enableCustomerOwnedIp = value; }
        }

        // Check to see if EnableCustomerOwnedIp property is set
        internal bool IsSetEnableCustomerOwnedIp()
        {
            return this._enableCustomerOwnedIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// Specifies whether to enable mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora. Mapping Amazon Web Services IAM accounts
        /// to database accounts is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information about IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? EnableIAMDatabaseAuthentication
        {
            get { return this._enableIAMDatabaseAuthentication; }
            set { this._enableIAMDatabaseAuthentication = value; }
        }

        // Check to see if EnableIAMDatabaseAuthentication property is set
        internal bool IsSetEnableIAMDatabaseAuthentication()
        {
            return this._enableIAMDatabaseAuthentication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// Specifies whether to enable Performance Insights for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
        /// Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? EnablePerformanceInsights
        {
            get { return this._enablePerformanceInsights; }
            set { this._enablePerformanceInsights = value; }
        }

        // Check to see if EnablePerformanceInsights property is set
        internal bool IsSetEnablePerformanceInsights()
        {
            return this._enablePerformanceInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The target Oracle DB engine when you convert a non-CDB to a CDB. This intermediate
        /// step is necessary to upgrade an Oracle Database 19c non-CDB to an Oracle Database
        /// 21c CDB.
        /// </para>
        ///  
        /// <para>
        /// Note the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Make sure that you specify <c>oracle-ee-cdb</c> or <c>oracle-se2-cdb</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Make sure that your DB engine runs Oracle Database 19c with an April 2021 or later
        /// RU.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't convert a CDB to a non-CDB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't convert a replica database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't convert a non-CDB to a CDB and upgrade the engine version in the same command.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't convert the existing custom parameter or option group when it has options
        /// or parameters that are permanent or persistent. In this situation, the DB instance
        /// reverts to the default option and parameter group. To avoid reverting to the default,
        /// specify a new parameter group with <c>--db-parameter-group-name</c> and a new option
        /// group with <c>--option-group-name</c>.
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
        /// The version number of the database engine to upgrade to. Changing this parameter results
        /// in an outage and the change is applied during the next maintenance window unless the
        /// <c>ApplyImmediately</c> parameter is enabled for this request.
        /// </para>
        ///  
        /// <para>
        /// For major version upgrades, if a nondefault DB parameter group is currently in use,
        /// a new DB parameter group in the DB parameter group family for the new engine version
        /// must be specified. The new DB parameter group can be the default for that DB parameter
        /// group family.
        /// </para>
        ///  
        /// <para>
        /// If you specify only a major version, Amazon RDS updates the DB instance to the default
        /// minor version if the current minor version is lower. For information about valid engine
        /// versions, see <c>CreateDBInstance</c>, or call <c>DescribeDBEngineVersions</c>.
        /// </para>
        ///  
        /// <para>
        /// If the instance that you're modifying is acting as a read replica, the engine version
        /// that you specify must be the same or higher than the version that the source DB instance
        /// or cluster is running.
        /// </para>
        ///  
        /// <para>
        /// In RDS Custom for Oracle, this parameter is supported for read replicas only if they
        /// are in the <c>PATCH_DB_FAILURE</c> lifecycle.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are upgrading the engine version and modifying the DB instance class at the
        /// same time, the currently running engine version must be supported on the specified
        /// DB instance class. Otherwise, the operation returns an error. In this case, first
        /// run the operation to upgrade the engine version, and then run it again to modify the
        /// DB instance class.
        /// </para>
        ///  </li> </ul>
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
        /// The new Provisioned IOPS (I/O operations per second) value for the RDS instance.
        /// </para>
        ///  
        /// <para>
        /// Changing this setting doesn't result in an outage and the change is applied during
        /// the next maintenance window unless the <c>ApplyImmediately</c> parameter is enabled
        /// for this request. If you are migrating from Provisioned IOPS to standard storage,
        /// set this value to 0. The DB instance will require a reboot for the change in storage
        /// type to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you choose to migrate your DB instance from using standard storage to Provisioned
        /// IOPS (io1), or from Provisioned IOPS to standard storage, the process can take time.
        /// The duration of the migration depends on several factors such as database load, storage
        /// size, storage type (standard or Provisioned IOPS), amount of IOPS provisioned (if
        /// any), and the number of prior scale storage operations. Typical migration times are
        /// under 24 hours, but the process can take up to several days in some cases. During
        /// the migration, the DB instance is available for use, but might experience performance
        /// degradation. While the migration takes place, nightly backups for the instance are
        /// suspended. No other Amazon RDS operations can take place for the instance, including
        /// modifying the instance, rebooting the instance, deleting the instance, creating a
        /// read replica for the instance, and creating a DB snapshot of the instance.
        /// </para>
        ///   
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RDS for MariaDB, RDS for MySQL, RDS for Oracle, and RDS for PostgreSQL - The value
        /// supplied must be at least 10% greater than the current value. Values that are not
        /// at least 10% greater than the existing value are rounded up so that they are 10% greater
        /// than the current value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you increase the Provisioned IOPS, you must also specify the <c>AllocatedStorage</c>
        /// parameter. You can use the current value for <c>AllocatedStorage</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Uses existing setting
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
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RDS for Db2 - <c>bring-your-own-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MariaDB - <c>general-public-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server - <c>license-included</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - <c>general-public-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle - <c>bring-your-own-license | license-included</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - <c>postgresql-license</c> 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the DB instance doesn't manage the master user password with Amazon Web Services
        /// Secrets Manager, you can turn on this management. In this case, you can't specify
        /// <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// If the DB instance already manages the master user password with Amazon Web Services
        /// Secrets Manager, and you specify that the master user password is not managed with
        /// Amazon Web Services Secrets Manager, then you must specify <c>MasterUserPassword</c>.
        /// In this case, Amazon RDS deletes the secret and uses the new password for the master
        /// user specified by <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't manage the master user password with Amazon Web Services Secrets Manager if
        /// <c>MasterUserPassword</c> is specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't specify for RDS for Oracle CDB instances in the multi-tenant configuration.
        /// Use <c>ModifyTenantDatabase</c> instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't specify the parameters <c>ManageMasterUserPassword</c> and <c>MultiTenant</c>
        /// in the same operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ManageMasterUserPassword
        {
            get { return this._manageMasterUserPassword; }
            set { this._manageMasterUserPassword = value; }
        }

        // Check to see if ManageMasterUserPassword property is set
        internal bool IsSetManageMasterUserPassword()
        {
            return this._manageMasterUserPassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUserAuthenticationType. 
        /// <para>
        /// Specifies the authentication type for the master user. With IAM master user authentication,
        /// you can change the master DB user to use IAM database authentication.
        /// </para>
        ///  
        /// <para>
        /// You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>password</c> - Use standard database authentication with a password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>iam-db-auth</c> - Use IAM database authentication for the master user.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This option is only valid for RDS for PostgreSQL and Aurora PostgreSQL engines.
        /// </para>
        /// </summary>
        public MasterUserAuthenticationType MasterUserAuthenticationType
        {
            get { return this._masterUserAuthenticationType; }
            set { this._masterUserAuthenticationType = value; }
        }

        // Check to see if MasterUserAuthenticationType property is set
        internal bool IsSetMasterUserAuthenticationType()
        {
            return this._masterUserAuthenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new password for the master user.
        /// </para>
        ///  
        /// <para>
        /// Changing this parameter doesn't result in an outage and the change is asynchronously
        /// applied as soon as possible. Between the time of the request and the completion of
        /// the request, the <c>MasterUserPassword</c> element exists in the <c>PendingModifiedValues</c>
        /// element of the operation response.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon RDS API operations never return the password, so this operation provides a
        /// way to regain access to a primary instance user if the password is lost. This includes
        /// restoring privileges that might have been accidentally revoked.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora
        /// </para>
        ///  
        /// <para>
        /// The password for the master user is managed by the DB cluster. For more information,
        /// see <c>ModifyDBCluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle CDBs in the multi-tenant configuration
        /// </para>
        ///  
        /// <para>
        /// Specify the master password in <c>ModifyTenantDatabase</c> instead.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <c>ManageMasterUserPassword</c> is turned on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can include any printable ASCII character except "/", """, or "@". For RDS for Oracle,
        /// can't include the "&amp;" (ampersand) or the "'" (single quotes) character.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Length Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RDS for Db2 - Must contain from 8 to 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MariaDB - Must contain from 8 to 41 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server - Must contain from 8 to 128 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - Must contain from 8 to 41 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle - Must contain from 8 to 30 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - Must contain from 8 to 128 characters.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property MasterUserSecretKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to encrypt a secret that is automatically
        /// generated and managed in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if both of the following conditions are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB instance doesn't manage the master user password in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the DB instance already manages the master user password in Amazon Web Services
        /// Secrets Manager, you can't change the KMS key used to encrypt the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are turning on <c>ManageMasterUserPassword</c> to manage the master user password
        /// in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// If you are turning on <c>ManageMasterUserPassword</c> and don't specify <c>MasterUserSecretKmsKeyId</c>,
        /// then the <c>aws/secretsmanager</c> KMS key is used to encrypt the secret. If the secret
        /// is in a different Amazon Web Services account, then you can't use the <c>aws/secretsmanager</c>
        /// KMS key to encrypt the secret, and you must use a customer managed KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// There is a default KMS key for your Amazon Web Services account. Your Amazon Web Services
        /// account has a different default KMS key for each Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string MasterUserSecretKmsKeyId
        {
            get { return this._masterUserSecretKmsKeyId; }
            set { this._masterUserSecretKmsKeyId = value; }
        }

        // Check to see if MasterUserSecretKmsKeyId property is set
        internal bool IsSetMasterUserSecretKmsKeyId()
        {
            return this._masterUserSecretKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit in gibibytes (GiB) to which Amazon RDS can automatically scale the
        /// storage of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information about this setting, including limitations that apply to it, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIOPS.StorageTypes.html#USER_PIOPS.Autoscaling">
        /// Managing capacity automatically with Amazon RDS storage autoscaling</a> in the <i>Amazon
        /// RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage
        {
            get { return this._maxAllocatedStorage; }
            set { this._maxAllocatedStorage = value; }
        }

        // Check to see if MaxAllocatedStorage property is set
        internal bool IsSetMaxAllocatedStorage()
        {
            return this._maxAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB instance. To disable collection of Enhanced Monitoring metrics, specify
        /// <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringRoleArn</c> is specified, set <c>MonitoringInterval</c> to a value
        /// other than <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>0 | 1 | 5 | 10 | 15 | 30 | 60</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        public int? MonitoringInterval
        {
            get { return this._monitoringInterval; }
            set { this._monitoringInterval = value; }
        }

        // Check to see if MonitoringInterval property is set
        internal bool IsSetMonitoringInterval()
        {
            return this._monitoringInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringRoleArn. 
        /// <para>
        /// The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to Amazon
        /// CloudWatch Logs. For example, <c>arn:aws:iam:123456789012:role/emaccess</c>. For information
        /// on creating a monitoring role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than <c>0</c>, supply a <c>MonitoringRoleArn</c>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn
        {
            get { return this._monitoringRoleArn; }
            set { this._monitoringRoleArn = value; }
        }

        // Check to see if MonitoringRoleArn property is set
        internal bool IsSetMonitoringRoleArn()
        {
            return this._monitoringRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether the DB instance is a Multi-AZ deployment. Changing this parameter
        /// doesn't result in an outage. The change is applied during the next maintenance window
        /// unless the <c>ApplyImmediately</c> parameter is enabled for this request.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Specifies whether the to convert your DB instance from the single-tenant conﬁguration
        /// to the multi-tenant conﬁguration. This parameter is supported only for RDS for Oracle
        /// CDB instances.
        /// </para>
        ///  
        /// <para>
        /// During the conversion, RDS creates an initial tenant database and associates the DB
        /// name, master user name, character set, and national character set metadata with this
        /// database. The tags associated with the instance also propagate to the initial tenant
        /// database. You can add more tenant databases to your DB instance by using the <c>CreateTenantDatabase</c>
        /// operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// The conversion to the multi-tenant configuration is permanent and irreversible, so
        /// you can't later convert back to the single-tenant configuration. When you specify
        /// this parameter, you must also specify <c>ApplyImmediately</c>.
        /// </para>
        ///  </important>
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB instance.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4 | DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType
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
        /// Gets and sets the property NewDBInstanceIdentifier. 
        /// <para>
        /// The new identifier for the DB instance when renaming a DB instance. When you change
        /// the DB instance identifier, an instance reboot occurs immediately if you enable <c>ApplyImmediately</c>,
        /// or will occur during the next maintenance window if you disable <c>ApplyImmediately</c>.
        /// This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mydbinstance</c> 
        /// </para>
        /// </summary>
        public string NewDBInstanceIdentifier
        {
            get { return this._newDBInstanceIdentifier; }
            set { this._newDBInstanceIdentifier = value; }
        }

        // Check to see if NewDBInstanceIdentifier property is set
        internal bool IsSetNewDBInstanceIdentifier()
        {
            return this._newDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group to associate the DB instance with.
        /// </para>
        ///  
        /// <para>
        /// Changing this parameter doesn't result in an outage, with one exception. If the parameter
        /// change results in an option group that enables OEM, it can cause a brief period, lasting
        /// less than a second, during which new connections are rejected but existing connections
        /// aren't interrupted.
        /// </para>
        ///  
        /// <para>
        /// The change is applied during the next maintenance window unless the <c>ApplyImmediately</c>
        /// parameter is enabled for this request.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can't
        /// be removed from an option group, and that option group can't be removed from a DB
        /// instance after it is associated with a DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of Performance Insights
        /// data.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>PerformanceInsightsKMSKeyId</c>, then Amazon RDS
        /// uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKMSKeyId
        {
            get { return this._performanceInsightsKMSKeyId; }
            set { this._performanceInsightsKMSKeyId = value; }
        }

        // Check to see if PerformanceInsightsKMSKeyId property is set
        internal bool IsSetPerformanceInsightsKMSKeyId()
        {
            return this._performanceInsightsKMSKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsRetentionPeriod. 
        /// <para>
        /// The number of days to retain Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>month</i> * 31, where <i>month</i> is a number of months from 1-23. Examples:
        /// <c>93</c> (3 months * 31), <c>341</c> (11 months * 31), <c>589</c> (19 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>731</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>7</c> days
        /// </para>
        ///  
        /// <para>
        /// If you specify a retention period that isn't valid, such as <c>94</c>, Amazon RDS
        /// returns an error.
        /// </para>
        /// </summary>
        public int? PerformanceInsightsRetentionPeriod
        {
            get { return this._performanceInsightsRetentionPeriod; }
            set { this._performanceInsightsRetentionPeriod = value; }
        }

        // Check to see if PerformanceInsightsRetentionPeriod property is set
        internal bool IsSetPerformanceInsightsRetentionPeriod()
        {
            return this._performanceInsightsRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, as determined by the <c>BackupRetentionPeriod</c> parameter. Changing
        /// this parameter doesn't result in an outage and the change is asynchronously applied
        /// as soon as possible. The default is a 30-minute window selected at random from an
        /// 8-hour block of time for each Amazon Web Services Region. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">Backup
        /// window</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The daily time range for
        /// creating automated backups is managed by the DB cluster. For more information, see
        /// <c>ModifyDBCluster</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <c>hh24:mi-hh24:mi</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
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
        /// The weekly time range during which system maintenance can occur, which might result
        /// in an outage. Changing this parameter doesn't result in an outage, except in the following
        /// situation, and the change is asynchronously applied as soon as possible. If there
        /// are pending actions that cause a reboot, and the maintenance window is changed to
        /// include the current time, then changing this parameter causes a reboot of the DB instance.
        /// If you change this window to the current time, there must be at least 30 minutes between
        /// the current time and end of the window to ensure pending changes are applied.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#Concepts.DBMaintenance">Amazon
        /// RDS Maintenance Window</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <c>ddd:hh24:mi-ddd:hh24:mi</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The day values must be <c>mon | tue | wed | thu | fri | sat | sun</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred backup window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The order of priority in which an Aurora Replica is promoted to the primary instance
        /// after a failure of the existing primary instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.AuroraHighAvailability.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>0 - 15</c> 
        /// </para>
        /// </summary>
        public int? PromotionTier
        {
            get { return this._promotionTier; }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance is publicly accessible and you connect from outside of the DB
        /// instance's virtual private cloud (VPC), its Domain Name System (DNS) endpoint resolves
        /// to the public IP address. When you connect from within the same VPC as the DB instance,
        /// the endpoint resolves to the private IP address. Access to the DB instance is ultimately
        /// controlled by the security group it uses. That public access isn't permitted if the
        /// security group assigned to the DB instance doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        ///  <c>PubliclyAccessible</c> only applies to DB instances in a VPC. The DB instance
        /// must be part of a public subnet and <c>PubliclyAccessible</c> must be enabled for
        /// it to be publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// Changes to the <c>PubliclyAccessible</c> parameter are applied immediately regardless
        /// of the value of the <c>ApplyImmediately</c> parameter.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaMode. 
        /// <para>
        /// The open mode of a replica database.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported for Db2 DB instances and Oracle DB instances.
        /// </para>
        ///  <dl> <dt>Db2</dt> <dd> 
        /// <para>
        /// Standby DB replicas are included in Db2 Advanced Edition (AE) and Db2 Standard Edition
        /// (SE). The main use case for standby replicas is cross-Region disaster recovery. Because
        /// it doesn't accept user connections, a standby replica can't serve a read-only workload.
        /// </para>
        ///  
        /// <para>
        /// You can create a combination of standby and read-only DB replicas for the same primary
        /// DB instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-replication.html">Working
        /// with replicas for Amazon RDS for Db2</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create standby DB replicas for RDS for Db2, set this parameter to <c>mounted</c>.
        /// </para>
        ///  </dd> <dt>Oracle</dt> <dd> 
        /// <para>
        /// Mounted DB replicas are included in Oracle Database Enterprise Edition. The main use
        /// case for mounted replicas is cross-Region disaster recovery. The primary database
        /// doesn't use Active Data Guard to transmit information to the mounted replica. Because
        /// it doesn't accept user connections, a mounted replica can't serve a read-only workload.
        /// </para>
        ///  
        /// <para>
        /// You can create a combination of mounted and read-only DB replicas for the same primary
        /// DB instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Working
        /// with read replicas for Amazon RDS for Oracle</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom, you must specify this parameter and set it to <c>mounted</c>. The
        /// value won't be set by default. After replica creation, you can manage the open mode
        /// manually.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReplicaMode ReplicaMode
        {
            get { return this._replicaMode; }
            set { this._replicaMode = value; }
        }

        // Check to see if ReplicaMode property is set
        internal bool IsSetReplicaMode()
        {
            return this._replicaMode != null;
        }

        /// <summary>
        /// Gets and sets the property ResumeFullAutomationModeMinutes. 
        /// <para>
        /// The number of minutes to pause the automation. When the time period ends, RDS Custom
        /// resumes full automation.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>60</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be at least 60.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be no more than 1,440.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? ResumeFullAutomationModeMinutes
        {
            get { return this._resumeFullAutomationModeMinutes; }
            set { this._resumeFullAutomationModeMinutes = value; }
        }

        // Check to see if ResumeFullAutomationModeMinutes property is set
        internal bool IsSetResumeFullAutomationModeMinutes()
        {
            return this._resumeFullAutomationModeMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotateMasterUserPassword. 
        /// <para>
        /// Specifies whether to rotate the secret managed by Amazon Web Services Secrets Manager
        /// for the master user password.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB instance. The secret value contains the updated
        /// password.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must apply the change immediately when rotating the master user password.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? RotateMasterUserPassword
        {
            get { return this._rotateMasterUserPassword; }
            set { this._rotateMasterUserPassword = value; }
        }

        // Check to see if RotateMasterUserPassword property is set
        internal bool IsSetRotateMasterUserPassword()
        {
            return this._rotateMasterUserPassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput value for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to the <c>gp3</c> storage type.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
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
        /// The storage type to associate with the DB instance.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>io1</c>, <c>io2</c>, or <c>gp3</c> you must also include a value
        /// for the <c>Iops</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you choose to migrate your DB instance from using standard storage to gp2 (General
        /// Purpose SSD), gp3, or Provisioned IOPS (io1), or from these storage types to standard
        /// storage, the process can take time. The duration of the migration depends on several
        /// factors such as database load, storage size, storage type (standard or Provisioned
        /// IOPS), amount of IOPS provisioned (if any), and the number of prior scale storage
        /// operations. Typical migration times are under 24 hours, but the process can take up
        /// to several days in some cases. During the migration, the DB instance is available
        /// for use, but might experience performance degradation. While the migration takes place,
        /// nightly backups for the instance are suspended. No other Amazon RDS operations can
        /// take place for the instance, including modifying the instance, rebooting the instance,
        /// deleting the instance, creating a read replica for the instance, and creating a DB
        /// snapshot of the instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2 | standard</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>io1</c>, if the <c>Iops</c> parameter is specified. Otherwise, <c>gp2</c>.
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
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which to associate the instance for TDE encryption.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Gets and sets the property TdeCredentialPassword. 
        /// <para>
        /// The password for the given ARN from the key store in order to access the device.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TdeCredentialPassword
        {
            get { return this._tdeCredentialPassword; }
            set { this._tdeCredentialPassword = value; }
        }

        // Check to see if TdeCredentialPassword property is set
        internal bool IsSetTdeCredentialPassword()
        {
            return this._tdeCredentialPassword != null;
        }

        /// <summary>
        /// Gets and sets the property UseDefaultProcessorFeatures. 
        /// <para>
        /// Specifies whether the DB instance class of the DB instance uses its default processor
        /// features.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? UseDefaultProcessorFeatures
        {
            get { return this._useDefaultProcessorFeatures; }
            set { this._useDefaultProcessorFeatures = value; }
        }

        // Check to see if UseDefaultProcessorFeatures property is set
        internal bool IsSetUseDefaultProcessorFeatures()
        {
            return this._useDefaultProcessorFeatures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of Amazon EC2 VPC security groups to associate with this DB instance. This
        /// change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora (The associated list of EC2 VPC security groups is managed by the DB
        /// cluster. For more information, see <c>ModifyDBCluster</c>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match existing VPC security group IDs.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}