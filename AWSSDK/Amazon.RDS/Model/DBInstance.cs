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
    public class DBInstance
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
        private OptionGroupMembership optionGroupMembership;
        private string characterSetName;
        private string secondaryAvailabilityZone;
        private bool? publiclyAccessible;

        /// <summary>
        /// Contains a user-supplied database identifier. This is the unique key that identifies a DB Instance.
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
        public DBInstance WithDBInstanceIdentifier(string dBInstanceIdentifier)
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
        /// Contains the name of the compute and memory capacity class of the DB Instance.
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
        public DBInstance WithDBInstanceClass(string dBInstanceClass)
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
        /// Provides the name of the database engine to be used for this DB Instance.
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
        public DBInstance WithEngine(string engine)
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
        /// Specifies the current state of this database.
        ///  
        /// </summary>
        public string DBInstanceStatus
        {
            get { return this.dBInstanceStatus; }
            set { this.dBInstanceStatus = value; }
        }

        /// <summary>
        /// Sets the DBInstanceStatus property
        /// </summary>
        /// <param name="dBInstanceStatus">The value to set for the DBInstanceStatus property </param>
        /// <returns>this instance</returns>
        public DBInstance WithDBInstanceStatus(string dBInstanceStatus)
        {
            this.dBInstanceStatus = dBInstanceStatus;
            return this;
        }
            

        // Check to see if DBInstanceStatus property is set
        internal bool IsSetDBInstanceStatus()
        {
            return this.dBInstanceStatus != null;
        }

        /// <summary>
        /// Contains the master username for the DB Instance.
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
        public DBInstance WithMasterUsername(string masterUsername)
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
        /// The meaning of this parameter differs according to the database engine you use. <b>MySQL</b> Contains the name of the initial database of
        /// this instance that was provided at create time, if one was specified when the DB Instance was created. This same name is returned for the
        /// life of the DB Instance. Type: String <b>Oracle</b> Contains the Oracle System ID (SID) of the created DB Instance.
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
        public DBInstance WithDBName(string dBName)
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
        /// Specifies the connection endpoint.
        ///  
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        /// <summary>
        /// Sets the Endpoint property
        /// </summary>
        /// <param name="endpoint">The value to set for the Endpoint property </param>
        /// <returns>this instance</returns>
        public DBInstance WithEndpoint(Endpoint endpoint)
        {
            this.endpoint = endpoint;
            return this;
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

        /// <summary>
        /// Sets the AllocatedStorage property
        /// </summary>
        /// <param name="allocatedStorage">The value to set for the AllocatedStorage property </param>
        /// <returns>this instance</returns>
        public DBInstance WithAllocatedStorage(int allocatedStorage)
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
        /// Provides the date and time the DB Instance was created.
        ///  
        /// </summary>
        public DateTime InstanceCreateTime
        {
            get { return this.instanceCreateTime ?? default(DateTime); }
            set { this.instanceCreateTime = value; }
        }

        /// <summary>
        /// Sets the InstanceCreateTime property
        /// </summary>
        /// <param name="instanceCreateTime">The value to set for the InstanceCreateTime property </param>
        /// <returns>this instance</returns>
        public DBInstance WithInstanceCreateTime(DateTime instanceCreateTime)
        {
            this.instanceCreateTime = instanceCreateTime;
            return this;
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

        /// <summary>
        /// Sets the PreferredBackupWindow property
        /// </summary>
        /// <param name="preferredBackupWindow">The value to set for the PreferredBackupWindow property </param>
        /// <returns>this instance</returns>
        public DBInstance WithPreferredBackupWindow(string preferredBackupWindow)
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
        /// Specifies the number of days for which automatic DB Snapshots are retained.
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
        public DBInstance WithBackupRetentionPeriod(int backupRetentionPeriod)
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
        /// Provides List of DB Security Group elements containing only <c>DBSecurityGroup.Name</c> and <c>DBSecurityGroup.Status</c> subelements.
        ///  
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroups
        {
            get { return this.dBSecurityGroups; }
            set { this.dBSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the DBSecurityGroups collection
        /// </summary>
        /// <param name="dBSecurityGroups">The values to add to the DBSecurityGroups collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithDBSecurityGroups(params DBSecurityGroupMembership[] dBSecurityGroups)
        {
            foreach (DBSecurityGroupMembership element in dBSecurityGroups)
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
        public DBInstance WithDBSecurityGroups(IEnumerable<DBSecurityGroupMembership> dBSecurityGroups)
        {
            foreach (DBSecurityGroupMembership element in dBSecurityGroups)
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
        /// Provides List of VPC security group elements that the DB Instance belongs to.
        ///  
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this.vpcSecurityGroups; }
            set { this.vpcSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the VpcSecurityGroups collection
        /// </summary>
        /// <param name="vpcSecurityGroups">The values to add to the VpcSecurityGroups collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithVpcSecurityGroups(params VpcSecurityGroupMembership[] vpcSecurityGroups)
        {
            foreach (VpcSecurityGroupMembership element in vpcSecurityGroups)
            {
                this.vpcSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VpcSecurityGroups collection
        /// </summary>
        /// <param name="vpcSecurityGroups">The values to add to the VpcSecurityGroups collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithVpcSecurityGroups(IEnumerable<VpcSecurityGroupMembership> vpcSecurityGroups)
        {
            foreach (VpcSecurityGroupMembership element in vpcSecurityGroups)
            {
                this.vpcSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this.vpcSecurityGroups.Count > 0;
        }

        /// <summary>
        /// Provides the list of DB Parameter Groups applied to this DB Instance.
        ///  
        /// </summary>
        public List<DBParameterGroupStatus> DBParameterGroups
        {
            get { return this.dBParameterGroups; }
            set { this.dBParameterGroups = value; }
        }
        /// <summary>
        /// Adds elements to the DBParameterGroups collection
        /// </summary>
        /// <param name="dBParameterGroups">The values to add to the DBParameterGroups collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithDBParameterGroups(params DBParameterGroupStatus[] dBParameterGroups)
        {
            foreach (DBParameterGroupStatus element in dBParameterGroups)
            {
                this.dBParameterGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DBParameterGroups collection
        /// </summary>
        /// <param name="dBParameterGroups">The values to add to the DBParameterGroups collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithDBParameterGroups(IEnumerable<DBParameterGroupStatus> dBParameterGroups)
        {
            foreach (DBParameterGroupStatus element in dBParameterGroups)
            {
                this.dBParameterGroups.Add(element);
            }

            return this;
        }

        // Check to see if DBParameterGroups property is set
        internal bool IsSetDBParameterGroups()
        {
            return this.dBParameterGroups.Count > 0;
        }

        /// <summary>
        /// Specifies the name of the Availability Zone the DB Instance is located in.
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
        public DBInstance WithAvailabilityZone(string availabilityZone)
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
        /// Provides the inforamtion of the subnet group associated with the DB instance, including the name, descrption and subnets in the subnet
        /// group.
        ///  
        /// </summary>
        public DBSubnetGroup DBSubnetGroup
        {
            get { return this.dBSubnetGroup; }
            set { this.dBSubnetGroup = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroup property
        /// </summary>
        /// <param name="dBSubnetGroup">The value to set for the DBSubnetGroup property </param>
        /// <returns>this instance</returns>
        public DBInstance WithDBSubnetGroup(DBSubnetGroup dBSubnetGroup)
        {
            this.dBSubnetGroup = dBSubnetGroup;
            return this;
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

        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The value to set for the PreferredMaintenanceWindow property </param>
        /// <returns>this instance</returns>
        public DBInstance WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// Specifies that changes to the DB Instance are pending. This element is only included when changes are pending. Specific changes are
        /// identified by subelements.
        ///  
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this.pendingModifiedValues; }
            set { this.pendingModifiedValues = value; }
        }

        /// <summary>
        /// Sets the PendingModifiedValues property
        /// </summary>
        /// <param name="pendingModifiedValues">The value to set for the PendingModifiedValues property </param>
        /// <returns>this instance</returns>
        public DBInstance WithPendingModifiedValues(PendingModifiedValues pendingModifiedValues)
        {
            this.pendingModifiedValues = pendingModifiedValues;
            return this;
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

        /// <summary>
        /// Sets the LatestRestorableTime property
        /// </summary>
        /// <param name="latestRestorableTime">The value to set for the LatestRestorableTime property </param>
        /// <returns>this instance</returns>
        public DBInstance WithLatestRestorableTime(DateTime latestRestorableTime)
        {
            this.latestRestorableTime = latestRestorableTime;
            return this;
        }
            

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this.latestRestorableTime.HasValue;
        }

        /// <summary>
        /// Specifies if the DB Instance is a Multi-AZ deployment.
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
        public DBInstance WithMultiAZ(bool multiAZ)
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
        /// Indicates the database engine version.
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
        public DBInstance WithEngineVersion(string engineVersion)
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
        /// Indicates that minor version patches are applied automatically.
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
        public DBInstance WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
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
        /// Contains the identifier of the source DB Instance if this DB Instance is a Read Replica.
        ///  
        /// </summary>
        public string ReadReplicaSourceDBInstanceIdentifier
        {
            get { return this.readReplicaSourceDBInstanceIdentifier; }
            set { this.readReplicaSourceDBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the ReadReplicaSourceDBInstanceIdentifier property
        /// </summary>
        /// <param name="readReplicaSourceDBInstanceIdentifier">The value to set for the ReadReplicaSourceDBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public DBInstance WithReadReplicaSourceDBInstanceIdentifier(string readReplicaSourceDBInstanceIdentifier)
        {
            this.readReplicaSourceDBInstanceIdentifier = readReplicaSourceDBInstanceIdentifier;
            return this;
        }
            

        // Check to see if ReadReplicaSourceDBInstanceIdentifier property is set
        internal bool IsSetReadReplicaSourceDBInstanceIdentifier()
        {
            return this.readReplicaSourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Contains one or more identifiers of the Read Replicas associated with this DB Instance.
        ///  
        /// </summary>
        public List<string> ReadReplicaDBInstanceIdentifiers
        {
            get { return this.readReplicaDBInstanceIdentifiers; }
            set { this.readReplicaDBInstanceIdentifiers = value; }
        }
        /// <summary>
        /// Adds elements to the ReadReplicaDBInstanceIdentifiers collection
        /// </summary>
        /// <param name="readReplicaDBInstanceIdentifiers">The values to add to the ReadReplicaDBInstanceIdentifiers collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithReadReplicaDBInstanceIdentifiers(params string[] readReplicaDBInstanceIdentifiers)
        {
            foreach (string element in readReplicaDBInstanceIdentifiers)
            {
                this.readReplicaDBInstanceIdentifiers.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ReadReplicaDBInstanceIdentifiers collection
        /// </summary>
        /// <param name="readReplicaDBInstanceIdentifiers">The values to add to the ReadReplicaDBInstanceIdentifiers collection </param>
        /// <returns>this instance</returns>
        public DBInstance WithReadReplicaDBInstanceIdentifiers(IEnumerable<string> readReplicaDBInstanceIdentifiers)
        {
            foreach (string element in readReplicaDBInstanceIdentifiers)
            {
                this.readReplicaDBInstanceIdentifiers.Add(element);
            }

            return this;
        }

        // Check to see if ReadReplicaDBInstanceIdentifiers property is set
        internal bool IsSetReadReplicaDBInstanceIdentifiers()
        {
            return this.readReplicaDBInstanceIdentifiers.Count > 0;
        }

        /// <summary>
        /// License model information for this DB Instance.
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
        public DBInstance WithLicenseModel(string licenseModel)
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
        /// Specifies the Provisioned IOPS (I/O operations per second) value.
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
        public DBInstance WithIops(int iops)
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
        /// Specifies the name and status of the option group that this instance belongs to.
        ///  
        /// </summary>
        public OptionGroupMembership OptionGroupMembership
        {
            get { return this.optionGroupMembership; }
            set { this.optionGroupMembership = value; }
        }

        /// <summary>
        /// Sets the OptionGroupMembership property
        /// </summary>
        /// <param name="optionGroupMembership">The value to set for the OptionGroupMembership property </param>
        /// <returns>this instance</returns>
        public DBInstance WithOptionGroupMembership(OptionGroupMembership optionGroupMembership)
        {
            this.optionGroupMembership = optionGroupMembership;
            return this;
        }
            

        // Check to see if OptionGroupMembership property is set
        internal bool IsSetOptionGroupMembership()
        {
            return this.optionGroupMembership != null;
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

        /// <summary>
        /// Sets the CharacterSetName property
        /// </summary>
        /// <param name="characterSetName">The value to set for the CharacterSetName property </param>
        /// <returns>this instance</returns>
        public DBInstance WithCharacterSetName(string characterSetName)
        {
            this.characterSetName = characterSetName;
            return this;
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

        /// <summary>
        /// Sets the SecondaryAvailabilityZone property
        /// </summary>
        /// <param name="secondaryAvailabilityZone">The value to set for the SecondaryAvailabilityZone property </param>
        /// <returns>this instance</returns>
        public DBInstance WithSecondaryAvailabilityZone(string secondaryAvailabilityZone)
        {
            this.secondaryAvailabilityZone = secondaryAvailabilityZone;
            return this;
        }
            

        // Check to see if SecondaryAvailabilityZone property is set
        internal bool IsSetSecondaryAvailabilityZone()
        {
            return this.secondaryAvailabilityZone != null;
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
        public DBInstance WithPubliclyAccessible(bool publiclyAccessible)
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
