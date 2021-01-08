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
    /// </summary>
    public partial class CreateDBInstanceRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private int? _backupRetentionPeriod;
        private string _characterSetName;
        private bool? _copyTagsToSnapshot;
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
        private string _masterUsername;
        private string _masterUserPassword;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _ncharCharacterSetName;
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
        /// <param name="allocatedStorage">The amount of storage (in gibibytes) to allocate for the DB instance. Type: Integer  <b>Amazon Aurora</b>  Not applicable. Aurora cluster volumes automatically grow as the amount of data in your database increases, though you are only charged for the space that you use in an Aurora cluster volume.  <b>MySQL</b>  Constraints to the amount of storage for each storage type are the following:  <ul> <li> General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul>  <b>MariaDB</b>  Constraints to the amount of storage for each storage type are the following:  <ul> <li> General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul>  <b>PostgreSQL</b>  Constraints to the amount of storage for each storage type are the following:  <ul> <li> General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 5 to 3072. </li> </ul>  <b>Oracle</b>  Constraints to the amount of storage for each storage type are the following:  <ul> <li> General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. </li> <li> Provisioned IOPS storage (io1): Must be an integer from 100 to 65536. </li> <li> Magnetic storage (standard): Must be an integer from 10 to 3072. </li> </ul>  <b>SQL Server</b>  Constraints to the amount of storage for each storage type are the following:  <ul> <li> General Purpose (SSD) storage (gp2): <ul> <li> Enterprise and Standard editions: Must be an integer from 200 to 16384. </li> <li> Web and Express editions: Must be an integer from 20 to 16384. </li> </ul> </li> <li> Provisioned IOPS storage (io1): <ul> <li> Enterprise and Standard editions: Must be an integer from 200 to 16384. </li> <li> Web and Express editions: Must be an integer from 100 to 16384. </li> </ul> </li> <li> Magnetic storage (standard): <ul> <li> Enterprise and Standard editions: Must be an integer from 200 to 1024. </li> <li> Web and Express editions: Must be an integer from 20 to 1024. </li> </ul> </li> </ul></param>
        /// <param name="dbInstanceClass">The compute and memory capacity of the DB instance, for example, <code>db.m4.large</code>. Not all DB instance classes are available in all AWS Regions, or for all database engines. For the full list of DB instance classes, and availability for your engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB Instance Class</a> in the <i>Amazon RDS User Guide.</i> </param>
        /// <param name="engine">The name of the database engine to be used for this instance.  Not every database engine is available for every AWS Region.  Valid Values:  <ul> <li>  <code>aurora</code> (for MySQL 5.6-compatible Aurora) </li> <li>  <code>aurora-mysql</code> (for MySQL 5.7-compatible Aurora) </li> <li>  <code>aurora-postgresql</code>  </li> <li>  <code>mariadb</code>  </li> <li>  <code>mysql</code>  </li> <li>  <code>oracle-ee</code>  </li> <li>  <code>oracle-se2</code>  </li> <li>  <code>oracle-se1</code>  </li> <li>  <code>oracle-se</code>  </li> <li>  <code>postgres</code>  </li> <li>  <code>sqlserver-ee</code>  </li> <li>  <code>sqlserver-se</code>  </li> <li>  <code>sqlserver-ex</code>  </li> <li>  <code>sqlserver-web</code>  </li> </ul></param>
        /// <param name="masterUsername">The name for the master user.  <b>Amazon Aurora</b>  Not applicable. The name for the master user is managed by the DB cluster.   <b>MariaDB</b>  Constraints: <ul> <li> Required for MariaDB. </li> <li> Must be 1 to 16 letters or numbers. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul>  <b>Microsoft SQL Server</b>  Constraints: <ul> <li> Required for SQL Server. </li> <li> Must be 1 to 128 letters or numbers. </li> <li> The first character must be a letter. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul>  <b>MySQL</b>  Constraints: <ul> <li> Required for MySQL. </li> <li> Must be 1 to 16 letters or numbers. </li> <li> First character must be a letter. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul>  <b>Oracle</b>  Constraints: <ul> <li> Required for Oracle. </li> <li> Must be 1 to 30 letters or numbers. </li> <li> First character must be a letter. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul>  <b>PostgreSQL</b>  Constraints: <ul> <li> Required for PostgreSQL. </li> <li> Must be 1 to 63 letters or numbers. </li> <li> First character must be a letter. </li> <li> Can't be a reserved word for the chosen database engine. </li> </ul></param>
        /// <param name="masterUserPassword">The password for the master user. The password can include any printable ASCII character except "/", """, or "@".  <b>Amazon Aurora</b>  Not applicable. The password for the master user is managed by the DB cluster.  <b>MariaDB</b>  Constraints: Must contain from 8 to 41 characters.  <b>Microsoft SQL Server</b>  Constraints: Must contain from 8 to 128 characters.  <b>MySQL</b>  Constraints: Must contain from 8 to 41 characters.  <b>Oracle</b>  Constraints: Must contain from 8 to 30 characters.  <b>PostgreSQL</b>  Constraints: Must contain from 8 to 128 characters.</param>
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
        /// The amount of storage (in gibibytes) to allocate for the DB instance.
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
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints to the amount of storage for each storage type are the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536.
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536.
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536.
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536.
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
        /// General Purpose (SSD) storage (gp2):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Enterprise and Standard editions: Must be an integer from 200 to 16384.
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
        /// Enterprise and Standard editions: Must be an integer from 200 to 16384.
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
        /// Enterprise and Standard editions: Must be an integer from 200 to 1024.
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
        ///  The Availability Zone (AZ) where the database will be created. For information on
        /// AWS Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>. 
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's AWS Region.
        /// </para>
        ///  
        /// <para>
        ///  Example: <code>us-east-1d</code> 
        /// </para>
        ///  
        /// <para>
        ///  Constraint: The <code>AvailabilityZone</code> parameter can't be specified if the
        /// DB instance is a Multi-AZ deployment. The specified Availability Zone must be in the
        /// same AWS Region as the current endpoint. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're creating a DB instance in an RDS on VMware environment, specify the identifier
        /// of the custom Availability Zone to create the DB instance in.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
        /// RDS on VMware User Guide.</a> 
        /// </para>
        ///  </note>
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
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// For supported engines, indicates that the DB instance should be associated with the
        /// specified CharacterSet.
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The identifier of the DB cluster that the instance will belong to.
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
        /// The compute and memory capacity of the DB instance, for example, <code>db.m4.large</code>.
        /// Not all DB instance classes are available in all AWS Regions, or for all database
        /// engines. For the full list of DB instance classes, and availability for your engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide.</i> 
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
        /// isn't specified, no database is created in the DB instance.
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
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Must be null.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// The name of the database to create when the primary instance of the DB cluster is
        /// created. If this parameter isn't specified, no database is created in the DB instance.
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
        /// Can't be a word reserved by the specified database engine
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
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
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
        /// Default: The default DB security group for the database engine.
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
        /// If there is no DB subnet group, then it is a non-VPC DB instance.
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
        /// protection is disabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
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
        /// values in the list depend on the DB engine being used. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs </a> in the <i>Amazon Relational Database
        /// Service User Guide</i>.
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
        /// and <code>trace</code>. 
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
        /// with Amazon RDS on AWS Outposts</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about CoIPs, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-networking-components.html#ip-addressing">Customer-owned
        /// IP addresses</a> in the <i>AWS Outposts User Guide</i>.
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
        /// A value that indicates whether to enable mapping of AWS Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping is disabled.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora. Mapping AWS IAM accounts to database
        /// accounts is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide.</i> 
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
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
        /// Amazon Performance Insights</a> in the <i>Amazon Relational Database Service User
        /// Guide</i>. 
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
        /// Not every database engine is available for every AWS Region. 
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
        ///  <code>aurora-mysql</code> (for MySQL 5.7-compatible Aurora)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql</code> 
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
        ///  <code>oracle-se2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se</code> 
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
        /// action.
        /// </para>
        ///  
        /// <para>
        /// The following are the database engines and links to information about the major and
        /// minor versions that are available with Amazon RDS. Not every database engine is available
        /// for every AWS Region.
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
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MariaDB.html#MariaDB.Concepts.VersionMgmt">MariaDB
        /// on Amazon RDS Versions</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Microsoft SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.VersionSupport">Microsoft
        /// SQL Server Versions on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MySQL.html#MySQL.Concepts.VersionMgmt">MySQL
        /// on Amazon RDS Versions</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.Oracle.PatchComposition.html">Oracle
        /// Database Engine Release Notes</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_PostgreSQL.html#PostgreSQL.Concepts.General.DBVersions">Supported
        /// PostgreSQL Database Versions</a> in the <i>Amazon RDS User Guide.</i> 
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
        /// allocated for the DB instance. For information about valid Iops values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Amazon
        /// RDS Provisioned IOPS Storage to Improve Performance</a> in the <i>Amazon RDS User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: For MariaDB, MySQL, Oracle, and PostgreSQL DB instances, must be a multiple
        /// between .5 and 50 of the storage amount for the DB instance. For SQL Server DB instances,
        /// must be a multiple between 1 and 50 of the storage amount for the DB instance. 
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
        /// The AWS KMS key identifier for an encrypted DB instance.
        /// </para>
        ///  
        /// <para>
        /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the
        /// AWS KMS customer master key (CMK). To use a CMK in a different AWS account, specify
        /// the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The AWS KMS key identifier is managed by the DB cluster. For more
        /// information, see <code>CreateDBCluster</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>StorageEncrypted</code> is enabled, and you do not specify a value for the
        /// <code>KmsKeyId</code> parameter, then Amazon RDS uses your default CMK. There is a
        /// default CMK for your AWS account. Your AWS account has a different default CMK for
        /// each AWS Region.
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
        ///  Valid values: <code>license-included</code> | <code>bring-your-own-license</code>
        /// | <code>general-public-license</code> 
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
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required for MariaDB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be 1 to 16 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a reserved word for the chosen database engine.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Microsoft SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required for SQL Server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be 1 to 128 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a reserved word for the chosen database engine.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required for MySQL.
        /// </para>
        ///  </li> <li> 
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
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required for Oracle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be 1 to 30 letters or numbers.
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
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required for PostgreSQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be 1 to 63 letters or numbers.
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
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit to which Amazon RDS can automatically scale the storage of the DB
        /// instance.
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
        /// for the DB instance. To disable collecting Enhanced Monitoring metrics, specify 0.
        /// The default is 0.
        /// </para>
        ///  
        /// <para>
        /// If <code>MonitoringRoleArn</code> is specified, then you must also set <code>MonitoringInterval</code>
        /// to a value other than 0.
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
        /// For information on creating a monitoring role, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html#USER_Monitoring.OS.Enabling">Setting
        /// Up and Enabling Enhanced Monitoring</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <code>MonitoringInterval</code> is set to a value other than 0, then you must supply
        /// a <code>MonitoringRoleArn</code> value.
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// Indicates that the DB instance should be associated with the specified option group.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can't
        /// be removed from an option group. Also, that option group can't be removed from a DB
        /// instance once it is associated with a DB instance
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
        /// The AWS KMS key identifier for encryption of Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the
        /// AWS KMS customer master key (CMK).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for <code>PerformanceInsightsKMSKeyId</code>, then Amazon
        /// RDS uses your default CMK. There is a default CMK for your AWS account. Your AWS account
        /// has a different default CMK for each AWS Region.
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
        /// The amount of time, in days, to retain Performance Insights data. Valid values are
        /// 7 or 731 (2 years). 
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
        ///  Default: <code>3306</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>1150-65535</code> 
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
        ///  Default: <code>3306</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>1150-65535</code> 
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
        ///  Default: <code>5432</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>1150-65535</code> 
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
        ///  Default: <code>1521</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        ///  Default: <code>1433</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>1150-65535</code> except <code>1234</code>, <code>1434</code>,
        /// <code>3260</code>, <code>3343</code>, <code>3389</code>, <code>47001</code>, and <code>49152-49156</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        ///  Default: <code>3306</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>1150-65535</code> 
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
        ///  The daily time range during which automated backups are created if automated backups
        /// are enabled, using the <code>BackupRetentionPeriod</code> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">The
        /// Backup Window</a> in the <i>Amazon RDS User Guide</i>. 
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
        ///  The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region. To see the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow">
        /// Adjusting the Preferred DB Instance Maintenance Window</a> in the <i>Amazon RDS User
        /// Guide</i>. 
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
        ///  Format: <code>ddd:hh24:mi-ddd:hh24:mi</code> 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region, occurring on a random day of the week. 
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
        /// 
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
        /// When the DB instance is publicly accessible, its DNS endpoint resolves to the private
        /// IP address from within the DB instance's VPC, and to the public IP address from outside
        /// of the DB instance's VPC. Access to the DB instance is ultimately controlled by the
        /// security group it uses, and that public access is not permitted if the security group
        /// assigned to the DB instance doesn't permit it.
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
        /// If the default VPC in the target region doesn’t have an Internet gateway attached
        /// to it, the DB instance is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the default VPC in the target region has an Internet gateway attached to it, the
        /// DB instance is public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <code>DBSubnetGroupName</code> is specified, and <code>PubliclyAccessible</code>
        /// isn't specified, the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the subnets are part of a VPC that doesn’t have an Internet gateway attached to
        /// it, the DB instance is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the subnets are part of a VPC that has an Internet gateway attached to it, the
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies the storage type to be associated with the DB instance.
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>standard | gp2 | io1</code> 
        /// </para>
        ///  
        /// <para>
        ///  If you specify <code>io1</code>, you must also include a value for the <code>Iops</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        ///  Default: <code>io1</code> if the <code>Iops</code> parameter is specified, otherwise
        /// <code>gp2</code> 
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