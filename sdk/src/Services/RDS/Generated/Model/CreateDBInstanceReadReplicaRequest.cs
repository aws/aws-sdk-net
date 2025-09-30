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
    /// Container for the parameters to the CreateDBInstanceReadReplica operation.
    /// Creates a new DB instance that acts as a read replica for an existing source DB instance
    /// or Multi-AZ DB cluster. You can create a read replica for a DB instance running Db2,
    /// MariaDB, MySQL, Oracle, PostgreSQL, or SQL Server. You can create a read replica for
    /// a Multi-AZ DB cluster running MySQL or PostgreSQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
    /// with read replicas</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html#multi-az-db-clusters-migrating-to-instance-with-read-replica">Migrating
    /// from a Multi-AZ DB cluster to a DB instance using a read replica</a> in the <i>Amazon
    /// RDS User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Amazon Aurora doesn't support this operation. To create a DB instance for an Aurora
    /// DB cluster, use the <c>CreateDBInstance</c> operation.
    /// </para>
    ///  
    /// <para>
    /// RDS creates read replicas with backups disabled. All other attributes (including DB
    /// security groups and DB parameter groups) are inherited from the source DB instance
    /// or cluster, except as specified.
    /// </para>
    ///  <important> 
    /// <para>
    /// Your source DB instance or cluster must have backup retention enabled.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateDBInstanceReadReplicaRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private string _backupTarget;
        private string _caCertificateIdentifier;
        private bool? _copyTagsToSnapshot;
        private string _customIamInstanceProfile;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbParameterGroupName;
        private string _dbSubnetGroupName;
        private bool? _dedicatedLogVolume;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainAuthSecretArn;
        private List<string> _domainDnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainFqdn;
        private string _domainIAMRoleName;
        private string _domainOu;
        private List<string> _enableCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enableCustomerOwnedIp;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private int? _iops;
        private string _kmsKeyId;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _networkType;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preSignedUrl;
        private List<ProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;
        private bool? _publiclyAccessible;
        private ReplicaMode _replicaMode;
        private string _sourceDBClusterIdentifier;
        private string _sourceDBInstanceIdentifier;
        private int? _storageThroughput;
        private string _storageType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _upgradeStorageConfig;
        private bool? _useDefaultProcessorFeatures;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceReadReplicaRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceReadReplicaRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier of the read replica. This identifier is the unique key that identifies a DB instance. This parameter is stored as a lowercase string.</param>
        /// <param name="sourceDBInstanceIdentifier">The identifier of the DB instance that will act as the source for the read replica. Each DB instance can have up to 15 read replicas, except for the following engines: <ul> <li> Db2 - Can have up to three replicas. </li> <li> Oracle - Can have up to five read replicas. </li> <li> SQL Server - Can have up to five read replicas. </li> </ul> Constraints: <ul> <li> Must be the identifier of an existing Db2, MariaDB, MySQL, Oracle, PostgreSQL, or SQL Server DB instance. </li> <li> Can't be specified if the <c>SourceDBClusterIdentifier</c> parameter is also specified. </li> <li> For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.limitations.html#oracle-read-replicas.limitations.versions-and-licenses">Version and licensing considerations for RDS for Oracle replicas</a> in the <i>Amazon RDS User Guide</i>. </li> <li> For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.html#SQLServer.ReadReplicas.Limitations">Read replica limitations with SQL Server</a> in the <i>Amazon RDS User Guide</i>. </li> <li> The specified DB instance must have automatic backups enabled, that is, its backup retention period must be greater than 0. </li> <li> If the source DB instance is in the same Amazon Web Services Region as the read replica, specify a valid DB instance identifier. </li> <li> If the source DB instance is in a different Amazon Web Services Region from the read replica, specify a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply to SQL Server or RDS Custom, which don't support cross-Region replicas. </li> </ul></param>
        public CreateDBInstanceReadReplicaRequest(string dbInstanceIdentifier, string sourceDBInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
            _sourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gibibytes) to allocate initially for the read replica. Follow
        /// the allocation rules specified in <c>CreateDBInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting isn't valid for RDS for SQL Server.
        /// </para>
        ///  <note> 
        /// <para>
        /// Be sure to allocate enough storage for your read replica so that the create operation
        /// can succeed. You can also allocate additional storage for future growth.
        /// </para>
        ///  </note>
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
        /// Specifies whether to automatically apply minor engine upgrades to the read replica
        /// during the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits the value from the source DB instance.
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone (AZ) where the read replica will be created.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>us-east-1d</c> 
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
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// The location where RDS stores automated backups and manual snapshots.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>local</c> for Dedicated Local Zones
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region</c> for Amazon Web Services Region
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string BackupTarget
        {
            get { return this._backupTarget; }
            set { this._backupTarget = value; }
        }

        // Check to see if BackupTarget property is set
        internal bool IsSetBackupTarget()
        {
            return this._backupTarget != null;
        }

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The CA certificate identifier to use for the read replica's server certificate.
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the read replica to snapshots of the read
        /// replica. By default, tags aren't copied.
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
        /// Gets and sets the property CustomIamInstanceProfile. 
        /// <para>
        /// The instance profile associated with the underlying Amazon EC2 instance of an RDS
        /// Custom DB instance. The instance profile must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The profile must exist in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The profile must have an IAM role that Amazon EC2 has permissions to assume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance profile name and the associated IAM role name must start with the prefix
        /// <c>AWSRDSCustom</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of permissions required for the IAM role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-setup-orcl.html#custom-setup-orcl.iam-vpc">
        /// Configure IAM and your VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting is required for RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string CustomIamInstanceProfile
        {
            get { return this._customIamInstanceProfile; }
            set { this._customIamInstanceProfile = value; }
        }

        // Check to see if CustomIamInstanceProfile property is set
        internal bool IsSetCustomIamInstanceProfile()
        {
            return this._customIamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// The mode of Database Insights to enable for the read replica.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting isn't supported.
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
        /// The compute and memory capacity of the read replica, for example db.m4.large. Not
        /// all DB instance classes are available in all Amazon Web Services Regions, or for all
        /// database engines. For the full list of DB instance classes, and availability for your
        /// engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits the value from the source DB instance.
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
        /// The DB instance identifier of the read replica. This identifier is the unique key
        /// that identifies a DB instance. This parameter is stored as a lowercase string.
        /// </para>
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
        /// The name of the DB parameter group to associate with this read replica DB instance.
        /// </para>
        ///  
        /// <para>
        /// For the Db2 DB engine, if your source DB instance uses the bring your own license
        /// (BYOL) model, then a custom parameter group must be associated with the replica. For
        /// a same Amazon Web Services Region replica, if you don't specify a custom parameter
        /// group, Amazon RDS associates the custom parameter group associated with the source
        /// DB instance. For a cross-Region replica, you must specify a custom parameter group.
        /// This custom parameter group must include your IBM Site ID and IBM Customer ID. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-licensing.html#db2-prereqs-ibm-info">IBM
        /// IDs for bring your own license (BYOL) for Db2</a>. 
        /// </para>
        ///  
        /// <para>
        /// For Single-AZ or Multi-AZ DB instance read replica instances, if you don't specify
        /// a value for <c>DBParameterGroupName</c>, then Amazon RDS uses the <c>DBParameterGroup</c>
        /// of the source DB instance for a same Region read replica, or the default <c>DBParameterGroup</c>
        /// for the specified DB engine for a cross-Region read replica.
        /// </para>
        ///  
        /// <para>
        /// For Multi-AZ DB cluster same Region read replica instances, if you don't specify a
        /// value for <c>DBParameterGroupName</c>, then Amazon RDS uses the default <c>DBParameterGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// Specifying a parameter group for this operation is only supported for MySQL DB instances
        /// for cross-Region read replicas, for Multi-AZ DB cluster read replica instances, for
        /// Db2 DB instances, and for Oracle DB instances. It isn't supported for MySQL DB instances
        /// for same Region read replicas or for RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
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
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// A DB subnet group for the DB instance. The new DB instance is created in the VPC associated
        /// with the DB subnet group. If no DB subnet group is specified, then the new DB instance
        /// isn't created in a VPC.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB subnet group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB subnet group must be in the same Amazon Web Services Region in which
        /// the operation is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All read replicas in one Amazon Web Services Region that are created from the same
        /// source DB instance must either:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify DB subnet groups from the same VPC. All these read replicas are created in
        /// the same VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not specify a DB subnet group. All these read replicas are created outside of any
        /// VPC.
        /// </para>
        ///  </li> </ul> </li> </ul> 
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
        /// Specifies whether to enable deletion protection for the DB instance. The database
        /// can't be deleted when deletion protection is enabled. By default, deletion protection
        /// isn't enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
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
        /// The Active Directory directory ID to create the DB instance in. Currently, only MySQL,
        /// Microsoft SQL Server, Oracle, and PostgreSQL DB instances can be created in an Active
        /// Directory Domain.
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
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of logs that the new DB instance is to export to CloudWatch Logs. The values
        /// in the list depend on the DB engine being used. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs </a> in the <i>Amazon RDS User Guide</i>.
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
        /// Gets and sets the property EnableCustomerOwnedIp. 
        /// <para>
        /// Specifies whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts
        /// read replica.
        /// </para>
        ///  
        /// <para>
        /// A <i>CoIP</i> provides local or external connectivity to resources in your Outpost
        /// subnets through your on-premises network. For some use cases, a CoIP can provide lower
        /// latency for connections to the read replica from outside of its virtual private cloud
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
        /// For more information about IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide</i>.
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
        /// Specifies whether to enable Performance Insights for the read replica.
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
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to initially allocate
        /// for the DB instance.
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
        /// The Amazon Web Services KMS key identifier for an encrypted read replica.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If you create an encrypted read replica in the same Amazon Web Services Region as
        /// the source DB instance or Multi-AZ DB cluster, don't specify a value for this parameter.
        /// A read replica in the same Amazon Web Services Region is always encrypted with the
        /// same KMS key as the source DB instance or cluster.
        /// </para>
        ///  
        /// <para>
        /// If you create an encrypted read replica in a different Amazon Web Services Region,
        /// then you must specify a KMS key identifier for the destination Amazon Web Services
        /// Region. KMS keys are specific to the Amazon Web Services Region that they are created
        /// in, and you can't use KMS keys from one Amazon Web Services Region in another Amazon
        /// Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// You can't create an encrypted read replica from an unencrypted DB instance or Multi-AZ
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom, which uses the same KMS key as the primary
        /// replica.
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
        /// for the read replica. To disable collection of Enhanced Monitoring metrics, specify
        /// <c>0</c>. The default is <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringRoleArn</c> is specified, then you must set <c>MonitoringInterval</c>
        /// to a value other than <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>0, 1, 5, 10, 15, 30, 60</c> 
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
        /// on creating a monitoring role, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than 0, then you must supply
        /// a <c>MonitoringRoleArn</c> value.
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
        /// Specifies whether the read replica is in a Multi-AZ deployment.
        /// </para>
        ///  
        /// <para>
        /// You can create a read replica as a Multi-AZ DB instance. RDS creates a standby of
        /// your replica in another Availability Zone for failover support for the replica. Creating
        /// your read replica as a Multi-AZ DB instance is independent of whether the source is
        /// a Multi-AZ DB instance or a Multi-AZ DB cluster.
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for read replica.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i> 
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
        /// The option group to associate the DB instance with. If not specified, RDS uses the
        /// option group associated with the source DB instance or cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// For SQL Server, you must use the option group associated with the source.
        /// </para>
        ///  </note> 
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
        /// If you do not specify a value for <c>PerformanceInsightsKMSKeyId</c>, then Amazon
        /// RDS uses your default KMS key. There is a default KMS key for your Amazon Web Services
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number that the DB instance uses for connections.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits the value from the source DB instance.
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
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// When you are creating a read replica from one Amazon Web Services GovCloud (US) Region
        /// to another or from one China Amazon Web Services Region to another, the URL that contains
        /// a Signature Version 4 signed request for the <c>CreateDBInstanceReadReplica</c> API
        /// operation in the source Amazon Web Services Region that contains the source DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to Amazon Web Services GovCloud (US) Regions and China Amazon
        /// Web Services Regions. It's ignored in other Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only when replicating from a source DB <i>instance</i>. Source
        /// DB clusters aren't supported in Amazon Web Services GovCloud (US) Regions and China
        /// Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter when you create an encrypted read replica from another
        /// Amazon Web Services Region by using the Amazon RDS API. Don't specify <c>PreSignedUrl</c>
        /// when you are creating an encrypted read replica in the same Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <c>CreateDBInstanceReadReplica</c>
        /// API operation that can run in the source Amazon Web Services Region that contains
        /// the encrypted source DB instance. The presigned URL request must contain the following
        /// parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DestinationRegion</c> - The Amazon Web Services Region that the encrypted read
        /// replica is created in. This Amazon Web Services Region is the same one where the <c>CreateDBInstanceReadReplica</c>
        /// operation is called that contains this presigned URL.
        /// </para>
        ///  
        /// <para>
        /// For example, if you create an encrypted DB instance in the us-west-1 Amazon Web Services
        /// Region, from a source DB instance in the us-east-2 Amazon Web Services Region, then
        /// you call the <c>CreateDBInstanceReadReplica</c> operation in the us-east-1 Amazon
        /// Web Services Region and provide a presigned URL that contains a call to the <c>CreateDBInstanceReadReplica</c>
        /// operation in the us-west-2 Amazon Web Services Region. For this example, the <c>DestinationRegion</c>
        /// in the presigned URL must be set to the us-east-1 Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KmsKeyId</c> - The KMS key identifier for the key to use to encrypt the read replica
        /// in the destination Amazon Web Services Region. This is the same identifier for both
        /// the <c>CreateDBInstanceReadReplica</c> operation that is called in the destination
        /// Amazon Web Services Region, and the operation contained in the presigned URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceDBInstanceIdentifier</c> - The DB instance identifier for the encrypted
        /// DB instance to be replicated. This identifier must be in the Amazon Resource Name
        /// (ARN) format for the source Amazon Web Services Region. For example, if you are creating
        /// an encrypted read replica from a DB instance in the us-west-2 Amazon Web Services
        /// Region, then your <c>SourceDBInstanceIdentifier</c> looks like the following example:
        /// <c>arn:aws:rds:us-west-2:123456789012:instance:mysql-instance1-20161115</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests: Using Query Parameters (Amazon Web Services Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>.
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
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB cluster's virtual private cloud
        /// (VPC). It resolves to the public IP address from outside of the DB cluster's VPC.
        /// Access to the DB cluster is ultimately controlled by the security group it uses. That
        /// public access isn't permitted if the security group assigned to the DB cluster doesn't
        /// permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBInstance</a>.
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
        /// The open mode of the replica database.
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
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the Multi-AZ DB cluster that will act as the source for the read
        /// replica. Each DB cluster can have up to 15 read replicas.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier of an existing Multi-AZ DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <c>SourceDBInstanceIdentifier</c> parameter is also specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB cluster must have automatic backups enabled, that is, its backup
        /// retention period must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The source DB cluster must be in the same Amazon Web Services Region as the read replica.
        /// Cross-Region replication isn't supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBClusterIdentifier
        {
            get { return this._sourceDBClusterIdentifier; }
            set { this._sourceDBClusterIdentifier = value; }
        }

        // Check to see if SourceDBClusterIdentifier property is set
        internal bool IsSetSourceDBClusterIdentifier()
        {
            return this._sourceDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBInstanceIdentifier. 
        /// <para>
        /// The identifier of the DB instance that will act as the source for the read replica.
        /// Each DB instance can have up to 15 read replicas, except for the following engines:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Db2 - Can have up to three replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Oracle - Can have up to five read replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SQL Server - Can have up to five read replicas.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier of an existing Db2, MariaDB, MySQL, Oracle, PostgreSQL, or
        /// SQL Server DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <c>SourceDBClusterIdentifier</c> parameter is also specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.limitations.html#oracle-read-replicas.limitations.versions-and-licenses">Version
        /// and licensing considerations for RDS for Oracle replicas</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.html#SQLServer.ReadReplicas.Limitations">Read
        /// replica limitations with SQL Server</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB instance must have automatic backups enabled, that is, its backup
        /// retention period must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in the same Amazon Web Services Region as the read replica,
        /// specify a valid DB instance identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in a different Amazon Web Services Region from the read
        /// replica, specify a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing
        /// an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply
        /// to SQL Server or RDS Custom, which don't support cross-Region replicas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBInstanceIdentifier
        {
            get { return this._sourceDBInstanceIdentifier; }
            set { this._sourceDBInstanceIdentifier = value; }
        }

        // Check to see if SourceDBInstanceIdentifier property is set
        internal bool IsSetSourceDBInstanceIdentifier()
        {
            return this._sourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// Specifies the storage throughput value for the read replica.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom or Amazon Aurora DB instances.
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
        /// The storage type to associate with the read replica.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>io1</c>, <c>io2</c>, or <c>gp3</c>, you must also include a value
        /// for the <c>Iops</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2 | standard</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>io1</c> if the <c>Iops</c> parameter is specified. Otherwise, <c>gp3</c>.
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
        /// Gets and sets the property Tags.
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
        /// Gets and sets the property UpgradeStorageConfig. 
        /// <para>
        /// Whether to upgrade the storage file system configuration on the read replica. This
        /// option migrates the read replica from the old storage file system layout to the preferred
        /// layout.
        /// </para>
        /// </summary>
        public bool? UpgradeStorageConfig
        {
            get { return this._upgradeStorageConfig; }
            set { this._upgradeStorageConfig = value; }
        }

        // Check to see if UpgradeStorageConfig property is set
        internal bool IsSetUpgradeStorageConfig()
        {
            return this._upgradeStorageConfig.HasValue; 
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
        /// A list of Amazon EC2 VPC security groups to associate with the read replica.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Default: The default EC2 VPC security group for the DB subnet group's VPC.
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