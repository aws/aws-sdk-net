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
    /// Container for the parameters to the CreateDBCluster operation.
    /// Creates a new Amazon Aurora DB cluster or Multi-AZ DB cluster.
    /// 
    ///  
    /// <para>
    /// If you create an Aurora DB cluster, the request creates an empty cluster. You must
    /// explicitly create the writer instance for your DB cluster using the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html">CreateDBInstance</a>
    /// operation. If you create a Multi-AZ DB cluster, the request creates a writer and two
    /// reader DB instances for you, each in a different Availability Zone.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>ReplicationSourceIdentifier</c> parameter to create an Amazon Aurora
    /// DB cluster as a read replica of another DB cluster or Amazon RDS for MySQL or PostgreSQL
    /// DB instance. For more information about Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">What
    /// is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can also use the <c>ReplicationSourceIdentifier</c> parameter to create a Multi-AZ
    /// DB cluster read replica with an RDS for MySQL or PostgreSQL DB instance as the source.
    /// For more information about Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">Multi-AZ
    /// DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDBClusterRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _backtrackWindow;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private string _characterSetName;
        private ClusterScalabilityType _clusterScalabilityType;
        private bool? _copyTagsToSnapshot;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _databaseName;
        private string _dbClusterIdentifier;
        private string _dbClusterInstanceClass;
        private string _dbClusterParameterGroupName;
        private string _dbSubnetGroupName;
        private string _dbSystemId;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enableGlobalWriteForwarding;
        private bool? _enableHttpEndpoint;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enableLimitlessDatabase;
        private bool? _enableLocalWriteForwarding;
        private bool? _enablePerformanceInsights;
        private string _engine;
        private string _engineLifecycleSupport;
        private string _engineMode;
        private string _engineVersion;
        private string _globalClusterIdentifier;
        private int? _iops;
        private string _kmsKeyId;
        private bool? _manageMasterUserPassword;
        private MasterUserAuthenticationType _masterUserAuthenticationType;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _masterUserSecretKmsKeyId;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private string _networkType;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _preSignedUrl;
        private bool? _publiclyAccessible;
        private RdsCustomClusterConfiguration _rdsCustomClusterConfiguration;
        private string _replicationSourceIdentifier;
        private ScalingConfiguration _scalingConfiguration;
        private ServerlessV2ScalingConfiguration _serverlessV2ScalingConfiguration;
        private bool? _storageEncrypted;
        private string _storageType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
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
        ///  
        /// <para>
        /// This setting is required to create a Multi-AZ DB cluster.
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
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Specifies whether minor engine upgrades are applied automatically to the DB cluster
        /// during the maintenance window. By default, minor engine upgrades are applied automatically.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB cluster.
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones (AZs) where you specifically want to create DB instances
        /// in the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For the first three DB instances that you create, RDS distributes each DB instance
        /// to a different AZ that you specify. For additional DB instances that you create, RDS
        /// randomly distributes them to the AZs that you specified. For example, if you create
        /// a DB cluster with one writer instance and three reader instances, RDS might distribute
        /// the writer instance to AZ 1, the first reader instance to AZ 2, the second reader
        /// instance to AZ 3, and the third reader instance to either AZ 1, AZ 2, or AZ 3. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.RegionsAndAvailabilityZones.html#Concepts.RegionsAndAvailabilityZones.AvailabilityZones">Availability
        /// Zones</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.AuroraHighAvailability.html#Concepts.AuroraHighAvailability.Instances">High
        /// availability for Aurora DB instances</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't specify more than three AZs.
        /// </para>
        ///  </li> </ul>
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
        /// The number of days for which automated backups are retained.
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
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// The name of the character set (<c>CharacterSet</c>) to associate the DB cluster with.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
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
        /// Gets and sets the property ClusterScalabilityType. 
        /// <para>
        /// Specifies the scalability mode of the Aurora DB cluster. When set to <c>limitless</c>,
        /// the cluster operates as an Aurora Limitless Database. When set to <c>standard</c>
        /// (the default), the cluster uses normal DB instance creation.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't modify this setting after you create the DB cluster.
        /// </para>
        ///  </note>
        /// </summary>
        public ClusterScalabilityType ClusterScalabilityType
        {
            get { return this._clusterScalabilityType; }
            set { this._clusterScalabilityType = value; }
        }

        // Check to see if ClusterScalabilityType property is set
        internal bool IsSetClusterScalabilityType()
        {
            return this._clusterScalabilityType != null;
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
        /// The mode of Database Insights to enable for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If you set this value to <c>advanced</c>, you must also set the <c>PerformanceInsightsEnabled</c>
        /// parameter to <c>true</c> and the <c>PerformanceInsightsRetentionPeriod</c> parameter
        /// to 465.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name for your database of up to 64 alphanumeric characters. A database named <c>postgres</c>
        /// is always created. If this parameter is specified, an additional database with this
        /// name is created.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// The identifier for this DB cluster. This parameter is stored as a lowercase string.
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
        /// Must contain from 1 to 63 (for Aurora DB clusters) or 1 to 52 (for Multi-AZ DB clusters)
        /// letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster1</c> 
        /// </para>
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
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// instance class</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting is required to create a Multi-AZ DB cluster.
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
        /// The name of the DB cluster parameter group to associate with this DB cluster. If you
        /// don't specify a value, then the default DB cluster parameter group for the specified
        /// DB engine and version is used.
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
        /// If supplied, must match the name of an existing DB cluster parameter group.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// A DB subnet group to associate with this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is required to create a Multi-AZ DB cluster.
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
        /// Must match the name of an existing DB subnet group.
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
        /// Gets and sets the property DBSystemId. 
        /// <para>
        /// Reserved for future use.
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
        /// The Active Directory directory ID to create the DB cluster in.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Aurora DB clusters, Amazon RDS can use Kerberos authentication to authenticate
        /// users that connect to the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html">Kerberos
        /// authentication</a> in the <i>Amazon Aurora User Guide</i>.
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
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of log types that need to be enabled for exporting to CloudWatch Logs.
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
        /// For more information about exporting CloudWatch Logs for Amazon RDS, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableCloudwatchLogsExports
        {
            get { return this._enableCloudwatchLogsExports; }
            set { this._enableCloudwatchLogsExports = value; }
        }

        // Check to see if EnableCloudwatchLogsExports property is set
        internal bool IsSetEnableCloudwatchLogsExports()
        {
            return this._enableCloudwatchLogsExports != null && (this._enableCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Specifies whether to enable the HTTP endpoint for the DB cluster. By default, the
        /// HTTP endpoint isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// When enabled, the HTTP endpoint provides a connectionless web service API (RDS Data
        /// API) for running SQL queries on the DB cluster. You can also query your database from
        /// inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
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
        /// This setting is no longer used. Instead use the <c>ClusterScalabilityType</c> setting.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to use for this DB cluster.
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
        ///  <c>aurora-mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>neptune</c> - For information about using Amazon Neptune, see the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/intro.html">
        /// <i>Amazon Neptune User Guide</i> </a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The life cycle type for this DB cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, this value is set to <c>open-source-rds-extended-support</c>, which enrolls
        /// your DB cluster into Amazon RDS Extended Support. At the end of standard support,
        /// you can avoid charges for Extended Support by setting the value to <c>open-source-rds-extended-support-disabled</c>.
        /// In this case, creating the DB cluster will fail if the DB major version is past its
        /// end of standard support date.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use this setting to enroll your DB cluster into Amazon RDS Extended Support.
        /// With RDS Extended Support, you can run the selected major engine version on your DB
        /// cluster past the end of standard support for that engine version. For more information,
        /// see the following sections:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora - <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon Aurora</a> in the <i>Amazon Aurora User Guide</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon RDS - <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon RDS</a> in the <i>Amazon RDS User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>open-source-rds-extended-support | open-source-rds-extended-support-disabled</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>open-source-rds-extended-support</c> 
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport
        {
            get { return this._engineLifecycleSupport; }
            set { this._engineLifecycleSupport = value; }
        }

        // Check to see if EngineLifecycleSupport property is set
        internal bool IsSetEngineLifecycleSupport()
        {
            return this._engineLifecycleSupport != null;
        }

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The DB engine mode of the DB cluster, either <c>provisioned</c> or <c>serverless</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>serverless</c> engine mode only applies for Aurora Serverless v1 DB clusters.
        /// Aurora Serverless v2 DB clusters use the <c>provisioned</c> engine mode.
        /// </para>
        ///  
        /// <para>
        /// For information about limitations and requirements for Serverless DB clusters, see
        /// the following sections in the <i>Amazon Aurora User Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html#aurora-serverless.limitations">Limitations
        /// of Aurora Serverless v1</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.requirements.html">Requirements
        /// for Aurora Serverless v2</a> 
        /// </para>
        ///  </li> </ul> 
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
        /// The version number of the database engine to use.
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for Aurora MySQL version 2 (5.7-compatible)
        /// and version 3 (MySQL 8.0-compatible), use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-mysql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can supply either <c>5.7</c> or <c>8.0</c> to use the default engine version for
        /// Aurora MySQL version 2 or version 3, respectively.
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
        /// For information about a specific engine, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora MySQL - see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Updates.html">Database
        /// engine updates for Amazon Aurora MySQL</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora PostgreSQL - see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraPostgreSQL.Updates.20180305.html">Amazon
        /// Aurora PostgreSQL releases and engine versions</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MySQL.html#MySQL.Concepts.VersionMgmt">Amazon
        /// RDS for MySQL</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_PostgreSQL.html#PostgreSQL.Concepts">Amazon
        /// RDS for PostgreSQL</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> </ul> 
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
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The global cluster ID of an Aurora cluster that becomes the primary cluster in the
        /// new global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for each DB instance in the Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Provisioned
        /// IOPS storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting is required to create a Multi-AZ DB cluster.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for an encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// When a KMS key isn't specified in <c>KmsKeyId</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>ReplicationSourceIdentifier</c> identifies an encrypted source, then Amazon
        /// RDS uses the KMS key used to encrypt the source. Otherwise, Amazon RDS uses your default
        /// KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>StorageEncrypted</c> parameter is enabled and <c>ReplicationSourceIdentifier</c>
        /// isn't specified, then Amazon RDS uses your default KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// There is a default KMS key for your Amazon Web Services account. Your Amazon Web Services
        /// account has a different default KMS key for each Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// If you create a read replica of an encrypted DB cluster in another Amazon Web Services
        /// Region, make sure to set <c>KmsKeyId</c> to a KMS key identifier that is valid in
        /// the destination Amazon Web Services Region. This KMS key is used to encrypt the read
        /// replica in that Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager.
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
        /// Can't manage the master user password with Amazon Web Services Secrets Manager if
        /// <c>MasterUserPassword</c> is specified.
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
        /// you can configure the master DB user with IAM database authentication when you create
        /// a DB cluster.
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
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The name of the master user for the DB cluster.
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
        /// Must be 1 to 16 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a reserved word for the chosen database engine.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The password for the master database user.
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
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>MasterUserSecretKmsKeyId</c>, then the <c>aws/secretsmanager</c>
        /// KMS key is used to encrypt the secret. If the secret is in a different Amazon Web
        /// Services account, then you can't use the <c>aws/secretsmanager</c> KMS key to encrypt
        /// the secret, and you must use a customer managed KMS key.
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
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// For information on creating a monitoring role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html#USER_Monitoring.OS.Enabling">Setting
        /// up and enabling Enhanced Monitoring</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than <c>0</c>, supply a <c>MonitoringRoleArn</c>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// The port number on which the instances in the DB cluster accept connections.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// RDS for MySQL and Aurora MySQL - <c>3306</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL and Aurora PostgreSQL - <c>5432</c> 
        /// </para>
        ///  </li> </ul>
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
        /// are enabled using the <c>BackupRetentionPeriod</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region. To view the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Managing.Backups.html#Aurora.Managing.Backups.BackupWindow">
        /// Backup window</a> in the <i>Amazon Aurora User Guide</i>.
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
        /// The weekly time range during which system maintenance can occur.
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
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// When you are replicating a DB cluster from one Amazon Web Services GovCloud (US) Region
        /// to another, an URL that contains a Signature Version 4 signed request for the <c>CreateDBCluster</c>
        /// operation to be called in the source Amazon Web Services Region where the DB cluster
        /// is replicated from. Specify <c>PreSignedUrl</c> only when you are performing cross-Region
        /// replication from an encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <c>CreateDBCluster</c> API operation
        /// that can run in the source Amazon Web Services Region that contains the encrypted
        /// DB cluster to copy.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL request must contain the following parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsKeyId</c> - The KMS key identifier for the KMS key to use to encrypt the copy
        /// of the DB cluster in the destination Amazon Web Services Region. This should refer
        /// to the same KMS key for both the <c>CreateDBCluster</c> operation that is called in
        /// the destination Amazon Web Services Region, and the operation contained in the presigned
        /// URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DestinationRegion</c> - The name of the Amazon Web Services Region that Aurora
        /// read replica will be created in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplicationSourceIdentifier</c> - The DB cluster identifier for the encrypted
        /// DB cluster to be copied. This identifier must be in the Amazon Resource Name (ARN)
        /// format for the source Amazon Web Services Region. For example, if you are copying
        /// an encrypted DB cluster from the us-west-2 Amazon Web Services Region, then your <c>ReplicationSourceIdentifier</c>
        /// would look like Example: <c>arn:aws:rds:us-west-2:123456789012:cluster:aurora-cluster1</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (Amazon Web Services Signature Version
        /// 4)</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
        /// Signature Version 4 Signing Process</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an Amazon Web Services SDK tool or the CLI, you can specify <c>SourceRegion</c>
        /// (or <c>--source-region</c> for the CLI) instead of specifying <c>PreSignedUrl</c>
        /// manually. Specifying <c>SourceRegion</c> autogenerates a presigned URL that is a valid
        /// request for the operation that can run in the source Amazon Web Services Region.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB cluster is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster is publicly accessible and you connect from outside of the DB
        /// cluster's virtual private cloud (VPC), its Domain Name System (DNS) endpoint resolves
        /// to the public IP address. When you connect from within the same VPC as the DB cluster,
        /// the endpoint resolves to the private IP address. Access to the DB cluster is ultimately
        /// controlled by the security group it uses. That public access isn't permitted if the
        /// security group assigned to the DB cluster doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster isn't publicly accessible, it is an internal DB cluster with a
        /// DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Default: The default behavior varies depending on whether <c>DBSubnetGroupName</c>
        /// is specified.
        /// </para>
        ///  
        /// <para>
        /// If <c>DBSubnetGroupName</c> isn't specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the default VPC in the target Region doesn’t have an internet gateway attached
        /// to it, the DB cluster is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the default VPC in the target Region has an internet gateway attached to it, the
        /// DB cluster is public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBSubnetGroupName</c> is specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the subnets are part of a VPC that doesn’t have an internet gateway attached to
        /// it, the DB cluster is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the subnets are part of a VPC that has an internet gateway attached to it, the
        /// DB cluster is public.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property RdsCustomClusterConfiguration. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public RdsCustomClusterConfiguration RdsCustomClusterConfiguration
        {
            get { return this._rdsCustomClusterConfiguration; }
            set { this._rdsCustomClusterConfiguration = value; }
        }

        // Check to see if RdsCustomClusterConfiguration property is set
        internal bool IsSetRdsCustomClusterConfiguration()
        {
            return this._rdsCustomClusterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSourceIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source DB instance or DB cluster if this DB
        /// cluster is created as a read replica.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string ReplicationSourceIdentifier
        {
            get { return this._replicationSourceIdentifier; }
            set { this._replicationSourceIdentifier = value; }
        }

        // Check to see if ReplicationSourceIdentifier property is set
        internal bool IsSetReplicationSourceIdentifier()
        {
            return this._replicationSourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// For DB clusters in <c>serverless</c> DB engine mode, the scaling properties of the
        /// DB cluster.
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
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB cluster is encrypted.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// This setting is required to create a Multi-AZ DB cluster.
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
        ///  </li> </ul> <note> 
        /// <para>
        /// When you create an Aurora DB cluster with the storage type set to <c>aurora-iopt1</c>,
        /// the storage type is returned in the response. The storage type isn't returned when
        /// you set it to <c>aurora</c>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the DB cluster.
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
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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