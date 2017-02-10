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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Describes a configuration management server.
    /// </summary>
    public partial class CMServer
    {
        private int? _backupRetentionCount;
        private DateTime? _createdAt;
        private bool? _disableAutomatedBackup;
        private string _endpoint;
        private string _engine;
        private List<EngineAttribute> _engineAttributes = new List<EngineAttribute>();
        private string _engineModel;
        private string _engineVersion;
        private string _instanceProfileArn;
        private string _instanceType;
        private string _keyPair;
        private MaintenanceStatus _maintenanceStatus;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<string> _securityGroupIds = new List<string>();
        private string _serverArn;
        private string _serverName;
        private string _serviceRoleArn;
        private ServerStatus _status;
        private string _statusReason;
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property BackupRetentionCount. 
        /// <para>
        /// The number of automated backups to keep. 
        /// </para>
        /// </summary>
        public int BackupRetentionCount
        {
            get { return this._backupRetentionCount.GetValueOrDefault(); }
            set { this._backupRetentionCount = value; }
        }

        // Check to see if BackupRetentionCount property is set
        internal bool IsSetBackupRetentionCount()
        {
            return this._backupRetentionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Time stamp of server creation. Example <code>2016-07-29T13:38:47.520Z</code> 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableAutomatedBackup. 
        /// <para>
        /// Disables automated backups. The number of stored backups is dependent on the value
        /// of PreferredBackupCount. 
        /// </para>
        /// </summary>
        public bool DisableAutomatedBackup
        {
            get { return this._disableAutomatedBackup.GetValueOrDefault(); }
            set { this._disableAutomatedBackup = value; }
        }

        // Check to see if DisableAutomatedBackup property is set
        internal bool IsSetDisableAutomatedBackup()
        {
            return this._disableAutomatedBackup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        ///  A DNS name that can be used to access the engine. Example: <code>myserver-asdfghjkl.us-east-1.opsworks.io</code>
        /// 
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine type of the server. The valid value in this release is <code>Chef</code>.
        /// 
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
        /// Gets and sets the property EngineAttributes. 
        /// <para>
        /// The response of a createServer() request returns the master credential to access the
        /// server in EngineAttributes. These credentials are not stored by AWS OpsWorks for Chef
        /// Automate; they are returned only as part of the result of createServer(). 
        /// </para>
        ///  <p class="title"> <b>Attributes returned in a createServer response:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CHEF_PIVOTAL_KEY</code>: A base64-encoded RSA private key that is generated
        /// by AWS OpsWorks for Chef Automate. This private key is required to access the Chef
        /// API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CHEF_STARTER_KIT</code>: A base64-encoded ZIP file. The ZIP file contains a
        /// Chef starter kit, which includes a README, a configuration file, and the required
        /// RSA private key. Save this file, unzip it, and then change to the directory where
        /// you've unzipped the file contents. From this directory, you can run Knife commands.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<EngineAttribute> EngineAttributes
        {
            get { return this._engineAttributes; }
            set { this._engineAttributes = value; }
        }

        // Check to see if EngineAttributes property is set
        internal bool IsSetEngineAttributes()
        {
            return this._engineAttributes != null && this._engineAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EngineModel. 
        /// <para>
        /// The engine model of the server. The valid value in this release is <code>Single</code>.
        /// 
        /// </para>
        /// </summary>
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
        /// The engine version of the server. Because Chef is the engine available in this release,
        /// the valid value for EngineVersion is <code>12</code>. 
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
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The instance profile ARN of the server. 
        /// </para>
        /// </summary>
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
        ///  The instance type for the server, as specified in the CloudFormation stack. This
        /// might not be the same instance type that is shown in the EC2 console. 
        /// </para>
        /// </summary>
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
        /// The key pair associated with the server. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MaintenanceStatus. 
        /// <para>
        /// The status of the most recent server maintenance run. Shows <code>SUCCESS</code> or
        /// <code>FAILED</code>. 
        /// </para>
        /// </summary>
        public MaintenanceStatus MaintenanceStatus
        {
            get { return this._maintenanceStatus; }
            set { this._maintenanceStatus = value; }
        }

        // Check to see if MaintenanceStatus property is set
        internal bool IsSetMaintenanceStatus()
        {
            return this._maintenanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The preferred backup period specified for the server. 
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
        /// The preferred maintenance period specified for the server. 
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        ///  The security group IDs for the server, as specified in the CloudFormation stack.
        /// These might not be the same security groups that are shown in the EC2 console. 
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServerArn. 
        /// <para>
        /// The ARN of the server. 
        /// </para>
        /// </summary>
        public string ServerArn
        {
            get { return this._serverArn; }
            set { this._serverArn = value; }
        }

        // Check to see if ServerArn property is set
        internal bool IsSetServerArn()
        {
            return this._serverArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server. 
        /// </para>
        /// </summary>
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
        /// The service role ARN used to create the server. 
        /// </para>
        /// </summary>
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
        ///  The server's status. This field displays the states of actions in progress, such
        /// as creating, running, or backing up the server, as well as server health. 
        /// </para>
        /// </summary>
        public ServerStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  Depending on the server status, this field has either a human-readable message (such
        /// as a create or backup error), or an escaped block of JSON (used for health check results).
        /// 
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The subnet IDs specified in a CreateServer request. 
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}