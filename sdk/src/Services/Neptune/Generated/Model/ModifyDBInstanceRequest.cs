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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBInstance operation.
    /// Modifies settings for a DB instance. You can change one or more database configuration
    /// parameters by specifying these parameters and the new values in the request. To learn
    /// what modifications you can make to your DB instance, call <a>DescribeValidDBInstanceModifications</a>
    /// before you call <a>ModifyDBInstance</a>.
    /// </summary>
    public partial class ModifyDBInstanceRequest : AmazonNeptuneRequest
    {
        private int? _allocatedStorage;
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private bool? _autoMinorVersionUpgrade;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private CloudwatchLogsExportConfiguration _cloudwatchLogsExportConfiguration;
        private bool? _copyTagsToSnapshot;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbParameterGroupName;
        private int? _dbPortNumber;
        private List<string> _dbSecurityGroups = new List<string>();
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private string _engineVersion;
        private int? _iops;
        private string _licenseModel;
        private string _masterUserPassword;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _newDBInstanceIdentifier;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private string _storageType;
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The new amount of storage (in gibibytes) to allocate for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Storage is managed by the DB Cluster.
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
        /// Indicates that major version upgrades are allowed. Changing this parameter doesn't
        /// result in an outage and the change is asynchronously applied as soon as possible.
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
        /// are applied on the next call to <a>RebootDBInstance</a>, or the next failure reboot.
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
        ///  Indicates that minor version upgrades are applied automatically to the DB instance
        /// during the maintenance window. Changing this parameter doesn't result in an outage
        /// except in the following case and the change is asynchronously applied as soon as possible.
        /// An outage will result if this parameter is set to <code>true</code> during the maintenance
        /// window, and a newer minor version is available, and Neptune has enabled auto patching
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
        /// Not applicable. The retention period for automated backups is managed by the DB cluster.
        /// For more information, see <a>ModifyDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
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
        /// Indicates the certificate that needs to be associated with the instance.
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
        /// Logs for a specific DB instance or DB cluster.
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The new compute and memory capacity of the DB instance, for example, <code>db.m4.large</code>.
        /// Not all DB instance classes are available in all AWS Regions.
        /// </para>
        ///  
        /// <para>
        /// If you modify the DB instance class, an outage occurs during the change. The change
        /// is applied during the next maintenance window, unless <code>ApplyImmediately</code>
        /// is specified as <code>true</code> for this request.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
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
        /// The DB instance identifier. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBInstance.
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
        /// The name of the DB parameter group to apply to the DB instance. Changing this setting
        /// doesn't result in an outage. The parameter group name itself is changed immediately,
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
        /// The port number on which the database accepts connections.
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
        ///  Default: <code>8182</code> 
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
        /// A list of DB security groups to authorize on this DB instance. Changing this setting
        /// doesn't result in an outage and the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match existing DBSecurityGroups.
        /// </para>
        ///  </li> </ul>
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
        /// The new DB subnet group for the DB instance. You can use this parameter to move your
        /// DB instance to a different VPC.
        /// </para>
        ///  
        /// <para>
        /// Changing the subnet group causes an outage during the change. The change is applied
        /// during the next maintenance window, unless you specify <code>true</code> for the <code>ApplyImmediately</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If supplied, must match the name of an existing DBSubnetGroup.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mySubnetGroup</code> 
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
        /// protection is disabled. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-instances-delete.html">Deleting
        /// a DB Instance</a>.
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
        /// Not supported.
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
        /// Not supported
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
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// True to enable mapping of AWS Identity and Access Management (IAM) accounts to database
        /// accounts, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// You can enable IAM database authentication for the following database engines
        /// </para>
        ///  
        /// <para>
        /// Not applicable. Mapping AWS IAM accounts to database accounts is managed by the DB
        /// cluster. For more information, see <a>ModifyDBCluster</a>.
        /// </para>
        ///  
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
        ///  <i>(Not supported by Neptune)</i> 
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to upgrade to. Currently, setting this parameter
        /// has no effect. To upgrade your database engine to the most recent release, use the
        /// <a>ApplyPendingMaintenanceAction</a> API.
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
        /// The new Provisioned IOPS (I/O operations per second) value for the instance.
        /// </para>
        ///  
        /// <para>
        /// Changing this setting doesn't result in an outage and the change is applied during
        /// the next maintenance window unless the <code>ApplyImmediately</code> parameter is
        /// set to <code>true</code> for this request.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// Not supported.
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// Not applicable.
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
        /// The ARN for the IAM role that permits Neptune to send enhanced monitoring metrics
        /// to Amazon CloudWatch Logs. For example, <code>arn:aws:iam:123456789012:role/emaccess</code>.
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
        /// Specifies if the DB instance is a Multi-AZ deployment. Changing this parameter doesn't
        /// result in an outage and the change is applied during the next maintenance window unless
        /// the <code>ApplyImmediately</code> parameter is set to <code>true</code> for this request.
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
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>mydbinstance</code> 
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
        ///  <i>(Not supported by Neptune)</i> 
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
        ///  <i>(Not supported by Neptune)</i> 
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  The daily time range during which automated backups are created if automated backups
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The daily time range for creating automated backups is managed by
        /// the DB cluster. For more information, see <a>ModifyDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format hh24:mi-hh24:mi
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Time Coordinated (UTC)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes
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
        /// The weekly time range (in UTC) during which system maintenance can occur, which might
        /// result in an outage. Changing this parameter doesn't result in an outage, except in
        /// the following situation, and the change is asynchronously applied as soon as possible.
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
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which a Read Replica is promoted to the primary
        /// instance after a failure of the existing primary instance.
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
        /// This flag should no longer be used.
        /// </para>
        /// </summary>
        [Obsolete("This parameter is not supported")]
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
        /// Not supported.
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to authorize on this DB instance. This change is
        /// asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// Not applicable. The associated list of EC2 VPC security groups is managed by the DB
        /// cluster. For more information, see <a>ModifyDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match existing VpcSecurityGroupIds.
        /// </para>
        ///  </li> </ul>
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