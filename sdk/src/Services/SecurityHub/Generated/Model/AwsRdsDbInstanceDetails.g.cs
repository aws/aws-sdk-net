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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains the details of an Amazon RDS DB instance.
    /// </summary>
    public partial class AwsRdsDbInstanceDetails
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to initially allocate for the DB instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AssociatedRoles. 
        /// <para>
        /// The IAM roles associated with the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbInstanceAssociatedRole> AssociatedRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbInstanceAssociatedRole>() : null;

        /// <summary>
        /// Checks to see if the AssociatedRoles property is set.
        /// </summary>
        internal bool IsSetAssociatedRoles() => this.AssociatedRoles != null && (this.AssociatedRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates whether minor version patches are applied automatically.
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
        /// The Availability Zone where the DB instance will be created.
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
        /// The number of days for which to retain automated backups.
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
        /// The name of the character set that this DB instance is associated with.
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
        /// Whether to copy resource tags to snapshots of the DB instance.
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
        /// Gets and sets the property DBName. 
        /// <para>
        /// The meaning of this parameter differs according to the database engine you use.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL, MariaDB, SQL Server, PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Contains the name of the initial database of this instance that was provided at create
        /// time, if one was specified when the DB instance was created. This same name is returned
        /// for the life of the DB instance.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Contains the Oracle System ID (SID) of the created DB instance. Not shown when the
        /// returned parameters don't apply to an Oracle DB instance. 
        /// </para>
        /// </summary>
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

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
        /// Gets and sets the property DbInstanceStatus. 
        /// <para>
        /// The current status of the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceStatus property is set.
        /// </summary>
        internal bool IsSetDbInstanceStatus() => this.DbInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property DbParameterGroups. 
        /// <para>
        /// A list of the DB parameter groups to assign to the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbParameterGroup> DbParameterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbParameterGroup>() : null;

        /// <summary>
        /// Checks to see if the DbParameterGroups property is set.
        /// </summary>
        internal bool IsSetDbParameterGroups() => this.DbParameterGroups != null && (this.DbParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbSecurityGroups. 
        /// <para>
        /// A list of the DB security groups to assign to the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DbSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DbSecurityGroups property is set.
        /// </summary>
        internal bool IsSetDbSecurityGroups() => this.DbSecurityGroups != null && (this.DbSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbSubnetGroup. 
        /// <para>
        /// Information about the subnet group that is associated with the DB instance.
        /// </para>
        /// </summary>
        public AwsRdsDbSubnetGroup DbSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DbSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDbSubnetGroup() => this.DbSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB instance. This
        /// identifier is found in CloudTrail log entries whenever the KMS key for the DB instance
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
        /// Indicates whether the DB instance has deletion protection enabled.
        /// </para>
        ///  
        /// <para>
        /// When deletion protection is enabled, the database cannot be deleted.
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
        /// The Active Directory domain membership records associated with the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbDomainMembership> DomainMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbDomainMembership>() : null;

        /// <summary>
        /// Checks to see if the DomainMemberships property is set.
        /// </summary>
        internal bool IsSetDomainMemberships() => this.DomainMemberships != null && (this.DomainMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnabledCloudWatchLogsExports. 
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
        public List<string> EnabledCloudWatchLogsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledCloudWatchLogsExports property is set.
        /// </summary>
        internal bool IsSetEnabledCloudWatchLogsExports() => this.EnabledCloudWatchLogsExports != null && (this.EnabledCloudWatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Specifies the connection endpoint.
        /// </para>
        /// </summary>
        public AwsRdsDbInstanceEndpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Provides the name of the database engine to use for this DB instance.
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
        /// The ARN of the CloudWatch Logs log stream that receives the enhanced monitoring metrics
        /// data for the DB instance.
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
        /// True if mapping of IAM accounts to database accounts is enabled, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// IAM database authentication can be enabled for the following database engines.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For MySQL 5.6, minor version 5.6.34 or higher
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For MySQL 5.7, minor version 5.7.16 or higher
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora 5.6 or higher
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IAMDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIAMDatabaseAuthenticationEnabled() => this.IAMDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// Indicates when the DB instance was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string InstanceCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCreateTime property is set.
        /// </summary>
        internal bool IsSetInstanceCreateTime() => this.InstanceCreateTime != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the provisioned IOPS (I/O operations per second) for this DB instance.
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
        /// If <c>StorageEncrypted</c> is true, the KMS key identifier for the encrypted DB instance.
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
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetLatestRestorableTime() => this.LatestRestorableTime != null;

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
        /// Gets and sets the property ListenerEndpoint.
        /// </summary>
        public AwsRdsDbInstanceEndpoint ListenerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ListenerEndpoint property is set.
        /// </summary>
        internal bool IsSetListenerEndpoint() => this.ListenerEndpoint != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name of the DB instance.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit to which Amazon RDS can automatically scale the storage of the DB
        /// instance.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetMaxAllocatedStorage() => this.MaxAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when enhanced monitoring metrics are collected
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
        /// The ARN for the IAM role that permits Amazon RDS to send enhanced monitoring metrics
        /// to CloudWatch Logs.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringRoleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringRoleArn() => this.MonitoringRoleArn != null;

        /// <summary>
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// Whether the DB instance is a multiple Availability Zone deployment.
        /// </para>
        /// </summary>
        public bool? MultiAz { get; set; }

        /// <summary>
        /// Checks to see if the MultiAz property is set.
        /// </summary>
        internal bool IsSetMultiAz() => this.MultiAz.HasValue;

        /// <summary>
        /// Gets and sets the property OptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbOptionGroupMembership> OptionGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbOptionGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the OptionGroupMemberships property is set.
        /// </summary>
        internal bool IsSetOptionGroupMemberships() => this.OptionGroupMemberships != null && (this.OptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Changes to the DB instance that are currently pending.
        /// </para>
        /// </summary>
        public AwsRdsDbPendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsEnabled. 
        /// <para>
        /// Indicates whether Performance Insights is enabled for the DB instance.
        /// </para>
        /// </summary>
        public bool? PerformanceInsightsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsEnabled property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsEnabled() => this.PerformanceInsightsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKmsKeyId. 
        /// <para>
        /// The identifier of the KMS key used to encrypt the Performance Insights data.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsKmsKeyId property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsKmsKeyId() => this.PerformanceInsightsKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsRetentionPeriod. 
        /// <para>
        /// The number of days to retain Performance Insights data.
        /// </para>
        /// </summary>
        public int? PerformanceInsightsRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsRetentionPeriod() => this.PerformanceInsightsRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The range of time each day when automated backups are created, if automated backups
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// Uses the format <c>HH:MM-HH:MM</c>. For example, <c>04:52-05:22</c>.
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
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// Uses the format <c>&lt;day&gt;:HH:MM-&lt;day&gt;:HH:MM</c>.
        /// </para>
        ///  
        /// <para>
        /// For the day values, use <c>mon</c>|<c>tue</c>|<c>wed</c>|<c>thu</c>|<c>fri</c>|<c>sat</c>|<c>sun</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>sun:09:32-sun:10:02</c>.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbProcessorFeature> ProcessorFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbProcessorFeature>() : null;

        /// <summary>
        /// Checks to see if the ProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetProcessorFeatures() => this.ProcessorFeatures != null && (this.ProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The order in which to promote an Aurora replica to the primary instance after a failure
        /// of the existing primary instance.
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
        /// Specifies the accessibility options for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// A value of true specifies an Internet-facing instance with a publicly resolvable DNS
        /// name, which resolves to a public IP address.
        /// </para>
        ///  
        /// <para>
        /// A value of false specifies an internal instance with a DNS name that resolves to a
        /// private IP address. 
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
        /// List of identifiers of Aurora DB clusters to which the RDS DB instance is replicated
        /// as a read replica.
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
        /// List of identifiers of the read replicas associated with this DB instance.
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
        /// If this DB instance is a read replica, contains the identifier of the source DB instance.
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
        /// For a DB instance with multi-Availability Zone support, the name of the secondary
        /// Availability Zone.
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
        /// The status of a read replica. If the instance isn't a read replica, this is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbStatusInfo> StatusInfos { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbStatusInfo>() : null;

        /// <summary>
        /// Checks to see if the StatusInfos property is set.
        /// </summary>
        internal bool IsSetStatusInfos() => this.StatusInfos != null && (this.StatusInfos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB instance is encrypted.
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
        /// The storage type for the DB instance.
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
        /// The time zone of the DB instance.
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
        /// A list of VPC security groups that the DB instance belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbInstanceVpcSecurityGroup> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbInstanceVpcSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
