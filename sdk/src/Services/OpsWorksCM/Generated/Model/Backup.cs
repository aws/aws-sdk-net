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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Describes a single backup.
    /// </summary>
    public partial class Backup
    {
        private string _backupArn;
        private string _backupId;
        private BackupType _backupType;
        private DateTime? _createdAt;
        private string _description;
        private string _engine;
        private string _engineModel;
        private string _engineVersion;
        private string _instanceProfileArn;
        private string _instanceType;
        private string _keyPair;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private int? _s3DataSize;
        private string _s3DataUrl;
        private string _s3LogUrl;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serverName;
        private string _serviceRoleArn;
        private BackupStatus _status;
        private string _statusDescription;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _toolsVersion;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// The ARN of the backup. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string BackupArn
        {
            get { return this._backupArn; }
            set { this._backupArn = value; }
        }

        // Check to see if BackupArn property is set
        internal bool IsSetBackupArn()
        {
            return this._backupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        ///  The generated ID of the backup. Example: <c>myServerName-yyyyMMddHHmmssSSS</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=79)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupType. 
        /// <para>
        ///  The backup type. Valid values are <c>automated</c> or <c>manual</c>. 
        /// </para>
        /// </summary>
        public BackupType BackupType
        {
            get { return this._backupType; }
            set { this._backupType = value; }
        }

        // Check to see if BackupType property is set
        internal bool IsSetBackupType()
        {
            return this._backupType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time stamp when the backup was created in the database. Example: <c>2016-07-29T13:38:47.520Z</c>
        /// 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A user-provided description for a manual backup. This field is empty for automated
        /// backups. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The engine type that is obtained from the server when the backup is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        /// Gets and sets the property EngineModel. 
        /// <para>
        ///  The engine model that is obtained from the server when the backup is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string EngineModel
        {
            get { return this._engineModel; }
            set { this._engineModel = value; }
        }

        // Check to see if EngineModel property is set
        internal bool IsSetEngineModel()
        {
            return this._engineModel != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The engine version that is obtained from the server when the backup is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        ///  The EC2 instance profile ARN that is obtained from the server when the backup is
        /// created. Because this value is stored, you are not required to provide the InstanceProfileArn
        /// again if you restore a backup. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string InstanceProfileArn
        {
            get { return this._instanceProfileArn; }
            set { this._instanceProfileArn = value; }
        }

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this._instanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type that is obtained from the server when the backup is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        ///  The key pair that is obtained from the server when the backup is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string KeyPair
        {
            get { return this._keyPair; }
            set { this._keyPair = value; }
        }

        // Check to see if KeyPair property is set
        internal bool IsSetKeyPair()
        {
            return this._keyPair != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  The preferred backup period that is obtained from the server when the backup is created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        ///  The preferred maintenance period that is obtained from the server when the backup
        /// is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        /// Gets and sets the property S3DataSize. 
        /// <para>
        ///  This field is deprecated and is no longer used. 
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and is no longer used")]
        public int? S3DataSize
        {
            get { return this._s3DataSize; }
            set { this._s3DataSize = value; }
        }

        // Check to see if S3DataSize property is set
        internal bool IsSetS3DataSize()
        {
            return this._s3DataSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3DataUrl. 
        /// <para>
        ///  This field is deprecated and is no longer used. 
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and is no longer used")]
        [AWSProperty(Max=10000)]
        public string S3DataUrl
        {
            get { return this._s3DataUrl; }
            set { this._s3DataUrl = value; }
        }

        // Check to see if S3DataUrl property is set
        internal bool IsSetS3DataUrl()
        {
            return this._s3DataUrl != null;
        }

        /// <summary>
        /// Gets and sets the property S3LogUrl. 
        /// <para>
        ///  The Amazon S3 URL of the backup's log file. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string S3LogUrl
        {
            get { return this._s3LogUrl; }
            set { this._s3LogUrl = value; }
        }

        // Check to see if S3LogUrl property is set
        internal bool IsSetS3LogUrl()
        {
            return this._s3LogUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        ///  The security group IDs that are obtained from the server when the backup is created.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        ///  The name of the server from which the backup was made. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        ///  The service role ARN that is obtained from the server when the backup is created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a backup while in progress. 
        /// </para>
        /// </summary>
        public BackupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDescription. 
        /// <para>
        ///  An informational message about backup status. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string StatusDescription
        {
            get { return this._statusDescription; }
            set { this._statusDescription = value; }
        }

        // Check to see if StatusDescription property is set
        internal bool IsSetStatusDescription()
        {
            return this._statusDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The subnet IDs that are obtained from the server when the backup is created. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToolsVersion. 
        /// <para>
        ///  The version of OpsWorks CM-specific tools that is obtained from the server when the
        /// backup is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string ToolsVersion
        {
            get { return this._toolsVersion; }
            set { this._toolsVersion = value; }
        }

        // Check to see if ToolsVersion property is set
        internal bool IsSetToolsVersion()
        {
            return this._toolsVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        ///  The user ARN of the requester for manual backups. This field is empty for automated
        /// backups. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}