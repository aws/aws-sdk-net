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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the details of an Amazon Neptune DB instance.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBInstances</a> action.
    /// </para>
    /// </summary>
    public partial class DBInstance
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates that minor version patches are applied automatically.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone the DB instance is located in.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// Specifies the number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The identifier of the CA certificate for this DB instance.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        ///  <i>(Not supported by Neptune)</i> 
        /// </para>
        /// </summary>
        public string CharacterSetName { get; set; }

        /// <summary>
        /// Checks to see if the CharacterSetName property is set.
        /// </summary>
        internal bool IsSetCharacterSetName() => this.CharacterSetName != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether tags are copied from the DB instance to snapshots of the DB instance.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// If the DB instance is a member of a DB cluster, contains the name of the DB cluster
        /// that the DB instance is a member of.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceArn property is set.
        /// </summary>
        internal bool IsSetDBInstanceArn() => this.DBInstanceArn != null;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// Contains the name of the compute and memory capacity class of the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// Contains a user-supplied database identifier. This identifier is the unique key that
        /// identifies a DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBInstanceStatus. 
        /// <para>
        /// Specifies the current state of this database.
        /// </para>
        /// </summary>
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceStatus property is set.
        /// </summary>
        internal bool IsSetDBInstanceStatus() => this.DBInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The database name.
        /// </para>
        /// </summary>
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroups. 
        /// <para>
        /// Provides the list of DB parameter groups applied to this DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBParameterGroupStatus> DBParameterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<DBParameterGroupStatus>() : null;

        /// <summary>
        /// Checks to see if the DBParameterGroups property is set.
        /// </summary>
        internal bool IsSetDBParameterGroups() => this.DBParameterGroups != null && (this.DBParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBSecurityGroups. 
        /// <para>
        ///  Provides List of DB security group elements containing only <c>DBSecurityGroup.Name</c>
        /// and <c>DBSecurityGroup.Status</c> subelements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<DBSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the DBSecurityGroups property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroups() => this.DBSecurityGroups != null && (this.DBSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Specifies information on the subnet group associated with the DB instance, including
        /// the name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public DBSubnetGroup DBSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroup() => this.DBSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DbInstancePort. 
        /// <para>
        /// Specifies the port that the DB instance listens on. If the DB instance is part of
        /// a DB cluster, this can be a different port than the DB cluster port.
        /// </para>
        /// </summary>
        public int? DbInstancePort { get; set; }

        /// <summary>
        /// Checks to see if the DbInstancePort property is set.
        /// </summary>
        internal bool IsSetDbInstancePort() => this.DbInstancePort.HasValue;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The Amazon Region-unique, immutable identifier for the DB instance. This identifier
        /// is found in Amazon CloudTrail log entries whenever the Amazon KMS key for the DB instance
        /// is accessed.
        /// </para>
        /// </summary>
        public string DbiResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbiResourceId property is set.
        /// </summary>
        internal bool IsSetDbiResourceId() => this.DbiResourceId != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether or not the DB instance has deletion protection enabled. The instance
        /// can't be deleted when deletion protection is enabled. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-instances-delete.html">Deleting
        /// a DB Instance</a>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property DomainMemberships. 
        /// <para>
        /// Not supported
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainMembership> DomainMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainMembership>() : null;

        /// <summary>
        /// Checks to see if the DomainMemberships property is set.
        /// </summary>
        internal bool IsSetDomainMemberships() => this.DomainMemberships != null && (this.DomainMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnabledCloudwatchLogsExports. 
        /// <para>
        /// A list of log types that this DB instance is configured to export to CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledCloudwatchLogsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledCloudwatchLogsExports property is set.
        /// </summary>
        internal bool IsSetEnabledCloudwatchLogsExports() => this.EnabledCloudwatchLogsExports != null && (this.EnabledCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Specifies the connection endpoint.
        /// </para>
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Provides the name of the database engine to be used for this DB instance.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Indicates the database engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property EnhancedMonitoringResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch Logs log stream that receives
        /// the Enhanced Monitoring metrics data for the DB instance.
        /// </para>
        /// </summary>
        public string EnhancedMonitoringResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMonitoringResourceArn property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoringResourceArn() => this.EnhancedMonitoringResourceArn != null;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// True if Amazon Identity and Access Management (IAM) authentication is enabled, and
        /// otherwise false.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IAMDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIAMDatabaseAuthenticationEnabled() => this.IAMDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// Provides the date and time the DB instance was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCreateTime property is set.
        /// </summary>
        internal bool IsSetInstanceCreateTime() => this.InstanceCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the Provisioned IOPS (I/O operations per second) value.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  Not supported: The encryption for DB instances is managed by the DB cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// Specifies the latest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetLatestRestorableTime() => this.LatestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// License model information for this DB instance.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB instance.
        /// </para>
        /// </summary>
        public int? MonitoringInterval { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringInterval property is set.
        /// </summary>
        internal bool IsSetMonitoringInterval() => this.MonitoringInterval.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringRoleArn. 
        /// <para>
        /// The ARN for the IAM role that permits Neptune to send Enhanced Monitoring metrics
        /// to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringRoleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringRoleArn() => this.MonitoringRoleArn != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies if the DB instance is a Multi-AZ deployment.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB instance. Inherited from the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4</c>, <c>DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OptionGroupMemberships. 
        /// <para>
        ///  <i>(Not supported by Neptune)</i> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionGroupMembership> OptionGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the OptionGroupMemberships property is set.
        /// </summary>
        internal bool IsSetOptionGroupMemberships() => this.OptionGroupMemberships != null && (this.OptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Specifies that changes to the DB instance are pending. This element is only included
        /// when changes are pending. Specific changes are identified by subelements.
        /// </para>
        /// </summary>
        public PendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsEnabled. 
        /// <para>
        ///  <i>(Not supported by Neptune)</i> 
        /// </para>
        /// </summary>
        public bool? PerformanceInsightsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsEnabled property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsEnabled() => this.PerformanceInsightsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        ///  <i>(Not supported by Neptune)</i> 
        /// </para>
        /// </summary>
        public string PerformanceInsightsKMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsKMSKeyId property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsKMSKeyId() => this.PerformanceInsightsKMSKeyId != null;

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  Specifies the daily time range during which automated backups are created if automated
        /// backups are enabled, as determined by the <c>BackupRetentionPeriod</c>.
        /// </para>
        /// </summary>
        public string PreferredBackupWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredBackupWindow property is set.
        /// </summary>
        internal bool IsSetPreferredBackupWindow() => this.PreferredBackupWindow != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which system maintenance can occur, in Universal
        /// Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which a Read Replica is promoted to the primary
        /// instance after a failure of the existing primary instance. 
        /// </para>
        /// </summary>
        public int? PromotionTier { get; set; }

        /// <summary>
        /// Checks to see if the PromotionTier property is set.
        /// </summary>
        internal bool IsSetPromotionTier() => this.PromotionTier.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Indicates whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance is publicly accessible and you connect from outside of the DB
        /// instance's virtual private cloud (VPC), its Domain Name System (DNS) endpoint resolves
        /// to the public IP address. When you connect from within the same VPC as the DB instance,
        /// the endpoint resolves to the private IP address. Access to the DB instance is ultimately
        /// controlled by the security group it uses. That public access isn't permitted if the
        /// security group assigned to the DB cluster doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property ReadReplicaDBClusterIdentifiers. 
        /// <para>
        /// Contains one or more identifiers of DB clusters that are Read Replicas of this DB
        /// instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaDBClusterIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadReplicaDBClusterIdentifiers property is set.
        /// </summary>
        internal bool IsSetReadReplicaDBClusterIdentifiers() => this.ReadReplicaDBClusterIdentifiers != null && (this.ReadReplicaDBClusterIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReadReplicaDBInstanceIdentifiers. 
        /// <para>
        /// Contains one or more identifiers of the Read Replicas associated with this DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaDBInstanceIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadReplicaDBInstanceIdentifiers property is set.
        /// </summary>
        internal bool IsSetReadReplicaDBInstanceIdentifiers() => this.ReadReplicaDBInstanceIdentifiers != null && (this.ReadReplicaDBInstanceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReadReplicaSourceDBInstanceIdentifier. 
        /// <para>
        /// Contains the identifier of the source DB instance if this DB instance is a Read Replica.
        /// </para>
        /// </summary>
        public string ReadReplicaSourceDBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReadReplicaSourceDBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetReadReplicaSourceDBInstanceIdentifier() => this.ReadReplicaSourceDBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// If present, specifies the name of the secondary Availability Zone for a DB instance
        /// with multi-AZ support.
        /// </para>
        /// </summary>
        public string SecondaryAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSecondaryAvailabilityZone() => this.SecondaryAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property StatusInfos. 
        /// <para>
        /// The status of a Read Replica. If the instance is not a Read Replica, this is blank.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBInstanceStatusInfo> StatusInfos { get; set; } = AWSConfigs.InitializeCollections ? new List<DBInstanceStatusInfo>() : null;

        /// <summary>
        /// Checks to see if the StatusInfos property is set.
        /// </summary>
        internal bool IsSetStatusInfos() => this.StatusInfos != null && (this.StatusInfos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Not supported: The encryption for DB instances is managed by the DB cluster.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies the storage type associated with the DB instance.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which the instance is associated for TDE encryption.
        /// </para>
        /// </summary>
        public string TdeCredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the TdeCredentialArn property is set.
        /// </summary>
        internal bool IsSetTdeCredentialArn() => this.TdeCredentialArn != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// Not supported.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Provides a list of VPC security group elements that the DB instance belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
