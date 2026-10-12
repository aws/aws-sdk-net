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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabaseSummary
    {
        /// <summary>
        /// Gets and sets the property ActualUsedDataStorageSizeInTBs. 
        /// <para>
        /// The actual amount of data storage currently in use by the Autonomous Database, in
        /// TB.
        /// </para>
        /// </summary>
        public double? ActualUsedDataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the ActualUsedDataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetActualUsedDataStorageSizeInTBs() => this.ActualUsedDataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property AdminPasswordSourceSummary. 
        /// <para>
        /// The summary of the admin password source configuration for the Autonomous Database.
        /// </para>
        /// </summary>
        public AdminPasswordSourceSummary AdminPasswordSourceSummary { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSourceSummary property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSourceSummary() => this.AdminPasswordSourceSummary != null;

        /// <summary>
        /// Gets and sets the property AllocatedStorageSizeInTBs. 
        /// <para>
        /// The amount of storage currently allocated to the Autonomous Database, in TB.
        /// </para>
        /// </summary>
        public double? AllocatedStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetAllocatedStorageSizeInTBs() => this.AllocatedStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property AllowlistedIps. 
        /// <para>
        /// The list of IP addresses that are allowed to access the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> AllowlistedIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowlistedIps property is set.
        /// </summary>
        internal bool IsSetAllowlistedIps() => this.AllowlistedIps != null && (this.AllowlistedIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApexDetails. 
        /// <para>
        /// The Oracle Application Express (APEX) details for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseApex ApexDetails { get; set; }

        /// <summary>
        /// Checks to see if the ApexDetails property is set.
        /// </summary>
        internal bool IsSetApexDetails() => this.ApexDetails != null;

        /// <summary>
        /// Gets and sets the property AutoRefreshFrequencyInSeconds. 
        /// <para>
        /// The frequency, in seconds, at which the refreshable clone Autonomous Database is automatically
        /// refreshed.
        /// </para>
        /// </summary>
        public int? AutoRefreshFrequencyInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AutoRefreshFrequencyInSeconds property is set.
        /// </summary>
        internal bool IsSetAutoRefreshFrequencyInSeconds() => this.AutoRefreshFrequencyInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AutoRefreshPointLagInSeconds. 
        /// <para>
        /// The time lag, in seconds, between the refreshable clone and its source Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public int? AutoRefreshPointLagInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AutoRefreshPointLagInSeconds property is set.
        /// </summary>
        internal bool IsSetAutoRefreshPointLagInSeconds() => this.AutoRefreshPointLagInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AutonomousDatabaseArn { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseArn property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseArn() => this.AutonomousDatabaseArn != null;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string AutonomousDatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseId property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseId() => this.AutonomousDatabaseId != null;

        /// <summary>
        /// Gets and sets the property AutonomousMaintenanceScheduleType. 
        /// <para>
        /// The maintenance schedule type for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousMaintenanceScheduleType AutonomousMaintenanceScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousMaintenanceScheduleType property is set.
        /// </summary>
        internal bool IsSetAutonomousMaintenanceScheduleType() => this.AutonomousMaintenanceScheduleType != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the Autonomous Database is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The unique identifier of the Availability Zone where the Autonomous Database is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailableUpgradeVersions. 
        /// <para>
        /// The list of Oracle Database software versions to which the Autonomous Database can
        /// be upgraded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> AvailableUpgradeVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailableUpgradeVersions property is set.
        /// </summary>
        internal bool IsSetAvailableUpgradeVersions() => this.AvailableUpgradeVersions != null && (this.AvailableUpgradeVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for automatic backups of the Autonomous Database.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriodInDays() => this.BackupRetentionPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property ByolComputeCountLimit. 
        /// <para>
        /// The maximum number of compute resources that you can allocate to the Autonomous Database
        /// under the bring-your-own-license (BYOL) model.
        /// </para>
        /// </summary>
        public int? ByolComputeCountLimit { get; set; }

        /// <summary>
        /// Checks to see if the ByolComputeCountLimit property is set.
        /// </summary>
        internal bool IsSetByolComputeCountLimit() => this.ByolComputeCountLimit.HasValue;

        /// <summary>
        /// Gets and sets the property CharacterSet. 
        /// <para>
        /// The character set of the Autonomous Database.
        /// </para>
        /// </summary>
        public string CharacterSet { get; set; }

        /// <summary>
        /// Checks to see if the CharacterSet property is set.
        /// </summary>
        internal bool IsSetCharacterSet() => this.CharacterSet != null;

        /// <summary>
        /// Gets and sets the property CloneTableSpaceList. 
        /// <para>
        /// The list of tablespace identifiers to clone for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> CloneTableSpaceList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the CloneTableSpaceList property is set.
        /// </summary>
        internal bool IsSetCloneTableSpaceList() => this.CloneTableSpaceList != null && (this.CloneTableSpaceList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity, in number of Elastic CPUs (ECPUs) or Oracle CPUs (OCPUs), assigned
        /// to the Autonomous Database.
        /// </para>
        /// </summary>
        public float? ComputeCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputeCount property is set.
        /// </summary>
        internal bool IsSetComputeCount() => this.ComputeCount.HasValue;

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The compute model of the Autonomous Database, either ECPU or OCPU.
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel { get; set; }

        /// <summary>
        /// Checks to see if the ComputeModel property is set.
        /// </summary>
        internal bool IsSetComputeModel() => this.ComputeModel != null;

        /// <summary>
        /// Gets and sets the property ConnectionStringDetails. 
        /// <para>
        /// The connection string details for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseConnectionStrings ConnectionStringDetails { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStringDetails property is set.
        /// </summary>
        internal bool IsSetConnectionStringDetails() => this.ConnectionStringDetails != null;

        /// <summary>
        /// Gets and sets the property ConnectionUrls. 
        /// <para>
        /// The connection URLs for accessing tools and services for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseConnectionUrls ConnectionUrls { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionUrls property is set.
        /// </summary>
        internal bool IsSetConnectionUrls() => this.ConnectionUrls != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores allocated to the Autonomous Database.
        /// </para>
        /// </summary>
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Autonomous Database was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerContacts. 
        /// <para>
        /// The list of customer contacts that receive operational notifications from Oracle for
        /// the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContacts { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;

        /// <summary>
        /// Checks to see if the CustomerContacts property is set.
        /// </summary>
        internal bool IsSetCustomerContacts() => this.CustomerContacts != null && (this.CustomerContacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSafeStatus. 
        /// <para>
        /// The status of the Oracle Data Safe registration for the Autonomous Database.
        /// </para>
        /// </summary>
        public DataSafeStatus DataSafeStatus { get; set; }

        /// <summary>
        /// Checks to see if the DataSafeStatus property is set.
        /// </summary>
        internal bool IsSetDataSafeStatus() => this.DataSafeStatus != null;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInGBs. 
        /// <para>
        /// The size, in gigabytes (GB), of the data volume allocated for the Autonomous Database.
        /// </para>
        /// </summary>
        public int? DataStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInGBs() => this.DataStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size, in terabytes (TB), of the data volume allocated for the Autonomous Database.
        /// </para>
        /// </summary>
        public double? DataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInTBs() => this.DataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseEdition. 
        /// <para>
        /// The Oracle Database edition of the Autonomous Database.
        /// </para>
        /// </summary>
        public DatabaseEdition DatabaseEdition { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseEdition property is set.
        /// </summary>
        internal bool IsSetDatabaseEdition() => this.DatabaseEdition != null;

        /// <summary>
        /// Gets and sets the property DatabaseManagementStatus. 
        /// <para>
        /// The status of Oracle Database Management for the Autonomous Database.
        /// </para>
        /// </summary>
        public DatabaseManagementStatus DatabaseManagementStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseManagementStatus property is set.
        /// </summary>
        internal bool IsSetDatabaseManagementStatus() => this.DatabaseManagementStatus != null;

        /// <summary>
        /// Gets and sets the property DatabaseType. 
        /// <para>
        /// The type of the Autonomous Database, either a regular database or a clone.
        /// </para>
        /// </summary>
        public DatabaseType DatabaseType { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseType property is set.
        /// </summary>
        internal bool IsSetDatabaseType() => this.DatabaseType != null;

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of the Autonomous Database.
        /// </para>
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// Checks to see if the DbName property is set.
        /// </summary>
        internal bool IsSetDbName() => this.DbName != null;

        /// <summary>
        /// Gets and sets the property DbToolsDetails. 
        /// <para>
        /// The list of database management tools enabled for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatabaseTool> DbToolsDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<DatabaseTool>() : null;

        /// <summary>
        /// Checks to see if the DbToolsDetails property is set.
        /// </summary>
        internal bool IsSetDbToolsDetails() => this.DbToolsDetails != null && (this.DbToolsDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbVersion. 
        /// <para>
        /// The Oracle Database software version of the Autonomous Database.
        /// </para>
        /// </summary>
        public string DbVersion { get; set; }

        /// <summary>
        /// Checks to see if the DbVersion property is set.
        /// </summary>
        internal bool IsSetDbVersion() => this.DbVersion != null;

        /// <summary>
        /// Gets and sets the property DbWorkload. 
        /// <para>
        /// The intended use of the Autonomous Database, such as transaction processing, data
        /// warehouse, JSON database, or APEX.
        /// </para>
        /// </summary>
        public DbWorkload DbWorkload { get; set; }

        /// <summary>
        /// Checks to see if the DbWorkload property is set.
        /// </summary>
        internal bool IsSetDbWorkload() => this.DbWorkload != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the Autonomous Database.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EncryptionSummary. 
        /// <para>
        /// The encryption configuration for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionSummary EncryptionSummary { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSummary property is set.
        /// </summary>
        internal bool IsSetEncryptionSummary() => this.EncryptionSummary != null;

        /// <summary>
        /// Gets and sets the property FailedDataRecoveryInSeconds. 
        /// <para>
        /// The amount of time, in seconds, that the data in the Autonomous Database is behind
        /// the data in the primary database.
        /// </para>
        /// </summary>
        public int? FailedDataRecoveryInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the FailedDataRecoveryInSeconds property is set.
        /// </summary>
        internal bool IsSetFailedDataRecoveryInSeconds() => this.FailedDataRecoveryInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property InMemoryAreaInGBs. 
        /// <para>
        /// The size of the in-memory area of the Autonomous Database, in GB.
        /// </para>
        /// </summary>
        public int? InMemoryAreaInGBs { get; set; }

        /// <summary>
        /// Checks to see if the InMemoryAreaInGBs property is set.
        /// </summary>
        internal bool IsSetInMemoryAreaInGBs() => this.InMemoryAreaInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property IsAutoScalingEnabled. 
        /// <para>
        /// Indicates whether automatic scaling of the compute resources is enabled for the Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public bool? IsAutoScalingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsAutoScalingEnabled property is set.
        /// </summary>
        internal bool IsSetIsAutoScalingEnabled() => this.IsAutoScalingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsAutoScalingForStorageEnabled. 
        /// <para>
        /// Indicates whether automatic scaling of the storage is enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public bool? IsAutoScalingForStorageEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsAutoScalingForStorageEnabled property is set.
        /// </summary>
        internal bool IsSetIsAutoScalingForStorageEnabled() => this.IsAutoScalingForStorageEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsBackupRetentionLocked. 
        /// <para>
        /// Indicates whether the backup retention period of the Autonomous Database is locked.
        /// </para>
        /// </summary>
        public bool? IsBackupRetentionLocked { get; set; }

        /// <summary>
        /// Checks to see if the IsBackupRetentionLocked property is set.
        /// </summary>
        internal bool IsSetIsBackupRetentionLocked() => this.IsBackupRetentionLocked.HasValue;

        /// <summary>
        /// Gets and sets the property IsLocalDataGuardEnabled. 
        /// <para>
        /// Indicates whether local Oracle Data Guard is enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public bool? IsLocalDataGuardEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsLocalDataGuardEnabled property is set.
        /// </summary>
        internal bool IsSetIsLocalDataGuardEnabled() => this.IsLocalDataGuardEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsMtlsConnectionRequired. 
        /// <para>
        /// Indicates whether mutual TLS (mTLS) authentication is required to connect to the Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public bool? IsMtlsConnectionRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsMtlsConnectionRequired property is set.
        /// </summary>
        internal bool IsSetIsMtlsConnectionRequired() => this.IsMtlsConnectionRequired.HasValue;

        /// <summary>
        /// Gets and sets the property IsReconnectCloneEnabled. 
        /// <para>
        /// Indicates whether reconnecting the refreshable clone to its source Autonomous Database
        /// is enabled.
        /// </para>
        /// </summary>
        public bool? IsReconnectCloneEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsReconnectCloneEnabled property is set.
        /// </summary>
        internal bool IsSetIsReconnectCloneEnabled() => this.IsReconnectCloneEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsRefreshableClone. 
        /// <para>
        /// Indicates whether the Autonomous Database is a refreshable clone.
        /// </para>
        /// </summary>
        public bool? IsRefreshableClone { get; set; }

        /// <summary>
        /// Checks to see if the IsRefreshableClone property is set.
        /// </summary>
        internal bool IsSetIsRefreshableClone() => this.IsRefreshableClone.HasValue;

        /// <summary>
        /// Gets and sets the property IsRemoteDataGuardEnabled. 
        /// <para>
        /// Indicates whether remote Oracle Data Guard is enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public bool? IsRemoteDataGuardEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsRemoteDataGuardEnabled property is set.
        /// </summary>
        internal bool IsSetIsRemoteDataGuardEnabled() => this.IsRemoteDataGuardEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model that applies to the Autonomous Database.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property LocalAdgAutoFailoverMaxDataLossLimit. 
        /// <para>
        /// The maximum data loss limit, in seconds, for automatic failover to the local Oracle
        /// Data Guard standby database.
        /// </para>
        /// </summary>
        public int? LocalAdgAutoFailoverMaxDataLossLimit { get; set; }

        /// <summary>
        /// Checks to see if the LocalAdgAutoFailoverMaxDataLossLimit property is set.
        /// </summary>
        internal bool IsSetLocalAdgAutoFailoverMaxDataLossLimit() => this.LocalAdgAutoFailoverMaxDataLossLimit.HasValue;

        /// <summary>
        /// Gets and sets the property LocalDisasterRecoveryType. 
        /// <para>
        /// The type of local disaster recovery configured for the Autonomous Database.
        /// </para>
        /// </summary>
        public DisasterRecoveryType LocalDisasterRecoveryType { get; set; }

        /// <summary>
        /// Checks to see if the LocalDisasterRecoveryType property is set.
        /// </summary>
        internal bool IsSetLocalDisasterRecoveryType() => this.LocalDisasterRecoveryType != null;

        /// <summary>
        /// Gets and sets the property LocalStandbyDb. 
        /// <para>
        /// The details of the local standby Autonomous Database in an Oracle Data Guard configuration.
        /// </para>
        /// </summary>
        public DatabaseStandbySummary LocalStandbyDb { get; set; }

        /// <summary>
        /// Checks to see if the LocalStandbyDb property is set.
        /// </summary>
        internal bool IsSetLocalStandbyDb() => this.LocalStandbyDb != null;

        /// <summary>
        /// Gets and sets the property LongTermBackupSchedule. 
        /// <para>
        /// The long-term backup schedule for the Autonomous Database.
        /// </para>
        /// </summary>
        public LongTermBackupSchedule LongTermBackupSchedule { get; set; }

        /// <summary>
        /// Checks to see if the LongTermBackupSchedule property is set.
        /// </summary>
        internal bool IsSetLongTermBackupSchedule() => this.LongTermBackupSchedule != null;

        /// <summary>
        /// Gets and sets the property MaintenanceTargetComponent. 
        /// <para>
        /// The component on the Autonomous Database that the current maintenance is being applied
        /// to.
        /// </para>
        /// </summary>
        public string MaintenanceTargetComponent { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTargetComponent property is set.
        /// </summary>
        internal bool IsSetMaintenanceTargetComponent() => this.MaintenanceTargetComponent != null;

        /// <summary>
        /// Gets and sets the property MemoryPerOracleComputeUnitInGBs. 
        /// <para>
        /// The amount of memory allocated per Oracle Compute Unit, in GB.
        /// </para>
        /// </summary>
        public int? MemoryPerOracleComputeUnitInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemoryPerOracleComputeUnitInGBs property is set.
        /// </summary>
        internal bool IsSetMemoryPerOracleComputeUnitInGBs() => this.MemoryPerOracleComputeUnitInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property NcharacterSet. 
        /// <para>
        /// The national character set of the Autonomous Database.
        /// </para>
        /// </summary>
        public string NcharacterSet { get; set; }

        /// <summary>
        /// Checks to see if the NcharacterSet property is set.
        /// </summary>
        internal bool IsSetNcharacterSet() => this.NcharacterSet != null;

        /// <summary>
        /// Gets and sets the property NetServicesArchitecture. 
        /// <para>
        /// The Oracle Net Services architecture of the Autonomous Database, either dedicated
        /// or shared.
        /// </para>
        /// </summary>
        public NetServicesArchitecture NetServicesArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the NetServicesArchitecture property is set.
        /// </summary>
        internal bool IsSetNetServicesArchitecture() => this.NetServicesArchitecture != null;

        /// <summary>
        /// Gets and sets the property NextLongTermBackupTimeStamp. 
        /// <para>
        /// The date and time of the next scheduled long-term backup of the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? NextLongTermBackupTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the NextLongTermBackupTimeStamp property is set.
        /// </summary>
        internal bool IsSetNextLongTermBackupTimeStamp() => this.NextLongTermBackupTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the Oracle Cloud Infrastructure (OCI) resource anchor associated with
        /// the Autonomous Database.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property OciUrl. 
        /// <para>
        /// The URL for accessing the OCI console page for the Autonomous Database.
        /// </para>
        /// </summary>
        public string OciUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciUrl property is set.
        /// </summary>
        internal bool IsSetOciUrl() => this.OciUrl != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous Database.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network associated with the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string OdbNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkArn property is set.
        /// </summary>
        internal bool IsSetOdbNetworkArn() => this.OdbNetworkArn != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network associated with the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

        /// <summary>
        /// Gets and sets the property OpenMode. 
        /// <para>
        /// The mode in which the Autonomous Database is open, either read-only or read/write.
        /// </para>
        /// </summary>
        public OpenMode OpenMode { get; set; }

        /// <summary>
        /// Checks to see if the OpenMode property is set.
        /// </summary>
        internal bool IsSetOpenMode() => this.OpenMode != null;

        /// <summary>
        /// Gets and sets the property OperationsInsightsStatus. 
        /// <para>
        /// The status of Oracle Operations Insights for the Autonomous Database.
        /// </para>
        /// </summary>
        public OperationsInsightsStatus OperationsInsightsStatus { get; set; }

        /// <summary>
        /// Checks to see if the OperationsInsightsStatus property is set.
        /// </summary>
        internal bool IsSetOperationsInsightsStatus() => this.OperationsInsightsStatus != null;

        /// <summary>
        /// Gets and sets the property PeerDbIds. 
        /// <para>
        /// The list of unique identifiers of the peer Autonomous Databases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> PeerDbIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeerDbIds property is set.
        /// </summary>
        internal bool IsSetPeerDbIds() => this.PeerDbIds != null && (this.PeerDbIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the current operation on the Autonomous Database, as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property PermissionLevel. 
        /// <para>
        /// The permission level of the Autonomous Database.
        /// </para>
        /// </summary>
        public PermissionLevel PermissionLevel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionLevel property is set.
        /// </summary>
        internal bool IsSetPermissionLevel() => this.PermissionLevel != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The private endpoint for the Autonomous Database.
        /// </para>
        /// </summary>
        public string PrivateEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpoint property is set.
        /// </summary>
        internal bool IsSetPrivateEndpoint() => this.PrivateEndpoint != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpointIp. 
        /// <para>
        /// The private endpoint IP address for the Autonomous Database.
        /// </para>
        /// </summary>
        public string PrivateEndpointIp { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpointIp property is set.
        /// </summary>
        internal bool IsSetPrivateEndpointIp() => this.PrivateEndpointIp != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpointLabel. 
        /// <para>
        /// The private endpoint label for the Autonomous Database.
        /// </para>
        /// </summary>
        public string PrivateEndpointLabel { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpointLabel property is set.
        /// </summary>
        internal bool IsSetPrivateEndpointLabel() => this.PrivateEndpointLabel != null;

        /// <summary>
        /// Gets and sets the property ProvisionableCpus. 
        /// <para>
        /// The list of CPU core counts that you can provision for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> ProvisionableCpus { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the ProvisionableCpus property is set.
        /// </summary>
        internal bool IsSetProvisionableCpus() => this.ProvisionableCpus != null && (this.ProvisionableCpus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RefreshableMode. 
        /// <para>
        /// The refresh mode of the refreshable clone Autonomous Database.
        /// </para>
        /// </summary>
        public RefreshableMode RefreshableMode { get; set; }

        /// <summary>
        /// Checks to see if the RefreshableMode property is set.
        /// </summary>
        internal bool IsSetRefreshableMode() => this.RefreshableMode != null;

        /// <summary>
        /// Gets and sets the property RefreshableStatus. 
        /// <para>
        /// The refresh status of the refreshable clone Autonomous Database.
        /// </para>
        /// </summary>
        public RefreshableStatus RefreshableStatus { get; set; }

        /// <summary>
        /// Checks to see if the RefreshableStatus property is set.
        /// </summary>
        internal bool IsSetRefreshableStatus() => this.RefreshableStatus != null;

        /// <summary>
        /// Gets and sets the property RemoteDisasterRecoveryConfiguration. 
        /// <para>
        /// The configuration of the remote disaster recovery for the Autonomous Database.
        /// </para>
        /// </summary>
        public DisasterRecoveryConfiguration RemoteDisasterRecoveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDisasterRecoveryConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoteDisasterRecoveryConfiguration() => this.RemoteDisasterRecoveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourcePoolLeaderId. 
        /// <para>
        /// The unique identifier of the resource pool leader Autonomous Database.
        /// </para>
        /// </summary>
        public string ResourcePoolLeaderId { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePoolLeaderId property is set.
        /// </summary>
        internal bool IsSetResourcePoolLeaderId() => this.ResourcePoolLeaderId != null;

        /// <summary>
        /// Gets and sets the property ResourcePoolSummary. 
        /// <para>
        /// The configuration of the resource pool for the Autonomous Database.
        /// </para>
        /// </summary>
        public ResourcePoolSummary ResourcePoolSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePoolSummary property is set.
        /// </summary>
        internal bool IsSetResourcePoolSummary() => this.ResourcePoolSummary != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Oracle Data Guard role of the Autonomous Database.
        /// </para>
        /// </summary>
        public DataGuardRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property ScheduledOperations. 
        /// <para>
        /// The list of scheduled start and stop times for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledOperationDetails> ScheduledOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<ScheduledOperationDetails>() : null;

        /// <summary>
        /// Checks to see if the ScheduledOperations property is set.
        /// </summary>
        internal bool IsSetScheduledOperations() => this.ScheduledOperations != null && (this.ScheduledOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceConsoleUrl. 
        /// <para>
        /// The URL for accessing the Oracle service console for the Autonomous Database.
        /// </para>
        /// </summary>
        public string ServiceConsoleUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServiceConsoleUrl property is set.
        /// </summary>
        internal bool IsSetServiceConsoleUrl() => this.ServiceConsoleUrl != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique identifier of the source from which the Autonomous Database was created.
        /// </para>
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property SqlWebDeveloperUrl. 
        /// <para>
        /// The URL for accessing Oracle SQL Developer Web for the Autonomous Database.
        /// </para>
        /// </summary>
        public string SqlWebDeveloperUrl { get; set; }

        /// <summary>
        /// Checks to see if the SqlWebDeveloperUrl property is set.
        /// </summary>
        internal bool IsSetSqlWebDeveloperUrl() => this.SqlWebDeveloperUrl != null;

        /// <summary>
        /// Gets and sets the property StandbyAllowlistedIps. 
        /// <para>
        /// The list of IP addresses that are allowed to access the standby Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> StandbyAllowlistedIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StandbyAllowlistedIps property is set.
        /// </summary>
        internal bool IsSetStandbyAllowlistedIps() => this.StandbyAllowlistedIps != null && (this.StandbyAllowlistedIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StandbyAllowlistedIpsSource. 
        /// <para>
        /// The source of the allowlisted IP addresses for the standby Autonomous Database.
        /// </para>
        /// </summary>
        public StandbyAllowlistedIpsSource StandbyAllowlistedIpsSource { get; set; }

        /// <summary>
        /// Checks to see if the StandbyAllowlistedIpsSource property is set.
        /// </summary>
        internal bool IsSetStandbyAllowlistedIpsSource() => this.StandbyAllowlistedIpsSource != null;

        /// <summary>
        /// Gets and sets the property StandbyDb. 
        /// <para>
        /// The details of the standby Autonomous Database in a cross-Region Oracle Data Guard
        /// configuration.
        /// </para>
        /// </summary>
        public DatabaseStandbySummary StandbyDb { get; set; }

        /// <summary>
        /// Checks to see if the StandbyDb property is set.
        /// </summary>
        internal bool IsSetStandbyDb() => this.StandbyDb != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the Autonomous Database, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeDataGuardRoleChanged. 
        /// <para>
        /// The date and time when the Oracle Data Guard role of the Autonomous Database last
        /// changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDataGuardRoleChanged { get; set; }

        /// <summary>
        /// Checks to see if the TimeDataGuardRoleChanged property is set.
        /// </summary>
        internal bool IsSetTimeDataGuardRoleChanged() => this.TimeDataGuardRoleChanged.HasValue;

        /// <summary>
        /// Gets and sets the property TimeDeletionOfFreeAutonomousDatabase. 
        /// <para>
        /// The date and time when the inactive Always Free Autonomous Database is scheduled to
        /// be automatically deleted.
        /// </para>
        /// </summary>
        public DateTime? TimeDeletionOfFreeAutonomousDatabase { get; set; }

        /// <summary>
        /// Checks to see if the TimeDeletionOfFreeAutonomousDatabase property is set.
        /// </summary>
        internal bool IsSetTimeDeletionOfFreeAutonomousDatabase() => this.TimeDeletionOfFreeAutonomousDatabase.HasValue;

        /// <summary>
        /// Gets and sets the property TimeDisasterRecoveryRoleChanged. 
        /// <para>
        /// The date and time when the disaster recovery role of the Autonomous Database last
        /// changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDisasterRecoveryRoleChanged { get; set; }

        /// <summary>
        /// Checks to see if the TimeDisasterRecoveryRoleChanged property is set.
        /// </summary>
        internal bool IsSetTimeDisasterRecoveryRoleChanged() => this.TimeDisasterRecoveryRoleChanged.HasValue;

        /// <summary>
        /// Gets and sets the property TimeLocalDataGuardEnabled. 
        /// <para>
        /// The date and time when local Oracle Data Guard was enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeLocalDataGuardEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TimeLocalDataGuardEnabled property is set.
        /// </summary>
        internal bool IsSetTimeLocalDataGuardEnabled() => this.TimeLocalDataGuardEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TimeMaintenanceBegin. 
        /// <para>
        /// The date and time when the next maintenance of the Autonomous Database begins.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceBegin { get; set; }

        /// <summary>
        /// Checks to see if the TimeMaintenanceBegin property is set.
        /// </summary>
        internal bool IsSetTimeMaintenanceBegin() => this.TimeMaintenanceBegin.HasValue;

        /// <summary>
        /// Gets and sets the property TimeMaintenanceEnd. 
        /// <para>
        /// The date and time when the next maintenance of the Autonomous Database ends.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceEnd { get; set; }

        /// <summary>
        /// Checks to see if the TimeMaintenanceEnd property is set.
        /// </summary>
        internal bool IsSetTimeMaintenanceEnd() => this.TimeMaintenanceEnd.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfAutoRefreshStart. 
        /// <para>
        /// The date and time at which the automatic refresh of the refreshable clone Autonomous
        /// Database starts.
        /// </para>
        /// </summary>
        public DateTime? TimeOfAutoRefreshStart { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfAutoRefreshStart property is set.
        /// </summary>
        internal bool IsSetTimeOfAutoRefreshStart() => this.TimeOfAutoRefreshStart.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfLastBackup. 
        /// <para>
        /// The date and time of the last backup of the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastBackup { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfLastBackup property is set.
        /// </summary>
        internal bool IsSetTimeOfLastBackup() => this.TimeOfLastBackup.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfLastFailover. 
        /// <para>
        /// The date and time of the last failover operation for the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastFailover { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfLastFailover property is set.
        /// </summary>
        internal bool IsSetTimeOfLastFailover() => this.TimeOfLastFailover.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfLastRefresh. 
        /// <para>
        /// The date and time of the last refresh of the refreshable clone Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastRefresh { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfLastRefresh property is set.
        /// </summary>
        internal bool IsSetTimeOfLastRefresh() => this.TimeOfLastRefresh.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfLastRefreshPoint. 
        /// <para>
        /// The date and time as of which the data in the refreshable clone Autonomous Database
        /// is current.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastRefreshPoint { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfLastRefreshPoint property is set.
        /// </summary>
        internal bool IsSetTimeOfLastRefreshPoint() => this.TimeOfLastRefreshPoint.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfLastSwitchover. 
        /// <para>
        /// The date and time of the last switchover operation for the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastSwitchover { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfLastSwitchover property is set.
        /// </summary>
        internal bool IsSetTimeOfLastSwitchover() => this.TimeOfLastSwitchover.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfNextRefresh. 
        /// <para>
        /// The date and time of the next scheduled refresh of the refreshable clone Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfNextRefresh { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfNextRefresh property is set.
        /// </summary>
        internal bool IsSetTimeOfNextRefresh() => this.TimeOfNextRefresh.HasValue;

        /// <summary>
        /// Gets and sets the property TimeReclamationOfFreeAutonomousDatabase. 
        /// <para>
        /// The date and time when the Always Free Autonomous Database is scheduled to be stopped
        /// because of inactivity.
        /// </para>
        /// </summary>
        public DateTime? TimeReclamationOfFreeAutonomousDatabase { get; set; }

        /// <summary>
        /// Checks to see if the TimeReclamationOfFreeAutonomousDatabase property is set.
        /// </summary>
        internal bool IsSetTimeReclamationOfFreeAutonomousDatabase() => this.TimeReclamationOfFreeAutonomousDatabase.HasValue;

        /// <summary>
        /// Gets and sets the property TimeUndeleted. 
        /// <para>
        /// The date and time when the Autonomous Database was restored after deletion.
        /// </para>
        /// </summary>
        public DateTime? TimeUndeleted { get; set; }

        /// <summary>
        /// Checks to see if the TimeUndeleted property is set.
        /// </summary>
        internal bool IsSetTimeUndeleted() => this.TimeUndeleted.HasValue;

        /// <summary>
        /// Gets and sets the property TimeUntilReconnectCloneEnabled. 
        /// <para>
        /// The date and time until which reconnecting the refreshable clone to its source Autonomous
        /// Database is allowed.
        /// </para>
        /// </summary>
        public DateTime? TimeUntilReconnectCloneEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TimeUntilReconnectCloneEnabled property is set.
        /// </summary>
        internal bool IsSetTimeUntilReconnectCloneEnabled() => this.TimeUntilReconnectCloneEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TotalBackupStorageSizeInGBs. 
        /// <para>
        /// The total amount of backup storage used by the Autonomous Database, in GB.
        /// </para>
        /// </summary>
        public double? TotalBackupStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalBackupStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalBackupStorageSizeInGBs() => this.TotalBackupStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property UsedDataStorageSizeInGBs. 
        /// <para>
        /// The amount of data storage currently in use by the Autonomous Database, in GB.
        /// </para>
        /// </summary>
        public int? UsedDataStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the UsedDataStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetUsedDataStorageSizeInGBs() => this.UsedDataStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property UsedDataStorageSizeInTBs. 
        /// <para>
        /// The amount of data storage currently in use by the Autonomous Database, in TB.
        /// </para>
        /// </summary>
        public double? UsedDataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the UsedDataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetUsedDataStorageSizeInTBs() => this.UsedDataStorageSizeInTBs.HasValue;
    }
}
