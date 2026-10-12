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
    /// Container for the parameters to the CreateCloudAutonomousVmCluster operation. Creates
    /// a new Autonomous VM cluster in the specified Exadata infrastructure.
    /// </summary>
    public partial class CreateCloudAutonomousVmClusterRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The data disk group size to be allocated for Autonomous Databases, in terabytes (TB).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? AutonomousDataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetAutonomousDataStorageSizeInTBs() => this.AutonomousDataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-provided token to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Exadata infrastructure where the VM cluster will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCountPerNode. 
        /// <para>
        /// The number of CPU cores to be enabled per VM cluster node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? CpuCoreCountPerNode { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCountPerNode property is set.
        /// </summary>
        internal bool IsSetCpuCoreCountPerNode() => this.CpuCoreCountPerNode.HasValue;

        /// <summary>
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The list of database servers to be used for the Autonomous VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> DbServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DbServers property is set.
        /// </summary>
        internal bool IsSetDbServers() => this.DbServers != null && (this.DbServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-provided description of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name for the Autonomous VM cluster. The name does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IsMtlsEnabledVmCluster. 
        /// <para>
        /// Specifies whether to enable mutual TLS (mTLS) authentication for the Autonomous VM
        /// cluster.
        /// </para>
        /// </summary>
        public bool? IsMtlsEnabledVmCluster { get; set; }

        /// <summary>
        /// Checks to see if the IsMtlsEnabledVmCluster property is set.
        /// </summary>
        internal bool IsSetIsMtlsEnabledVmCluster() => this.IsMtlsEnabledVmCluster.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

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
        /// Gets and sets the property MemoryPerOracleComputeUnitInGBs. 
        /// <para>
        /// The amount of memory to be allocated per OCPU, in GB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MemoryPerOracleComputeUnitInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemoryPerOracleComputeUnitInGBs property is set.
        /// </summary>
        internal bool IsSetMemoryPerOracleComputeUnitInGBs() => this.MemoryPerOracleComputeUnitInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to be used for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

        /// <summary>
        /// Gets and sets the property ScanListenerPortNonTls. 
        /// <para>
        /// The SCAN listener port for non-TLS (TCP) protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 8999)]
        public int? ScanListenerPortNonTls { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortNonTls property is set.
        /// </summary>
        internal bool IsSetScanListenerPortNonTls() => this.ScanListenerPortNonTls.HasValue;

        /// <summary>
        /// Gets and sets the property ScanListenerPortTls. 
        /// <para>
        /// The SCAN listener port for TLS (TCP) protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 8999)]
        public int? ScanListenerPortTls { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortTls property is set.
        /// </summary>
        internal bool IsSetScanListenerPortTls() => this.ScanListenerPortTls.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Free-form tags for this resource. Each tag is a key-value pair with no predefined
        /// name, type, or namespace.
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
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone to use for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property TotalContainerDatabases. 
        /// <para>
        /// The total number of Autonomous CDBs that you can create in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the TotalContainerDatabases property is set.
        /// </summary>
        internal bool IsSetTotalContainerDatabases() => this.TotalContainerDatabases.HasValue;
    }
}
