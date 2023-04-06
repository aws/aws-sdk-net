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
        private string _dbClusterIdentifier;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbName;
        private string _dbParameterGroupName;
        private List<string> _dbSecurityGroups = new List<string>();
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = new List<string>();
        private bool? _enableCustomerOwnedIp;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private string _engine;
        private string _engineVersion;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private bool? _manageMasterUserPassword;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _masterUserSecretKmsKeyId;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _ncharCharacterSetName;
        private string _networkType;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<ProcessorFeature> _processorFeatures = new List<ProcessorFeature>();
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private bool? _storageEncrypted;
        private int? _storageThroughput;
        private string _storageType;
        private List<Tag> _tags = new List<Tag>();
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private string _timezone;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li> Must contain from 1 to 63 letters, numbers, or hyphens. </li> <li> First character must be a letter. </li> <li> Can't end with a hyphen or contain two consecutive hyphens. </li> </ul> Example: <code>mydbinstance</code> </param>
        /// <param name="allocatedStorage">The amount of storage in gibibytes (GiB) to allocate for the DB instance. Type: Integer  <b>Amazon Aurora</b>  Not applicable. Aurora cluster volumes automatically grow as the amount of data in your database increases, though you are only charged for the space that you use in an Aurora cluster volume.  <b>Amazon RDS Custom</b>  Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 40 to 65536 for RDS Custom for Oracle, 16384 for RDS Custom for SQL Server. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 40 to 65536 for RDS Custom for Oracle, 16384 for RDS Custom for SQL Server. </li> </ul>  <b>MySQL</b>  Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul>  <b>MariaDB</b>  Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul>  <b>PostgreSQL</b>  Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul>  <b>Oracle</b>  Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 10 to 3072. </li> </ul>  <b>SQL Server</b>  Constraints to the amount of storage for each storage type are the following: <ul> <li> General Purpose (SSD) storage (gp2, gp3): <ul> <li> Enterprise and Standard editions: Must be an integer from 20 to 16384. </li> <li> Web and Express editions: Must be an integer from 20 to 16384. </li> </ul> </li> <li> Provisioned IOPS storage (io1): <ul> <li> Enterprise and Standard editions: Must be an integer from 100 to 16384. </li> <li> Web and Express editions: Must be an integer from 100 to 16384. </li> </ul> </li> <li> Magnetic storage (standard): <ul> <li> Enterprise and Standard editions: Must be an integer from 20 to 1024. </li> <li> Web and Express editions: Must be an integer from 20 to 1024. </li> </ul> </li> </ul></param>
        /// <param name="dbInstanceClass">The compute and memory capacity of the DB instance, for example db.m5.large. Not all DB instance classes are available in all Amazon Web Services Regions, or for all database engines. For the full list of DB instance classes, and availability for your engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB instance classes</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.DBInstanceClass.html">Aurora DB instance classes</a> in the <i>Amazon Aurora User Guide</i>.</param>
        /// <param name="engine">The name of the database engine to be used for this instance. Not every database engine is available for every Amazon Web Services Region. Valid Values: <ul> <li>  <code>aurora</code> (for MySQL 5.6-compatible Aurora) </li> <li>  <code>aurora-mysql</code> (for MySQL 5.7-compatible and MySQL 8.0-compatible Aurora) </li> <li>  <code>aurora-postgresql</code>  </li> <li>  <code>custom-oracle-ee (for RDS Custom for Oracle DB instances)</code>  </li> <li>  <code>custom-oracle-ee-cdb (for RDS Custom for Oracle DB instances)</code>  </li> <li>  <code>custom-sqlserver-ee (for RDS Custom for SQL Server DB instances)</code>  </li> <li>  <code>custom-sqlserver-se (for RDS Custom for SQL Server DB instances)</code>  </li> <li>  <code>custom-sqlserver-web (for RDS Custom for SQL Server DB instances)</code>  </li> <li>  <code>mariadb</code>  </li> <li>  <code>mysql</code>  </li> <li>  <code>oracle-ee</code>  </li> <li>  <code>oracle-ee-cdb</code>  </li> <li>  <code>oracle-se2</code>  </li> <li>  <code>oracle-se2-cdb</code>  </li> <li>  <code>postgres</code>  </li> <li>  <code>sqlserver-ee</code>  </li> <li>  <code>sqlserver-se</code>  </li> <li>  <code>sqlserver-ex</code>  </li> <li>  <code>sqlserver-web</code>  </li> </ul></param>
        /// <param name="masterUsername">The name for the master user.  <b>Amazon Aurora</b>  Not applicable. The name for the master user is managed by the DB cluster.  <b>Amazon RDS</b>  Constraints: <ul> <li> Required. </li> <li> Must be 1 to 16 letters, numbers, or underscores. </li> <li> First character must be a letter. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul></param>
        /// <param name="masterUserPassword">The password for the master user. The password can include any printable ASCII character except "/", """, or "@".  <b>Amazon Aurora</b>  Not applicable. The password for the master user is managed by the DB cluster. Constraints: Can't be specified if <code>ManageMasterUserPassword</code> is turned on.  <b>MariaDB</b>  Constraints: Must contain from 8 to 41 characters.  <b>Microsoft SQL Server</b>  Constraints: Must contain from 8 to 128 characters.  <b>MySQL</b>  Constraints: Must contain from 8 to 41 characters.  <b>Oracle</b>  Constraints: Must contain from 8 to 30 characters.  <b>PostgreSQL</b>  Constraints: Must contain from 8 to 128 characters.</param>
        public CreateDBInstanceRequest(string dbInstanceIdentifier, int allocatedStorage, string dbInstanceClass, string engine, string masterUsername, string masterUserPassword)
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
        /// Type: Integer
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Aurora cluster volumes automatically grow as the amount of data in
        /// your database increases, though you are only charged for the space that you use in
        /// an Aurora cluster volume.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon RDS Custom</b> 
        /// </para>
        ///  
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
        /// Provisioned IOPS storage (io1): Must be an integer from 40 to 65536 for RDS Custom
        /// for Oracle, 16384 for RDS Custom for SQL Server.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 5 to 3072.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 5 to 3072.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 5 to 3072.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2, gp3): Must be an integer from 20 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 65536.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic storage (standard): Must be an integer from 10 to 3072.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
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
        /// Provisioned IOPS storage (io1):
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
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public int AllocatedStorage
        {
            get { return this._allocatedStorage.GetValueOrDefault(); }
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
        /// A value that indicates whether minor engine upgrades are applied automatically to
        /// the DB instance during the maintenance window. By default, minor engine upgrades are
        /// applied automatically.
        /// </para>
        ///  
        /// <para>
        /// If you create an RDS Custom DB instance, you must set <code>AutoMinorVersionUpgrade</code>
        /// to <code>false</code>.
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
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
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Each Aurora DB cluster hosts copies of its storage in three separate Availability
        /// Zones. Specify one of these Availability Zones. Aurora automatically chooses an appropriate
        /// Availability Zone if you don't specify one.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>us-east-1d</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraint: The <code>AvailabilityZone</code> parameter can't be specified if the
        /// DB instance is a Multi-AZ deployment. The specified Availability Zone must be in the
        /// same Amazon Web Services Region as the current endpoint.
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
        /// to a positive number enables backups. Setting this parameter to 0 disables automated
        /// backups.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The retention period for automated backups is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a value from 0 to 35
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to 0 if the DB instance is a source to read replicas
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to 0 for an RDS Custom for Oracle DB instance
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
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
        /// Specifies where automated backups and manual snapshots are stored.
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>outposts</code> (Amazon Web Services Outposts) and <code>region</code>
        /// (Amazon Web Services Region). The default is <code>region</code>.
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
        /// Specifies the CA certificate identifier to use for the DB instance’s server certificate.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// For supported engines, this value indicates that the DB instance should be associated
        /// with the specified <code>CharacterSet</code>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom. However, if you need to change the character
        /// set, you can change it on the database itself.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The character set is managed by the DB cluster. For more information,
        /// see <code>CreateDBCluster</code>.
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy tags from the DB instance to snapshots of the
        /// DB instance. By default, tags are not copied.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Copying tags to snapshots is managed by the DB cluster. Setting this
        /// value for an Aurora DB instance has no effect on the DB cluster setting.
        /// </para>
        /// </summary>
        public bool CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot.GetValueOrDefault(); }
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
        /// <code>AWSRDSCustom</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of permissions required for the IAM role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-setup-orcl.html#custom-setup-orcl.iam-vpc">
        /// Configure IAM and your VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting is required for RDS Custom.
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The identifier of the DB cluster that the instance will belong to.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// The compute and memory capacity of the DB instance, for example db.m5.large. Not all
        /// DB instance classes are available in all Amazon Web Services Regions, or for all database
        /// engines. For the full list of DB instance classes, and availability for your engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
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
        /// The DB instance identifier. This parameter is stored as a lowercase string.
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
        /// Example: <code>mydbinstance</code> 
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
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
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
        /// Can't be a word reserved by the specified database engine
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
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
        /// Can't be a word reserved by the specified database engine
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// isn't specified, a database named <code>postgres</code> is created in the DB instance.
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
        /// Can't be a word reserved by the specified database engine
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// The Oracle System ID (SID) of the created DB instance. If you specify <code>null</code>,
        /// the default value <code>ORCL</code> is used. You can't specify the string NULL, or
        /// any other reserved word, for <code>DBName</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>ORCL</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be longer than 8 characters
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Amazon RDS Custom for Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// The Oracle System ID (SID) of the created RDS Custom DB instance. If you don't specify
        /// a value, the default value is <code>ORCL</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>ORCL</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must contain 1 to 8 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must contain a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't be a word reserved by the database engine.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Amazon RDS Custom for SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Must be null.
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Must be null.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora MySQL</b> 
        /// </para>
        ///  
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
        /// It must contain 1 to 64 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't be a word reserved by the database engine.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Amazon Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// The name of the database to create when the primary DB instance of the Aurora PostgreSQL
        /// DB cluster is created. If this parameter isn't specified for an Aurora PostgreSQL
        /// DB cluster, a database named <code>postgres</code> is created in the DB cluster.
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
        /// It must begin with a letter. Subsequent characters can be letters, underscores, or
        /// digits (0 to 9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't be a word reserved by the database engine.
        /// </para>
        ///  </li> </ul>
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
        /// The name of the DB parameter group to associate with this DB instance. If you do not
        /// specify a value, then the default DB parameter group for the specified DB engine and
        /// version is used.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't end with a hyphen or contain two consecutive hyphens.
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
        /// create new DB instances. Use the <code>VpcSecurityGroupIds</code> setting instead.
        /// </para>
        /// </summary>
        public List<string> DBSecurityGroups
        {
            get { return this._dbSecurityGroups; }
            set { this._dbSecurityGroups = value; }
        }

        // Check to see if DBSecurityGroups property is set
        internal bool IsSetDBSecurityGroups()
        {
            return this._dbSecurityGroups != null && this._dbSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// A DB subnet group to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must match the name of an existing DBSubnetGroup. Must not be default.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mydbsubnetgroup</code> 
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// A value that indicates whether the DB instance has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection isn't enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. You can enable or disable deletion protection for the DB cluster.
        /// For more information, see <code>CreateDBCluster</code>. DB instances in a DB cluster
        /// can be deleted even when deletion protection is enabled for the DB cluster.
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
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
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The domain is managed by the DB cluster.
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
        /// Specify the name of the IAM role to be used when making API calls to the Directory
        /// Service.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The domain is managed by the DB cluster.
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
        /// The list of log types that need to be enabled for exporting to CloudWatch Logs. The
        /// values in the list depend on the DB engine. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">
        /// Publishing Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. CloudWatch Logs exports are managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        ///  <b>RDS Custom</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>audit</code>, <code>error</code>, <code>general</code>,
        /// and <code>slowquery</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Microsoft SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>agent</code> and <code>error</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>audit</code>, <code>error</code>, <code>general</code>,
        /// and <code>slowquery</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>alert</code>, <code>audit</code>, <code>listener</code>,
        /// <code>trace</code>, and <code>oemagent</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>postgresql</code> and <code>upgrade</code>.
        /// </para>
        /// </summary>
        public List<string> EnableCloudwatchLogsExports
        {
            get { return this._enableCloudwatchLogsExports; }
            set { this._enableCloudwatchLogsExports = value; }
        }

        // Check to see if EnableCloudwatchLogsExports property is set
        internal bool IsSetEnableCloudwatchLogsExports()
        {
            return this._enableCloudwatchLogsExports != null && this._enableCloudwatchLogsExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableCustomerOwnedIp. 
        /// <para>
        /// A value that indicates whether to enable a customer-owned IP address (CoIP) for an
        /// RDS on Outposts DB instance.
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
        public bool EnableCustomerOwnedIp
        {
            get { return this._enableCustomerOwnedIp.GetValueOrDefault(); }
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
        /// A value that indicates whether to enable mapping of Amazon Web Services Identity and
        /// Access Management (IAM) accounts to database accounts. By default, mapping isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Mapping Amazon Web Services IAM accounts to database accounts is managed
        /// by the DB cluster.
        /// </para>
        /// </summary>
        public bool EnableIAMDatabaseAuthentication
        {
            get { return this._enableIAMDatabaseAuthentication.GetValueOrDefault(); }
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
        /// A value that indicates whether to enable Performance Insights for the DB instance.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
        /// Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public bool EnablePerformanceInsights
        {
            get { return this._enablePerformanceInsights.GetValueOrDefault(); }
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
        /// The name of the database engine to be used for this instance.
        /// </para>
        ///  
        /// <para>
        /// Not every database engine is available for every Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aurora</code> (for MySQL 5.6-compatible Aurora)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-mysql</code> (for MySQL 5.7-compatible and MySQL 8.0-compatible Aurora)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-oracle-ee (for RDS Custom for Oracle DB instances)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-oracle-ee-cdb (for RDS Custom for Oracle DB instances)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-sqlserver-ee (for RDS Custom for SQL Server DB instances)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-sqlserver-se (for RDS Custom for SQL Server DB instances)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-sqlserver-web (for RDS Custom for SQL Server DB instances)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mysql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee-cdb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2-cdb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web</code> 
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to use.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid engine versions, use the <code>DescribeDBEngineVersions</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following are the database engines and links to information about the major and
        /// minor versions that are available with Amazon RDS. Not every database engine is available
        /// for every Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The version number of the database engine to be used by the DB instance
        /// is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon RDS Custom for Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// A custom engine version (CEV) that you have previously created. This setting is required
        /// for RDS Custom for Oracle. The CEV name has the following format: 19.<i>customized_string</i>.
        /// A valid CEV name is <code>19.my_cev1</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-creating.html#custom-creating.create">
        /// Creating an RDS Custom for Oracle DB instance</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon RDS Custom for SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-reqs-limits-MS.html">RDS
        /// Custom for SQL Server general requirements</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MariaDB.html#MariaDB.Concepts.VersionMgmt">MariaDB
        /// on Amazon RDS Versions</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Microsoft SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.VersionSupport">Microsoft
        /// SQL Server Versions on Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MySQL.html#MySQL.Concepts.VersionMgmt">MySQL
        /// on Amazon RDS Versions</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.Oracle.PatchComposition.html">Oracle
        /// Database Engine Release Notes</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// For information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_PostgreSQL.html#PostgreSQL.Concepts">Amazon
        /// RDS for PostgreSQL versions and extensions</a> in the <i>Amazon RDS User Guide</i>.
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
        /// allocated for the DB instance. For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html">Amazon
        /// RDS DB instance storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: For MariaDB, MySQL, Oracle, and PostgreSQL DB instances, must be a multiple
        /// between .5 and 50 of the storage amount for the DB instance. For SQL Server DB instances,
        /// must be a multiple between 1 and 50 of the storage amount for the DB instance.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Storage is managed by the DB cluster.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
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
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The Amazon Web Services KMS key identifier is managed by the DB cluster.
        /// For more information, see <code>CreateDBCluster</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>StorageEncrypted</code> is enabled, and you do not specify a value for the
        /// <code>KmsKeyId</code> parameter, then Amazon RDS uses your default KMS key. There
        /// is a default KMS key for your Amazon Web Services account. Your Amazon Web Services
        /// account has a different default KMS key for each Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon RDS Custom</b> 
        /// </para>
        ///  
        /// <para>
        /// A KMS key is required for RDS Custom instances. For most RDS engines, if you leave
        /// this parameter empty while enabling <code>StorageEncrypted</code>, the engine uses
        /// the default KMS key. However, RDS Custom doesn't use the default key when this parameter
        /// is empty. You must explicitly specify a key.
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
        /// License model information for this DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>license-included</code> | <code>bring-your-own-license</code>
        /// | <code>general-public-license</code> 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable.
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
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// A value that indicates whether to manage the master user password with Amazon Web
        /// Services Secrets Manager.
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
        /// <code>MasterUserPassword</code> is specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool ManageMasterUserPassword
        {
            get { return this._manageMasterUserPassword.GetValueOrDefault(); }
            set { this._manageMasterUserPassword = value; }
        }

        // Check to see if ManageMasterUserPassword property is set
        internal bool IsSetManageMasterUserPassword()
        {
            return this._manageMasterUserPassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The name for the master user.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The name for the master user is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon RDS</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required.
        /// </para>
        ///  </li> <li> 
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
        /// The password for the master user. The password can include any printable ASCII character
        /// except "/", """, or "@".
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The password for the master user is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Can't be specified if <code>ManageMasterUserPassword</code> is turned
        /// on.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 41 characters.
        /// </para>
        ///  
        /// <para>
        ///  <b>Microsoft SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 128 characters.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 41 characters.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 30 characters.
        /// </para>
        ///  
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 128 characters.
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
        /// If you don't specify <code>MasterUserSecretKmsKeyId</code>, then the <code>aws/secretsmanager</code>
        /// KMS key is used to encrypt the secret. If the secret is in a different Amazon Web
        /// Services account, then you can't use the <code>aws/secretsmanager</code> KMS key to
        /// encrypt the secret, and you must use a customer managed KMS key.
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
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Storage is managed by the DB cluster.
        /// </para>
        /// </summary>
        public int MaxAllocatedStorage
        {
            get { return this._maxAllocatedStorage.GetValueOrDefault(); }
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
        /// 0. The default is 0.
        /// </para>
        ///  
        /// <para>
        /// If <code>MonitoringRoleArn</code> is specified, then you must set <code>MonitoringInterval</code>
        /// to a value other than 0.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>0, 1, 5, 10, 15, 30, 60</code> 
        /// </para>
        /// </summary>
        public int MonitoringInterval
        {
            get { return this._monitoringInterval.GetValueOrDefault(); }
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
        /// CloudWatch Logs. For example, <code>arn:aws:iam:123456789012:role/emaccess</code>.
        /// For information on creating a monitoring role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html#USER_Monitoring.OS.Enabling">Setting
        /// Up and Enabling Enhanced Monitoring</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <code>MonitoringInterval</code> is set to a value other than 0, then you must supply
        /// a <code>MonitoringRoleArn</code> value.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// A value that indicates whether the DB instance is a Multi-AZ deployment. You can't
        /// set the <code>AvailabilityZone</code> parameter if the DB instance is a Multi-AZ deployment.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. DB instance Availability Zones (AZs) are managed by the DB cluster.
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NcharCharacterSetName. 
        /// <para>
        /// The name of the NCHAR character set for the Oracle DB instance.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't apply to RDS Custom.
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
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IPV4</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DUAL</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The network type is determined by the <code>DBSubnetGroup</code> specified for the
        /// DB instance. A <code>DBSubnetGroup</code> can support only the IPv4 protocol or the
        /// IPv4 and the IPv6 protocols (<code>DUAL</code>).
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
        /// A value that indicates that the DB instance should be associated with the specified
        /// option group.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can't
        /// be removed from an option group. Also, that option group can't be removed from a DB
        /// instance after it is associated with a DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable.
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
        /// If you do not specify a value for <code>PerformanceInsightsKMSKeyId</code>, then Amazon
        /// RDS uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// The number of days to retain Performance Insights data. The default is 7 days. The
        /// following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 7
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>month</i> * 31, where <i>month</i> is a number of months from 1-23
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 731
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, the following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 93 (3 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 341 (11 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 589 (19 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 731
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify a retention period such as 94, which isn't a valid value, RDS issues
        /// an error.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public int PerformanceInsightsRetentionPeriod
        {
            get { return this._performanceInsightsRetentionPeriod.GetValueOrDefault(); }
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
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>3306</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        /// Type: Integer
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>3306</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        /// Type: Integer
        /// </para>
        ///  
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>5432</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        /// Type: Integer
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>1521</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>1433</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>1150-65535</code> except <code>1234</code>, <code>1434</code>,
        /// <code>3260</code>, <code>3343</code>, <code>3389</code>, <code>47001</code>, and <code>49152-49156</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>3306</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        /// Type: Integer
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
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
        /// are enabled, using the <code>BackupRetentionPeriod</code> parameter. The default is
        /// a 30-minute window selected at random from an 8-hour block of time for each Amazon
        /// Web Services Region. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">Backup
        /// window</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The daily time range for creating automated backups is managed by
        /// the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <code>hh24:mi-hh24:mi</code>.
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
        /// The time range each week during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC). For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#Concepts.DBMaintenance">Amazon
        /// RDS Maintenance Window</a>.
        /// </para>
        ///  
        /// <para>
        /// Format: <code>ddd:hh24:mi-ddd:hh24:mi</code> 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week.
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 30-minute window.
        /// </para>
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
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable.
        /// </para>
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures
        {
            get { return this._processorFeatures; }
            set { this._processorFeatures = value; }
        }

        // Check to see if ProcessorFeatures property is set
        internal bool IsSetProcessorFeatures()
        {
            return this._processorFeatures != null && this._processorFeatures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which an Aurora Replica is promoted to the primary
        /// instance after a failure of the existing primary instance. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Managing.Backups.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 0 - 15
        /// </para>
        /// </summary>
        public int PromotionTier
        {
            get { return this._promotionTier.GetValueOrDefault(); }
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
        /// A value that indicates whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB instance's virtual private cloud
        /// (VPC). It resolves to the public IP address from outside of the DB instance's VPC.
        /// Access to the DB instance is ultimately controlled by the security group it uses.
        /// That public access is not permitted if the security group assigned to the DB instance
        /// doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// Default: The default behavior varies depending on whether <code>DBSubnetGroupName</code>
        /// is specified.
        /// </para>
        ///  
        /// <para>
        /// If <code>DBSubnetGroupName</code> isn't specified, and <code>PubliclyAccessible</code>
        /// isn't specified, the following applies:
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
        /// If <code>DBSubnetGroupName</code> is specified, and <code>PubliclyAccessible</code>
        /// isn't specified, the following applies:
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
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
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
        /// A value that indicates whether the DB instance is encrypted. By default, it isn't
        /// encrypted.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom instances, either set this parameter to <code>true</code> or leave
        /// it unset. If you set this parameter to <code>false</code>, RDS reports an error.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The encryption for DB instances is managed by the DB cluster.
        /// </para>
        /// </summary>
        public bool StorageEncrypted
        {
            get { return this._storageEncrypted.GetValueOrDefault(); }
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
        /// Specifies the storage throughput value for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to the <code>gp3</code> storage type.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom or Amazon Aurora.
        /// </para>
        /// </summary>
        public int StorageThroughput
        {
            get { return this._storageThroughput.GetValueOrDefault(); }
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
        /// Specifies the storage type to be associated with the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>gp2 | gp3 | io1 | standard</code> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>io1</code> or <code>gp3</code>, you must also include a value
        /// for the <code>Iops</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>io1</code> if the <code>Iops</code> parameter is specified, otherwise
        /// <code>gp2</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Storage is managed by the DB cluster.
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which to associate the instance for TDE encryption.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable.
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
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
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
        /// by <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.TimeZone">Microsoft
        /// SQL Server</a>.
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
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The associated list of EC2 VPC security groups is managed by the DB
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: The default EC2 VPC security group for the DB subnet group's VPC.
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

    }
}