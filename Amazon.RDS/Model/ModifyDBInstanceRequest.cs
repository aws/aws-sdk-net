/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Modify settings for a DB Instance. You can change one or more database configuration parameters by specifying these parameters and
    /// the new values in the request. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBInstance"/>
    public class ModifyDBInstanceRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private int? allocatedStorage;
        private string dBInstanceClass;
        private List<string> dBSecurityGroups = new List<string>();
        private bool? applyImmediately;
        private string masterUserPassword;
        private string dBParameterGroupName;
        private int? backupRetentionPeriod;
        private string preferredBackupWindow;
        private string preferredMaintenanceWindow;
        private bool? multiAZ;
        private string engineVersion;
        private bool? allowMajorVersionUpgrade;
        private bool? autoMinorVersionUpgrade;

        /// <summary>
        /// The DB Instance identifier. This value is stored as a lowercase string. Constraints: <ul> <li>Must be the identifier for an existing DB
        /// Instance</li> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens</li> </ul> Example: <copy>mydbinstance</copy>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="dBInstanceIdentifier">The value to set for the DBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
        }
            

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;       
        }

        /// <summary>
        /// The new storage capacity of the RDS instance. This change does not result in an outage and is applied during the next maintenance window
        /// unless the <c>ApplyImmediately</c> parameter is specified as <c>true</c> for this request. <b>MySQL</b> Default: Uses existing setting Valid
        /// Values: 5-1024 Constraints: Value supplied must be at least 10% greater than the current value. Values that are not at least 10% greater
        /// than the existing value are rounded up so that they are 10% greater than the current value. Type: Integer <b>MySQL</b> Default: Uses
        /// existing setting Valid Values: 10-1024 Constraints: Value supplied must be at least 10% greater than the current value. Values that are not
        /// at least 10% greater than the existing value are rounded up so that they are 10% greater than the current value.
        ///  
        /// </summary>
        public int AllocatedStorage
        {
            get { return this.allocatedStorage ?? default(int); }
            set { this.allocatedStorage = value; }
        }

        /// <summary>
        /// Sets the AllocatedStorage property
        /// </summary>
        /// <param name="allocatedStorage">The value to set for the AllocatedStorage property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithAllocatedStorage(int allocatedStorage)
        {
            this.allocatedStorage = allocatedStorage;
            return this;
        }
            

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this.allocatedStorage.HasValue;       
        }

        /// <summary>
        /// The new compute and memory capacity of the DB Instance. Passing a value for this parameter causes an outage during the change and is applied
        /// during the next maintenance window, unless the <c>ApplyImmediately</c> parameter is specified as <c>true</c> for this request. Default: Uses
        /// existing setting Valid Values: <c>db.m1.small | db.m1.large | db.m1.xlarge | db.m2.xlarge | db.m2.2xlarge | db.m2.4xlarge</c>
        ///  
        /// </summary>
        public string DBInstanceClass
        {
            get { return this.dBInstanceClass; }
            set { this.dBInstanceClass = value; }
        }

        /// <summary>
        /// Sets the DBInstanceClass property
        /// </summary>
        /// <param name="dBInstanceClass">The value to set for the DBInstanceClass property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBInstanceClass(string dBInstanceClass)
        {
            this.dBInstanceClass = dBInstanceClass;
            return this;
        }
            

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;       
        }

        /// <summary>
        /// A list of DB Security Groups to authorize on this DB Instance. This change is asynchronously applied as soon as possible. Constraints: <ul>
        /// <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two
        /// consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public List<string> DBSecurityGroups
        {
            get { return this.dBSecurityGroups; }
            set { this.dBSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the DBSecurityGroups collection
        /// </summary>
        /// <param name="dBSecurityGroups">The values to add to the DBSecurityGroups collection </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBSecurityGroups(params string[] dBSecurityGroups)
        {
            foreach (string element in dBSecurityGroups)
            {
                this.dBSecurityGroups.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the DBSecurityGroups collection
        /// </summary>
        /// <param name="dBSecurityGroups">The values to add to the DBSecurityGroups collection </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBSecurityGroups(IEnumerable<string> dBSecurityGroups)
        {
            foreach (string element in dBSecurityGroups)
            {
                this.dBSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if DBSecurityGroups property is set
        internal bool IsSetDBSecurityGroups()
        {
            return this.dBSecurityGroups.Count > 0;       
        }

        /// <summary>
        /// Specifies whether or not the modifications in this request and any pending modifications are asynchronously applied as soon as possible,
        /// regardless of the <c>PreferredMaintenanceWindow</c> setting for the DB Instance. If this parameter is passed as <c>false</c>, changes to the
        /// DB Instance are applied on the next call to <a>RebootDBInstance</a>, the next maintenance reboot, or the next failure reboot, whichever
        /// occurs first. Default: <c>false</c>
        ///  
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this.applyImmediately ?? default(bool); }
            set { this.applyImmediately = value; }
        }

        /// <summary>
        /// Sets the ApplyImmediately property
        /// </summary>
        /// <param name="applyImmediately">The value to set for the ApplyImmediately property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithApplyImmediately(bool applyImmediately)
        {
            this.applyImmediately = applyImmediately;
            return this;
        }
            

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this.applyImmediately.HasValue;       
        }

        /// <summary>
        /// The new password for the DB Instance master user. This change is asynchronously applied as soon as possible. Between the time of the request
        /// and the completion of the request, the <c>MasterUserPassword</c> element exists in the <c>PendingModifiedValues</c> element of the operation
        /// response. Default: Uses existing setting Constraints: Must be 4 to 41 alphanumeric characters (engine specific) <note> Amazon RDS APIs never
        /// return the password, so this API provides a way to regain access to a master instance user if the password is lost. </note>
        ///  
        /// </summary>
        public string MasterUserPassword
        {
            get { return this.masterUserPassword; }
            set { this.masterUserPassword = value; }
        }

        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">The value to set for the MasterUserPassword property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithMasterUserPassword(string masterUserPassword)
        {
            this.masterUserPassword = masterUserPassword;
            return this;
        }
            

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this.masterUserPassword != null;       
        }

        /// <summary>
        /// The name of the DB Parameter Group to apply to this DB Instance. This change is asynchronously applied as soon as possible for parameters
        /// when the <i>ApplyImmediately</i> parameter is specified as <c>true</c> for this request. Default: Uses existing setting Constraints: The DB
        /// Parameter Group must be in the same DB Parameter Group family as this DB Instance.
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="dBParameterGroupName">The value to set for the DBParameterGroupName property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBParameterGroupName(string dBParameterGroupName)
        {
            this.dBParameterGroupName = dBParameterGroupName;
            return this;
        }
            

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;       
        }

        /// <summary>
        /// The number of days to retain automated backups. Setting this parameter to a positive number enables backups. Setting this parameter to 0
        /// disables automated backups. Default: Uses existing setting Constraints: <ul> <li>Must be a value from 0 to 8</li> <li>Cannot be set to 0 if
        /// the DB Instance is a master instance with read replicas or of the DB Instance is a read replica</li> </ul>
        ///  
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this.backupRetentionPeriod ?? default(int); }
            set { this.backupRetentionPeriod = value; }
        }

        /// <summary>
        /// Sets the BackupRetentionPeriod property
        /// </summary>
        /// <param name="backupRetentionPeriod">The value to set for the BackupRetentionPeriod property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithBackupRetentionPeriod(int backupRetentionPeriod)
        {
            this.backupRetentionPeriod = backupRetentionPeriod;
            return this;
        }
            

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this.backupRetentionPeriod.HasValue;       
        }

        /// <summary>
        /// The daily time range during which automated backups are created if automated backups are enabled, as determined by the
        /// <c>BackupRetentionPeriod</c>. Constraints: <ul> <li>Must be in the format hh24:mi-hh24:mi</li> <li>Times should be Universal Time
        /// Coordinated (UTC)</li> <li>Must not conflict with the preferred maintenance window</li> <li>Must be at least 30 minutes</li> </ul>
        ///  
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this.preferredBackupWindow; }
            set { this.preferredBackupWindow = value; }
        }

        /// <summary>
        /// Sets the PreferredBackupWindow property
        /// </summary>
        /// <param name="preferredBackupWindow">The value to set for the PreferredBackupWindow property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithPreferredBackupWindow(string preferredBackupWindow)
        {
            this.preferredBackupWindow = preferredBackupWindow;
            return this;
        }
            

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this.preferredBackupWindow != null;       
        }

        /// <summary>
        /// The weekly time range (in UTC) during which system maintenance can occur, which may result in an outage. This change is made immediately. If
        /// moving this window to the current time, there must be at least 120 minutes between the current time and end of the window to ensure pending
        /// changes are applied. Default: Uses existing setting Format: ddd:hh24:mi-ddd:hh24:mi Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// Constraints: Must be at least 30 minutes
        ///  
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindow; }
            set { this.preferredMaintenanceWindow = value; }
        }

        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The value to set for the PreferredMaintenanceWindow property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
        {
            this.preferredMaintenanceWindow = preferredMaintenanceWindow;
            return this;
        }
            

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindow != null;       
        }

        /// <summary>
        /// Specifies if the DB Instance is a Multi-AZ deployment. Constraints: Cannot be specified if the DB Instance is a read replica.
        ///  
        /// </summary>
        public bool MultiAZ
        {
            get { return this.multiAZ ?? default(bool); }
            set { this.multiAZ = value; }
        }

        /// <summary>
        /// Sets the MultiAZ property
        /// </summary>
        /// <param name="multiAZ">The value to set for the MultiAZ property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithMultiAZ(bool multiAZ)
        {
            this.multiAZ = multiAZ;
            return this;
        }
            

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;       
        }

        /// <summary>
        /// The version number of the database engine to upgrade to. For major version upgrades, if a nondefault DB Parameter Group is currently in use,
        /// a new DB Parameter Group in the DB Parameter Group Family for the new engine version must be specified. The new DB Parameter Group can be
        /// the default for that DB Parameter Group Family. Example: <c>5.1.42</c>
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;       
        }

        /// <summary>
        /// Indicates that major version upgrades are allowed. Constraints: This parameter must be set to true when specifying a value for the
        /// EngineVersion parameter that is a different major version than the DB Instance's current version.
        ///  
        /// </summary>
        public bool AllowMajorVersionUpgrade
        {
            get { return this.allowMajorVersionUpgrade ?? default(bool); }
            set { this.allowMajorVersionUpgrade = value; }
        }

        /// <summary>
        /// Sets the AllowMajorVersionUpgrade property
        /// </summary>
        /// <param name="allowMajorVersionUpgrade">The value to set for the AllowMajorVersionUpgrade property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithAllowMajorVersionUpgrade(bool allowMajorVersionUpgrade)
        {
            this.allowMajorVersionUpgrade = allowMajorVersionUpgrade;
            return this;
        }
            

        // Check to see if AllowMajorVersionUpgrade property is set
        internal bool IsSetAllowMajorVersionUpgrade()
        {
            return this.allowMajorVersionUpgrade.HasValue;       
        }

        /// <summary>
        /// Indicates that minor version upgrades will be applied automatically to the DB Instance during the maintenance window.
        ///  
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this.autoMinorVersionUpgrade ?? default(bool); }
            set { this.autoMinorVersionUpgrade = value; }
        }

        /// <summary>
        /// Sets the AutoMinorVersionUpgrade property
        /// </summary>
        /// <param name="autoMinorVersionUpgrade">The value to set for the AutoMinorVersionUpgrade property </param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
        {
            this.autoMinorVersionUpgrade = autoMinorVersionUpgrade;
            return this;
        }
            

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;       
        }
    }
}
    
