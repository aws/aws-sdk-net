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
    /// <summary>
    /// Creates a new Amazon RDS database instance.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class CreateDBInstanceRequest
    {
        private string DBNameField;
        private string DBInstanceIdentifierField;
        private Decimal? allocatedStorageField;
        private string DBInstanceClassField;
        private string engineField;
        private string masterUsernameField;
        private string masterUserPasswordField;
        private List<string> DBSecurityGroupsField;
        private string availabilityZoneField;
        private string preferredMaintenanceWindowField;
        private string DBParameterGroupNameField;
        private Decimal? backupRetentionPeriodField;
        private string preferredBackupWindowField;
        private Decimal? portField;

        /// <summary>
        /// Gets and sets the DBName property.
        /// Name of a database to create when the DB Instance is created. If this parameter is not specified, no database is created in the DB Instance.
        /// Must contain 1 to 64 alphanumeric characters. Cannot be a word reserved by the specified database engine.
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
        /// <param name="DBName">Name of a database to create when the DB Instance is created. If this parameter is not specified, no database is created in the DB Instance.
        /// Must contain 1 to 64 alphanumeric characters. Cannot be a word reserved by the specified database engine.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBName(string DBName)
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
        /// Gets and sets the DBInstanceIdentifier property.
        /// DB Instance identifier. This is the unique key that identifies a DB Instance. This parameter is stored as a lowercase string.
        /// ust contain from 1 to 63 alphanumeric characters or hyphens.
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
        /// <param name="DBInstanceIdentifier">DB Instance identifier. This is the unique key that identifies a DB Instance. This parameter is stored as a lowercase string.
        /// ust contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBInstanceIdentifier(string DBInstanceIdentifier)
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
        /// Amount of storage to be initially allocated for the database instance, in gigabytes.
        /// Must be an integer between 5 and 1024.
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
        /// <param name="allocatedStorage">Amount of storage to be initially allocated for the database instance, in gigabytes.
        /// Must be an integer between 5 and 1024.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithAllocatedStorage(Decimal allocatedStorage)
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
        /// Contains the compute and memory capacity of the DB Instance.
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
        /// <param name="DBInstanceClass">Contains the compute and memory capacity of the DB Instance.
        /// Valid values: db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBInstanceClass(string DBInstanceClass)
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
        /// Name of the database engine to be used for this instance.
        /// Valid values: MySQL5.1
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
        /// <param name="engine">Name of the database engine to be used for this instance.
        /// Valid values: MySQL5.1</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithEngine(string engine)
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
        /// Gets and sets the MasterUsername property.
        /// Name of master user for your DB Instance.
        /// Must be 1 to 15 alphanumeric characters.
        /// First character must be a letter.
        /// Cannot be a reserved word for the chosen database engine.
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
        /// <param name="masterUsername">Name of master user for your DB Instance.
        /// Must be 1 to 15 alphanumeric characters.
        /// First character must be a letter.
        /// Cannot be a reserved word for the chosen database engine.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithMasterUsername(string masterUsername)
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
        /// Gets and sets the MasterUserPassword property.
        /// Password for the master DB Instance user. Must contain 4 to 16 alphanumeric characters.
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
        /// <param name="masterUserPassword">Password for the master DB Instance user. Must contain 4 to 16 alphanumeric characters.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithMasterUserPassword(string masterUserPassword)
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
        /// Gets and sets the DBSecurityGroups property.
        /// List of DB Security Groups to associate with this DB Instance.
        /// The default DB Security Group for the database engine.
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
        /// <param name="list">List of DB Security Groups to associate with this DB Instance.
        /// The default DB Security Group for the database engine.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBSecurityGroups(params string[] list)
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
        /// Gets and sets the AvailabilityZone property.
        /// The EC2 Availability Zone that the database instance will be created in.
        /// Default: A random, system-chosen Availability Zone.
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
        /// <param name="availabilityZone">The EC2 Availability Zone that the database instance will be created in.
        /// Default: A random, system-chosen Availability Zone.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithAvailabilityZone(string availabilityZone)
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
        /// Format: ddd:hh24:mi-ddd:hh24:mi.
        /// Default: Sun:05:00-Sun:09:00 UTC.
        /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
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
        /// <param name="preferredMaintenanceWindow">The weekly time range (in UTC) during which system maintenance can occur.
        /// Format: ddd:hh24:mi-ddd:hh24:mi.
        /// Default: Sun:05:00-Sun:09:00 UTC.
        /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
        /// Constraints: Minimum four hour period.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// Gets and sets the DBParameterGroupName property.
        /// Name of the database parameter group to associate with this DB instance. If this argument is omitted, the
        /// default DBParameterGroup for the specified engine will be used.
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
        /// <param name="DBParameterGroupName">Name of the database parameter group to associate with this DB instance. If this argument is omitted, the
        /// default DBParameterGroup for the specified engine will be used.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBParameterGroupName(string DBParameterGroupName)
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
        /// The number of days for which automated backups are retained. Setting this parameter to a positive number enables backups.
        /// Setting this parameter to 0 disables automated backups.
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
        /// <param name="backupRetentionPeriod">The number of days for which automated backups are retained. Setting this parameter to a positive number enables backups.
        /// Setting this parameter to 0 disables automated backups.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithBackupRetentionPeriod(Decimal backupRetentionPeriod)
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
        /// The daily time range during which automated backups are created if automated backups are enabled.
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
        /// <param name="preferredBackupWindow">The daily time range during which automated backups are created if automated backups are enabled.</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithPreferredBackupWindow(string preferredBackupWindow)
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
        /// Gets and sets the Port property.
        /// Port number on which the database accepts connections.
        /// Default: 3306
        /// Valid Values: 1150-65535
        /// </summary>
        [XmlElementAttribute(ElementName = "Port")]
        public Decimal Port
        {
            get { return this.portField.GetValueOrDefault(); }
            set { this.portField = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">Port number on which the database accepts connections.
        /// Default: 3306
        /// Valid Values: 1150-65535</param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithPort(Decimal port)
        {
            this.portField = port;
            return this;
        }

        /// <summary>
        /// Checks if Port property is set
        /// </summary>
        /// <returns>true if Port property is set</returns>
        public bool IsSetPort()
        {
            return this.portField.HasValue;
        }

    }
}
