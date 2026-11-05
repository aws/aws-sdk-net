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
    /// Information about an Exadata infrastructure.
    /// </summary>
    public partial class CloudExadataInfrastructureSummary
    {
        /// <summary>
        /// Gets and sets the property ActivatedStorageCount. 
        /// <para>
        /// The number of storage servers requested for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? ActivatedStorageCount { get; set; }

        /// <summary>
        /// Checks to see if the ActivatedStorageCount property is set.
        /// </summary>
        internal bool IsSetActivatedStorageCount() => this.ActivatedStorageCount.HasValue;

        /// <summary>
        /// Gets and sets the property AdditionalStorageCount. 
        /// <para>
        /// The number of storage servers requested for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? AdditionalStorageCount { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalStorageCount property is set.
        /// </summary>
        internal bool IsSetAdditionalStorageCount() => this.AdditionalStorageCount.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located.
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
        /// The AZ ID of the AZ where the Exadata infrastructure is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailableStorageSizeInGBs. 
        /// <para>
        /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? AvailableStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableStorageSizeInGBs() => this.AvailableStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string CloudExadataInfrastructureArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureArn property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureArn() => this.CloudExadataInfrastructureArn != null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier for the Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The number of database servers for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? ComputeCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputeCount property is set.
        /// </summary>
        internal bool IsSetComputeCount() => this.ComputeCount.HasValue;

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The OCI model compute model used when you create or clone an instance: ECPU or OCPU.
        /// An ECPU is an abstracted measure of compute resources. ECPUs are based on the number
        /// of cores elastically allocated from a pool of compute and storage servers. An OCPU
        /// is a legacy physical measure of compute resources. OCPUs are based on the physical
        /// core of a processor with hyper-threading enabled. 
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel { get; set; }

        /// <summary>
        /// Checks to see if the ComputeModel property is set.
        /// </summary>
        internal bool IsSetComputeModel() => this.ComputeModel != null;

        /// <summary>
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The total number of CPU cores that are allocated to the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? CpuCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCount property is set.
        /// </summary>
        internal bool IsSetCpuCount() => this.CpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Exadata infrastructure was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerContactsToSendToOCI. 
        /// <para>
        /// The email addresses of contacts to receive notification from Oracle about maintenance
        /// updates for the Exadata infrastructure.
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
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size of the Exadata infrastructure's data disk group, in terabytes (TB).
        /// </para>
        /// </summary>
        public double? DataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInTBs() => this.DataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseServerType. 
        /// <para>
        /// The database server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        public string DatabaseServerType { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseServerType property is set.
        /// </summary>
        internal bool IsSetDatabaseServerType() => this.DatabaseServerType != null;

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The size of the Exadata infrastructure's local node storage, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbServerVersion. 
        /// <para>
        /// The software version of the database servers on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string DbServerVersion { get; set; }

        /// <summary>
        /// Checks to see if the DbServerVersion property is set.
        /// </summary>
        internal bool IsSetDbServerVersion() => this.DbServerVersion != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExascaleConfiguration. 
        /// <para>
        /// The Exascale storage configuration of the Exadata infrastructure. This value is present
        /// only when Exascale storage is configured on the infrastructure.
        /// </para>
        /// </summary>
        public ExascaleConfiguration ExascaleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExascaleConfiguration property is set.
        /// </summary>
        internal bool IsSetExascaleConfiguration() => this.ExascaleConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastMaintenanceRunId. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string LastMaintenanceRunId { get; set; }

        /// <summary>
        /// Checks to see if the LastMaintenanceRunId property is set.
        /// </summary>
        internal bool IsSetLastMaintenanceRunId() => this.LastMaintenanceRunId != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The scheduling details for the maintenance window. Patching and system updates take
        /// place during the maintenance window.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property MaxCpuCount. 
        /// <para>
        /// The total number of CPU cores available on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? MaxCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCpuCount property is set.
        /// </summary>
        internal bool IsSetMaxCpuCount() => this.MaxCpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDataStorageInTBs. 
        /// <para>
        /// The total amount of data disk group storage, in terabytes (TB), that's available on
        /// the Exadata infrastructure.
        /// </para>
        /// </summary>
        public double? MaxDataStorageInTBs { get; set; }

        /// <summary>
        /// Checks to see if the MaxDataStorageInTBs property is set.
        /// </summary>
        internal bool IsSetMaxDataStorageInTBs() => this.MaxDataStorageInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDbNodeStorageSizeInGBs. 
        /// <para>
        /// The total amount of local node storage, in gigabytes (GB), that's available on the
        /// Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? MaxDbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MaxDbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetMaxDbNodeStorageSizeInGBs() => this.MaxDbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxMemoryInGBs. 
        /// <para>
        /// The total amount of memory, in gigabytes (GB), that's available on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? MaxMemoryInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MaxMemoryInGBs property is set.
        /// </summary>
        internal bool IsSetMaxMemoryInGBs() => this.MaxMemoryInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GB), that's allocated on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MonthlyDbServerVersion. 
        /// <para>
        /// The monthly software version of the database servers (dom0) installed on the Exadata
        /// infrastructure.
        /// </para>
        /// </summary>
        public string MonthlyDbServerVersion { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyDbServerVersion property is set.
        /// </summary>
        internal bool IsSetMonthlyDbServerVersion() => this.MonthlyDbServerVersion != null;

        /// <summary>
        /// Gets and sets the property MonthlyStorageServerVersion. 
        /// <para>
        /// The monthly software version of the storage servers installed on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string MonthlyStorageServerVersion { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyStorageServerVersion property is set.
        /// </summary>
        internal bool IsSetMonthlyStorageServerVersion() => this.MonthlyStorageServerVersion != null;

        /// <summary>
        /// Gets and sets the property NextMaintenanceRunId. 
        /// <para>
        /// The OCID of the next maintenance run for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string NextMaintenanceRunId { get; set; }

        /// <summary>
        /// Checks to see if the NextMaintenanceRunId property is set.
        /// </summary>
        internal bool IsSetNextMaintenanceRunId() => this.NextMaintenanceRunId != null;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the Exadata infrastructure.
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
        /// The HTTPS link to the Exadata infrastructure in OCI.
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
        /// The OCID of the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the Exadata infrastructure,
        /// expressed as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The model name of the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Exadata infrastructure.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StorageCount. 
        /// <para>
        /// The number of storage servers that are activated for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? StorageCount { get; set; }

        /// <summary>
        /// Checks to see if the StorageCount property is set.
        /// </summary>
        internal bool IsSetStorageCount() => this.StorageCount.HasValue;

        /// <summary>
        /// Gets and sets the property StorageServerType. 
        /// <para>
        /// The storage server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        public string StorageServerType { get; set; }

        /// <summary>
        /// Checks to see if the StorageServerType property is set.
        /// </summary>
        internal bool IsSetStorageServerType() => this.StorageServerType != null;

        /// <summary>
        /// Gets and sets the property StorageServerVersion. 
        /// <para>
        /// The software version of the storage servers on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string StorageServerVersion { get; set; }

        /// <summary>
        /// Checks to see if the StorageServerVersion property is set.
        /// </summary>
        internal bool IsSetStorageServerVersion() => this.StorageServerVersion != null;

        /// <summary>
        /// Gets and sets the property TotalStorageSizeInGBs. 
        /// <para>
        /// The total amount of storage, in gigabytes (GB), on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? TotalStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalStorageSizeInGBs() => this.TotalStorageSizeInGBs.HasValue;
    }
}
