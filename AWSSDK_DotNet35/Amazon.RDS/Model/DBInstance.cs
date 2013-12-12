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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Contains the result of a successful invocation of the following actions: </para>
    /// <ul>
    /// <li> CreateDBInstance </li>
    /// <li> DeleteDBInstance </li>
    /// <li> ModifyDBInstance </li>
    /// 
    /// </ul>
    /// <para>This data type is used as a response element in the DescribeDBInstances action.</para>
    /// </summary>
    public partial class DBInstance : AmazonWebServiceResponse
    {
        
        private string dBInstanceIdentifier;
        private string dBInstanceClass;
        private string engine;
        private string dBInstanceStatus;
        private string masterUsername;
        private string dBName;
        private Endpoint endpoint;
        private int? allocatedStorage;
        private DateTime? instanceCreateTime;
        private string preferredBackupWindow;
        private int? backupRetentionPeriod;
        private List<DBSecurityGroupMembership> dBSecurityGroups = new List<DBSecurityGroupMembership>();
        private List<VpcSecurityGroupMembership> vpcSecurityGroups = new List<VpcSecurityGroupMembership>();
        private List<DBParameterGroupStatus> dBParameterGroups = new List<DBParameterGroupStatus>();
        private string availabilityZone;
        private DBSubnetGroup dBSubnetGroup;
        private string preferredMaintenanceWindow;
        private PendingModifiedValues pendingModifiedValues;
        private DateTime? latestRestorableTime;
        private bool? multiAZ;
        private string engineVersion;
        private bool? autoMinorVersionUpgrade;
        private string readReplicaSourceDBInstanceIdentifier;
        private List<string> readReplicaDBInstanceIdentifiers = new List<string>();
        private string licenseModel;
        private int? iops;
        private List<OptionGroupMembership> optionGroupMemberships = new List<OptionGroupMembership>();
        private string characterSetName;
        private string secondaryAvailabilityZone;
        private bool? publiclyAccessible;
        private List<DBInstanceStatusInfo> statusInfos = new List<DBInstanceStatusInfo>();


        /// <summary>
        /// Contains a user-supplied database identifier. This is the unique key that identifies a DB instance.
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
        /// Contains the name of the compute and memory capacity class of the DB instance.
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
        /// Provides the name of the database engine to be used for this DB instance.
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
        /// Specifies the current state of this database.
        ///  
        /// </summary>
        public string DBInstanceStatus
        {
            get { return this.dBInstanceStatus; }
            set { this.dBInstanceStatus = value; }
        }

        // Check to see if DBInstanceStatus property is set
        internal bool IsSetDBInstanceStatus()
        {
            return this.dBInstanceStatus != null;
        }

        /// <summary>
        /// Contains the master username for the DB instance.
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
        /// The meaning of this parameter differs according to the database engine you use. For example, this value returns only MySQL information when
        /// returning values from CreateDBInstanceReadReplica since read replicas are only supported for MySQL. <b>MySQL</b> Contains the name of the
        /// initial database of this instance that was provided at create time, if one was specified when the DB instance was created. This same name is
        /// returned for the life of the DB instance. Type: String <b>Oracle</b> Contains the Oracle System ID (SID) of the created DB instance. Not
        /// shown when the returned parameters do not apply to an Oracle DB instance.
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
        /// Specifies the connection endpoint.
        ///  
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

        /// <summary>
        /// Specifies the allocated storage size specified in gigabytes.
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
        /// Provides the date and time the DB instance was created.
        ///  
        /// </summary>
        public DateTime InstanceCreateTime
        {
            get { return this.instanceCreateTime ?? default(DateTime); }
            set { this.instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this.instanceCreateTime.HasValue;
        }

        /// <summary>
        /// Specifies the daily time range during which automated backups are created if automated backups are enabled, as determined by the
        /// <c>BackupRetentionPeriod</c>.
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
        /// Specifies the number of days for which automatic DB snapshots are retained.
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
        /// Provides List of DB security group elements containing only <c>DBSecurityGroup.Name</c> and <c>DBSecurityGroup.Status</c> subelements.
        ///  
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroups
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
        /// Provides List of VPC security group elements that the DB instance belongs to.
        ///  
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this.vpcSecurityGroups; }
            set { this.vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this.vpcSecurityGroups.Count > 0;
        }

        /// <summary>
        /// Provides the list of DB parameter groups applied to this DB instance.
        ///  
        /// </summary>
        public List<DBParameterGroupStatus> DBParameterGroups
        {
            get { return this.dBParameterGroups; }
            set { this.dBParameterGroups = value; }
        }

        // Check to see if DBParameterGroups property is set
        internal bool IsSetDBParameterGroups()
        {
            return this.dBParameterGroups.Count > 0;
        }

        /// <summary>
        /// Specifies the name of the Availability Zone the DB instance is located in.
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
        /// Specifies information on the subnet group associated with the DB instance, including the name, description, and subnets in the subnet group.
        ///  
        /// </summary>
        public DBSubnetGroup DBSubnetGroup
        {
            get { return this.dBSubnetGroup; }
            set { this.dBSubnetGroup = value; }
        }

        // Check to see if DBSubnetGroup property is set
        internal bool IsSetDBSubnetGroup()
        {
            return this.dBSubnetGroup != null;
        }

        /// <summary>
        /// Specifies the weekly time range (in UTC) during which system maintenance can occur.
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
        /// Specifies that changes to the DB instance are pending. This element is only included when changes are pending. Specific changes are
        /// identified by subelements.
        ///  
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this.pendingModifiedValues; }
            set { this.pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this.pendingModifiedValues != null;
        }

        /// <summary>
        /// Specifies the latest time to which a database can be restored with point-in-time restore.
        ///  
        /// </summary>
        public DateTime LatestRestorableTime
        {
            get { return this.latestRestorableTime ?? default(DateTime); }
            set { this.latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this.latestRestorableTime.HasValue;
        }

        /// <summary>
        /// Specifies if the DB instance is a Multi-AZ deployment.
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
        /// Indicates the database engine version.
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
        /// Indicates that minor version patches are applied automatically.
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
        /// Contains the identifier of the source DB instance if this DB instance is a read replica.
        ///  
        /// </summary>
        public string ReadReplicaSourceDBInstanceIdentifier
        {
            get { return this.readReplicaSourceDBInstanceIdentifier; }
            set { this.readReplicaSourceDBInstanceIdentifier = value; }
        }

        // Check to see if ReadReplicaSourceDBInstanceIdentifier property is set
        internal bool IsSetReadReplicaSourceDBInstanceIdentifier()
        {
            return this.readReplicaSourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Contains one or more identifiers of the read replicas associated with this DB instance.
        ///  
        /// </summary>
        public List<string> ReadReplicaDBInstanceIdentifiers
        {
            get { return this.readReplicaDBInstanceIdentifiers; }
            set { this.readReplicaDBInstanceIdentifiers = value; }
        }

        // Check to see if ReadReplicaDBInstanceIdentifiers property is set
        internal bool IsSetReadReplicaDBInstanceIdentifiers()
        {
            return this.readReplicaDBInstanceIdentifiers.Count > 0;
        }

        /// <summary>
        /// License model information for this DB instance.
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
        /// Specifies the Provisioned IOPS (I/O operations per second) value.
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
        /// Provides the list of option group memberships for this DB instance.
        ///  
        /// </summary>
        public List<OptionGroupMembership> OptionGroupMemberships
        {
            get { return this.optionGroupMemberships; }
            set { this.optionGroupMemberships = value; }
        }

        // Check to see if OptionGroupMemberships property is set
        internal bool IsSetOptionGroupMemberships()
        {
            return this.optionGroupMemberships.Count > 0;
        }

        /// <summary>
        /// If present, specifies the name of the character set that this instance is associated with.
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
        /// If present, specifies the name of the secondary Availability Zone for a DB instance with multi-AZ support.
        ///  
        /// </summary>
        public string SecondaryAvailabilityZone
        {
            get { return this.secondaryAvailabilityZone; }
            set { this.secondaryAvailabilityZone = value; }
        }

        // Check to see if SecondaryAvailabilityZone property is set
        internal bool IsSetSecondaryAvailabilityZone()
        {
            return this.secondaryAvailabilityZone != null;
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
        /// The status of a read replica. If the instance is not a read replica, this will be blank.
        ///  
        /// </summary>
        public List<DBInstanceStatusInfo> StatusInfos
        {
            get { return this.statusInfos; }
            set { this.statusInfos = value; }
        }

        // Check to see if StatusInfos property is set
        internal bool IsSetStatusInfos()
        {
            return this.statusInfos.Count > 0;
        }
    }
}
