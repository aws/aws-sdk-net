/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateDBInstance operation.
    /// <para> Creates a new DB instance. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBInstance"/>
    public class CreateDBInstanceRequest : AmazonWebServiceRequest
    {
        private string dBName;
        private string dBInstanceIdentifier;
        private int? allocatedStorage;
        private string dBInstanceClass;
        private string engine;
        private string masterUsername;
        private string masterUserPassword;
        private List<string> dBSecurityGroups = new List<string>();
        private List<string> vpcSecurityGroupIds = new List<string>();
        private string availabilityZone;
        private string dBSubnetGroupName;
        private string preferredMaintenanceWindow;
        private string dBParameterGroupName;
        private int? backupRetentionPeriod;
        private string preferredBackupWindow;
        private int? port;
        private bool? multiAZ;
        private string engineVersion;
        private bool? autoMinorVersionUpgrade;
        private string licenseModel;
        private int? iops;
        private string optionGroupName;
        private string characterSetName;
        private bool? publiclyAccessible;

        /// <summary>
        /// The meaning of this parameter differs according to the database engine you use. <b>MySQL</b> The name of the database to create when the DB
        /// Instance is created. If this parameter is not specified, no database is created in the DB Instance. Constraints: <ul> <li>Must contain 1 to
        /// 64 alphanumeric characters</li> <li>Cannot be a word reserved by the specified database engine</li> </ul> Type: String <b>Oracle</b> The
        /// Oracle System ID (SID) of the created DB Instance. Default: <c>ORCL</c> Constraints: <ul> <li>Cannot be longer than 8 characters</li> </ul>
        /// <b>SQL Server</b> Not applicable. Must be null.
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        /// <summary>
        /// Sets the DBName property
        /// </summary>
        /// <param name="dBName">The value to set for the DBName property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBName(string dBName)
        {
            this.dBName = dBName;
            return this;
        }
            

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// The DB Instance identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric
        /// characters or hyphens (1 to 15 for SQL Server).</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two
        /// consecutive hyphens.</li> </ul> Example: <c>mydbinstance</c>
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
        public CreateDBInstanceRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
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
        /// The amount of storage (in gigabytes) to be initially allocated for the database instance. <b>MySQL</b> Constraints: Must be an integer from
        /// 5 to 1024. Type: Integer <b>Oracle</b> Constraints: Must be an integer from 10 to 1024. <b>SQL Server</b> Constraints: Must be an integer
        /// from 200 to 1024 (Standard Edition and Enterprise Edition) or from 30 to 1024 (Express Edition and Web Edition)
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
        public CreateDBInstanceRequest WithAllocatedStorage(int allocatedStorage)
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
        /// The compute and memory capacity of the DB Instance. Valid Values: <c>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge |
        /// db.m2.xlarge |db.m2.2xlarge | db.m2.4xlarge</c>
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
        public CreateDBInstanceRequest WithDBInstanceClass(string dBInstanceClass)
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
        /// The name of the database engine to be used for this instance. Valid Values: <c>MySQL</c> | <c>oracle-se1</c> | <c>oracle-se</c> |
        /// <c>oracle-ee</c> | <c>sqlserver-ee</c> | <c>sqlserver-se</c> | <c>sqlserver-ex</c> | <c>sqlserver-web</c>
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">The value to set for the Engine property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithEngine(string engine)
        {
            this.engine = engine;
            return this;
        }
            

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// The name of master user for the client DB Instance. <b>MySQL</b> Constraints: <ul> <li>Must be 1 to 16 alphanumeric characters.</li>
        /// <li>First character must be a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li> </ul> Type: String
        /// <b>Oracle</b> Constraints: <ul> <li>Must be 1 to 30 alphanumeric characters.</li> <li>First character must be a letter.</li> <li>Cannot be a
        /// reserved word for the chosen database engine.</li> </ul> <b>SQL Server</b> Constraints: <ul> <li>Must be 1 to 128 alphanumeric
        /// characters.</li> <li>First character must be a letter.</li> <li>Cannot be a reserved word for the chosen database engine.</li> </ul>
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The value to set for the MasterUsername property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithMasterUsername(string masterUsername)
        {
            this.masterUsername = masterUsername;
            return this;
        }
            

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;
        }

        /// <summary>
        /// The password for the master database user. Can be any printable ASCII character except "/", "\", or "@". Type: String <b>MySQL</b>
        /// Constraints: Must contain from 8 to 41 alphanumeric characters. <b>Oracle</b> Constraints: Must contain from 8 to 30 alphanumeric
        /// characters. <b>SQL Server</b> Constraints: Must contain from 8 to 128 alphanumeric characters.
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
        public CreateDBInstanceRequest WithMasterUserPassword(string masterUserPassword)
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
        /// A list of DB Security Groups to associate with this DB Instance. Default: The default DB Security Group for the database engine.
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
        public CreateDBInstanceRequest WithDBSecurityGroups(params string[] dBSecurityGroups)
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
        public CreateDBInstanceRequest WithDBSecurityGroups(IEnumerable<string> dBSecurityGroups)
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
        /// A list of EC2 VPC Security Groups to associate with this DB Instance. Default: The default EC2 VPC Security Group for the DB Subnet group's
        /// VPC.
        ///  
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this.vpcSecurityGroupIds; }
            set { this.vpcSecurityGroupIds = value; }
        }
        /// <summary>
        /// Adds elements to the VpcSecurityGroupIds collection
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithVpcSecurityGroupIds(params string[] vpcSecurityGroupIds)
        {
            foreach (string element in vpcSecurityGroupIds)
            {
                this.vpcSecurityGroupIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VpcSecurityGroupIds collection
        /// </summary>
        /// <param name="vpcSecurityGroupIds">The values to add to the VpcSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithVpcSecurityGroupIds(IEnumerable<string> vpcSecurityGroupIds)
        {
            foreach (string element in vpcSecurityGroupIds)
            {
                this.vpcSecurityGroupIds.Add(element);
            }

            return this;
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this.vpcSecurityGroupIds.Count > 0;
        }

        /// <summary>
        /// The EC2 Availability Zone that the database instance will be created in. Default: A random, system-chosen Availability Zone in the
        /// endpoint's region. Example: <c>us-east-1d</c> Constraint: The AvailabilityZone parameter cannot be specified if the MultiAZ parameter is set
        /// to <c>true</c>. The specified Availability Zone must be in the same region as the current endpoint.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// A DB Subnet Group to associate with this DB Instance. If there is no DB Subnet Group, then it is a non-VPC DB instance.
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroupName property
        /// </summary>
        /// <param name="dBSubnetGroupName">The value to set for the DBSubnetGroupName property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithDBSubnetGroupName(string dBSubnetGroupName)
        {
            this.dBSubnetGroupName = dBSubnetGroupName;
            return this;
        }
            

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// The weekly time range (in UTC) during which system maintenance can occur. Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> Default: A 30-minute window
        /// selected at random from an 8-hour block of time per region, occurring on a random day of the week. The following list shows the time blocks
        /// for each region from which the default maintenance windows are assigned. <ul> <li><b>US-East (Northern Virginia) Region:</b> 03:00-11:00
        /// UTC</li> <li><b>US-West (Northern California) Region:</b> 06:00-14:00 UTC</li> <li><b>EU (Ireland) Region:</b> 22:00-06:00 UTC</li>
        /// <li><b>Asia Pacific (Singapore) Region:</b> 14:00-22:00 UTC</li> <li><b>Asia Pacific (Tokyo) Region: </b> 17:00-03:00 UTC</li> </ul> Valid
        /// Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun Constraints: Minimum 30-minute window.
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
        public CreateDBInstanceRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// The name of the DB Parameter Group to associate with this DB instance. If this argument is omitted, the default DBParameterGroup for the
        /// specified engine will be used. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a letter</li>
        /// <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
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
        public CreateDBInstanceRequest WithDBParameterGroupName(string dBParameterGroupName)
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
        /// The number of days for which automated backups are retained. Setting this parameter to a positive number enables backups. Setting this
        /// parameter to 0 disables automated backups. Default: 1 Constraints: <ul> <li>Must be a value from 0 to 8</li> <li>Cannot be set to 0 if the
        /// DB Instance is a master instance with read replicas</li> </ul>
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
        public CreateDBInstanceRequest WithBackupRetentionPeriod(int backupRetentionPeriod)
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
        /// The daily time range during which automated backups are created if automated backups are enabled, using the <c>BackupRetentionPeriod</c>
        /// parameter. Default: A 30-minute window selected at random from an 8-hour block of time per region. The following list shows the time blocks
        /// for each region from which the default backup windows are assigned. <ul> <li><b>US-East (Northern Virginia) Region:</b> 03:00-11:00 UTC</li>
        /// <li><b>US-West (Northern California) Region:</b> 06:00-14:00 UTC</li> <li><b>EU (Ireland) Region:</b> 22:00-06:00 UTC</li> <li><b>Asia
        /// Pacific (Singapore) Region:</b> 14:00-22:00 UTC</li> <li><b>Asia Pacific (Tokyo) Region: </b> 17:00-03:00 UTC</li> </ul> Constraints: Must
        /// be in the format <c>hh24:mi-hh24:mi</c>. Times should be Universal Time Coordinated (UTC). Must not conflict with the preferred maintenance
        /// window. Must be at least 30 minutes.
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
        public CreateDBInstanceRequest WithPreferredBackupWindow(string preferredBackupWindow)
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
        /// The port number on which the database accepts connections. <b>MySQL</b> Default: <c>3306</c> Valid Values: <c>1150-65535</c> Type: Integer
        /// <b>Oracle</b> Default: <c>1521</c> Valid Values: <c>1150-65535</c> <b>SQL Server</b> Default: <c>1433</c> Valid Values: <c>1150-65535</c>
        /// except for <c>1434</c> and <c>3389</c>.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithPort(int port)
        {
            this.port = port;
            return this;
        }
            

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// Specifies if the DB Instance is a Multi-AZ deployment. You cannot set the AvailabilityZone parameter if the MultiAZ parameter is set to
        /// true.
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
        public CreateDBInstanceRequest WithMultiAZ(bool multiAZ)
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
        /// The version number of the database engine to use. <b>MySQL</b> Example: <c>5.1.42</c> Type: String <b>Oracle</b> Example: <c>11.2.0.2.v2</c>
        /// Type: String <b>SQL Server</b> Example: <c>10.50.2789.0.v1</c>
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
        public CreateDBInstanceRequest WithEngineVersion(string engineVersion)
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
        /// Indicates that minor engine upgrades will be applied automatically to the DB Instance during the maintenance window. Default: <c>true</c>
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
        public CreateDBInstanceRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
        {
            this.autoMinorVersionUpgrade = autoMinorVersionUpgrade;
            return this;
        }
            

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;
        }

        /// <summary>
        /// License model information for this DB Instance. Valid values: <c>license-included</c> | <c>bring-your-own-license</c> |
        /// <c>general-public-license</c>
        ///  
        /// </summary>
        public string LicenseModel
        {
            get { return this.licenseModel; }
            set { this.licenseModel = value; }
        }

        /// <summary>
        /// Sets the LicenseModel property
        /// </summary>
        /// <param name="licenseModel">The value to set for the LicenseModel property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithLicenseModel(string licenseModel)
        {
            this.licenseModel = licenseModel;
            return this;
        }
            

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this.licenseModel != null;
        }

        /// <summary>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially allocated for the DB Instance. Constraints: Must be an
        /// integer greater than 1000.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        /// <summary>
        /// Sets the Iops property
        /// </summary>
        /// <param name="iops">The value to set for the Iops property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithIops(int iops)
        {
            this.iops = iops;
            return this;
        }
            

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }

        /// <summary>
        /// Indicates that the DB Instance should be associated with the specified option group.
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        /// <summary>
        /// Sets the OptionGroupName property
        /// </summary>
        /// <param name="optionGroupName">The value to set for the OptionGroupName property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithOptionGroupName(string optionGroupName)
        {
            this.optionGroupName = optionGroupName;
            return this;
        }
            

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

        /// <summary>
        /// For supported engines, indicates that the DB Instance should be associated with the specified CharacterSet.
        ///  
        /// </summary>
        public string CharacterSetName
        {
            get { return this.characterSetName; }
            set { this.characterSetName = value; }
        }

        /// <summary>
        /// Sets the CharacterSetName property
        /// </summary>
        /// <param name="characterSetName">The value to set for the CharacterSetName property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithCharacterSetName(string characterSetName)
        {
            this.characterSetName = characterSetName;
            return this;
        }
            

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this.characterSetName != null;
        }
        public bool PubliclyAccessible
        {
            get { return this.publiclyAccessible ?? default(bool); }
            set { this.publiclyAccessible = value; }
        }

        /// <summary>
        /// Sets the PubliclyAccessible property
        /// </summary>
        /// <param name="publiclyAccessible">The value to set for the PubliclyAccessible property </param>
        /// <returns>this instance</returns>
        public CreateDBInstanceRequest WithPubliclyAccessible(bool publiclyAccessible)
        {
            this.publiclyAccessible = publiclyAccessible;
            return this;
        }
            

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this.publiclyAccessible.HasValue;
        }
    }
}
    
