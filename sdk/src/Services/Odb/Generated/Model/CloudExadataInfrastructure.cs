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
    /// Information about an Exadata infrastructure.
    /// </summary>
    public partial class CloudExadataInfrastructure
    {
        private int? _activatedStorageCount;
        private int? _additionalStorageCount;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private int? _availableStorageSizeInGBs;
        private string _cloudExadataInfrastructureArn;
        private string _cloudExadataInfrastructureId;
        private int? _computeCount;
        private ComputeModel _computeModel;
        private int? _cpuCount;
        private DateTime? _createdAt;
        private List<CustomerContact> _customerContactsToSendToOCI = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;
        private string _databaseServerType;
        private double? _dataStorageSizeInTBs;
        private int? _dbNodeStorageSizeInGBs;
        private string _dbServerVersion;
        private string _displayName;
        private string _lastMaintenanceRunId;
        private MaintenanceWindow _maintenanceWindow;
        private int? _maxCpuCount;
        private double? _maxDataStorageInTBs;
        private int? _maxDbNodeStorageSizeInGBs;
        private int? _maxMemoryInGBs;
        private int? _memorySizeInGBs;
        private string _monthlyDbServerVersion;
        private string _monthlyStorageServerVersion;
        private string _nextMaintenanceRunId;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _ociUrl;
        private float? _percentProgress;
        private string _shape;
        private ResourceStatus _status;
        private string _statusReason;
        private int? _storageCount;
        private string _storageServerType;
        private string _storageServerVersion;
        private int? _totalStorageSizeInGBs;

        /// <summary>
        /// Gets and sets the property ActivatedStorageCount. 
        /// <para>
        /// The number of storage servers requested for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? ActivatedStorageCount
        {
            get { return this._activatedStorageCount; }
            set { this._activatedStorageCount = value; }
        }

        // Check to see if ActivatedStorageCount property is set
        internal bool IsSetActivatedStorageCount()
        {
            return this._activatedStorageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalStorageCount. 
        /// <para>
        /// The number of storage servers requested for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? AdditionalStorageCount
        {
            get { return this._additionalStorageCount; }
            set { this._additionalStorageCount = value; }
        }

        // Check to see if AdditionalStorageCount property is set
        internal bool IsSetAdditionalStorageCount()
        {
            return this._additionalStorageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID of the AZ where the Exadata infrastructure is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableStorageSizeInGBs. 
        /// <para>
        /// The amount of available storage, in gigabytes (GB), for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? AvailableStorageSizeInGBs
        {
            get { return this._availableStorageSizeInGBs; }
            set { this._availableStorageSizeInGBs = value; }
        }

        // Check to see if AvailableStorageSizeInGBs property is set
        internal bool IsSetAvailableStorageSizeInGBs()
        {
            return this._availableStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string CloudExadataInfrastructureArn
        {
            get { return this._cloudExadataInfrastructureArn; }
            set { this._cloudExadataInfrastructureArn = value; }
        }

        // Check to see if CloudExadataInfrastructureArn property is set
        internal bool IsSetCloudExadataInfrastructureArn()
        {
            return this._cloudExadataInfrastructureArn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier for the Exadata infrastructure.
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
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The number of database servers for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? ComputeCount
        {
            get { return this._computeCount; }
            set { this._computeCount = value; }
        }

        // Check to see if ComputeCount property is set
        internal bool IsSetComputeCount()
        {
            return this._computeCount.HasValue; 
        }

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
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The total number of CPU cores that are allocated to the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? CpuCount
        {
            get { return this._cpuCount; }
            set { this._cpuCount = value; }
        }

        // Check to see if CpuCount property is set
        internal bool IsSetCpuCount()
        {
            return this._cpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Exadata infrastructure was created.
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
        /// Gets and sets the property CustomerContactsToSendToOCI. 
        /// <para>
        /// The email addresses of contacts to receive notification from Oracle about maintenance
        /// updates for the Exadata infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContactsToSendToOCI
        {
            get { return this._customerContactsToSendToOCI; }
            set { this._customerContactsToSendToOCI = value; }
        }

        // Check to see if CustomerContactsToSendToOCI property is set
        internal bool IsSetCustomerContactsToSendToOCI()
        {
            return this._customerContactsToSendToOCI != null && (this._customerContactsToSendToOCI.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseServerType. 
        /// <para>
        /// The database server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        public string DatabaseServerType
        {
            get { return this._databaseServerType; }
            set { this._databaseServerType = value; }
        }

        // Check to see if DatabaseServerType property is set
        internal bool IsSetDatabaseServerType()
        {
            return this._databaseServerType != null;
        }

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size of the Exadata infrastructure's data disk group, in terabytes (TB).
        /// </para>
        /// </summary>
        public double? DataStorageSizeInTBs
        {
            get { return this._dataStorageSizeInTBs; }
            set { this._dataStorageSizeInTBs = value; }
        }

        // Check to see if DataStorageSizeInTBs property is set
        internal bool IsSetDataStorageSizeInTBs()
        {
            return this._dataStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The size of the Exadata infrastructure's local node storage, in gigabytes (GB).
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
        /// Gets and sets the property DbServerVersion. 
        /// <para>
        /// The software version of the database servers (dom0) in the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string DbServerVersion
        {
            get { return this._dbServerVersion; }
            set { this._dbServerVersion = value; }
        }

        // Check to see if DbServerVersion property is set
        internal bool IsSetDbServerVersion()
        {
            return this._dbServerVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the Exadata infrastructure.
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
        /// Gets and sets the property LastMaintenanceRunId. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the last maintenance run for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string LastMaintenanceRunId
        {
            get { return this._lastMaintenanceRunId; }
            set { this._lastMaintenanceRunId = value; }
        }

        // Check to see if LastMaintenanceRunId property is set
        internal bool IsSetLastMaintenanceRunId()
        {
            return this._lastMaintenanceRunId != null;
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
        /// Gets and sets the property MaxCpuCount. 
        /// <para>
        /// The total number of CPU cores available on the Exadata infrastructure.
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
        /// Gets and sets the property MaxDataStorageInTBs. 
        /// <para>
        /// The total amount of data disk group storage, in terabytes (TB), that's available on
        /// the Exadata infrastructure.
        /// </para>
        /// </summary>
        public double? MaxDataStorageInTBs
        {
            get { return this._maxDataStorageInTBs; }
            set { this._maxDataStorageInTBs = value; }
        }

        // Check to see if MaxDataStorageInTBs property is set
        internal bool IsSetMaxDataStorageInTBs()
        {
            return this._maxDataStorageInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDbNodeStorageSizeInGBs. 
        /// <para>
        /// The total amount of local node storage, in gigabytes (GB), that's available on the
        /// Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? MaxDbNodeStorageSizeInGBs
        {
            get { return this._maxDbNodeStorageSizeInGBs; }
            set { this._maxDbNodeStorageSizeInGBs = value; }
        }

        // Check to see if MaxDbNodeStorageSizeInGBs property is set
        internal bool IsSetMaxDbNodeStorageSizeInGBs()
        {
            return this._maxDbNodeStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxMemoryInGBs. 
        /// <para>
        /// The total amount of memory, in gigabytes (GB), that's available on the Exadata infrastructure.
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
        /// The amount of memory, in gigabytes (GB), that's allocated on the Exadata infrastructure.
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
        /// Gets and sets the property MonthlyDbServerVersion. 
        /// <para>
        /// The monthly software version of the database servers installed on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string MonthlyDbServerVersion
        {
            get { return this._monthlyDbServerVersion; }
            set { this._monthlyDbServerVersion = value; }
        }

        // Check to see if MonthlyDbServerVersion property is set
        internal bool IsSetMonthlyDbServerVersion()
        {
            return this._monthlyDbServerVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyStorageServerVersion. 
        /// <para>
        /// The monthly software version of the storage servers installed on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string MonthlyStorageServerVersion
        {
            get { return this._monthlyStorageServerVersion; }
            set { this._monthlyStorageServerVersion = value; }
        }

        // Check to see if MonthlyStorageServerVersion property is set
        internal bool IsSetMonthlyStorageServerVersion()
        {
            return this._monthlyStorageServerVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextMaintenanceRunId. 
        /// <para>
        /// The OCID of the next maintenance run for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string NextMaintenanceRunId
        {
            get { return this._nextMaintenanceRunId; }
            set { this._nextMaintenanceRunId = value; }
        }

        // Check to see if NextMaintenanceRunId property is set
        internal bool IsSetNextMaintenanceRunId()
        {
            return this._nextMaintenanceRunId != null;
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the Exadata infrastructure.
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
        /// The name of the OCI resource anchor for the Exadata infrastructure.
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
        /// Gets and sets the property OciUrl. 
        /// <para>
        /// The HTTPS link to the Exadata infrastructure in OCI.
        /// </para>
        /// </summary>
        public string OciUrl
        {
            get { return this._ociUrl; }
            set { this._ociUrl = value; }
        }

        // Check to see if OciUrl property is set
        internal bool IsSetOciUrl()
        {
            return this._ociUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the Exadata infrastructure,
        /// expressed as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The model name of the Exadata infrastructure.
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
        /// The current status of the Exadata infrastructure.
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
        /// Additional information about the status of the Exadata infrastructure.
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
        /// Gets and sets the property StorageCount. 
        /// <para>
        /// The number of storage servers that are activated for the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? StorageCount
        {
            get { return this._storageCount; }
            set { this._storageCount = value; }
        }

        // Check to see if StorageCount property is set
        internal bool IsSetStorageCount()
        {
            return this._storageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageServerType. 
        /// <para>
        /// The storage server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        public string StorageServerType
        {
            get { return this._storageServerType; }
            set { this._storageServerType = value; }
        }

        // Check to see if StorageServerType property is set
        internal bool IsSetStorageServerType()
        {
            return this._storageServerType != null;
        }

        /// <summary>
        /// Gets and sets the property StorageServerVersion. 
        /// <para>
        /// The software version of the storage servers on the Exadata infrastructure.
        /// </para>
        /// </summary>
        public string StorageServerVersion
        {
            get { return this._storageServerVersion; }
            set { this._storageServerVersion = value; }
        }

        // Check to see if StorageServerVersion property is set
        internal bool IsSetStorageServerVersion()
        {
            return this._storageServerVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TotalStorageSizeInGBs. 
        /// <para>
        /// The total amount of storage, in gigabytes (GB), on the the Exadata infrastructure.
        /// </para>
        /// </summary>
        public int? TotalStorageSizeInGBs
        {
            get { return this._totalStorageSizeInGBs; }
            set { this._totalStorageSizeInGBs = value; }
        }

        // Check to see if TotalStorageSizeInGBs property is set
        internal bool IsSetTotalStorageSizeInGBs()
        {
            return this._totalStorageSizeInGBs.HasValue; 
        }

    }
}