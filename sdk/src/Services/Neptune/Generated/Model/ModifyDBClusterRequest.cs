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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBCluster operation.
    /// Modify a setting for a DB cluster. You can change one or more database configuration
    /// parameters by specifying these parameters and the new values in the request.
    /// </summary>
    public partial class ModifyDBClusterRequest : AmazonNeptuneRequest
    {
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private int? _backupRetentionPeriod;
        private CloudwatchLogsExportConfiguration _cloudwatchLogsExportConfiguration;
        private bool? _copyTagsToSnapshot;
        private string _dbClusterIdentifier;
        private string _dbClusterParameterGroupName;
        private string _dbInstanceParameterGroupName;
        private bool? _deletionProtection;
        private bool? _enableIAMDatabaseAuthentication;
        private string _engineVersion;
        private string _masterUserPassword;
        private string _newDBClusterIdentifier;
        private string _optionGroupName;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private ServerlessV2ScalingConfiguration _serverlessV2ScalingConfiguration;
        private string _storageType;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// A value that indicates whether upgrades between different major versions are allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: You must set the allow-major-version-upgrade flag when providing an <c>EngineVersion</c>
        /// parameter that uses a different major version than the DB cluster's current version.
        /// </para>
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
        /// A value that specifies whether the modifications in this request and any pending modifications
        /// are asynchronously applied as soon as possible, regardless of the <c>PreferredMaintenanceWindow</c>
        /// setting for the DB cluster. If this parameter is set to <c>false</c>, changes to the
        /// DB cluster are applied during the next maintenance window.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApplyImmediately</c> parameter only affects <c>NewDBClusterIdentifier</c> values.
        /// If you set the <c>ApplyImmediately</c> parameter value to false, then changes to <c>NewDBClusterIdentifier</c>
        /// values are applied during the next maintenance window. All other changes are applied
        /// immediately, regardless of the value of the <c>ApplyImmediately</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained. You must specify a minimum
        /// value of 1.
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
        /// Must be a value from 1 to 35
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
        /// Gets and sets the property CloudwatchLogsExportConfiguration. 
        /// <para>
        /// The configuration setting for the log types to be enabled for export to CloudWatch
        /// Logs for a specific DB cluster. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/cloudwatch-logs.html#cloudwatch-logs-cli">Using
        /// the CLI to publish Neptune audit logs to CloudWatch Logs</a>.
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
        ///  <i>If set to <c>true</c>, tags are copied to any snapshot of the DB cluster that
        /// is created.</i> 
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the cluster being modified. This parameter is not case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBCluster.
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
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to use for the DB cluster.
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
        /// When you apply a parameter group using <c>DBInstanceParameterGroupName</c>, parameter
        /// changes aren't applied during the next maintenance window but instead are applied
        /// immediately.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: The existing name setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB parameter group must be in the same DB parameter group family as the target
        /// DB cluster version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DBInstanceParameterGroupName</c> parameter is only valid in combination with
        /// the <c>AllowMajorVersionUpgrade</c> parameter.
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
        /// A value that indicates whether the DB cluster has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection is disabled.
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
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// True to enable mapping of Amazon Identity and Access Management (IAM) accounts to
        /// database accounts, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to which you want to upgrade. Changing this
        /// parameter results in an outage. The change is applied during the next maintenance
        /// window unless the <c>ApplyImmediately</c> parameter is set to true.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid engine versions, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/engine-releases.html">Engine
        /// Releases for Amazon Neptune</a>, or call <a>DescribeDBEngineVersions</a>.
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// Not supported by Neptune.
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
        /// Gets and sets the property NewDBClusterIdentifier. 
        /// <para>
        /// The new DB cluster identifier for the DB cluster when renaming a DB cluster. This
        /// value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens
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
        ///  <i>Not supported by Neptune.</i> 
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
        /// The port number on which the DB cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value must be <c>1150-65535</c> 
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
        /// for each Amazon Region.
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
        /// Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Region, occurring on a random day of the week.
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
        /// Gets and sets the property ServerlessV2ScalingConfiguration. 
        /// <para>
        /// Contains the scaling configuration of a Neptune Serverless DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/neptune-serverless-using.html">Using
        /// Amazon Neptune Serverless</a> in the <i>Amazon Neptune User Guide</i>.
        /// </para>
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
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>standard</c> </b>   –   ( <i>the default</i> ) Configures cost-effective database
        /// storage for applications with moderate to small I/O usage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>iopt1</c> </b>   –   Enables <a href="https://docs.aws.amazon.com/neptune/latest/userguide/storage-types.html#provisioned-iops-storage">I/O-Optimized
        /// storage</a> that's designed to meet the needs of I/O-intensive graph workloads that
        /// require predictable pricing with low I/O latency and consistent I/O throughput.
        /// </para>
        ///  
        /// <para>
        /// Neptune I/O-Optimized storage is only available starting with engine release 1.3.0.0.
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
        /// A list of VPC security groups that the DB cluster will belong to.
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