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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBCluster operation.
    /// Modifies a setting for an Amazon DocumentDB cluster. You can change one or more database
    /// configuration parameters by specifying these parameters and the new values in the
    /// request.
    /// </summary>
    public partial class ModifyDBClusterRequest : AmazonDocDBRequest
    {
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private int? _backupRetentionPeriod;
        private CloudwatchLogsExportConfiguration _cloudwatchLogsExportConfiguration;
        private string _dbClusterIdentifier;
        private string _dbClusterParameterGroupName;
        private bool? _deletionProtection;
        private string _engineVersion;
        private bool? _manageMasterUserPassword;
        private string _masterUserPassword;
        private string _masterUserSecretKmsKeyId;
        private string _newDBClusterIdentifier;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _rotateMasterUserPassword;
        private ServerlessV2ScalingConfiguration _serverlessV2ScalingConfiguration;
        private string _storageType;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// A value that indicates whether major version upgrades are allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: You must allow major version upgrades when specifying a value for the
        /// <c>EngineVersion</c> parameter that is a different major version than the DB cluster's
        /// current version.
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
        /// A value that specifies whether the changes in this request and any pending changes
        /// are asynchronously applied as soon as possible, regardless of the <c>PreferredMaintenanceWindow</c>
        /// setting for the cluster. If this parameter is set to <c>false</c>, changes to the
        /// cluster are applied during the next maintenance window.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApplyImmediately</c> parameter affects only the <c>NewDBClusterIdentifier</c>
        /// and <c>MasterUserPassword</c> values. If you set this parameter value to <c>false</c>,
        /// the changes to the <c>NewDBClusterIdentifier</c> and <c>MasterUserPassword</c> values
        /// are applied during the next maintenance window. All other changes are applied immediately,
        /// regardless of the value of the <c>ApplyImmediately</c> parameter.
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
        /// Gets and sets the property CloudwatchLogsExportConfiguration. 
        /// <para>
        /// The configuration setting for the log types to be enabled for export to Amazon CloudWatch
        /// Logs for a specific instance or cluster. The <c>EnableLogTypes</c> and <c>DisableLogTypes</c>
        /// arrays determine which logs are exported (or not exported) to CloudWatch Logs.
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The cluster identifier for the cluster that is being modified. This parameter is not
        /// case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <c>DBCluster</c>.
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
        /// The name of the cluster parameter group to use for the cluster.
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether this cluster can be deleted. If <c>DeletionProtection</c> is enabled,
        /// the cluster cannot be deleted unless it is modified and <c>DeletionProtection</c>
        /// is disabled. <c>DeletionProtection</c> protects clusters from being accidentally deleted.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to which you want to upgrade. Changing this
        /// parameter results in an outage. The change is applied during the next maintenance
        /// window unless <c>ApplyImmediately</c> is enabled.
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for Amazon DocumentDB use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws docdb describe-db-engine-versions --engine docdb --query "DBEngineVersions[].EngineVersion"</c>
        /// 
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
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager. If the cluster doesn't manage the master user password with Amazon Web Services
        /// Secrets Manager, you can turn on this management. In this case, you can't specify
        /// <c>MasterUserPassword</c>. If the cluster already manages the master user password
        /// with Amazon Web Services Secrets Manager, and you specify that the master user password
        /// is not managed with Amazon Web Services Secrets Manager, then you must specify <c>MasterUserPassword</c>.
        /// In this case, Amazon DocumentDB deletes the secret and uses the new password for the
        /// master user specified by <c>MasterUserPassword</c>.
        /// </para>
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
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The password for the master database user. This password can contain any printable
        /// ASCII character except forward slash (/), double quote ("), or the "at" symbol (@).
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 100 characters.
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
        /// This setting is valid only if both of the following conditions are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The cluster doesn't manage the master user password in Amazon Web Services Secrets
        /// Manager. If the cluster already manages the master user password in Amazon Web Services
        /// Secrets Manager, you can't change the KMS key that is used to encrypt the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are enabling <c>ManageMasterUserPassword</c> to manage the master user password
        /// in Amazon Web Services Secrets Manager. If you are turning on <c>ManageMasterUserPassword</c>
        /// and don't specify <c>MasterUserSecretKmsKeyId</c>, then the <c>aws/secretsmanager</c>
        /// KMS key is used to encrypt the secret. If the secret is in a different Amazon Web
        /// Services account, then you can't use the <c>aws/secretsmanager</c> KMS key to encrypt
        /// the secret, and you must use a customer managed KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
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
        /// Gets and sets the property NewDBClusterIdentifier. 
        /// <para>
        /// The new cluster identifier for the cluster when renaming a cluster. This value is
        /// stored as a lowercase string.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a value from <c>1150</c> to <c>65535</c>. 
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original cluster.
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
        /// for each Amazon Web Services Region. 
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
        /// for each Amazon Web Services Region, occurring on a random day of the week. 
        /// </para>
        ///  
        /// <para>
        /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
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
        /// Gets and sets the property RotateMasterUserPassword. 
        /// <para>
        /// Specifies whether to rotate the secret managed by Amazon Web Services Secrets Manager
        /// for the master user password.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if the master user password is managed by Amazon DocumentDB
        /// in Amazon Web Services Secrets Manager for the cluster. The secret value contains
        /// the updated password.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You must apply the change immediately when rotating the master user password.
        /// </para>
        /// </summary>
        public bool? RotateMasterUserPassword
        {
            get { return this._rotateMasterUserPassword; }
            set { this._rotateMasterUserPassword = value; }
        }

        // Check to see if RotateMasterUserPassword property is set
        internal bool IsSetRotateMasterUserPassword()
        {
            return this._rotateMasterUserPassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration. 
        /// <para>
        /// Contains the scaling configuration of an Amazon DocumentDB Serverless cluster.
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
        /// For information on storage types for Amazon DocumentDB clusters, see Cluster storage
        /// configurations in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for storage type - <c>standard | iopt1</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>standard </c> 
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of virtual private cloud (VPC) security groups that the cluster will belong
        /// to.
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