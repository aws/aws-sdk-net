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
    /// Container for the parameters to the ModifyDBCluster operation.
    /// Modifies the settings of an Amazon Aurora DB cluster or a Multi-AZ DB cluster. You
    /// can change one or more settings by specifying these parameters and the new values
    /// in the request.
    /// 
    ///  
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyDBClusterRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _allowEngineModeChange;
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private bool? _autoMinorVersionUpgrade;
        private string _awsBackupRecoveryPointArn;
        private long? _backtrackWindow;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private CloudwatchLogsExportConfiguration _cloudwatchLogsExportConfiguration;
        private bool? _copyTagsToSnapshot;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _dbClusterIdentifier;
        private string _dbClusterInstanceClass;
        private string _dbClusterParameterGroupName;
        private string _dbInstanceParameterGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private bool? _enableGlobalWriteForwarding;
        private bool? _enableHttpEndpoint;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enableLimitlessDatabase;
        private bool? _enableLocalWriteForwarding;
        private bool? _enablePerformanceInsights;
        private string _engineMode;
        private string _engineVersion;
        private int? _iops;
        private bool? _manageMasterUserPassword;
        private MasterUserAuthenticationType _masterUserAuthenticationType;
        private string _masterUserPassword;
        private string _masterUserSecretKmsKeyId;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private string _networkType;
        private string _newDBClusterIdentifier;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _rotateMasterUserPassword;
        private ScalingConfiguration _scalingConfiguration;
        private ServerlessV2ScalingConfiguration _serverlessV2ScalingConfiguration;
        private string _storageType;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) to allocate to each DB instance in the Multi-AZ
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
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
        /// Gets and sets the property AllowEngineModeChange. 
        /// <para>
        /// Specifies whether engine mode changes from <c>serverless</c> to <c>provisioned</c>
        /// are allowed.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora Serverless v1 DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must allow engine mode changes when specifying a different value for the <c>EngineMode</c>
        /// parameter from the DB cluster's current engine mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? AllowEngineModeChange
        {
            get { return this._allowEngineModeChange; }
            set { this._allowEngineModeChange = value; }
        }

        // Check to see if AllowEngineModeChange property is set
        internal bool IsSetAllowEngineModeChange()
        {
            return this._allowEngineModeChange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// Specifies whether major version upgrades are allowed.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must allow major version upgrades when specifying a value for the <c>EngineVersion</c>
        /// parameter that is a different major version than the DB cluster's current version.
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
        /// Specifies whether the modifications in this request are asynchronously applied as
        /// soon as possible, regardless of the <c>PreferredMaintenanceWindow</c> setting for
        /// the DB cluster. If this parameter is disabled, changes to the DB cluster are applied
        /// during the next maintenance window.
        /// </para>
        ///  
        /// <para>
        /// Most modifications can be applied immediately or during the next scheduled maintenance
        /// window. Some modifications, such as turning on deletion protection and changing the
        /// master password, are applied immediately—regardless of when you choose to apply them.
        /// </para>
        ///  
        /// <para>
        /// By default, this parameter is disabled.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Specifies whether minor engine upgrades are applied automatically to the DB cluster
        /// during the maintenance window. By default, minor engine upgrades are applied automatically.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters.
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
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. To disable backtracking, set this value to
        /// <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora MySQL DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If specified, this value must be set to a number from 0 to 259,200 (72 hours).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? BacktrackWindow
        {
            get { return this._backtrackWindow; }
            set { this._backtrackWindow = value; }
        }

        // Check to see if BacktrackWindow property is set
        internal bool IsSetBacktrackWindow()
        {
            return this._backtrackWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained. Specify a minimum value
        /// of <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a value from 1 to 35.
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
        /// The CA certificate identifier to use for the DB cluster's server certificate.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters
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
        /// Gets and sets the property CloudwatchLogsExportConfiguration. 
        /// <para>
        /// The configuration setting for the log types to be enabled for export to CloudWatch
        /// Logs for a specific DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// The following values are valid for each DB engine:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora MySQL - <c>audit | error | general | instance | slowquery | iam-db-auth-error</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora PostgreSQL - <c>instance | postgresql | iam-db-auth-error</c> 
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
        /// Specifies whether to copy all tags from the DB cluster to snapshots of the DB cluster.
        /// The default is not to copy them.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Specifies the mode of Database Insights to enable for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If you change the value from <c>standard</c> to <c>advanced</c>, you must set the
        /// <c>PerformanceInsightsEnabled</c> parameter to <c>true</c> and the <c>PerformanceInsightsRetentionPeriod</c>
        /// parameter to 465.
        /// </para>
        ///  
        /// <para>
        /// If you change the value from <c>advanced</c> to <c>standard</c>, you can set the <c>PerformanceInsightsEnabled</c>
        /// parameter to <c>true</c> to collect detailed database counter and per-query metrics.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the cluster being modified. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DBClusterInstanceClass. 
        /// <para>
        /// The compute and memory capacity of each DB instance in the Multi-AZ DB cluster, for
        /// example <c>db.m6gd.xlarge</c>. Not all DB instance classes are available in all Amazon
        /// Web Services Regions, or for all database engines.
        /// </para>
        ///  
        /// <para>
        /// For the full list of DB instance classes and availability for your engine, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">
        /// DB Instance Class</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        /// </summary>
        public string DBClusterInstanceClass
        {
            get { return this._dbClusterInstanceClass; }
            set { this._dbClusterInstanceClass = value; }
        }

        // Check to see if DBClusterInstanceClass property is set
        internal bool IsSetDBClusterInstanceClass()
        {
            return this._dbClusterInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to use for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to apply to all instances of the DB cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you apply a parameter group using the <c>DBInstanceParameterGroupName</c> parameter,
        /// the DB cluster isn't rebooted automatically. Also, parameter changes are applied immediately
        /// rather than during the next maintenance window.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Default: The existing name setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB parameter group must be in the same DB parameter group family as this DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DBInstanceParameterGroupName</c> parameter is valid in combination with the
        /// <c>AllowMajorVersionUpgrade</c> parameter for a major version upgrade only.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBInstanceParameterGroupName
        {
            get { return this._dbInstanceParameterGroupName; }
            set { this._dbInstanceParameterGroupName = value; }
        }

        // Check to see if DBInstanceParameterGroupName property is set
        internal bool IsSetDBInstanceParameterGroupName()
        {
            return this._dbInstanceParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the DB cluster has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled. By default, deletion protection isn't
        /// enabled.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Active Directory directory ID to move the DB cluster to. Specify <c>none</c> to
        /// remove the cluster from its current domain. The domain must be created prior to this
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html">Kerberos
        /// Authentication</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
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
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// The name of the IAM role to use when making API calls to the Directory Service.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
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
        /// Gets and sets the property EnableGlobalWriteForwarding. 
        /// <para>
        /// Specifies whether to enable this DB cluster to forward write operations to the primary
        /// cluster of a global cluster (Aurora global database). By default, write operations
        /// are not allowed on Aurora DB clusters that are secondary clusters in an Aurora global
        /// database.
        /// </para>
        ///  
        /// <para>
        /// You can set this value only on Aurora DB clusters that are members of an Aurora global
        /// database. With this parameter enabled, a secondary cluster can forward writes to the
        /// current primary cluster, and the resulting changes are replicated back to this cluster.
        /// For the primary DB cluster of an Aurora global database, this value is used immediately
        /// if the primary is demoted by a global cluster API operation, but it does nothing until
        /// then.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? EnableGlobalWriteForwarding
        {
            get { return this._enableGlobalWriteForwarding; }
            set { this._enableGlobalWriteForwarding = value; }
        }

        // Check to see if EnableGlobalWriteForwarding property is set
        internal bool IsSetEnableGlobalWriteForwarding()
        {
            return this._enableGlobalWriteForwarding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableHttpEndpoint. 
        /// <para>
        /// Specifies whether to enable the HTTP endpoint for an Aurora Serverless v1 DB cluster.
        /// By default, the HTTP endpoint isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// When enabled, the HTTP endpoint provides a connectionless web service API (RDS Data
        /// API) for running SQL queries on the Aurora Serverless v1 DB cluster. You can also
        /// query your database from inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter applies only to Aurora Serverless v1 DB clusters. To enable or disable
        /// the HTTP endpoint for an Aurora Serverless v2 or provisioned DB cluster, use the <c>EnableHttpEndpoint</c>
        /// and <c>DisableHttpEndpoint</c> operations.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? EnableHttpEndpoint
        {
            get { return this._enableHttpEndpoint; }
            set { this._enableHttpEndpoint = value; }
        }

        // Check to see if EnableHttpEndpoint property is set
        internal bool IsSetEnableHttpEndpoint()
        {
            return this._enableHttpEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// Specifies whether to enable mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication</a> in the <i>Amazon Aurora User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">IAM
        /// database authentication for MariaDB, MySQL, and PostgreSQL</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property EnableLimitlessDatabase. 
        /// <para>
        /// Specifies whether to enable Aurora Limitless Database. You must enable Aurora Limitless
        /// Database to create a DB shard group.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is no longer used. Instead use the <c>ClusterScalabilityType</c> setting
        /// when you create your Aurora Limitless Database DB cluster.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EnableLimitlessDatabase
        {
            get { return this._enableLimitlessDatabase; }
            set { this._enableLimitlessDatabase = value; }
        }

        // Check to see if EnableLimitlessDatabase property is set
        internal bool IsSetEnableLimitlessDatabase()
        {
            return this._enableLimitlessDatabase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableLocalWriteForwarding. 
        /// <para>
        /// Specifies whether read replicas can forward write operations to the writer DB instance
        /// in the DB cluster. By default, write operations aren't allowed on reader DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? EnableLocalWriteForwarding
        {
            get { return this._enableLocalWriteForwarding; }
            set { this._enableLocalWriteForwarding = value; }
        }

        // Check to see if EnableLocalWriteForwarding property is set
        internal bool IsSetEnableLocalWriteForwarding()
        {
            return this._enableLocalWriteForwarding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// Specifies whether to turn on Performance Insights for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">
        /// Using Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The DB engine mode of the DB cluster, either <c>provisioned</c> or <c>serverless</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The DB engine mode can be modified only from <c>serverless</c> to <c>provisioned</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBCluster.html">
        /// CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
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
        /// The version number of the database engine to which you want to upgrade. Changing this
        /// parameter results in an outage. The change is applied during the next maintenance
        /// window unless <c>ApplyImmediately</c> is enabled.
        /// </para>
        ///  
        /// <para>
        /// If the cluster that you're modifying has one or more read replicas, all replicas must
        /// be running an engine version that's the same or later than the version you specify.
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for Aurora MySQL, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-mysql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for Aurora PostgreSQL, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-postgresql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for RDS for MySQL, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine mysql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for RDS for PostgreSQL, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine postgres --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for each DB instance in the Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Amazon
        /// RDS Provisioned IOPS storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a multiple between .5 and 50 of the storage amount for the DB cluster.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster doesn't manage the master user password with Amazon Web Services
        /// Secrets Manager, you can turn on this management. In this case, you can't specify
        /// <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster already manages the master user password with Amazon Web Services
        /// Secrets Manager, and you specify that the master user password is not managed with
        /// Amazon Web Services Secrets Manager, then you must specify <c>MasterUserPassword</c>.
        /// In this case, RDS deletes the secret and uses the new password for the master user
        /// specified by <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
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
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
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
        /// The new password for the master database user.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 8 to 41 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can contain any printable ASCII character except "/", """, or "@".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if <c>ManageMasterUserPassword</c> is turned on.
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
        /// The DB cluster doesn't manage the master user password in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster already manages the master user password in Amazon Web Services
        /// Secrets Manager, you can't change the KMS key that is used to encrypt the secret.
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
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB cluster. To turn off collecting Enhanced Monitoring metrics, specify <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringRoleArn</c> is specified, also set <c>MonitoringInterval</c> to a
        /// value other than <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
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
        /// The Amazon Resource Name (ARN) for the IAM role that permits RDS to send Enhanced
        /// Monitoring metrics to Amazon CloudWatch Logs. An example is <c>arn:aws:iam:123456789012:role/emaccess</c>.
        /// For information on creating a monitoring role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
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
        /// Valid for Cluster Type: Multi-AZ DB clusters only
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
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
        /// Gets and sets the property NewDBClusterIdentifier. 
        /// <para>
        /// The new DB cluster identifier for the DB cluster when renaming a DB cluster. This
        /// value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Example: <c>my-cluster2</c> 
        /// </para>
        /// </summary>
        public string NewDBClusterIdentifier
        {
            get { return this._newDBClusterIdentifier; }
            set { this._newDBClusterIdentifier = value; }
        }

        // Check to see if NewDBClusterIdentifier property is set
        internal bool IsSetNewDBClusterIdentifier()
        {
            return this._newDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group to associate the DB cluster with.
        /// </para>
        ///  
        /// <para>
        /// DB clusters are associated with a default option group that can't be modified.
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
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// issues an error.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the DB cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original DB cluster.
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
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, using the <c>BackupRetentionPeriod</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region. To view the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Managing.Backups.html#Aurora.Managing.Backups.BackupWindow">
        /// Backup window</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week. To see
        /// the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow.Aurora">
        /// Adjusting the Preferred DB Cluster Maintenance Window</a> in the <i>Amazon Aurora
        /// User Guide</i>.
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
        /// Days must be one of <c>Mon | Tue | Wed | Thu | Fri | Sat | Sun</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
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
        /// Gets and sets the property RotateMasterUserPassword. 
        /// <para>
        /// Specifies whether to rotate the secret managed by Amazon Web Services Secrets Manager
        /// for the master user password.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB cluster. The secret value contains the updated
        /// password.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// The scaling properties of the DB cluster. You can only modify scaling properties for
        /// DB clusters in <c>serverless</c> DB engine mode.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public ScalingConfiguration ScalingConfiguration
        {
            get { return this._scalingConfiguration; }
            set { this._scalingConfiguration = value; }
        }

        // Check to see if ScalingConfiguration property is set
        internal bool IsSetScalingConfiguration()
        {
            return this._scalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration.
        /// </summary>
        public ServerlessV2ScalingConfiguration ServerlessV2ScalingConfiguration
        {
            get { return this._serverlessV2ScalingConfiguration; }
            set { this._serverlessV2ScalingConfiguration = value; }
        }

        // Check to see if ServerlessV2ScalingConfiguration property is set
        internal bool IsSetServerlessV2ScalingConfiguration()
        {
            return this._serverlessV2ScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type to associate with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information on storage types for Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Overview.StorageReliability.html#aurora-storage-type">Storage
        /// configurations for Amazon Aurora DB clusters</a>. For information on storage types
        /// for Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/create-multi-az-db-cluster.html#create-multi-az-db-cluster-settings">Settings
        /// for creating Multi-AZ DB clusters</a>.
        /// </para>
        ///  
        /// <para>
        /// When specified for a Multi-AZ DB cluster, a value for the <c>Iops</c> parameter is
        /// required.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora DB clusters - <c>aurora | aurora-iopt1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-AZ DB clusters - <c>io1 | io2 | gp3</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora DB clusters - <c>aurora</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-AZ DB clusters - <c>io1</c> 
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
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