/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBInstance operation.
    /// Creates a new DB instance.
    /// </summary>
    public partial class CreateDBInstanceRequest : AmazonNeptuneRequest
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
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = new List<string>();
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private string _engine;
        private string _engineVersion;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private string _masterUserPassword;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 16384.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 16384.
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 16384.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 16384.
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 16384.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 16384.
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
        /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 16384.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS storage (io1): Must be an integer from 100 to 16384.
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
        /// Indicates that minor engine upgrades are applied automatically to the DB instance
        /// during the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code> 
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
        ///  The EC2 Availability Zone that the DB instance is created in. For information on
        /// AWS Regions and Availability Zones, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
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
        ///  Constraint: The AvailabilityZone parameter can't be specified if the MultiAZ parameter
        /// is set to <code>true</code>. The specified Availability Zone must be in the same AWS
        /// Region as the current endpoint. 
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
        /// For more information, see <a>CreateDBCluster</a>.
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
        /// Cannot be set to 0 if the DB instance is a source to Read Replicas
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
        /// see <a>CreateDBCluster</a>.
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
        /// True to copy all tags from the DB instance to snapshots of the DB instance, and otherwise
        /// false. The default is false.
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
        ///  
        /// <para>
        /// For information on creating a DB cluster, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Type: String
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
        /// see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the Amazon Neptune User Guide. 
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
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>mydbinstance</code> 
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
        /// Gets and sets the property DBName. 
        /// <para>
        /// The meaning of this parameter differs according to the database engine you use.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// is not specified, no database is created in the DB instance.
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
        /// Cannot be a word reserved by the specified database engine
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// is not specified, no database is created in the DB instance.
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
        /// Cannot be a word reserved by the specified database engine
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// The name of the database to create when the DB instance is created. If this parameter
        /// is not specified, the default "postgres" database is created in the DB instance.
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
        /// Must begin with a letter or an underscore. Subsequent characters can be letters, underscores,
        /// or digits (0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a word reserved by the specified database engine
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
        /// Cannot be longer than 8 characters
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
        /// created. If this parameter is not specified, no database is created in the DB instance.
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
        /// Cannot be a word reserved by the specified database engine
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
        /// The name of the DB parameter group to associate with this DB instance. If this argument
        /// is omitted, the default DBParameterGroup for the specified engine is used.
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
        /// Cannot end with a hyphen or contain two consecutive hyphens
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specify the Active Directory Domain to create the instance in.
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
        /// The list of log types that need to be enabled for exporting to CloudWatch Logs.
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
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// True to enable mapping of AWS Identity and Access Management (IAM) accounts to database
        /// accounts, and otherwise false. 
        /// </para>
        ///  
        /// <para>
        /// You can enable IAM database authentication for the following database engines:
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Mapping AWS IAM accounts to database accounts is managed by the DB
        /// cluster. For more information, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For MySQL 5.6, minor version 5.6.34 or higher
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For MySQL 5.7, minor version 5.7.16 or higher
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>false</code> 
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
        /// True to enable Performance Insights for the DB instance, and otherwise false. 
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
        /// The following are the database engines and major and minor versions that are available
        /// with Amazon Neptune. Not every database engine is available for every AWS Region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The version number of the database engine to be used by the DB instance
        /// is managed by the DB cluster. For more information, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>10.2.12</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.2.11</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> </ul>  <ul> <li> 
        /// <para>
        ///  <code>10.1.31</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.1.26</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.1.23</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.1.19</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.1.14</code> (supported in all AWS Regions except us-east-2)
        /// </para>
        ///  </li> </ul>  <ul> <li> 
        /// <para>
        ///  <code>10.0.34</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.0.32</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.0.31</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.0.28</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.0.24</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.0.17</code> (supported in all AWS Regions except us-east-2, ca-central-1,
        /// eu-west-2)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Microsoft SQL Server 2017</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>14.00.1000.169.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Microsoft SQL Server 2016</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>13.00.4451.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>13.00.4422.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>13.00.2164.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Microsoft SQL Server 2014</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>12.00.5546.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.00.5000.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.00.4422.0.v1</code> (supported for all editions except Enterprise Edition,
        /// and all AWS Regions except ca-central-1 and eu-west-2)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Microsoft SQL Server 2012</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>11.00.6594.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.00.6020.0.v1</code> (supported for all editions, and all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.00.5058.0.v1</code> (supported for all editions, and all AWS Regions except
        /// us-east-2, ca-central-1, and eu-west-2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.00.2100.60.v1</code> (supported for all editions, and all AWS Regions except
        /// us-east-2, ca-central-1, and eu-west-2)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Microsoft SQL Server 2008 R2</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>10.50.6529.0.v1</code> (supported for all editions, and all AWS Regions except
        /// us-east-2, ca-central-1, and eu-west-2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.50.6000.34.v1</code> (supported for all editions, and all AWS Regions except
        /// us-east-2, ca-central-1, and eu-west-2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>10.50.2789.0.v1</code> (supported for all editions, and all AWS Regions except
        /// us-east-2, ca-central-1, and eu-west-2)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>5.7.21</code> (supported in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.7.19</code> (supported in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.7.17</code> (supported in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.7.16</code> (supported in all AWS regions)
        /// </para>
        ///  </li> </ul>  <ul> <li> 
        /// <para>
        ///  <code>5.6.39</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.6.37</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.6.35</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.6.34</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.6.29</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.6.27</code> (supported in all AWS Regions except us-east-2, ca-central-1,
        /// eu-west-2)
        /// </para>
        ///  </li> </ul>  <ul> <li> 
        /// <para>
        ///  <code>5.5.59</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.5.57</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.5.54</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.5.53</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5.5.46</code> (supported in all AWS Regions)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Oracle 12c</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>12.1.0.2.v9</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v8</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v7</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v6</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v5</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v4</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v3</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v2</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>12.1.0.2.v1</code> (supported for EE in all AWS regions, and SE2 in all AWS
        /// regions except us-gov-west-1)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Oracle 11g</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>11.2.0.4.v13</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v12</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v11</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v10</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v9</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v8</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v7</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v6</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v5</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v4</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v3</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>11.2.0.4.v1</code> (supported for EE, SE1, and SE, in all AWS regions)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Version 10.1</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version 9.6.x:</b> <code> 9.6.6 | 9.6.5 | 9.6.3 | 9.6.2 | 9.6.1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version 9.5.x:</b> <code> 9.5.9 | 9.5.7 | 9.5.6 | 9.5.4 | 9.5.2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version 9.4.x:</b> <code> 9.4.14 | 9.4.12 | 9.4.11 | 9.4.9 | 9.4.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version 9.3.x:</b> <code> 9.3.19 | 9.3.17 | 9.3.16 | 9.3.14 | 9.3.12</code> 
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
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for the DB instance. For information about valid Iops values, see see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Amazon
        /// Neptune Provisioned IOPS Storage to Improve Performance</a>. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a multiple between 1 and 50 of the storage amount for the DB
        /// instance. Must also be an integer multiple of 1000. For example, if the size of your
        /// DB instance is 500 GiB, then your <code>Iops</code> value can be 2000, 3000, 4000,
        /// or 5000. 
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
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are creating a DB instance with the same AWS account that owns the KMS encryption
        /// key used to encrypt the new DB instance, then you can use the KMS key alias instead
        /// of the ARN for the KM encryption key.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The KMS key identifier is managed by the DB cluster. For more information,
        /// see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>StorageEncrypted</code> parameter is true, and you do not specify a value
        /// for the <code>KmsKeyId</code> parameter, then Amazon Neptune will use your default
        /// encryption key. AWS KMS creates the default encryption key for your AWS account. Your
        /// AWS account has a different default encryption key for each AWS Region.
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
        /// Not applicable. The name for the master user is managed by the DB cluster. For more
        /// information, see <a>CreateDBCluster</a>. 
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
        /// Cannot be a reserved word for the chosen database engine.
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
        /// Cannot be a reserved word for the chosen database engine.
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
        /// Cannot be a reserved word for the chosen database engine.
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
        /// Cannot be a reserved word for the chosen database engine.
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
        /// Cannot be a reserved word for the chosen database engine.
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
        /// Not applicable. The password for the master user is managed by the DB cluster. For
        /// more information, see <a>CreateDBCluster</a>.
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
        /// For information on creating a monitoring role, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html#USER_Monitoring.OS.Enabling">Setting
        /// Up and Enabling Enhanced Monitoring</a>.
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
        /// Specifies if the DB instance is a Multi-AZ deployment. You can't set the AvailabilityZone
        /// parameter if the MultiAZ parameter is set to true.
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// Indicates that the DB instance should be associated with the specified option group.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can't
        /// be removed from an option group, and that option group can't be removed from a DB
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
        /// The AWS KMS key identifier for encryption of Performance Insights data. The KMS key
        /// ID is the Amazon Resource Name (ARN), KMS key identifier, or the KMS key alias for
        /// the KMS encryption key.
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
        ///  Valid Values: <code>1150-65535</code> 
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
        ///  Valid Values: <code>1150-65535</code> 
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
        ///  Valid Values: <code>1150-65535</code> 
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
        ///  Valid Values: <code>1150-65535</code> 
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
        ///  Valid Values: <code>1150-65535</code> except for <code>1434</code>, <code>3389</code>,
        /// <code>47001</code>, <code>49152</code>, and <code>49152</code> through <code>49156</code>.
        /// 
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
        ///  Valid Values: <code>1150-65535</code> 
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
        /// see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">The
        /// Backup Window</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The daily time range for creating automated backups is managed by
        /// the DB cluster. For more information, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        ///  The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region. To see the time blocks available, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow">
        /// Adjusting the Preferred DB Instance Maintenance Window</a>. 
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
        /// Time (UTC). For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#Concepts.DBMaintenance">Amazon
        /// Neptune Maintenance Window</a>. 
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
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which an Aurora Replica is promoted to the primary
        /// instance after a failure of the existing primary instance. For more information, see
        /// <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Aurora.Managing.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a>. 
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
        /// Specifies the accessibility options for the DB instance. A value of true specifies
        /// an Internet-facing instance with a publicly resolvable DNS name, which resolves to
        /// a public IP address. A value of false specifies an internal instance with a DNS name
        /// that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// Default: The default behavior varies depending on whether a VPC has been requested
        /// or not. The following list shows the default behavior in each case.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Default VPC:</b> true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VPC:</b> false
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If no DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance is publicly accessible. If a specific DB subnet
        /// group has been specified as part of the request and the PubliclyAccessible value has
        /// not been set, the DB instance is private.
        /// </para>
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
        /// Specifies whether the DB instance is encrypted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The encryption for DB instances is managed by the DB cluster. For
        /// more information, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: false
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
        /// <code>standard</code> 
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
        /// by <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_SQLServer.html#SQLServer.Concepts.General.TimeZone">Microsoft
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
        /// A list of EC2 VPC security groups to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Aurora</b> 
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The associated list of EC2 VPC security groups is managed by the DB
        /// cluster. For more information, see <a>CreateDBCluster</a>.
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