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
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the DB instance.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DBInstance
    {
        private string DBInstanceIdentifierField;
        private string DBInstanceClassField;
        private string engineField;
        private string DBInstanceStatusField;
        private string masterUsernameField;
        private string DBNameField;
        private Endpoint endpointField;
        private Decimal? allocatedStorageField;
        private DateTime? instanceCreateTimeField;
        private string preferredBackupWindowField;
        private Decimal? backupRetentionPeriodField;
        private List<DBSecurityGroupMembership> DBSecurityGroupField;
        private List<DBParameterGroupStatus> DBParameterGroupField;
        private string availabilityZoneField;
        private string preferredMaintenanceWindowField;
        private PendingModifiedValues pendingModifiedValuesField;
        private DateTime? latestRestorableTimeField;

        /// <summary>
        /// Gets and sets the DBInstanceIdentifier property.
        /// User-supplied database identifier, this is the unique key that identifies a DB Instance.
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
        /// <param name="DBInstanceIdentifier">User-supplied database identifier, this is the unique key that identifies a DB Instance.</param>
        /// <returns>this instance</returns>
        public DBInstance WithDBInstanceIdentifier(string DBInstanceIdentifier)
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
        /// Gets and sets the DBInstanceClass property.
        /// A value containing the name of the compute and memory capacity class of the DB Instance.
        /// Valid values: db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge
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
        /// <param name="DBInstanceClass">A value containing the name of the compute and memory capacity class of the DB Instance.
        /// Valid values: db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge</param>
        /// <returns>this instance</returns>
        public DBInstance WithDBInstanceClass(string DBInstanceClass)
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
        /// Gets and sets the Engine property.
        /// Name of the database engine to be used for this DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Engine")]
        public string Engine
        {
            get { return this.engineField; }
            set { this.engineField = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">Name of the database engine to be used for this DB Instance.</param>
        /// <returns>this instance</returns>
        public DBInstance WithEngine(string engine)
        {
            this.engineField = engine;
            return this;
        }

        /// <summary>
        /// Checks if Engine property is set
        /// </summary>
        /// <returns>true if Engine property is set</returns>
        public bool IsSetEngine()
        {
            return this.engineField != null;
        }

        /// <summary>
        /// Gets and sets the DBInstanceStatus property.
        /// Current state of this database.
        /// Values: available | backing-up | creating | deleted | deleting | failed | modifying | rebooting | resetting-mastercredentials
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceStatus")]
        public string DBInstanceStatus
        {
            get { return this.DBInstanceStatusField; }
            set { this.DBInstanceStatusField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceStatus property
        /// </summary>
        /// <param name="DBInstanceStatus">Current state of this database.
        /// Values: available | backing-up | creating | deleted | deleting | failed | modifying | rebooting | resetting-mastercredentials</param>
        /// <returns>this instance</returns>
        public DBInstance WithDBInstanceStatus(string DBInstanceStatus)
        {
            this.DBInstanceStatusField = DBInstanceStatus;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceStatus property is set
        /// </summary>
        /// <returns>true if DBInstanceStatus property is set</returns>
        public bool IsSetDBInstanceStatus()
        {
            return this.DBInstanceStatusField != null;
        }

        /// <summary>
        /// Gets and sets the MasterUsername property.
        /// The master username for the DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterUsername")]
        public string MasterUsername
        {
            get { return this.masterUsernameField; }
            set { this.masterUsernameField = value; }
        }

        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The master username for the DB Instance.</param>
        /// <returns>this instance</returns>
        public DBInstance WithMasterUsername(string masterUsername)
        {
            this.masterUsernameField = masterUsername;
            return this;
        }

        /// <summary>
        /// Checks if MasterUsername property is set
        /// </summary>
        /// <returns>true if MasterUsername property is set</returns>
        public bool IsSetMasterUsername()
        {
            return this.masterUsernameField != null;
        }

        /// <summary>
        /// Gets and sets the DBName property.
        /// Name of the initial database on this instance that was specified at create time, if one was specified when the DB
        /// Instance was created. This same name is returned for the life of the DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBName")]
        public string DBName
        {
            get { return this.DBNameField; }
            set { this.DBNameField = value; }
        }

        /// <summary>
        /// Sets the DBName property
        /// </summary>
        /// <param name="DBName">Name of the initial database on this instance that was specified at create time, if one was specified when the DB
        /// Instance was created. This same name is returned for the life of the DB Instance.</param>
        /// <returns>this instance</returns>
        public DBInstance WithDBName(string DBName)
        {
            this.DBNameField = DBName;
            return this;
        }

        /// <summary>
        /// Checks if DBName property is set
        /// </summary>
        /// <returns>true if DBName property is set</returns>
        public bool IsSetDBName()
        {
            return this.DBNameField != null;
        }

        /// <summary>
        /// Gets and sets the Endpoint property.
        /// The Endpoint type.
        /// </summary>
        [XmlElementAttribute(ElementName = "Endpoint")]
        public Endpoint Endpoint
        {
            get { return this.endpointField; }
            set { this.endpointField = value; }
        }

        /// <summary>
        /// Sets the Endpoint property
        /// </summary>
        /// <param name="endpoint">The Endpoint type.</param>
        /// <returns>this instance</returns>
        public DBInstance WithEndpoint(Endpoint endpoint)
        {
            this.endpointField = endpoint;
            return this;
        }

        /// <summary>
        /// Checks if Endpoint property is set
        /// </summary>
        /// <returns>true if Endpoint property is set</returns>
        public bool IsSetEndpoint()
        {
            return this.endpointField != null;
        }

        /// <summary>
        /// Gets and sets the AllocatedStorage property.
        /// Allocated storage size specified in gigabytes.
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
        /// <param name="allocatedStorage">Allocated storage size specified in gigabytes.</param>
        /// <returns>this instance</returns>
        public DBInstance WithAllocatedStorage(Decimal allocatedStorage)
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
        /// Gets and sets the InstanceCreateTime property.
        /// Date and time the DB Instance was created. Example: 2009-10-07T21:16:46.000Z.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCreateTime")]
        public DateTime InstanceCreateTime
        {
            get { return this.instanceCreateTimeField.GetValueOrDefault(); }
            set { this.instanceCreateTimeField = value; }
        }

        /// <summary>
        /// Sets the InstanceCreateTime property
        /// </summary>
        /// <param name="instanceCreateTime">Date and time the DB Instance was created. Example: 2009-10-07T21:16:46.000Z.</param>
        /// <returns>this instance</returns>
        public DBInstance WithInstanceCreateTime(DateTime instanceCreateTime)
        {
            this.instanceCreateTimeField = instanceCreateTime;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCreateTime property is set
        /// </summary>
        /// <returns>true if InstanceCreateTime property is set</returns>
        public bool IsSetInstanceCreateTime()
        {
            return this.instanceCreateTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the PreferredBackupWindow property.
        /// The daily time range during which automated backups are created if automated backups are
        /// enabled (as determined by the BackupRetentionPeriod.
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
        /// <param name="preferredBackupWindow">The daily time range during which automated backups are created if automated backups are
        /// enabled (as determined by the BackupRetentionPeriod.</param>
        /// <returns>this instance</returns>
        public DBInstance WithPreferredBackupWindow(string preferredBackupWindow)
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
        /// Gets and sets the BackupRetentionPeriod property.
        /// The number of days for which automatic DB Snapshots are retained. Setting this parameter to a positive number
        /// enables backups. Setting this parameter to 0 disables automatic backups.
        /// Default: 1
        /// Constraints: Can be from 0 to 8.
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
        /// <param name="backupRetentionPeriod">The number of days for which automatic DB Snapshots are retained. Setting this parameter to a positive number
        /// enables backups. Setting this parameter to 0 disables automatic backups.
        /// Default: 1
        /// Constraints: Can be from 0 to 8.</param>
        /// <returns>this instance</returns>
        public DBInstance WithBackupRetentionPeriod(Decimal backupRetentionPeriod)
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
        /// Gets and sets the DBSecurityGroup property.
        /// List of DB Security Group elements containing only DBSecurityGroup.Name and DBSecurityGroup.Status sub-elements.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroup")]
        public List<DBSecurityGroupMembership> DBSecurityGroup
        {
            get
            {
                if (this.DBSecurityGroupField == null)
                {
                    this.DBSecurityGroupField = new List<DBSecurityGroupMembership>();
                }
                return this.DBSecurityGroupField;
            }
            set { this.DBSecurityGroupField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroup property
        /// </summary>
        /// <param name="list">List of DB Security Group elements containing only DBSecurityGroup.Name and DBSecurityGroup.Status sub-elements.</param>
        /// <returns>this instance</returns>
        public DBInstance WithDBSecurityGroup(params DBSecurityGroupMembership[] list)
        {
            foreach (DBSecurityGroupMembership item in list)
            {
                DBSecurityGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroup property is set
        /// </summary>
        /// <returns>true if DBSecurityGroup property is set</returns>
        public bool IsSetDBSecurityGroup()
        {
            return (DBSecurityGroup.Count > 0);
        }
        /// <summary>
        /// Gets and sets the DBParameterGroup property.
        /// The list of DB Parameter Groups applied to this DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBParameterGroup")]
        public List<DBParameterGroupStatus> DBParameterGroup
        {
            get
            {
                if (this.DBParameterGroupField == null)
                {
                    this.DBParameterGroupField = new List<DBParameterGroupStatus>();
                }
                return this.DBParameterGroupField;
            }
            set { this.DBParameterGroupField = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroup property
        /// </summary>
        /// <param name="list">The list of DB Parameter Groups applied to this DB Instance.</param>
        /// <returns>this instance</returns>
        public DBInstance WithDBParameterGroup(params DBParameterGroupStatus[] list)
        {
            foreach (DBParameterGroupStatus item in list)
            {
                DBParameterGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DBParameterGroup property is set
        /// </summary>
        /// <returns>true if DBParameterGroup property is set</returns>
        public bool IsSetDBParameterGroup()
        {
            return (DBParameterGroup.Count > 0);
        }

        /// <summary>
        /// Gets and sets the AvailabilityZone property.
        /// The name of the Availability Zone the DB Instance is located in.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The name of the Availability Zone the DB Instance is located in.</param>
        /// <returns>this instance</returns>
        public DBInstance WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// Gets and sets the PreferredMaintenanceWindow property.
        /// The weekly time range (in UTC) during which system maintenance can occur.
        /// Example: Sun:05:00-Sun:09:00.
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
        /// <param name="preferredMaintenanceWindow">The weekly time range (in UTC) during which system maintenance can occur.
        /// Example: Sun:05:00-Sun:09:00.</param>
        /// <returns>this instance</returns>
        public DBInstance WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// Gets and sets the PendingModifiedValues property.
        /// Element that identifies changes to the DB Instance that are pending. This element is only included when changes are pending.
        /// Specific changes are identified by sub-elements.
        /// </summary>
        [XmlElementAttribute(ElementName = "PendingModifiedValues")]
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this.pendingModifiedValuesField; }
            set { this.pendingModifiedValuesField = value; }
        }

        /// <summary>
        /// Sets the PendingModifiedValues property
        /// </summary>
        /// <param name="pendingModifiedValues">Element that identifies changes to the DB Instance that are pending. This element is only included when changes are pending.
        /// Specific changes are identified by sub-elements.</param>
        /// <returns>this instance</returns>
        public DBInstance WithPendingModifiedValues(PendingModifiedValues pendingModifiedValues)
        {
            this.pendingModifiedValuesField = pendingModifiedValues;
            return this;
        }

        /// <summary>
        /// Checks if PendingModifiedValues property is set
        /// </summary>
        /// <returns>true if PendingModifiedValues property is set</returns>
        public bool IsSetPendingModifiedValues()
        {
            return this.pendingModifiedValuesField != null;
        }

        /// <summary>
        /// Gets and sets the LatestRestorableTime property.
        /// The latest restorable time.
        /// </summary>
        [XmlElementAttribute(ElementName = "LatestRestorableTime")]
        public DateTime LatestRestorableTime
        {
            get { return this.latestRestorableTimeField.GetValueOrDefault(); }
            set { this.latestRestorableTimeField = value; }
        }

        /// <summary>
        /// Sets the LatestRestorableTime property
        /// </summary>
        /// <param name="latestRestorableTime">The latest restorable time.</param>
        /// <returns>this instance</returns>
        public DBInstance WithLatestRestorableTime(DateTime latestRestorableTime)
        {
            this.latestRestorableTimeField = latestRestorableTime;
            return this;
        }

        /// <summary>
        /// Checks if LatestRestorableTime property is set
        /// </summary>
        /// <returns>true if LatestRestorableTime property is set</returns>
        public bool IsSetLatestRestorableTime()
        {
            return this.latestRestorableTimeField.HasValue;
        }

    }
}
