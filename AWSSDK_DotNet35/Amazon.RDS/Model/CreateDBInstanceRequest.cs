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
    public partial class CreateDBInstanceRequest : AmazonRDSRequest
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
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The meaning of this parameter differs according to the database engine you use. <b>MySQL</b> The name of the database to create when the DB
        /// instance is created. If this parameter is not specified, no database is created in the DB instance. Constraints: <ul> <li>Must contain 1 to
        /// 64 alphanumeric characters</li> <li>Cannot be a word reserved by the specified database engine</li> </ul> Type: String <b>Oracle</b> The
        /// Oracle System ID (SID) of the created DB instance. Default: <c>ORCL</c> Constraints: <ul> <li>Cannot be longer than 8 characters</li> </ul>
        /// <b>SQL Server</b> Not applicable. Must be null.
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// The DB instance identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric
        /// characters or hyphens (1 to 15 for SQL Server).</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two
        /// consecutive hyphens.</li> </ul> Example: <c>mydbinstance</c>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
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

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this.allocatedStorage.HasValue;
        }

        /// <summary>
        /// The compute and memory capacity of the DB instance. Valid Values: <c>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge |
        /// db.m2.xlarge |db.m2.2xlarge | db.m2.4xlarge</c>
        ///  
        /// </summary>
        public string DBInstanceClass
        {
            get { return this.dBInstanceClass; }
            set { this.dBInstanceClass = value; }
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

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// The name of master user for the client DB instance. <b>MySQL</b> Constraints: <ul> <li>Must be 1 to 16 alphanumeric characters.</li>
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

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;
        }

        /// <summary>
        /// The password for the master database user. Can be any printable ASCII character except "/", """, or "@". Type: String <b>MySQL</b>
        /// Constraints: Must contain from 8 to 41 characters. <b>Oracle</b> Constraints: Must contain from 8 to 30 characters. <b>SQL Server</b>
        /// Constraints: Must contain from 8 to 128 characters.
        ///  
        /// </summary>
        public string MasterUserPassword
        {
            get { return this.masterUserPassword; }
            set { this.masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this.masterUserPassword != null;
        }

        /// <summary>
        /// A list of DB security groups to associate with this DB instance. Default: The default DB security group for the database engine.
        ///  
        /// </summary>
        public List<string> DBSecurityGroups
        {
            get { return this.dBSecurityGroups; }
            set { this.dBSecurityGroups = value; }
        }

        // Check to see if DBSecurityGroups property is set
        internal bool IsSetDBSecurityGroups()
        {
            return this.dBSecurityGroups.Count > 0;
        }

        /// <summary>
        /// A list of EC2 VPC security groups to associate with this DB instance. Default: The default EC2 VPC security group for the DB subnet group's
        /// VPC.
        ///  
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this.vpcSecurityGroupIds; }
            set { this.vpcSecurityGroupIds = value; }
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

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// A DB subnet group to associate with this DB instance. If there is no DB subnet group, then it is a non-VPC DB instance.
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// The weekly time range (in UTC) during which system maintenance can occur. Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> Default: A 30-minute window
        /// selected at random from an 8-hour block of time per region, occurring on a random day of the week. To see the time blocks available, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/AdjustingTheMaintenanceWindow.html"> Adjusting the Preferred Maintenance
        /// Window</a> in the Amazon RDS User Guide. Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun Constraints: Minimum 30-minute window.
        ///  
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindow; }
            set { this.preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// The name of the DB parameter group to associate with this DB instance. If this argument is omitted, the default DBParameterGroup for the
        /// specified engine will be used. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a letter</li>
        /// <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;
        }

        /// <summary>
        /// The number of days for which automated backups are retained. Setting this parameter to a positive number enables backups. Setting this
        /// parameter to 0 disables automated backups. Default: 1 Constraints: <ul> <li>Must be a value from 0 to 35</li> <li>Cannot be set to 0 if the
        /// DB instance is a source to read replicas</li> </ul>
        ///  
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this.backupRetentionPeriod ?? default(int); }
            set { this.backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this.backupRetentionPeriod.HasValue;
        }

        /// <summary>
        /// The daily time range during which automated backups are created if automated backups are enabled, using the <c>BackupRetentionPeriod</c>
        /// parameter. Default: A 30-minute window selected at random from an 8-hour block of time per region. See the Amazon RDS User Guide for the
        /// time blocks for each region from which the default backup windows are assigned. Constraints: Must be in the format <c>hh24:mi-hh24:mi</c>.
        /// Times should be Universal Time Coordinated (UTC). Must not conflict with the preferred maintenance window. Must be at least 30 minutes.
        ///  
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this.preferredBackupWindow; }
            set { this.preferredBackupWindow = value; }
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

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// Specifies if the DB instance is a Multi-AZ deployment. You cannot set the AvailabilityZone parameter if the MultiAZ parameter is set to
        /// true.
        ///  
        /// </summary>
        public bool MultiAZ
        {
            get { return this.multiAZ ?? default(bool); }
            set { this.multiAZ = value; }
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

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// Indicates that minor engine upgrades will be applied automatically to the DB instance during the maintenance window. Default: <c>true</c>
        ///  
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this.autoMinorVersionUpgrade ?? default(bool); }
            set { this.autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;
        }

        /// <summary>
        /// License model information for this DB instance. Valid values: <c>license-included</c> | <c>bring-your-own-license</c> |
        /// <c>general-public-license</c>
        ///  
        /// </summary>
        public string LicenseModel
        {
            get { return this.licenseModel; }
            set { this.licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this.licenseModel != null;
        }

        /// <summary>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially allocated for the DB instance. Constraints: Must be an
        /// integer greater than 1000.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }

        /// <summary>
        /// Indicates that the DB instance should be associated with the specified option group. <!-- Note that persistent options, such as the
        /// TDE_SQLServer option for Microsoft SQL Server, cannot be removed from an option group while DB instances are associated with the option
        /// group. --> Permanent options, such as the TDE option for Oracle Advanced Security TDE, cannot be removed from an option group, and that
        /// option group cannot be removed from a DB instance once it is associated with a DB instance
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

        /// <summary>
        /// For supported engines, indicates that the DB instance should be associated with the specified CharacterSet.
        ///  
        /// </summary>
        public string CharacterSetName
        {
            get { return this.characterSetName; }
            set { this.characterSetName = value; }
        }

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this.characterSetName != null;
        }

        /// <summary>
        /// Specifies the accessibility options for the DB instance. A value of true specifies an Internet-facing instance with a publicly resolvable
        /// DNS name, which resolves to a public IP address. A value of false specifies an internal instance with a DNS name that resolves to a private
        /// IP address. Default: The default behavior varies depending on whether a VPC has been requested or not. The following list shows the default
        /// behavior in each case. <ul> <li><b>Default VPC:</b>true</li> <li><b>VPC:</b>false</li> </ul> If no DB subnet group has been specified as
        /// part of the request and the PubliclyAccessible value has not been set, the DB instance will be publicly accessible. If a specific DB subnet
        /// group has been specified as part of the request and the PubliclyAccessible value has not been set, the DB instance will be private.
        ///  
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this.publiclyAccessible ?? default(bool); }
            set { this.publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this.publiclyAccessible.HasValue;
        }

        /// <summary>
        /// A list of tags.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
