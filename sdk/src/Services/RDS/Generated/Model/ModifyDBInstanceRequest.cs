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
    /// Container for the parameters to the ModifyDBInstance operation.
    /// Modify settings for a DB instance. You can change one or more database configuration
    /// parameters by specifying these parameters and the new values in the request.
    /// </summary>
    public partial class ModifyDBInstanceRequest : AmazonRDSRequest
    {
        private int? _allocatedStorage;
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private bool? _autoMinorVersionUpgrade;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private bool? _copyTagsToSnapshot;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbParameterGroupName;
        private int? _dbPortNumber;
        private List<string> _dbSecurityGroups = new List<string>();
        private string _engineVersion;
        private int? _iops;
        private string _masterUserPassword;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _newDBInstanceIdentifier;
        private string _optionGroupName;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _storageType;
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyDBInstanceRequest() { }

        /// <summary>
        /// Instantiates ModifyDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier"> The DB instance identifier. This value is stored as a lowercase string.  Constraints: <ul> <li>Must be the identifier for an existing DB instance</li> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        public ModifyDBInstanceRequest(string dbInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  The new storage capacity of the RDS instance. Changing this setting does not result
        /// in an outage and the change is applied during the next maintenance window unless <code>ApplyImmediately</code>
        /// is set to <code>true</code> for this request. 
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 5-6144
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values
        /// that are not at least 10% greater than the existing value are rounded up so that they
        /// are 10% greater than the current value.
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
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 5-6144
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values
        /// that are not at least 10% greater than the existing value are rounded up so that they
        /// are 10% greater than the current value.
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
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 5-6144
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values
        /// that are not at least 10% greater than the existing value are rounded up so that they
        /// are 10% greater than the current value.
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
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 10-6144
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values
        /// that are not at least 10% greater than the existing value are rounded up so that they
        /// are 10% greater than the current value.
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Cannot be modified.
        /// </para>
        ///  
        /// <para>
        ///  If you choose to migrate your DB instance from using standard storage to using Provisioned
        /// IOPS, or from using Provisioned IOPS to using standard storage, the process can take
        /// time. The duration of the migration depends on several factors such as database load,
        /// storage size, storage type (standard or Provisioned IOPS), amount of IOPS provisioned
        /// (if any), and the number of prior scale storage operations. Typical migration times
        /// are under 24 hours, but the process can take up to several days in some cases. During
        /// the migration, the DB instance will be available for use, but might experience performance
        /// degradation. While the migration takes place, nightly backups for the instance will
        /// be suspended. No other Amazon RDS operations can take place for the instance, including
        /// modifying the instance, rebooting the instance, deleting the instance, creating a
        /// Read Replica for the instance, and creating a DB snapshot of the instance. 
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
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        ///  Indicates that major version upgrades are allowed. Changing this parameter does not
        /// result in an outage and the change is asynchronously applied as soon as possible.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints: This parameter must be set to true when specifying a value for the EngineVersion
        /// parameter that is a different major version than the DB instance's current version.
        /// </para>
        /// </summary>
        public bool AllowMajorVersionUpgrade
        {
            get { return this._allowMajorVersionUpgrade.GetValueOrDefault(); }
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
        /// are asynchronously applied as soon as possible, regardless of the <code>PreferredMaintenanceWindow</code>
        /// setting for the DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  If this parameter is set to <code>false</code>, changes to the DB instance are applied
        /// during the next maintenance window. Some parameter changes can cause an outage and
        /// will be applied on the next call to <a>RebootDBInstance</a>, or the next failure reboot.
        /// Review the table of parameters in <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.DBInstance.Modifying.html">Modifying
        /// a DB Instance and Using the Apply Immediately Parameter</a> to see the impact that
        /// setting <code>ApplyImmediately</code> to <code>true</code> or <code>false</code> has
        /// for each modified parameter and to determine when the changes will be applied. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
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
        ///  Indicates that minor version upgrades will be applied automatically to the DB instance
        /// during the maintenance window. Changing this parameter does not result in an outage
        /// except in the following case and the change is asynchronously applied as soon as possible.
        /// An outage will result if this parameter is set to <code>true</code> during the maintenance
        /// window, and a newer minor version is available, and RDS has enabled auto patching
        /// for that engine version. 
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        ///  The number of days to retain automated backups. Setting this parameter to a positive
        /// number enables backups. Setting this parameter to 0 disables automated backups. 
        /// </para>
        ///  
        /// <para>
        /// Changing this parameter can result in an outage if you change from 0 to a non-zero
        /// value or from a non-zero value to 0. These changes are applied during the next maintenance
        /// window unless the <code>ApplyImmediately</code> parameter is set to <code>true</code>
        /// for this request. If you change the parameter from one non-zero value to another non-zero
        /// value, the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be a value from 0 to 35</li> <li>Can be specified for a MySQL Read
        /// Replica only if the source is running MySQL 5.6</li> <li>Can be specified for a PostgreSQL
        /// Read Replica only if the source is running PostgreSQL 9.3.5</li> <li>Cannot be set
        /// to 0 if the DB instance is a source to Read Replicas</li> </ul>
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
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        ///  Indicates the certificate that needs to be associated with the instance. 
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
        /// True to copy all tags from the DB instance to snapshots of the DB instance; otherwise
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        ///  The new compute and memory capacity of the DB instance. To determine the instance
        /// classes that are available for a particular DB engine, use the <a>DescribeOrderableDBInstanceOptions</a>
        /// action. 
        /// </para>
        ///  
        /// <para>
        ///  Passing a value for this setting causes an outage during the change and is applied
        /// during the next maintenance window, unless <code>ApplyImmediately</code> is specified
        /// as <code>true</code> for this request. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge
        /// | db.m2.xlarge | db.m2.2xlarge | db.m2.4xlarge | db.m3.medium | db.m3.large | db.m3.xlarge
        /// | db.m3.2xlarge | db.m4.large | db.m4.xlarge | db.m4.2xlarge | db.m4.4xlarge | db.m4.10xlarge
        /// | db.r3.large | db.r3.xlarge | db.r3.2xlarge | db.r3.4xlarge | db.r3.8xlarge | db.t2.micro
        /// | db.t2.small | db.t2.medium | db.t2.large</code>
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
        ///  The DB instance identifier. This value is stored as a lowercase string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be the identifier for an existing DB instance</li> <li>Must contain
        /// from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a
        /// letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
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
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        ///  The name of the DB parameter group to apply to the DB instance. Changing this setting
        /// does not result in an outage. The parameter group name itself is changed immediately,
        /// but the actual parameter changes are not applied until you reboot the instance without
        /// failover. The db instance will NOT be rebooted automatically and the parameter changes
        /// will NOT be applied during the next maintenance window. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints: The DB parameter group must be in the same DB parameter group family
        /// as this DB instance.
        /// </para>
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
        ///  The port number on which the database accepts connections. 
        /// </para>
        ///  
        /// <para>
        /// The value of the <code>DBPortNumber</code> parameter must not match any of the port
        /// values specified for options in the option group for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Your database will restart when you change the <code>DBPortNumber</code> value regardless
        /// of the value of the <code>ApplyImmediately</code> parameter.
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
        /// </summary>
        public int DBPortNumber
        {
            get { return this._dbPortNumber.GetValueOrDefault(); }
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
        ///  A list of DB security groups to authorize on this DB instance. Changing this setting
        /// does not result in an outage and the change is asynchronously applied as soon as possible.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be
        /// a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul>
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The version number of the database engine to upgrade to. Changing this parameter
        /// results in an outage and the change is applied during the next maintenance window
        /// unless the <code>ApplyImmediately</code> parameter is set to <code>true</code> for
        /// this request. 
        /// </para>
        ///  
        /// <para>
        ///  For major version upgrades, if a non-default DB parameter group is currently in use,
        /// a new DB parameter group in the DB parameter group family for the new engine version
        /// must be specified. The new DB parameter group can be the default for that DB parameter
        /// group family. 
        /// </para>
        ///  
        /// <para>
        /// For a list of valid engine versions, see <a>CreateDBInstance</a>.
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
        ///  The new Provisioned IOPS (I/O operations per second) value for the RDS instance.
        /// Changing this setting does not result in an outage and the change is applied during
        /// the next maintenance window unless the <code>ApplyImmediately</code> parameter is
        /// set to <code>true</code> for this request. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values
        /// that are not at least 10% greater than the existing value are rounded up so that they
        /// are 10% greater than the current value. If you are migrating from Provisioned IOPS
        /// to standard storage, set this value to 0. The DB instance will require a reboot for
        /// the change in storage type to take effect.
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Setting the IOPS value for the SQL Server database engine is not supported.
        /// </para>
        ///  
        /// <para>
        /// Type: Integer
        /// </para>
        ///  
        /// <para>
        ///  If you choose to migrate your DB instance from using standard storage to using Provisioned
        /// IOPS, or from using Provisioned IOPS to using standard storage, the process can take
        /// time. The duration of the migration depends on several factors such as database load,
        /// storage size, storage type (standard or Provisioned IOPS), amount of IOPS provisioned
        /// (if any), and the number of prior scale storage operations. Typical migration times
        /// are under 24 hours, but the process can take up to several days in some cases. During
        /// the migration, the DB instance will be available for use, but might experience performance
        /// degradation. While the migration takes place, nightly backups for the instance will
        /// be suspended. No other Amazon RDS operations can take place for the instance, including
        /// modifying the instance, rebooting the instance, deleting the instance, creating a
        /// Read Replica for the instance, and creating a DB snapshot of the instance. 
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        ///  The new password for the DB instance master user. Can be any printable ASCII character
        /// except "/", """, or "@".
        /// </para>
        ///  
        /// <para>
        ///  Changing this parameter does not result in an outage and the change is asynchronously
        /// applied as soon as possible. Between the time of the request and the completion of
        /// the request, the <code>MasterUserPassword</code> element exists in the <code>PendingModifiedValues</code>
        /// element of the operation response. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be 8 to 41 alphanumeric characters (MySQL, MariaDB, and Amazon Aurora),
        /// 8 to 30 alphanumeric characters (Oracle), or 8 to 128 alphanumeric characters (SQL
        /// Server).
        /// </para>
        ///  <note> Amazon RDS API actions never return the password, so this action provides
        /// a way to regain access to a primary instance user if the password is lost. This includes
        /// restoring privileges that might have been accidentally revoked. </note>
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
        /// The default is 60.
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
        /// The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch
        /// Logs. For example, <code>arn:aws:iam:123456789012:role/emaccess</code>. For information
        /// on creating a monitoring role, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a>.
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
        ///  Specifies if the DB instance is a Multi-AZ deployment. Changing this parameter does
        /// not result in an outage and the change is applied during the next maintenance window
        /// unless the <code>ApplyImmediately</code> parameter is set to <code>true</code> for
        /// this request. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if the DB instance is a Read Replica. This parameter
        /// cannot be used with SQL Server DB instances. Multi-AZ for SQL Server DB instances
        /// is set using the Mirroring option in an option group associated with the DB instance.
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
        /// Gets and sets the property NewDBInstanceIdentifier. 
        /// <para>
        ///  The new DB instance identifier for the DB instance when renaming a DB instance. When
        /// you change the DB instance identifier, an instance reboot will occur immediately if
        /// you set <code>Apply Immediately</code> to true, or will occur during the next maintenance
        /// window if <code>Apply Immediately</code> to false. This value is stored as a lowercase
        /// string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First
        /// character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
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
        ///  Indicates that the DB instance should be associated with the specified option group.
        /// Changing this parameter does not result in an outage except in the following case
        /// and the change is applied during the next maintenance window unless the <code>ApplyImmediately</code>
        /// parameter is set to <code>true</code> for this request. If the parameter change results
        /// in an option group that enables OEM, this change can cause a brief (sub-second) period
        /// during which new connections are rejected but existing connections are not interrupted.
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  The daily time range during which automated backups are created if automated backups
        /// are enabled, as determined by the <code>BackupRetentionPeriod</code> parameter. Changing
        /// this parameter does not result in an outage and the change is asynchronously applied
        /// as soon as possible. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be in the format hh24:mi-hh24:mi</li> <li>Times should be in Universal
        /// Time Coordinated (UTC)</li> <li>Must not conflict with the preferred maintenance window</li>
        /// <li>Must be at least 30 minutes</li> </ul>
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
        ///  The weekly time range (in UTC) during which system maintenance can occur, which might
        /// result in an outage. Changing this parameter does not result in an outage, except
        /// in the following situation, and the change is asynchronously applied as soon as possible.
        /// If there are pending actions that cause a reboot, and the maintenance window is changed
        /// to include the current time, then changing this parameter will cause a reboot of the
        /// DB instance. If moving this window to the current time, there must be at least 30
        /// minutes between the current time and end of the window to ensure pending changes are
        /// applied. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Format: ddd:hh24:mi-ddd:hh24:mi
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be at least 30 minutes
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
        /// True to make the DB instance Internet-facing with a publicly resolvable DNS name,
        /// which resolves to a public IP address. False to make the DB instance internal with
        /// a DNS name that resolves to a private IP address. 
        /// </para>
        ///  
        /// <para>
        /// <code>PubliclyAccessible</code> only applies to DB instances in a VPC. The DB instance
        /// must be part of a public subnet and <code>PubliclyAccessible</code> must be true in
        /// order for it to be publicly accessible. 
        /// </para>
        ///  
        /// <para>
        /// Changes to the <code>PubliclyAccessible</code> parameter are applied immediately regardless
        /// of the value of the <code>ApplyImmediately</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  Default: false 
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
        ///  A list of EC2 VPC security groups to authorize on this DB instance. This change is
        /// asynchronously applied as soon as possible. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be
        /// a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul>
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