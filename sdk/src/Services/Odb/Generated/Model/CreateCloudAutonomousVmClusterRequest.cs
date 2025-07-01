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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
    /// Container for the parameters to the CreateCloudAutonomousVmCluster operation.
    /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
    /// </summary>
    public partial class CreateCloudAutonomousVmClusterRequest : AmazonOdbRequest
    {
        private double? _autonomousDataStorageSizeInTBs;
        private string _clientToken;
        private string _cloudExadataInfrastructureId;
        private int? _cpuCoreCountPerNode;
        private List<string> _dbServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _displayName;
        private bool? _isMtlsEnabledVmCluster;
        private LicenseModel _licenseModel;
        private MaintenanceWindow _maintenanceWindow;
        private int? _memoryPerOracleComputeUnitInGBs;
        private string _odbNetworkId;
        private int? _scanListenerPortNonTls;
        private int? _scanListenerPortTls;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _timeZone;
        private int? _totalContainerDatabases;

        /// <summary>
        /// Gets and sets the property AutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The data disk group size to be allocated for Autonomous Databases, in terabytes (TB).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? AutonomousDataStorageSizeInTBs
        {
            get { return this._autonomousDataStorageSizeInTBs; }
            set { this._autonomousDataStorageSizeInTBs = value; }
        }

        // Check to see if AutonomousDataStorageSizeInTBs property is set
        internal bool IsSetAutonomousDataStorageSizeInTBs()
        {
            return this._autonomousDataStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-provided token to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Exadata infrastructure where the VM cluster will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string CloudExadataInfrastructureId
        {
            get { return this._cloudExadataInfrastructureId; }
            set { this._cloudExadataInfrastructureId = value; }
        }

        // Check to see if CloudExadataInfrastructureId property is set
        internal bool IsSetCloudExadataInfrastructureId()
        {
            return this._cloudExadataInfrastructureId != null;
        }

        /// <summary>
        /// Gets and sets the property CpuCoreCountPerNode. 
        /// <para>
        /// The number of CPU cores to be enabled per VM cluster node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? CpuCoreCountPerNode
        {
            get { return this._cpuCoreCountPerNode; }
            set { this._cpuCoreCountPerNode = value; }
        }

        // Check to see if CpuCoreCountPerNode property is set
        internal bool IsSetCpuCoreCountPerNode()
        {
            return this._cpuCoreCountPerNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The list of database servers to be used for the Autonomous VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> DbServers
        {
            get { return this._dbServers; }
            set { this._dbServers = value; }
        }

        // Check to see if DbServers property is set
        internal bool IsSetDbServers()
        {
            return this._dbServers != null && (this._dbServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-provided description of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name for the Autonomous VM cluster. The name does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IsMtlsEnabledVmCluster. 
        /// <para>
        /// Specifies whether to enable mutual TLS (mTLS) authentication for the Autonomous VM
        /// cluster.
        /// </para>
        /// </summary>
        public bool? IsMtlsEnabledVmCluster
        {
            get { return this._isMtlsEnabledVmCluster; }
            set { this._isMtlsEnabledVmCluster = value; }
        }

        // Check to see if IsMtlsEnabledVmCluster property is set
        internal bool IsSetIsMtlsEnabledVmCluster()
        {
            return this._isMtlsEnabledVmCluster.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The scheduling details for the maintenance window. Patching and system updates take
        /// place during the maintenance window.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow
        {
            get { return this._maintenanceWindow; }
            set { this._maintenanceWindow = value; }
        }

        // Check to see if MaintenanceWindow property is set
        internal bool IsSetMaintenanceWindow()
        {
            return this._maintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryPerOracleComputeUnitInGBs. 
        /// <para>
        /// The amount of memory to be allocated per OCPU, in GB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? MemoryPerOracleComputeUnitInGBs
        {
            get { return this._memoryPerOracleComputeUnitInGBs; }
            set { this._memoryPerOracleComputeUnitInGBs = value; }
        }

        // Check to see if MemoryPerOracleComputeUnitInGBs property is set
        internal bool IsSetMemoryPerOracleComputeUnitInGBs()
        {
            return this._memoryPerOracleComputeUnitInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to be used for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbNetworkId
        {
            get { return this._odbNetworkId; }
            set { this._odbNetworkId = value; }
        }

        // Check to see if OdbNetworkId property is set
        internal bool IsSetOdbNetworkId()
        {
            return this._odbNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanListenerPortNonTls. 
        /// <para>
        /// The SCAN listener port for non-TLS (TCP) protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=8999)]
        public int? ScanListenerPortNonTls
        {
            get { return this._scanListenerPortNonTls; }
            set { this._scanListenerPortNonTls = value; }
        }

        // Check to see if ScanListenerPortNonTls property is set
        internal bool IsSetScanListenerPortNonTls()
        {
            return this._scanListenerPortNonTls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanListenerPortTls. 
        /// <para>
        /// The SCAN listener port for TLS (TCP) protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=8999)]
        public int? ScanListenerPortTls
        {
            get { return this._scanListenerPortTls; }
            set { this._scanListenerPortTls = value; }
        }

        // Check to see if ScanListenerPortTls property is set
        internal bool IsSetScanListenerPortTls()
        {
            return this._scanListenerPortTls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Free-form tags for this resource. Each tag is a key-value pair with no predefined
        /// name, type, or namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone to use for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

        /// <summary>
        /// Gets and sets the property TotalContainerDatabases. 
        /// <para>
        /// The total number of Autonomous CDBs that you can create in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? TotalContainerDatabases
        {
            get { return this._totalContainerDatabases; }
            set { this._totalContainerDatabases = value; }
        }

        // Check to see if TotalContainerDatabases property is set
        internal bool IsSetTotalContainerDatabases()
        {
            return this._totalContainerDatabases.HasValue; 
        }

    }
}