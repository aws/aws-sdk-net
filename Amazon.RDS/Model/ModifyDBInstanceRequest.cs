/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Changes the settings of an existing DB Instance.
    ///
    /// Changes are applied in the following manner: A ModifyDBInstance API call to modify security groups or to change the
    /// maintenance windows results in immediate action. Modification of the DB Parameter Group applies immediate parameters as
    /// soon as possible and pending-reboot parameters only when the RDS instance is rebooted. A request to scale the DB Instance
    /// class results puts the database instance into the modifying state.
    ///
    /// The DB Instance must be in available or modifying state for this API to accept changes.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class ModifyDBInstanceRequest
    {
        private string DBInstanceIdentifierField;
        private Decimal? allocatedStorageField;
        private string DBInstanceClassField;
        private List<string> DBSecurityGroupsField;
        private bool? applyImmediatelyField;
        private string masterUserPasswordField;
        private string DBParameterGroupNameField;
        private Decimal? backupRetentionPeriodField;
        private string preferredBackupWindowField;
        private string preferredMaintenanceWindowField;
        private bool? multiAZField;

        /// <summary>
        /// Gets and sets the DBInstanceIdentifier property.
        /// DB Instance identifier. This is the unique key that identifies a DB Instance. This parameter is stored as a lower-case string.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceIdentifier")]
        public string DBInstanceIdentifier
        {
            get { return this.DBInstanceIdentifierField; }
            set { this.DBInstanceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="DBInstanceIdentifier">DB Instance identifier. This is the unique key that identifies a DB Instance. This parameter is stored as a lower-case string.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBInstanceIdentifier(string DBInstanceIdentifier)
        {
            this.DBInstanceIdentifierField = DBInstanceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceIdentifier property is set
        /// </summary>
        /// <returns>true if DBInstanceIdentifier property is set</returns>
        public bool IsSetDBInstanceIdentifier()
        {
            return this.DBInstanceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the AllocatedStorage property.
        /// The new storage capacity of the RDS instance. This change does not result in an outage and is applied during the next maintenance
        /// window unless the ApplyImmediately parameter is specified as True for this request. Default: Uses existing setting. Valid Values: 5-1024.
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values are that are not at least 10% greater than the existing value are rounded up to the nearest 10 GB boundary.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocatedStorage")]
        public Decimal AllocatedStorage
        {
            get { return this.allocatedStorageField.GetValueOrDefault(); }
            set { this.allocatedStorageField = value; }
        }

        /// <summary>
        /// Sets the AllocatedStorage property
        /// </summary>
        /// <param name="allocatedStorage">The new storage capacity of the RDS instance. This change does not result in an outage and is applied during the next maintenance
        /// window unless the ApplyImmediately parameter is specified as True for this request. Default: Uses existing setting. Valid Values: 5-1024.
        /// Constraints: Value supplied must be at least 10% greater than the current value. Values are that are not at least 10% greater than the existing value are rounded up to the nearest 10 GB boundary.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithAllocatedStorage(Decimal allocatedStorage)
        {
            this.allocatedStorageField = allocatedStorage;
            return this;
        }

        /// <summary>
        /// Checks if AllocatedStorage property is set
        /// </summary>
        /// <returns>true if AllocatedStorage property is set</returns>
        public bool IsSetAllocatedStorage()
        {
            return this.allocatedStorageField.HasValue;
        }

        /// <summary>
        /// Gets and sets the DBInstanceClass property.
        /// The new compute and memory capacity of the DB Instance. This change causes an outage during the change and is
        /// applied during the next maintenance window, unless the ApplyImmediately parameter true for this request.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceClass")]
        public string DBInstanceClass
        {
            get { return this.DBInstanceClassField; }
            set { this.DBInstanceClassField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceClass property
        /// </summary>
        /// <param name="DBInstanceClass">The new compute and memory capacity of the DB Instance. This change causes an outage during the change and is
        /// applied during the next maintenance window, unless the ApplyImmediately parameter true for this request.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBInstanceClass(string DBInstanceClass)
        {
            this.DBInstanceClassField = DBInstanceClass;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceClass property is set
        /// </summary>
        /// <returns>true if DBInstanceClass property is set</returns>
        public bool IsSetDBInstanceClass()
        {
            return this.DBInstanceClassField != null;
        }

        /// <summary>
        /// Gets and sets the DBSecurityGroups property.
        /// List of DB Security Groups to authorize on this DB Instance. This change is asynchronously applied as soon as possible.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroups")]
        public List<string> DBSecurityGroups
        {
            get
            {
                if (this.DBSecurityGroupsField == null)
                {
                    this.DBSecurityGroupsField = new List<string>();
                }
                return this.DBSecurityGroupsField;
            }
            set { this.DBSecurityGroupsField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroups property
        /// </summary>
        /// <param name="list">List of DB Security Groups to authorize on this DB Instance. This change is asynchronously applied as soon as possible.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBSecurityGroups(params string[] list)
        {
            foreach (string item in list)
            {
                DBSecurityGroups.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroups property is set
        /// </summary>
        /// <returns>true if DBSecurityGroups property is set</returns>
        public bool IsSetDBSecurityGroups()
        {
            return (DBSecurityGroups.Count > 0);
        }

        /// <summary>
        /// Gets and sets the ApplyImmediately property.
        /// Specifies that the modifications in this request and any pending modifications are asynchronously applied as soon
        /// as possible, regardless of the PreferredMaintenanceWindow setting for the DB Instance. If this parameter is false,
        /// changes to the DB Instance are applied on the next call to RebootDBInstance or the next maintenance or failure
        /// reboot, whichever occurs first. Default is FALSE.
        /// </summary>
        [XmlElementAttribute(ElementName = "ApplyImmediately")]
        public bool ApplyImmediately
        {
            get { return this.applyImmediatelyField.GetValueOrDefault(); }
            set { this.applyImmediatelyField = value; }
        }

        /// <summary>
        /// Sets the ApplyImmediately property
        /// </summary>
        /// <param name="applyImmediately">Specifies that the modifications in this request and any pending modifications are asynchronously applied as soon
        /// as possible, regardless of the PreferredMaintenanceWindow setting for the DB Instance. If this parameter is false,
        /// changes to the DB Instance are applied on the next call to RebootDBInstance or the next maintenance or failure
        /// reboot, whichever occurs first. Default is FALSE.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithApplyImmediately(bool applyImmediately)
        {
            this.applyImmediatelyField = applyImmediately;
            return this;
        }

        /// <summary>
        /// Checks if ApplyImmediately property is set
        /// </summary>
        /// <returns>true if ApplyImmediately property is set</returns>
        public bool IsSetApplyImmediately()
        {
            return this.applyImmediatelyField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MasterUserPassword property.
        /// New password for the DB Instance master user. This change is asynchronously applied as soon as possible. Between
        /// the time of the request and the completion of the request, the MasterUserPassword element exists in the
        /// PendingModifiedValues element of the API response.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterUserPassword")]
        public string MasterUserPassword
        {
            get { return this.masterUserPasswordField; }
            set { this.masterUserPasswordField = value; }
        }

        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">New password for the DB Instance master user. This change is asynchronously applied as soon as possible. Between
        /// the time of the request and the completion of the request, the MasterUserPassword element exists in the
        /// PendingModifiedValues element of the API response.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithMasterUserPassword(string masterUserPassword)
        {
            this.masterUserPasswordField = masterUserPassword;
            return this;
        }

        /// <summary>
        /// Checks if MasterUserPassword property is set
        /// </summary>
        /// <returns>true if MasterUserPassword property is set</returns>
        public bool IsSetMasterUserPassword()
        {
            return this.masterUserPasswordField != null;
        }

        /// <summary>
        /// Gets and sets the DBParameterGroupName property.
        /// Name of the DB Parameter Group to apply to this DB Instance. This change is asynchronously applied as soon as possible for
        /// parameters when the ApplyMethod is immediate.
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBParameterGroupName")]
        public string DBParameterGroupName
        {
            get { return this.DBParameterGroupNameField; }
            set { this.DBParameterGroupNameField = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="DBParameterGroupName">Name of the DB Parameter Group to apply to this DB Instance. This change is asynchronously applied as soon as possible for
        /// parameters when the ApplyMethod is immediate.
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithDBParameterGroupName(string DBParameterGroupName)
        {
            this.DBParameterGroupNameField = DBParameterGroupName;
            return this;
        }

        /// <summary>
        /// Checks if DBParameterGroupName property is set
        /// </summary>
        /// <returns>true if DBParameterGroupName property is set</returns>
        public bool IsSetDBParameterGroupName()
        {
            return this.DBParameterGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the BackupRetentionPeriod property.
        /// The number of days to retain automated backups. Setting this parameter to a positive number enables backups. Setting this
        /// parameter to 0 disables automated backups. Constraints: Must be a value from 0 to 8.
        /// </summary>
        [XmlElementAttribute(ElementName = "BackupRetentionPeriod")]
        public Decimal BackupRetentionPeriod
        {
            get { return this.backupRetentionPeriodField.GetValueOrDefault(); }
            set { this.backupRetentionPeriodField = value; }
        }

        /// <summary>
        /// Sets the BackupRetentionPeriod property
        /// </summary>
        /// <param name="backupRetentionPeriod">The number of days to retain automated backups. Setting this parameter to a positive number enables backups. Setting this
        /// parameter to 0 disables automated backups. Constraints: Must be a value from 0 to 8.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithBackupRetentionPeriod(Decimal backupRetentionPeriod)
        {
            this.backupRetentionPeriodField = backupRetentionPeriod;
            return this;
        }

        /// <summary>
        /// Checks if BackupRetentionPeriod property is set
        /// </summary>
        /// <returns>true if BackupRetentionPeriod property is set</returns>
        public bool IsSetBackupRetentionPeriod()
        {
            return this.backupRetentionPeriodField.HasValue;
        }

        /// <summary>
        /// Gets and sets the PreferredBackupWindow property.
        /// The daily time range during which automated backups are created if backups are enabled.
        /// Must be in the format hh24:mi-hh24:mi.
        /// Times should be Universal Time Coordinated (UTC).
        /// Must not conflict with the --preferred-maintenance-window.
        /// Must be at least 2 hours.
        /// </summary>
        [XmlElementAttribute(ElementName = "PreferredBackupWindow")]
        public string PreferredBackupWindow
        {
            get { return this.preferredBackupWindowField; }
            set { this.preferredBackupWindowField = value; }
        }

        /// <summary>
        /// Sets the PreferredBackupWindow property
        /// </summary>
        /// <param name="preferredBackupWindow">The daily time range during which automated backups are created if backups are enabled.
        /// Must be in the format hh24:mi-hh24:mi.
        /// Times should be Universal Time Coordinated (UTC).
        /// Must not conflict with the --preferred-maintenance-window.
        /// Must be at least 2 hours.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithPreferredBackupWindow(string preferredBackupWindow)
        {
            this.preferredBackupWindowField = preferredBackupWindow;
            return this;
        }

        /// <summary>
        /// Checks if PreferredBackupWindow property is set
        /// </summary>
        /// <returns>true if PreferredBackupWindow property is set</returns>
        public bool IsSetPreferredBackupWindow()
        {
            return this.preferredBackupWindowField != null;
        }

        /// <summary>
        /// Gets and sets the PreferredMaintenanceWindow property.
        /// The weekly time range (in UTC) during which system maintenance can occur, which may result in an outage. This
        /// change is made immediately. If moving this window to the current time, there must be at least 120 minutes between
        /// the current time and end of the window to assure pending changes are applied.
        ///
        /// Default: Uses existing setting
        /// Format: ddd:hh24:mi-ddd:hh24:mi
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        ///
        /// Constraints: Minimum four hour period.
        /// </summary>
        [XmlElementAttribute(ElementName = "PreferredMaintenanceWindow")]
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindowField; }
            set { this.preferredMaintenanceWindowField = value; }
        }

        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The weekly time range (in UTC) during which system maintenance can occur, which may result in an outage. This
        /// change is made immediately. If moving this window to the current time, there must be at least 120 minutes between
        /// the current time and end of the window to assure pending changes are applied.
        ///
        /// Default: Uses existing setting
        /// Format: ddd:hh24:mi-ddd:hh24:mi
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        ///
        /// Constraints: Minimum four hour period.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
        {
            this.preferredMaintenanceWindowField = preferredMaintenanceWindow;
            return this;
        }

        /// <summary>
        /// Checks if PreferredMaintenanceWindow property is set
        /// </summary>
        /// <returns>true if PreferredMaintenanceWindow property is set</returns>
        public bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindowField != null;
        }

        /// <summary>
        /// Gets and sets the MultiAZ property.
        /// Specifies if the DB Instance is a Multi-AZ DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "MultiAZ")]
        public bool MultiAZ
        {
            get { return this.multiAZField.GetValueOrDefault(); }
            set { this.multiAZField = value; }
        }

        /// <summary>
        /// Sets the MultiAZ property
        /// </summary>
        /// <param name="multiAZ">Specifies if the DB Instance is a Multi-AZ DB Instance.</param>
        /// <returns>this instance</returns>
        public ModifyDBInstanceRequest WithMultiAZ(bool multiAZ)
        {
            this.multiAZField = multiAZ;
            return this;
        }

        /// <summary>
        /// Checks if MultiAZ property is set
        /// </summary>
        /// <returns>true if MultiAZ property is set</returns>
        public bool IsSetMultiAZ()
        {
            return this.multiAZField.HasValue;
        }

    }
}
