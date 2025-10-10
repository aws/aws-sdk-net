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
    /// Container for the parameters to the CreateDBInstance operation.
    /// Creates a new DB instance.
    /// 
    ///  
    /// <para>
    /// The new DB instance can be an RDS DB instance, or it can be a DB instance in an Aurora
    /// DB cluster. For an Aurora DB cluster, you can call this operation multiple times to
    /// add more than one DB instance to the cluster.
    /// </para>
    ///  
    /// <para>
    /// For more information about creating an RDS DB instance, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CreateDBInstance.html">
    /// Creating an Amazon RDS DB instance</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about creating a DB instance in an Aurora DB cluster, see <a
    /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.CreateInstance.html">
    /// Creating an Amazon Aurora DB cluster</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDBInstanceRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private int? _backupRetentionPeriod;
        private string _backupTarget;
        private string _caCertificateIdentifier;
        private string _characterSetName;
        private bool? _copyTagsToSnapshot;
        private string _customIamInstanceProfile;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _dbClusterIdentifier;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbName;
        private string _dbParameterGroupName;
        private List<string> _dbSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dbSubnetGroupName;
        private string _dbSystemId;
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
        private string _engine;
        private string _engineLifecycleSupport;
        private string _engineVersion;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private bool? _manageMasterUserPassword;
        private MasterUserAuthenticationType _masterUserAuthenticationType;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _masterUserSecretKmsKeyId;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private bool? _multiTenant;
        private string _ncharCharacterSetName;
        private string _networkType;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<ProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private bool? _storageEncrypted;
        private int? _storageThroughput;
        private string _storageType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private string _timezone;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The identifier for this DB instance. This parameter is stored as a lowercase string. Constraints: <ul> <li> Must contain from 1 to 63 letters, numbers, or hyphens. </li> <li> First character must be a letter. </li> <li> Can't end with a hyphen or contain two consecutive hyphens. </li> </ul> Example: <c>mydbinstance</c> </param>
        /// <param name="allocatedStorage">The amount of storage in gibibytes (GiB) to allocate for the DB instance. This setting doesn't apply to Amazon Aurora DB instances. Aurora cluster volumes automatically grow as the amount of data in your database increases, though you are only charged for the space that you use in an Aurora cluster volume. <dl> <dt>Amazon RDS Custom</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 40 to 65536 for RDS Custom for Oracle, 16384 for RDS Custom for SQL Server. </li> <li> Provisioned IOPS storage (io1, io2): Must be an integer from 40 to 65536 for RDS Custom for Oracle, 16384 for RDS Custom for SQL Server. </li> </ul> </dd> <dt>RDS for Db2</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536. </li> </ul> </dd> <dt>RDS for MariaDB</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul> </dd> <dt>RDS for MySQL</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul> </dd> <dt>RDS for Oracle</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 10 to 3072. </li> </ul> </dd> <dt>RDS for PostgreSQL</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul> </dd> <dt>RDS for SQL Server</dt> <dd> Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): <ul> <li> Enterprise and Standard editions: Must be an integer from 20 to 16384. </li> <li> Web and Express editions: Must be an integer from 20 to 16384. </li> </ul> </li> <li> Provisioned IOPS storage (io1, io2): <ul> <li> Enterprise and Standard editions: Must be an integer from 100 to 16384. </li> <li> Web and Express editions: Must be an integer from 100 to 16384. </li> </ul> </li> <li> Magnetic storage (standard): <ul> <li> Enterprise and Standard editions: Must be an integer from 20 to 1024. </li> <li> Web and Express editions: Must be an integer from 20 to 1024. </li> </ul> </li> </ul> </dd> </dl></param>
        /// <param name="dbInstanceClass">The compute and memory capacity of the DB instance, for example <c>db.m5.large</c>. Not all DB instance classes are available in all Amazon Web Services Regions, or for all database engines. For the full list of DB instance classes, and availability for your engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB instance classes</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.DBInstanceClass.html">Aurora DB instance classes</a> in the <i>Amazon Aurora User Guide</i>.</param>
        /// <param name="engine">The database engine to use for this DB instance. Not every database engine is available in every Amazon Web Services Region. Valid Values: <ul> <li>  <c>aurora-mysql</c> (for Aurora MySQL DB instances) </li> <li>  <c>aurora-postgresql</c> (for Aurora PostgreSQL DB instances) </li> <li>  <c>custom-oracle-ee</c> (for RDS Custom for Oracle DB instances) </li> <li>  <c>custom-oracle-ee-cdb</c> (for RDS Custom for Oracle DB instances) </li> <li>  <c>custom-oracle-se2</c> (for RDS Custom for Oracle DB instances) </li> <li>  <c>custom-oracle-se2-cdb</c> (for RDS Custom for Oracle DB instances) </li> <li>  <c>custom-sqlserver-ee</c> (for RDS Custom for SQL Server DB instances) </li> <li>  <c>custom-sqlserver-se</c> (for RDS Custom for SQL Server DB instances) </li> <li>  <c>custom-sqlserver-web</c> (for RDS Custom for SQL Server DB instances) </li> <li>  <c>custom-sqlserver-dev</c> (for RDS Custom for SQL Server DB instances) </li> <li>  <c>db2-ae</c>  </li> <li>  <c>db2-se</c>  </li> <li>  <c>mariadb</c>  </li> <li>  <c>mysql</c>  </li> <li>  <c>oracle-ee</c>  </li> <li>  <c>oracle-ee-cdb</c>  </li> <li>  <c>oracle-se2</c>  </li> <li>  <c>oracle-se2-cdb</c>  </li> <li>  <c>postgres</c>  </li> <li>  <c>sqlserver-ee</c>  </li> <li>  <c>sqlserver-se</c>  </li> <li>  <c>sqlserver-ex</c>  </li> <li>  <c>sqlserver-web</c>  </li> </ul></param>
        /// <param name="masterUsername">The name for the master user. This setting doesn't apply to Amazon Aurora DB instances. The name for the master user is managed by the DB cluster. This setting is required for RDS DB instances. Constraints: <ul> <li> Must be 1 to 16 letters, numbers, or underscores. </li> <li> First character must be a letter. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul></param>
        /// <param name="masterUserPassword">The password for the master user. This setting doesn't apply to Amazon Aurora DB instances. The password for the master user is managed by the DB cluster. Constraints: <ul> <li> Can't be specified if <c>ManageMasterUserPassword</c> is turned on. </li> <li> Can include any printable ASCII character except "/", """, or "@". For RDS for Oracle, can't include the "&amp;" (ampersand) or the "'" (single quotes) character. </li> </ul> Length Constraints: <ul> <li> RDS for Db2 - Must contain from 8 to 255 characters. </li> <li> RDS for MariaDB - Must contain from 8 to 41 characters. </li> <li> RDS for Microsoft SQL Server - Must contain from 8 to 128 characters. </li> <li> RDS for MySQL - Must contain from 8 to 41 characters. </li> <li> RDS for Oracle - Must contain from 8 to 30 characters. </li> <li> RDS for PostgreSQL - Must contain from 8 to 128 characters. </li> </ul></param>
        public CreateDBInstanceRequest(string dbInstanceIdentifier, int? allocatedStorage, string dbInstanceClass, string engine, string masterUsername, string masterUserPassword)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
            _allocatedStorage = allocatedStorage;
            _dbInstanceClass = dbInstanceClass;
            _engine = engine;
            _masterUsername = masterUsername;
            _masterUserPassword = masterUserPassword;
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) to allocate for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. Aurora cluster volumes automatically
        /// grow as the amount of data in your database increases, though you are only charged
        /// for the space that you use in an Aurora cluster volume.
        /// </para>
        ///  <dl> <dt>Amazon RDS Custom</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 40 to 65536 for
        /// RDS Custom for Oracle, 16384 for RDS Custom for SQL Server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2): Must be an integer from 40 to 65536 for RDS Custom
        /// for Oracle, 16384 for RDS Custom for SQL Server.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for Db2</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for MariaDB</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 5 to 3072.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for MySQL</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 5 to 3072.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for Oracle</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 10 to 3072.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for PostgreSQL</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 5 to 3072.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for SQL Server</dt> <dd> 
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Enterprise and Standard editions: Must be an integer from 20 to 16384.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Web and Express editions: Must be an integer from 20 to 16384.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1, io2):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Enterprise and Standard editions: Must be an integer from 100 to 16384.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Web and Express editions: Must be an integer from 100 to 16384.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Magnetic storage (standard):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Enterprise and Standard editions: Must be an integer from 20 to 1024.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Web and Express editions: Must be an integer from 20 to 1024.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> </dl>
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
        /// Specifies whether minor engine upgrades are applied automatically to the DB instance
        /// during the maintenance window. By default, minor engine upgrades are applied automatically.
        /// </para>
        ///  
        /// <para>
        /// If you create an RDS Custom DB instance, you must set <c>AutoMinorVersionUpgrade</c>
        /// to <c>false</c>.
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
        /// The Availability Zone (AZ) where the database will be created. For information on
        /// Amazon Web Services Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Aurora, each Aurora DB cluster hosts copies of its storage in three separate
        /// Availability Zones. Specify one of these Availability Zones. Aurora automatically
        /// chooses an appropriate Availability Zone if you don't specify one.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>AvailabilityZone</c> parameter can't be specified if the DB instance is a Multi-AZ
        /// deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified Availability Zone must be in the same Amazon Web Services Region as
        /// the current endpoint.
        /// </para>
        ///  </li> </ul> 
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained. Setting this parameter
        /// to a positive number enables backups. Setting this parameter to <c>0</c> disables
        /// automated backups.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The retention period for
        /// automated backups is managed by the DB cluster.
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
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// The location for storing automated backups and manual snapshots.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>local</c> (Dedicated Local Zone)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outposts</c> (Amazon Web Services Outposts)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region</c> (Amazon Web Services Region)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>region</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Working
        /// with Amazon RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
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
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// For supported engines, the character set (<c>CharacterSet</c>) to associate the DB
        /// instance with.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora - The character set is managed by the DB cluster. For more information,
        /// see <c>CreateDBCluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom - However, if you need to change the character set, you can change it on
        /// the database itself.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy tags from the DB instance to snapshots of the DB instance.
        /// By default, tags are not copied.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. Copying tags to snapshots
        /// is managed by the DB cluster. Setting this value for an Aurora DB instance has no
        /// effect on the DB cluster setting.
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
        /// Custom DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting is required for RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
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
        /// The mode of Database Insights to enable for the DB instance.
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The identifier of the DB cluster that this DB instance will belong to.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the DB instance, for example <c>db.m5.large</c>.
        /// Not all DB instance classes are available in all Amazon Web Services Regions, or for
        /// all database engines. For the full list of DB instance classes, and availability for
        /// your engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// instance classes</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.DBInstanceClass.html">Aurora
        /// DB instance classes</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier for this DB instance. This parameter is stored as a lowercase string.
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
        /// First character must be a letter.
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
        /// Gets and sets the property DBName. 
        /// <para>
        /// The meaning of this parameter differs according to the database engine you use.
        /// </para>
        ///  <dl> <dt>Amazon Aurora MySQL</dt> <dd> 
        /// <para>
        /// The name of the database to create when the primary DB instance of the Aurora MySQL
        /// DB cluster is created. If this parameter isn't specified for an Aurora MySQL DB cluster,
        /// no database is created in the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 64 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with a letter. Subsequent characters can be letters, underscores, or digits
        /// (0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>Amazon Aurora PostgreSQL</dt> <dd> 
        /// <para>
        /// The name of the database to create when the primary DB instance of the Aurora PostgreSQL
        /// DB cluster is created. A database named <c>postgres</c> is always created. If this
        /// parameter is specified, an additional database with this name is created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must contain 1 to 63 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with a letter. Subsequent characters can be letters, underscores, or digits
        /// (0 to 9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>Amazon RDS Custom for Oracle</dt> <dd> 
        /// <para>
        /// The Oracle System ID (SID) of the created RDS Custom DB instance. If you don't specify
        /// a value, the default value is <c>ORCL</c> for non-CDBs and <c>RDSCDB</c> for CDBs.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>ORCL</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 8 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>Amazon RDS Custom for SQL Server</dt> <dd> 
        /// <para>
        /// Not applicable. Must be null.
        /// </para>
        ///  </dd> <dt>RDS for Db2</dt> <dd> 
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// isn't specified, no database is created in the DB instance. In some cases, we recommend
        /// that you don't add a database name. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-db-instance-prereqs.html#db2-prereqs-additional-considerations">Additional
        /// considerations</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 64 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with a letter. Subsequent characters can be letters, underscores, or digits
        /// (0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the specified database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for MariaDB</dt> <dd> 
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// isn't specified, no database is created in the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 64 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with a letter. Subsequent characters can be letters, underscores, or digits
        /// (0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the specified database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for MySQL</dt> <dd> 
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// isn't specified, no database is created in the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 64 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with a letter. Subsequent characters can be letters, underscores, or digits
        /// (0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the specified database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for Oracle</dt> <dd> 
        /// <para>
        /// The Oracle System ID (SID) of the created DB instance. If you don't specify a value,
        /// the default value is <c>ORCL</c>. You can't specify the string <c>null</c>, or any
        /// other reserved word, for <c>DBName</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>ORCL</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be longer than 8 characters.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for PostgreSQL</dt> <dd> 
        /// <para>
        /// The name of the database to create when the DB instance is created. A database named
        /// <c>postgres</c> is always created. If this parameter is specified, an additional database
        /// with this name is created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1 to 63 letters, numbers, or underscores.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must begin with a letter. Subsequent characters can be letters, underscores, or digits
        /// (0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a word reserved by the specified database engine.
        /// </para>
        ///  </li> </ul> </dd> <dt>RDS for SQL Server</dt> <dd> 
        /// <para>
        /// Not applicable. Must be null.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string DBName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to associate with this DB instance. If you don't
        /// specify a value, then Amazon RDS uses the default DB parameter group for the specified
        /// DB engine and version.
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
        /// Must be 1 to 255 letters, numbers, or hyphens.
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
        /// Gets and sets the property DBSecurityGroups. 
        /// <para>
        /// A list of DB security groups to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the legacy EC2-Classic platform, which is no longer used to
        /// create new DB instances. Use the <c>VpcSecurityGroupIds</c> setting instead.
        /// </para>
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
        /// A DB subnet group to associate with this DB instance.
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
        /// The Oracle system identifier (SID), which is the name of the Oracle database instance
        /// that manages your database files. In this context, the term "Oracle database instance"
        /// refers exclusively to the system global area (SGA) and Oracle background processes.
        /// If you don't specify a SID, the value defaults to <c>RDSCDB</c>. The Oracle SID is
        /// also the name of your CDB.
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
        /// deletion protection for the DB cluster. For more information, see <c>CreateDBCluster</c>.
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Active Directory directory ID to create the DB instance in. Currently, you can
        /// create only Db2, MySQL, Microsoft SQL Server, Oracle, and PostgreSQL DB instances
        /// in an Active Directory Domain.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/kerberos-authentication.html">
        /// Kerberos Authentication</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora (The domain is managed by the DB cluster.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> </ul>
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
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora (The domain is managed by the DB cluster.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> </ul>
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
        /// The list of log types to enable for exporting to CloudWatch Logs. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">
        /// Publishing Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora (CloudWatch Logs exports are managed by the DB cluster.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following values are valid for each DB engine:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RDS for Db2 - <c>diag.log | notify.log | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MariaDB - <c>audit | error | general | slowquery | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server - <c>agent | error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - <c>audit | error | general | slowquery | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle - <c>alert | audit | listener | trace | oemagent</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - <c>postgresql | upgrade | iam-db-auth-error</c> 
        /// </para>
        ///  </li> </ul>
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
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora (Mapping Amazon Web Services IAM accounts to database accounts is managed
        /// by the DB cluster.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> </ul>
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
        /// Specifies whether to enable Performance Insights for the DB instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
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
        /// The database engine to use for this DB instance.
        /// </para>
        ///  
        /// <para>
        /// Not every database engine is available in every Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aurora-mysql</c> (for Aurora MySQL DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> (for Aurora PostgreSQL DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-ee</c> (for RDS Custom for Oracle DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-ee-cdb</c> (for RDS Custom for Oracle DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-se2</c> (for RDS Custom for Oracle DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-se2-cdb</c> (for RDS Custom for Oracle DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-sqlserver-ee</c> (for RDS Custom for SQL Server DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-sqlserver-se</c> (for RDS Custom for SQL Server DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-sqlserver-web</c> (for RDS Custom for SQL Server DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-sqlserver-dev</c> (for RDS Custom for SQL Server DB instances)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-ae</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-se</c> 
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
        ///  <c>oracle-ee-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web</c> 
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
        /// The life cycle type for this DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, this value is set to <c>open-source-rds-extended-support</c>, which enrolls
        /// your DB instance into Amazon RDS Extended Support. At the end of standard support,
        /// you can avoid charges for Extended Support by setting the value to <c>open-source-rds-extended-support-disabled</c>.
        /// In this case, creating the DB instance will fail if the DB major version is past its
        /// end of standard support date.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting applies only to RDS for MySQL and RDS for PostgreSQL. For Amazon Aurora
        /// DB instances, the life cycle type is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// You can use this setting to enroll your DB instance into Amazon RDS Extended Support.
        /// With RDS Extended Support, you can run the selected major engine version on your DB
        /// instance past the end of standard support for that engine version. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to use.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The version number of the
        /// database engine the DB instance uses is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid engine versions, use the <c>DescribeDBEngineVersions</c> operation.
        /// </para>
        ///  
        /// <para>
        /// The following are the database engines and links to information about the major and
        /// minor versions that are available with Amazon RDS. Not every database engine is available
        /// for every Amazon Web Services Region.
        /// </para>
        ///  <dl> <dt>Amazon RDS Custom for Oracle</dt> <dd> 
        /// <para>
        /// A custom engine version (CEV) that you have previously created. This setting is required
        /// for RDS Custom for Oracle. The CEV name has the following format: 19.<i>customized_string</i>.
        /// A valid CEV name is <c>19.my_cev1</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-creating.html#custom-creating.create">
        /// Creating an RDS Custom for Oracle DB instance</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>Amazon RDS Custom for SQL Server</dt> <dd> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-reqs-limits-MS.html">RDS
        /// Custom for SQL Server general requirements</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>RDS for Db2</dt> <dd> 
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Db2.html#Db2.Concepts.VersionMgmt">Db2
        /// on Amazon RDS versions</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>RDS for MariaDB</dt> <dd> 
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MariaDB.html#MariaDB.Concepts.VersionMgmt">MariaDB
        /// on Amazon RDS versions</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>RDS for Microsoft SQL Server</dt> <dd> 
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.VersionSupport">Microsoft
        /// SQL Server versions on Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>RDS for MySQL</dt> <dd> 
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MySQL.html#MySQL.Concepts.VersionMgmt">MySQL
        /// on Amazon RDS versions</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>RDS for Oracle</dt> <dd> 
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.Oracle.PatchComposition.html">Oracle
        /// Database Engine release notes</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> <dt>RDS for PostgreSQL</dt> <dd> 
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_PostgreSQL.html#PostgreSQL.Concepts">Amazon
        /// RDS for PostgreSQL versions and extensions</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </dd> </dl>
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
        /// The amount of Provisioned IOPS (input/output operations per second) to initially allocate
        /// for the DB instance. For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html">Amazon
        /// RDS DB instance storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. Storage is managed by the
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RDS for Db2, MariaDB, MySQL, Oracle, and PostgreSQL - Must be a multiple between
        /// .5 and 50 of the storage amount for the DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For RDS for SQL Server - Must be a multiple between 1 and 50 of the storage amount
        /// for the DB instance.
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
        /// The Amazon Web Services KMS key identifier for an encrypted DB instance.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The Amazon Web Services
        /// KMS key identifier is managed by the DB cluster. For more information, see <c>CreateDBCluster</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>StorageEncrypted</c> is enabled, and you do not specify a value for the <c>KmsKeyId</c>
        /// parameter, then Amazon RDS uses your default KMS key. There is a default KMS key for
        /// your Amazon Web Services account. Your Amazon Web Services account has a different
        /// default KMS key for each Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// For Amazon RDS Custom, a KMS key is required for DB instances. For most RDS engines,
        /// if you leave this parameter empty while enabling <c>StorageEncrypted</c>, the engine
        /// uses the default KMS key. However, RDS Custom doesn't use the default key when this
        /// parameter is empty. You must explicitly specify a key.
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
        /// The license model information for this DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// License models for RDS for Db2 require additional configuration. The bring your own
        /// license (BYOL) model requires a custom parameter group and an Amazon Web Services
        /// License Manager self-managed license. The Db2 license through Amazon Web Services
        /// Marketplace model requires an Amazon Web Services Marketplace subscription. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-licensing.html">Amazon
        /// RDS for Db2 licensing options</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default for RDS for Db2 is <c>bring-your-own-license</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RDS for Db2 - <c>bring-your-own-license | marketplace-license</c> 
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
        /// a DB instance.
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
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The name for the master user.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The name for the master
        /// user is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is required for RDS DB instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 16 letters, numbers, or underscores.
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
        /// The password for the master user.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The password for the master
        /// user is managed by the DB cluster.
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
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB instance.
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
        /// This setting doesn't apply to the following DB instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora (Storage is managed by the DB cluster.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS Custom
        /// </para>
        ///  </li> </ul>
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
        /// If <c>MonitoringRoleArn</c> is specified, then you must set <c>MonitoringInterval</c>
        /// to a value other than <c>0</c>.
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
        /// on creating a monitoring role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html#USER_Monitoring.OS.Enabling">Setting
        /// Up and Enabling Enhanced Monitoring</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than <c>0</c>, then you must
        /// supply a <c>MonitoringRoleArn</c> value.
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
        /// Specifies whether the DB instance is a Multi-AZ deployment. You can't set the <c>AvailabilityZone</c>
        /// parameter if the DB instance is a Multi-AZ deployment.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora because the DB instance Availability Zones
        /// (AZs) are managed by the DB cluster.
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
        /// Specifies whether to use the multi-tenant configuration or the single-tenant configuration
        /// (default). This parameter only applies to RDS for Oracle container database (CDB)
        /// engines.
        /// </para>
        ///  
        /// <para>
        /// Note the following restrictions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB engine that you specify in the request must support the multi-tenant configuration.
        /// If you attempt to enable the multi-tenant configuration on a DB engine that doesn't
        /// support it, the request fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify the multi-tenant configuration when you create your DB instance, you
        /// can't later modify this DB instance to use the single-tenant configuration.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property NcharCharacterSetName. 
        /// <para>
        /// The name of the NCHAR character set for the Oracle DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string NcharCharacterSetName
        {
            get { return this._ncharCharacterSetName; }
            set { this._ncharCharacterSetName = value; }
        }

        // Check to see if NcharCharacterSetName property is set
        internal bool IsSetNcharCharacterSetName()
        {
            return this._ncharCharacterSetName != null;
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group to associate the DB instance with.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can't
        /// be removed from an option group. Also, that option group can't be removed from a DB
        /// instance after it is associated with a DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the database accepts connections.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Aurora DB instances. The port number is managed by the
        /// cluster.
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
        /// are enabled, using the <c>BackupRetentionPeriod</c> parameter. The default is a 30-minute
        /// window selected at random from an 8-hour block of time for each Amazon Web Services
        /// Region. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">Backup
        /// window</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The daily time range for
        /// creating automated backups is managed by the DB cluster.
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
        /// The time range each week during which system maintenance can occur. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#Concepts.DBMaintenance">Amazon
        /// RDS Maintenance Window</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week.
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
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
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
        /// controlled by the security group it uses. That public access is not permitted if the
        /// security group assigned to the DB instance doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
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
        /// to it, the DB instance is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the default VPC in the target Region has an internet gateway attached to it, the
        /// DB instance is public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBSubnetGroupName</c> is specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the subnets are part of a VPC that doesn’t have an internet gateway attached to
        /// it, the DB instance is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the subnets are part of a VPC that has an internet gateway attached to it, the
        /// DB instance is public.
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
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifes whether the DB instance is encrypted. By default, it isn't encrypted.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom DB instances, either enable this setting or leave it unset. Otherwise,
        /// Amazon RDS reports an error.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The encryption for DB instances
        /// is managed by the DB cluster.
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
        /// The storage throughput value, in mebibyte per second (MiBps), for the DB instance.
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
        /// If you specify <c>io1</c>, <c>io2</c>, or <c>gp3</c>, you must also include a value
        /// for the <c>Iops</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. Storage is managed by the
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2 | standard</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>io1</c>, if the <c>Iops</c> parameter is specified. Otherwise, <c>gp3</c>.
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
        /// <para>
        /// Tags to assign to the DB instance.
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
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which to associate the instance for TDE encryption.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
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
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone of the DB instance. The time zone parameter is currently supported only
        /// by <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-time-zone">RDS
        /// for Db2</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.TimeZone">RDS
        /// for SQL Server</a>.
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of Amazon EC2 VPC security groups to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The associated list of EC2
        /// VPC security groups is managed by the DB cluster.
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