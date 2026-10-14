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
    /// Container for the parameters to the CreateAutonomousDatabase operation. Creates a
    /// new Autonomous Database.
    /// </summary>
    public partial class CreateAutonomousDatabaseRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AdminPassword. 
        /// <para>
        /// The password for the <c>ADMIN</c> user of the Autonomous Database.
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
        /// Gets and sets the property CharacterSet. 
        /// <para>
        /// The character set to use for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CharacterSet { get; set; }

        /// <summary>
        /// Checks to see if the CharacterSet property is set.
        /// </summary>
        internal bool IsSetCharacterSet() => this.CharacterSet != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-provided token to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity, in number of Elastic CPUs (ECPUs) or Oracle CPUs (OCPUs), to
        /// assign to the Autonomous Database.
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
        /// The list of customer contacts to receive operational notifications from Oracle Cloud
        /// Infrastructure (OCI) for the Autonomous Database.
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
        /// The name of the Autonomous Database. The name must begin with an alphabetic character
        /// and can contain a maximum of 30 alphanumeric characters. Special characters are not
        /// permitted. The name must be unique in the Amazon Web Services account.
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
        /// The user-friendly name for the Autonomous Database. The name does not have to be unique.
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
        /// Gets and sets the property NcharacterSet. 
        /// <para>
        /// The national character set to use for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NcharacterSet { get; set; }

        /// <summary>
        /// Checks to see if the NcharacterSet property is set.
        /// </summary>
        internal bool IsSetNcharacterSet() => this.NcharacterSet != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to be used for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

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
        /// Gets and sets the property Source. 
        /// <para>
        /// The source from which to create the Autonomous Database, such as a clone, backup,
        /// or cross-Region copy.
        /// </para>
        /// </summary>
        public SourceType Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The configuration details for the source used to create the Autonomous Database.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the Autonomous Database. Each tag is a key-value
        /// pair with no predefined name, type, or namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransportableTablespace. 
        /// <para>
        /// The transportable tablespace configuration to use when creating the Autonomous Database.
        /// </para>
        /// </summary>
        public TransportableTablespace TransportableTablespace { get; set; }

        /// <summary>
        /// Checks to see if the TransportableTablespace property is set.
        /// </summary>
        internal bool IsSetTransportableTablespace() => this.TransportableTablespace != null;
    }
}
