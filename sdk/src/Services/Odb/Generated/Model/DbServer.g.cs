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
    /// Information about a database server.
    /// </summary>
    public partial class DbServer
    {
        /// <summary>
        /// Gets and sets the property AutonomousVirtualMachineIds. 
        /// <para>
        /// The list of unique identifiers for the Autonomous VMs associated with this database
        /// server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> AutonomousVirtualMachineIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutonomousVirtualMachineIds property is set.
        /// </summary>
        internal bool IsSetAutonomousVirtualMachineIds() => this.AutonomousVirtualMachineIds != null && (this.AutonomousVirtualMachineIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutonomousVmClusterIds. 
        /// <para>
        /// The list of identifiers for the Autonomous VM clusters associated with this database
        /// server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> AutonomousVmClusterIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutonomousVmClusterIds property is set.
        /// </summary>
        internal bool IsSetAutonomousVmClusterIds() => this.AutonomousVmClusterIds != null && (this.AutonomousVmClusterIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The compute model of the database server (ECPU or OCPU).
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel { get; set; }

        /// <summary>
        /// Checks to see if the ComputeModel property is set.
        /// </summary>
        internal bool IsSetComputeModel() => this.ComputeModel != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores enabled on the database server.
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
        /// The date and time when the database server was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The allocated local node storage in GBs on the database server.
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbServerId. 
        /// <para>
        /// The unique identifier for the database server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string DbServerId { get; set; }

        /// <summary>
        /// Checks to see if the DbServerId property is set.
        /// </summary>
        internal bool IsSetDbServerId() => this.DbServerId != null;

        /// <summary>
        /// Gets and sets the property DbServerPatchingDetails. 
        /// <para>
        /// The scheduling details for the quarterly maintenance window. Patching and system updates
        /// take place during the maintenance window.
        /// </para>
        /// </summary>
        public DbServerPatchingDetails DbServerPatchingDetails { get; set; }

        /// <summary>
        /// Checks to see if the DbServerPatchingDetails property is set.
        /// </summary>
        internal bool IsSetDbServerPatchingDetails() => this.DbServerPatchingDetails != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the database server.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExadataInfrastructureId. 
        /// <para>
        /// The ID of the Exadata infrastructure the database server belongs to.
        /// </para>
        /// </summary>
        public string ExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the ExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetExadataInfrastructureId() => this.ExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property MaxCpuCount. 
        /// <para>
        /// The total number of CPU cores available.
        /// </para>
        /// </summary>
        public int? MaxCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCpuCount property is set.
        /// </summary>
        internal bool IsSetMaxCpuCount() => this.MaxCpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDbNodeStorageInGBs. 
        /// <para>
        /// The total local node storage available in GBs.
        /// </para>
        /// </summary>
        public int? MaxDbNodeStorageInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MaxDbNodeStorageInGBs property is set.
        /// </summary>
        internal bool IsSetMaxDbNodeStorageInGBs() => this.MaxDbNodeStorageInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxMemoryInGBs. 
        /// <para>
        /// The total memory available in GBs.
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
        /// The allocated memory in GBs on the database server.
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the database server.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the database server.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the database server. The shape determines the amount of CPU, storage,
        /// and memory resources available.
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
        /// The current status of the database server.
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
        /// Additional information about the current status of the database server.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property VmClusterIds. 
        /// <para>
        /// The OCID of the VM clusters that are associated with the database server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> VmClusterIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VmClusterIds property is set.
        /// </summary>
        internal bool IsSetVmClusterIds() => this.VmClusterIds != null && (this.VmClusterIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
