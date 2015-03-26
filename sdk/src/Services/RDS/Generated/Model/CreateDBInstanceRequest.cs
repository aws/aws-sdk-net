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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbName;
        private string _dbParameterGroupName;
        private List<string> _dbSecurityGroups = new List<string>();
        private string _dbSubnetGroupName;
        private string _engine;
        private string _engineVersion;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private string _masterUserPassword;
        private bool? _multiAZ;
        private string _optionGroupName;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private bool? _storageEncrypted;
        private string _storageType;
        private List<Tag> _tags = new List<Tag>();
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier"> The DB instance identifier. This parameter is stored as a lowercase string.  Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens (1 to 15 for SQL Server).</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive hyphens.</li> </ul> Example: <code>mydbinstance</code></param>
        /// <param name="allocatedStorage"> The amount of storage (in gigabytes) to be initially allocated for the database instance.   Type: Integer <b>MySQL</b>  Constraints: Must be an integer from 5 to 3072. <b>PostgreSQL</b>  Constraints: Must be an integer from 5 to 3072. <b>Oracle</b>  Constraints: Must be an integer from 10 to 3072. <b>SQL Server</b>  Constraints: Must be an integer from 200 to 1024 (Standard Edition and Enterprise Edition) or from 20 to 1024 (Express Edition and Web Edition)</param>
        /// <param name="dbInstanceClass"> The compute and memory capacity of the DB instance.   Valid Values: <code>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge | db.m2.xlarge |db.m2.2xlarge | db.m2.4xlarge | db.m3.medium | db.m3.large | db.m3.xlarge | db.m3.2xlarge | db.r3.large | db.r3.xlarge | db.r3.2xlarge | db.r3.4xlarge | db.r3.8xlarge | db.t2.micro | db.t2.small | db.t2.medium</code> </param>
        /// <param name="engine"> The name of the database engine to be used for this instance.   Valid Values: <code>MySQL</code> | <code>oracle-se1</code> | <code>oracle-se</code> | <code>oracle-ee</code> | <code>sqlserver-ee</code> | <code>sqlserver-se</code> | <code>sqlserver-ex</code> | <code>sqlserver-web</code> | <code>postgres</code>   Not every database engine is available for every AWS region. </param>
        /// <param name="masterUsername"> The name of master user for the client DB instance.  <b>MySQL</b> Constraints: <ul> <li>Must be 1 to 16 alphanumeric characters.</li> <li>First character must be a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li> </ul> Type: String <b>Oracle</b> Constraints: <ul> <li>Must be 1 to 30 alphanumeric characters.</li> <li>First character must be a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li> </ul> <b>SQL Server</b> Constraints: <ul> <li>Must be 1 to 128 alphanumeric characters.</li> <li>First character must be a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li> </ul></param>
        /// <param name="masterUserPassword"> The password for the master database user. Can be any printable ASCII character except "/", """, or "@".  Type: String <b>MySQL</b>  Constraints: Must contain from 8 to 41 characters.  <b>Oracle</b>  Constraints: Must contain from 8 to 30 characters.  <b>SQL Server</b>  Constraints: Must contain from 8 to 128 characters. </param>
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
        ///  The amount of storage (in gigabytes) to be initially allocated for the database instance.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Type: Integer
        /// </para>
        ///  
        /// <para>
        /// <b>MySQL</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be an integer from 5 to 3072.
        /// </para>
        ///  
        /// <para>
        /// <b>PostgreSQL</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be an integer from 5 to 3072.
        /// </para>
        ///  
        /// <para>
        /// <b>Oracle</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be an integer from 10 to 3072.
        /// </para>
        ///  
        /// <para>
        /// <b>SQL Server</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be an integer from 200 to 1024 (Standard Edition and Enterprise
        /// Edition) or from 20 to 1024 (Express Edition and Web Edition)
        /// </para>
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
        ///  Indicates that minor engine upgrades will be applied automatically to the DB instance
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
        ///  The EC2 Availability Zone that the database instance will be created in. For information
        /// on regions and Availability Zones, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Default: A random, system-chosen Availability Zone in the endpoint's region. 
        /// </para>
        ///  
        /// <para>
        ///  Example: <code>us-east-1d</code> 
        /// </para>
        ///  
        /// <para>
        ///  Constraint: The AvailabilityZone parameter cannot be specified if the MultiAZ parameter
        /// is set to <code>true</code>. The specified Availability Zone must be in the same region
        /// as the current endpoint. 
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
        ///  The number of days for which automated backups are retained. Setting this parameter
        /// to a positive number enables backups. Setting this parameter to 0 disables automated
        /// backups. 
        /// </para>
        ///  
        /// <para>
        ///  Default: 1 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be a value from 0 to 35</li> <li>Cannot be set to 0 if the DB instance
        /// is a source to Read Replicas</li> </ul>
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
        ///  For supported engines, indicates that the DB instance should be associated with the
        /// specified CharacterSet. 
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        ///  The compute and memory capacity of the DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <code>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge
        /// | db.m2.xlarge |db.m2.2xlarge | db.m2.4xlarge | db.m3.medium | db.m3.large | db.m3.xlarge
        /// | db.m3.2xlarge | db.r3.large | db.r3.xlarge | db.r3.2xlarge | db.r3.4xlarge | db.r3.8xlarge
        /// | db.t2.micro | db.t2.small | db.t2.medium</code> 
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
        ///  The DB instance identifier. This parameter is stored as a lowercase string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens (1 to 15 for
        /// SQL Server).</li> <li>First character must be a letter.</li> <li>Cannot end with a
        /// hyphen or contain two consecutive hyphens.</li> </ul> 
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
        /// <b>MySQL</b>
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
        ///  <ul> <li>Must contain 1 to 64 alphanumeric characters</li> <li>Cannot be a word reserved
        /// by the specified database engine</li> </ul> 
        /// <para>
        /// <b>PostgreSQL</b>
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
        ///  <ul> <li>Must contain 1 to 63 alphanumeric characters</li> <li>Must begin with a
        /// letter or an underscore. Subsequent characters can be letters, underscores, or digits
        /// (0-9).</li> <li>Cannot be a word reserved by the specified database engine</li> </ul>
        /// 
        /// <para>
        /// <b>Oracle</b>
        /// </para>
        ///  
        /// <para>
        ///  The Oracle System ID (SID) of the created DB instance. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>ORCL</code>
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Cannot be longer than 8 characters</li> </ul> 
        /// <para>
        /// <b>SQL Server</b>
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Must be null.
        /// </para>
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
        ///  The name of the DB parameter group to associate with this DB instance. If this argument
        /// is omitted, the default DBParameterGroup for the specified engine will be used. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: 
        /// </para>
        ///  <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be
        /// a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul>
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
        ///  A list of DB security groups to associate with this DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Default: The default DB security group for the database engine. 
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
        ///  A DB subnet group to associate with this DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  If there is no DB subnet group, then it is a non-VPC DB instance. 
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
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The name of the database engine to be used for this instance. 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <code>MySQL</code> | <code>oracle-se1</code> | <code>oracle-se</code>
        /// | <code>oracle-ee</code> | <code>sqlserver-ee</code> | <code>sqlserver-se</code> |
        /// <code>sqlserver-ex</code> | <code>sqlserver-web</code> | <code>postgres</code> 
        /// </para>
        ///  
        /// <para>
        ///  Not every database engine is available for every AWS region. 
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
        ///  The version number of the database engine to use. 
        /// </para>
        ///  
        /// <para>
        ///  The following are the database engines and major and minor versions that are available
        /// with Amazon RDS. Not every database engine is available for every AWS region. 
        /// </para>
        ///  
        /// <para>
        /// <b>MySQL</b>
        /// </para>
        ///  <ul> <li> <b>Version 5.1:</b> <code> 5.1.45 | 5.1.49 | 5.1.50 | 5.1.57 | 5.1.61 |
        /// 5.1.62 | 5.1.63 | 5.1.69 | 5.1.71 | 5.1.73</code> </li> <li> <b>Version 5.5:</b> <code>
        /// 5.5.12 | 5.5.20 | 5.5.23 | 5.5.25a | 5.5.27 | 5.5.31 | 5.5.33 | 5.5.37 | 5.5.38 |
        /// 5.5.8</code> </li> <li> <b>Version 5.6:</b> <code> 5.6.12 | 5.6.13 | 5.6.17 | 5.6.19
        /// | 5.6.21</code> </li> </ul> 
        /// <para>
        /// <b>Oracle Database Enterprise Edition (oracle-ee)</b>
        /// </para>
        ///  <ul> <li> <b>Version 11.2:</b> <code> 11.2.0.2.v3 | 11.2.0.2.v4 | 11.2.0.2.v5 | 11.2.0.2.v6
        /// | 11.2.0.2.v7 | 11.2.0.3.v1 | 11.2.0.4.v1</code> </li> </ul> 
        /// <para>
        /// <b>Oracle Database Standard Edition (oracle-se)</b>
        /// </para>
        ///  <ul> <li> <b>Version 11.2:</b> <code> 11.2.0.2.v3 | 11.2.0.2.v4 | 11.2.0.2.v5 | 11.2.0.2.v6
        /// | 11.2.0.2.v7 | 11.2.0.3.v1 | 11.2.0.4.v1</code> </li> </ul> 
        /// <para>
        /// <b>Oracle Database Standard Edition One (oracle-se1)</b>
        /// </para>
        ///  <ul> <li> <b>Version 11.2:</b> <code> 11.2.0.2.v3 | 11.2.0.2.v4 | 11.2.0.2.v5 | 11.2.0.2.v6
        /// | 11.2.0.2.v7 | 11.2.0.3.v1 | 11.2.0.4.v1</code> </li> </ul> 
        /// <para>
        /// <b>PostgreSQL</b>
        /// </para>
        ///  <ul> <li> <b>Version 9.3:</b> <code> 9.3.1 | 9.3.2 | 9.3.3</code> </li> </ul> 
        /// <para>
        /// <b>Microsoft SQL Server Enterprise Edition (sqlserver-ee)</b>
        /// </para>
        ///  <ul> <li> <b>Version 10.5:</b> <code> 10.50.2789.0.v1</code> </li> <li> <b>Version
        /// 11.0:</b> <code> 11.00.2100.60.v1</code> </li> </ul> 
        /// <para>
        /// <b>Microsoft SQL Server Express Edition (sqlserver-ex)</b>
        /// </para>
        ///  <ul> <li> <b>Version 10.5:</b> <code> 10.50.2789.0.v1</code> </li> <li> <b>Version
        /// 11.0:</b> <code> 11.00.2100.60.v1</code> </li> </ul> 
        /// <para>
        /// <b>Microsoft SQL Server Standard Edition (sqlserver-se)</b>
        /// </para>
        ///  <ul> <li> <b>Version 10.5:</b> <code> 10.50.2789.0.v1</code> </li> <li> <b>Version
        /// 11.0:</b> <code> 11.00.2100.60.v1</code> </li> </ul> 
        /// <para>
        /// <b>Microsoft SQL Server Web Edition (sqlserver-web)</b>
        /// </para>
        ///  <ul> <li> <b>Version 10.5:</b> <code> 10.50.2789.0.v1</code> </li> <li> <b>Version
        /// 11.0:</b> <code> 11.00.2100.60.v1</code> </li> </ul>
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
        ///  The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for the DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: To use PIOPS, this value must be an integer greater than 1000.
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
        ///  The KMS key identifier for an encrypted DB instance. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resoure Name (ARN) for the KMS encryption key.
        /// If you are creating a DB instance with the same AWS account that owns the KMS encryption
        /// key used to encrypt the new DB instance, then you can use the KMS key alias instead
        /// of the ARN for the KM encryption key.
        /// </para>
        ///  
        /// <para>
        /// If the <code>StorageEncrypted</code> parameter is true, and you do not specify a value
        /// for the <code>KmsKeyId</code> parameter, then Amazon RDS will use your default encryption
        /// key. AWS KMS creates the default encryption key for your AWS account. Your AWS account
        /// has a different default encryption key for each AWS region.
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
        ///  License model information for this DB instance. 
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
        ///  The name of master user for the client DB instance. 
        /// </para>
        ///  
        /// <para>
        /// <b>MySQL</b>
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be 1 to 16 alphanumeric characters.</li> <li>First character must be
        /// a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li>
        /// </ul> 
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// <b>Oracle</b>
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be 1 to 30 alphanumeric characters.</li> <li>First character must be
        /// a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li>
        /// </ul> 
        /// <para>
        /// <b>SQL Server</b>
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be 1 to 128 alphanumeric characters.</li> <li>First character must
        /// be a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li>
        /// </ul>
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
        ///  The password for the master database user. Can be any printable ASCII character except
        /// "/", """, or "@". 
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// <b>MySQL</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must contain from 8 to 41 characters. 
        /// </para>
        ///  
        /// <para>
        /// <b>Oracle</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must contain from 8 to 30 characters. 
        /// </para>
        ///  
        /// <para>
        /// <b>SQL Server</b>
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must contain from 8 to 128 characters. 
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
        ///  Specifies if the DB instance is a Multi-AZ deployment. You cannot set the AvailabilityZone
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
        ///  Indicates that the DB instance should be associated with the specified option group.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Permanent options, such as the TDE option for Oracle Advanced Security TDE, cannot
        /// be removed from an option group, and that option group cannot be removed from a DB
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
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port number on which the database accepts connections. 
        /// </para>
        ///  
        /// <para>
        /// <b>MySQL</b>
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
        /// <b>PostgreSQL</b>
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
        /// <b>Oracle</b>
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
        /// <b>SQL Server</b>
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
        /// see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.BackingUpAndRestoringAmazonRDSInstances.html">DB
        /// Instance Backups</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Default: A 30-minute window selected at random from an 8-hour block of time per region.
        /// See the Amazon RDS User Guide for the time blocks for each region from which the default
        /// backup windows are assigned. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be in the format <code>hh24:mi-hh24:mi</code>. Times should be
        /// Universal Time Coordinated (UTC). Must not conflict with the preferred maintenance
        /// window. Must be at least 30 minutes. 
        /// </para>
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
        ///  The weekly time range (in UTC) during which system maintenance can occur. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBMaintenance.html">DB
        /// Instance Maintenance</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Format: <code>ddd:hh24:mi-ddd:hh24:mi</code> 
        /// </para>
        ///  
        /// <para>
        ///  Default: A 30-minute window selected at random from an 8-hour block of time per region,
        /// occurring on a random day of the week. To see the time blocks available, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/AdjustingTheMaintenanceWindow.html">
        /// Adjusting the Preferred Maintenance Window</a> in the Amazon RDS User Guide. 
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///  Specifies the accessibility options for the DB instance. A value of true specifies
        /// an Internet-facing instance with a publicly resolvable DNS name, which resolves to
        /// a public IP address. A value of false specifies an internal instance with a DNS name
        /// that resolves to a private IP address. 
        /// </para>
        ///  
        /// <para>
        ///  Default: The default behavior varies depending on whether a VPC has been requested
        /// or not. The following list shows the default behavior in each case. 
        /// </para>
        ///  <ul> <li> <b>Default VPC:</b> true</li> <li> <b>VPC:</b> false</li> </ul> 
        /// <para>
        ///  If no DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance will be publicly accessible. If a specific
        /// DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance will be private. 
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
        ///  Specifies whether the DB instance is encrypted. 
        /// </para>
        ///  
        /// <para>
        ///  Default: false 
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
        ///  Specifies the storage type to be associated with the DB instance. 
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
        ///  Default: <code>io1</code> if the <code>Iops</code> parameter is specified; otherwise
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
        ///  The ARN from the Key Store with which to associate the instance for TDE encryption.
        /// 
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
        ///  The password for the given ARN from the Key Store in order to access the device.
        /// 
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///  A list of EC2 VPC security groups to associate with this DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Default: The default EC2 VPC security group for the DB subnet group's VPC. 
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