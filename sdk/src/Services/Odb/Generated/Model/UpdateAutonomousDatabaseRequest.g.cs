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
    /// Container for the parameters to the UpdateAutonomousDatabase operation. Updates the
    /// properties of an Autonomous Database.
    /// </summary>
    public partial class UpdateAutonomousDatabaseRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AdminPassword. 
        /// <para>
        /// The new password for the <c>ADMIN</c> user of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 12, Max = 30)]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Checks to see if the AdminPassword property is set.
        /// </summary>
        internal bool IsSetAdminPassword() => this.AdminPassword != null;

        /// <summary>
        /// Gets and sets the property AdminPasswordSource. 
        /// <para>
        /// The source of the admin password for the Autonomous Database. When set to <c>CUSTOMER_MANAGED_AWS_SECRET</c>,
        /// the admin password is retrieved from an Amazon Web Services Secrets Manager secret.
        /// </para>
        /// </summary>
        public AdminPasswordSource AdminPasswordSource { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSource property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSource() => this.AdminPasswordSource != null;

        /// <summary>
        /// Gets and sets the property AdminPasswordSourceConfiguration. 
        /// <para>
        /// The configuration of the admin password source for the Autonomous Database.
        /// </para>
        /// </summary>
        public AdminPasswordSourceConfigurationInput AdminPasswordSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSourceConfiguration() => this.AdminPasswordSourceConfiguration != null;

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
        /// Gets and sets the property AutoRefreshFrequencyInSeconds. 
        /// <para>
        /// The frequency, in seconds, at which the refreshable clone Autonomous Database is automatically
        /// refreshed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3600, Max = 604800)]
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
        [AWSProperty(Min = 0, Max = 604800)]
        public int? AutoRefreshPointLagInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AutoRefreshPointLagInSeconds property is set.
        /// </summary>
        internal bool IsSetAutoRefreshPointLagInSeconds() => this.AutoRefreshPointLagInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
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
        /// Gets and sets the property BackupRetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for automatic backups of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
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
        [AWSProperty(Min = 2)]
        public double? ByolComputeCountLimit { get; set; }

        /// <summary>
        /// Checks to see if the ByolComputeCountLimit property is set.
        /// </summary>
        internal bool IsSetByolComputeCountLimit() => this.ByolComputeCountLimit.HasValue;

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity, in number of ECPUs or OCPUs, to assign to the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 512)]
        public double? ComputeCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputeCount property is set.
        /// </summary>
        internal bool IsSetComputeCount() => this.ComputeCount.HasValue;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores to allocate to the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerContactsToSendToOCI. 
        /// <para>
        /// The list of customer contacts to receive operational notifications from OCI for the
        /// Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContactsToSendToOCI { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;

        /// <summary>
        /// Checks to see if the CustomerContactsToSendToOCI property is set.
        /// </summary>
        internal bool IsSetCustomerContactsToSendToOCI() => this.CustomerContactsToSendToOCI != null && (this.CustomerContactsToSendToOCI.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataStorageSizeInGBs. 
        /// <para>
        /// The size, in gigabytes (GB), of the data volume to allocate for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 393216)]
        public int? DataStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInGBs() => this.DataStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size, in terabytes (TB), of the data volume to allocate for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 384)]
        public int? DataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInTBs() => this.DataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseEdition. 
        /// <para>
        /// The Oracle Database edition to apply to the Autonomous Database.
        /// </para>
        /// </summary>
        public DatabaseEdition DatabaseEdition { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseEdition property is set.
        /// </summary>
        internal bool IsSetDatabaseEdition() => this.DatabaseEdition != null;

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The new name of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string DbName { get; set; }

        /// <summary>
        /// Checks to see if the DbName property is set.
        /// </summary>
        internal bool IsSetDbName() => this.DbName != null;

        /// <summary>
        /// Gets and sets the property DbToolsDetails. 
        /// <para>
        /// The list of database management tools to enable for the Autonomous Database.
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
        /// The Oracle Database software version to use for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        /// The new user-friendly name for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyConfiguration. 
        /// <para>
        /// The configuration of the encryption key to use for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionKeyConfigurationInput EncryptionKeyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyConfiguration() => this.EncryptionKeyConfiguration != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyProvider. 
        /// <para>
        /// The provider of the encryption key to use for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionKeyProviderInput EncryptionKeyProvider { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyProvider property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyProvider() => this.EncryptionKeyProvider != null;

        /// <summary>
        /// Gets and sets the property IsAutoScalingEnabled. 
        /// <para>
        /// Specifies whether to enable automatic scaling of the compute resources for the Autonomous
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
        /// Specifies whether to enable automatic scaling of the storage for the Autonomous Database.
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
        /// Specifies whether to lock the backup retention period of the Autonomous Database to
        /// prevent it from being shortened.
        /// </para>
        /// </summary>
        public bool? IsBackupRetentionLocked { get; set; }

        /// <summary>
        /// Checks to see if the IsBackupRetentionLocked property is set.
        /// </summary>
        internal bool IsSetIsBackupRetentionLocked() => this.IsBackupRetentionLocked.HasValue;

        /// <summary>
        /// Gets and sets the property IsDisconnectPeer. 
        /// <para>
        /// Specifies whether to disconnect the Autonomous Database from its peer database.
        /// </para>
        /// </summary>
        public bool? IsDisconnectPeer { get; set; }

        /// <summary>
        /// Checks to see if the IsDisconnectPeer property is set.
        /// </summary>
        internal bool IsSetIsDisconnectPeer() => this.IsDisconnectPeer.HasValue;

        /// <summary>
        /// Gets and sets the property IsLocalDataGuardEnabled. 
        /// <para>
        /// Specifies whether to enable local Oracle Data Guard for the Autonomous Database.
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
        /// Specifies whether mutual TLS (mTLS) authentication is required to connect to the Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public bool? IsMtlsConnectionRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsMtlsConnectionRequired property is set.
        /// </summary>
        internal bool IsSetIsMtlsConnectionRequired() => this.IsMtlsConnectionRequired.HasValue;

        /// <summary>
        /// Gets and sets the property IsRefreshableClone. 
        /// <para>
        /// Specifies whether the Autonomous Database is a refreshable clone.
        /// </para>
        /// </summary>
        public bool? IsRefreshableClone { get; set; }

        /// <summary>
        /// Checks to see if the IsRefreshableClone property is set.
        /// </summary>
        internal bool IsSetIsRefreshableClone() => this.IsRefreshableClone.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Autonomous Database.
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
        [AWSProperty(Min = 0, Max = 3600)]
        public int? LocalAdgAutoFailoverMaxDataLossLimit { get; set; }

        /// <summary>
        /// Checks to see if the LocalAdgAutoFailoverMaxDataLossLimit property is set.
        /// </summary>
        internal bool IsSetLocalAdgAutoFailoverMaxDataLossLimit() => this.LocalAdgAutoFailoverMaxDataLossLimit.HasValue;

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
        /// Gets and sets the property OpenMode. 
        /// <para>
        /// The mode in which to open the Autonomous Database, either read-only or read/write.
        /// </para>
        /// </summary>
        public OpenMode OpenMode { get; set; }

        /// <summary>
        /// Checks to see if the OpenMode property is set.
        /// </summary>
        internal bool IsSetOpenMode() => this.OpenMode != null;

        /// <summary>
        /// Gets and sets the property PeerDbId. 
        /// <para>
        /// The unique identifier of the peer Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string PeerDbId { get; set; }

        /// <summary>
        /// Checks to see if the PeerDbId property is set.
        /// </summary>
        internal bool IsSetPeerDbId() => this.PeerDbId != null;

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
        /// Gets and sets the property ResourcePoolLeaderId. 
        /// <para>
        /// The unique identifier of the resource pool leader Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
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
    }
}
