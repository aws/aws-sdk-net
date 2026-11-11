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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the <c>ModifyDBInstance</c> operation
    /// and contains changes that will be applied during the next maintenance window.
    /// </summary>
    public partial class PendingModifiedValues
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public PendingModifiedValues() { }

        /// <summary>
        /// Gets and sets the property AdditionalStorageVolumes. 
        /// <para>
        /// The additional storage volume modifications that are pending for the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalStorageVolume> AdditionalStorageVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalStorageVolume>() : null;

        /// <summary>
        /// Checks to see if the AdditionalStorageVolumes property is set.
        /// </summary>
        internal bool IsSetAdditionalStorageVolumes() => this.AdditionalStorageVolumes != null && (this.AdditionalStorageVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage size for the DB instance specified in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AutomationMode. 
        /// <para>
        /// The automation mode of the RDS Custom DB instance: <c>full</c> or <c>all-paused</c>.
        /// If <c>full</c>, the DB instance automates monitoring and instance recovery. If <c>all-paused</c>,
        /// the instance pauses automation for the duration set by <c>--resume-full-automation-mode-minutes</c>.
        /// </para>
        /// </summary>
        public AutomationMode AutomationMode { get; set; }

        /// <summary>
        /// Checks to see if the AutomationMode property is set.
        /// </summary>
        internal bool IsSetAutomationMode() => this.AutomationMode != null;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained.
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
        /// The identifier of the CA certificate for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier of the DB capacity reservation that the DB instance uses after a pending
        /// modification completes. Amazon RDS returns this value when a <c>ModifyDBInstance</c>
        /// request changes the DB capacity reservation, and the change hasn't been applied yet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBCapacityReservationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationIdentifier property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationIdentifier() => this.DBCapacityReservationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The name of the compute and memory capacity class for the DB instance.
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
        /// The database identifier for the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The DB subnet group for the DB instance.
        /// </para>
        /// </summary>
        public string DBSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupName() => this.DBSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.&gt;
        /// </para>
        /// </summary>
        public bool? DedicatedLogVolume { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedLogVolume property is set.
        /// </summary>
        internal bool IsSetDedicatedLogVolume() => this.DedicatedLogVolume.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine of the DB instance.
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
        /// The database engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// Indicates whether mapping of Amazon Web Services Identity and Access Management (IAM)
        /// accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IAMDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIAMDatabaseAuthenticationEnabled() => this.IAMDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The Provisioned IOPS value for the DB instance.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>license-included</c> | <c>bring-your-own-license</c> | <c>general-public-license</c>
        /// | <c>bring-your-own-media</c> 
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The master credentials for the DB instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Indicates whether the Single-AZ DB instance will change to a Multi-AZ deployment.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Indicates whether the DB instance will change to the multi-tenant configuration (TRUE)
        /// or the single-tenant configuration (FALSE). 
        /// </para>
        /// </summary>
        public bool? MultiTenant { get; set; }

        /// <summary>
        /// Checks to see if the MultiTenant property is set.
        /// </summary>
        internal bool IsSetMultiTenant() => this.MultiTenant.HasValue;

        /// <summary>
        /// Gets and sets the property PendingCloudwatchLogsExports.
        /// </summary>
        public PendingCloudwatchLogsExports PendingCloudwatchLogsExports { get; set; }

        /// <summary>
        /// Checks to see if the PendingCloudwatchLogsExports property is set.
        /// </summary>
        internal bool IsSetPendingCloudwatchLogsExports() => this.PendingCloudwatchLogsExports != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port for the DB instance.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

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
        public List<ProcessorFeature> ProcessorFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;

        /// <summary>
        /// Checks to see if the ProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetProcessorFeatures() => this.ProcessorFeatures != null && (this.ProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResumeFullAutomationModeTime. 
        /// <para>
        /// The number of minutes to pause the automation. When the time period ends, RDS Custom
        /// resumes full automation. The minimum value is 60 (default). The maximum value is 1,440.
        /// </para>
        /// </summary>
        public DateTime? ResumeFullAutomationModeTime { get; set; }

        /// <summary>
        /// Checks to see if the ResumeFullAutomationModeTime property is set.
        /// </summary>
        internal bool IsSetResumeFullAutomationModeTime() => this.ResumeFullAutomationModeTime.HasValue;

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput of the DB instance.
        /// </para>
        /// </summary>
        public int? StorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the StorageThroughput property is set.
        /// </summary>
        internal bool IsSetStorageThroughput() => this.StorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type of the DB instance.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
