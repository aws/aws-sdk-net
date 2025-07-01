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
    /// Information about a database server.
    /// </summary>
    public partial class DbServer
    {
        private List<string> _autonomousVirtualMachineIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _autonomousVmClusterIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ComputeModel _computeModel;
        private int? _cpuCoreCount;
        private DateTime? _createdAt;
        private int? _dbNodeStorageSizeInGBs;
        private string _dbServerId;
        private DbServerPatchingDetails _dbServerPatchingDetails;
        private string _displayName;
        private string _exadataInfrastructureId;
        private int? _maxCpuCount;
        private int? _maxDbNodeStorageInGBs;
        private int? _maxMemoryInGBs;
        private int? _memorySizeInGBs;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _shape;
        private ResourceStatus _status;
        private string _statusReason;
        private List<string> _vmClusterIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutonomousVirtualMachineIds. 
        /// <para>
        /// The list of unique identifiers for the Autonomous VMs associated with this database
        /// server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> AutonomousVirtualMachineIds
        {
            get { return this._autonomousVirtualMachineIds; }
            set { this._autonomousVirtualMachineIds = value; }
        }

        // Check to see if AutonomousVirtualMachineIds property is set
        internal bool IsSetAutonomousVirtualMachineIds()
        {
            return this._autonomousVirtualMachineIds != null && (this._autonomousVirtualMachineIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutonomousVmClusterIds. 
        /// <para>
        /// The list of identifiers for the Autonomous VM clusters associated with this database
        /// server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> AutonomousVmClusterIds
        {
            get { return this._autonomousVmClusterIds; }
            set { this._autonomousVmClusterIds = value; }
        }

        // Check to see if AutonomousVmClusterIds property is set
        internal bool IsSetAutonomousVmClusterIds()
        {
            return this._autonomousVmClusterIds != null && (this._autonomousVmClusterIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The compute model of the database server (ECPU or OCPU).
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel
        {
            get { return this._computeModel; }
            set { this._computeModel = value; }
        }

        // Check to see if ComputeModel property is set
        internal bool IsSetComputeModel()
        {
            return this._computeModel != null;
        }

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores enabled on the database server.
        /// </para>
        /// </summary>
        public int? CpuCoreCount
        {
            get { return this._cpuCoreCount; }
            set { this._cpuCoreCount = value; }
        }

        // Check to see if CpuCoreCount property is set
        internal bool IsSetCpuCoreCount()
        {
            return this._cpuCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the database server was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The allocated local node storage in GBs on the database server.
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs
        {
            get { return this._dbNodeStorageSizeInGBs; }
            set { this._dbNodeStorageSizeInGBs = value; }
        }

        // Check to see if DbNodeStorageSizeInGBs property is set
        internal bool IsSetDbNodeStorageSizeInGBs()
        {
            return this._dbNodeStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbServerId. 
        /// <para>
        /// The unique identifier for the database server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string DbServerId
        {
            get { return this._dbServerId; }
            set { this._dbServerId = value; }
        }

        // Check to see if DbServerId property is set
        internal bool IsSetDbServerId()
        {
            return this._dbServerId != null;
        }

        /// <summary>
        /// Gets and sets the property DbServerPatchingDetails. 
        /// <para>
        /// The scheduling details for the quarterly maintenance window. Patching and system updates
        /// take place during the maintenance window.
        /// </para>
        /// </summary>
        public DbServerPatchingDetails DbServerPatchingDetails
        {
            get { return this._dbServerPatchingDetails; }
            set { this._dbServerPatchingDetails = value; }
        }

        // Check to see if DbServerPatchingDetails property is set
        internal bool IsSetDbServerPatchingDetails()
        {
            return this._dbServerPatchingDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the database server.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExadataInfrastructureId. 
        /// <para>
        /// The ID of the Exadata infrastructure the database server belongs to.
        /// </para>
        /// </summary>
        public string ExadataInfrastructureId
        {
            get { return this._exadataInfrastructureId; }
            set { this._exadataInfrastructureId = value; }
        }

        // Check to see if ExadataInfrastructureId property is set
        internal bool IsSetExadataInfrastructureId()
        {
            return this._exadataInfrastructureId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCpuCount. 
        /// <para>
        /// The total number of CPU cores available.
        /// </para>
        /// </summary>
        public int? MaxCpuCount
        {
            get { return this._maxCpuCount; }
            set { this._maxCpuCount = value; }
        }

        // Check to see if MaxCpuCount property is set
        internal bool IsSetMaxCpuCount()
        {
            return this._maxCpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDbNodeStorageInGBs. 
        /// <para>
        /// The total local node storage available in GBs.
        /// </para>
        /// </summary>
        public int? MaxDbNodeStorageInGBs
        {
            get { return this._maxDbNodeStorageInGBs; }
            set { this._maxDbNodeStorageInGBs = value; }
        }

        // Check to see if MaxDbNodeStorageInGBs property is set
        internal bool IsSetMaxDbNodeStorageInGBs()
        {
            return this._maxDbNodeStorageInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxMemoryInGBs. 
        /// <para>
        /// The total memory available in GBs.
        /// </para>
        /// </summary>
        public int? MaxMemoryInGBs
        {
            get { return this._maxMemoryInGBs; }
            set { this._maxMemoryInGBs = value; }
        }

        // Check to see if MaxMemoryInGBs property is set
        internal bool IsSetMaxMemoryInGBs()
        {
            return this._maxMemoryInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The allocated memory in GBs on the database server.
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs
        {
            get { return this._memorySizeInGBs; }
            set { this._memorySizeInGBs = value; }
        }

        // Check to see if MemorySizeInGBs property is set
        internal bool IsSetMemorySizeInGBs()
        {
            return this._memorySizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the database server.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the database server.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName
        {
            get { return this._ociResourceAnchorName; }
            set { this._ociResourceAnchorName = value; }
        }

        // Check to see if OciResourceAnchorName property is set
        internal bool IsSetOciResourceAnchorName()
        {
            return this._ociResourceAnchorName != null;
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the database server. The shape determines the amount of CPU, storage,
        /// and memory resources available.
        /// </para>
        /// </summary>
        public string Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the database server.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the database server.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property VmClusterIds. 
        /// <para>
        /// The OCID of the VM clusters that are associated with the database server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> VmClusterIds
        {
            get { return this._vmClusterIds; }
            set { this._vmClusterIds = value; }
        }

        // Check to see if VmClusterIds property is set
        internal bool IsSetVmClusterIds()
        {
            return this._vmClusterIds != null && (this._vmClusterIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}