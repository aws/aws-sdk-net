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
    /// Information about an Autonomous VM cluster resource.
    /// </summary>
    public partial class CloudAutonomousVmCluster
    {
        private float? _autonomousDataStoragePercentage;
        private double? _autonomousDataStorageSizeInTBs;
        private double? _availableAutonomousDataStorageSizeInTBs;
        private int? _availableContainerDatabases;
        private float? _availableCpus;
        private string _cloudAutonomousVmClusterArn;
        private string _cloudAutonomousVmClusterId;
        private string _cloudExadataInfrastructureArn;
        private string _cloudExadataInfrastructureId;
        private ComputeModel _computeModel;
        private int? _cpuCoreCount;
        private int? _cpuCoreCountPerNode;
        private float? _cpuPercentage;
        private DateTime? _createdAt;
        private double? _dataStorageSizeInGBs;
        private double? _dataStorageSizeInTBs;
        private int? _dbNodeStorageSizeInGBs;
        private List<string> _dbServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _displayName;
        private string _domain;
        private double? _exadataStorageInTBsLowestScaledValue;
        private string _hostname;
        private List<IamRole> _iamRoles = AWSConfigs.InitializeCollections ? new List<IamRole>() : null;
        private bool? _isMtlsEnabledVmCluster;
        private LicenseModel _licenseModel;
        private MaintenanceWindow _maintenanceWindow;
        private int? _maxAcdsLowestScaledValue;
        private int? _memoryPerOracleComputeUnitInGBs;
        private int? _memorySizeInGBs;
        private int? _nodeCount;
        private int? _nonProvisionableAutonomousContainerDatabases;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _ociUrl;
        private string _odbNetworkArn;
        private string _odbNetworkId;
        private float? _percentProgress;
        private int? _provisionableAutonomousContainerDatabases;
        private int? _provisionedAutonomousContainerDatabases;
        private float? _provisionedCpus;
        private float? _reclaimableCpus;
        private float? _reservedCpus;
        private int? _scanListenerPortNonTls;
        private int? _scanListenerPortTls;
        private string _shape;
        private ResourceStatus _status;
        private string _statusReason;
        private DateTime? _timeDatabaseSslCertificateExpires;
        private DateTime? _timeOrdsCertificateExpires;
        private string _timeZone;
        private int? _totalContainerDatabases;

        /// <summary>
        /// Gets and sets the property AutonomousDataStoragePercentage. 
        /// <para>
        /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous
        /// VM cluster.
        /// </para>
        /// </summary>
        public float AutonomousDataStoragePercentage
        {
            get { return this._autonomousDataStoragePercentage.GetValueOrDefault(); }
            set { this._autonomousDataStoragePercentage = value; }
        }

        // Check to see if AutonomousDataStoragePercentage property is set
        internal bool IsSetAutonomousDataStoragePercentage()
        {
            return this._autonomousDataStoragePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster,
        /// in TB.
        /// </para>
        /// </summary>
        public double AutonomousDataStorageSizeInTBs
        {
            get { return this._autonomousDataStorageSizeInTBs.GetValueOrDefault(); }
            set { this._autonomousDataStorageSizeInTBs = value; }
        }

        // Check to see if AutonomousDataStorageSizeInTBs property is set
        internal bool IsSetAutonomousDataStorageSizeInTBs()
        {
            return this._autonomousDataStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableAutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The available data storage space for Autonomous Databases in the Autonomous VM cluster,
        /// in TB.
        /// </para>
        /// </summary>
        public double AvailableAutonomousDataStorageSizeInTBs
        {
            get { return this._availableAutonomousDataStorageSizeInTBs.GetValueOrDefault(); }
            set { this._availableAutonomousDataStorageSizeInTBs = value; }
        }

        // Check to see if AvailableAutonomousDataStorageSizeInTBs property is set
        internal bool IsSetAvailableAutonomousDataStorageSizeInTBs()
        {
            return this._availableAutonomousDataStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs that you can create with the currently available storage.
        /// </para>
        /// </summary>
        public int AvailableContainerDatabases
        {
            get { return this._availableContainerDatabases.GetValueOrDefault(); }
            set { this._availableContainerDatabases = value; }
        }

        // Check to see if AvailableContainerDatabases property is set
        internal bool IsSetAvailableContainerDatabases()
        {
            return this._availableContainerDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableCpus. 
        /// <para>
        /// The number of CPU cores available for allocation to Autonomous Databases.
        /// </para>
        /// </summary>
        public float AvailableCpus
        {
            get { return this._availableCpus.GetValueOrDefault(); }
            set { this._availableCpus = value; }
        }

        // Check to see if AvailableCpus property is set
        internal bool IsSetAvailableCpus()
        {
            return this._availableCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string CloudAutonomousVmClusterArn
        {
            get { return this._cloudAutonomousVmClusterArn; }
            set { this._cloudAutonomousVmClusterArn = value; }
        }

        // Check to see if CloudAutonomousVmClusterArn property is set
        internal bool IsSetCloudAutonomousVmClusterArn()
        {
            return this._cloudAutonomousVmClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=64)]
        public string CloudAutonomousVmClusterId
        {
            get { return this._cloudAutonomousVmClusterId; }
            set { this._cloudAutonomousVmClusterId = value; }
        }

        // Check to see if CloudAutonomousVmClusterId property is set
        internal bool IsSetCloudAutonomousVmClusterId()
        {
            return this._cloudAutonomousVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Cloud Exadata Infrastructure containing this
        /// Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The unique identifier of the Cloud Exadata Infrastructure containing this Autonomous
        /// VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
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
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
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
        /// The total number of CPU cores in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int CpuCoreCount
        {
            get { return this._cpuCoreCount.GetValueOrDefault(); }
            set { this._cpuCoreCount = value; }
        }

        // Check to see if CpuCoreCount property is set
        internal bool IsSetCpuCoreCount()
        {
            return this._cpuCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CpuCoreCountPerNode. 
        /// <para>
        /// The number of CPU cores enabled per node in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int CpuCoreCountPerNode
        {
            get { return this._cpuCoreCountPerNode.GetValueOrDefault(); }
            set { this._cpuCoreCountPerNode = value; }
        }

        // Check to see if CpuCoreCountPerNode property is set
        internal bool IsSetCpuCoreCountPerNode()
        {
            return this._cpuCoreCountPerNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CpuPercentage. 
        /// <para>
        /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public float CpuPercentage
        {
            get { return this._cpuPercentage.GetValueOrDefault(); }
            set { this._cpuPercentage = value; }
        }

        // Check to see if CpuPercentage property is set
        internal bool IsSetCpuPercentage()
        {
            return this._cpuPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Autonomous VM cluster was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataStorageSizeInGBs. 
        /// <para>
        /// The total data storage allocated to the Autonomous VM cluster, in GB.
        /// </para>
        /// </summary>
        public double DataStorageSizeInGBs
        {
            get { return this._dataStorageSizeInGBs.GetValueOrDefault(); }
            set { this._dataStorageSizeInGBs = value; }
        }

        // Check to see if DataStorageSizeInGBs property is set
        internal bool IsSetDataStorageSizeInGBs()
        {
            return this._dataStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The total data storage allocated to the Autonomous VM cluster, in TB.
        /// </para>
        /// </summary>
        public double DataStorageSizeInTBs
        {
            get { return this._dataStorageSizeInTBs.GetValueOrDefault(); }
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
        /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int DbNodeStorageSizeInGBs
        {
            get { return this._dbNodeStorageSizeInGBs.GetValueOrDefault(); }
            set { this._dbNodeStorageSizeInGBs = value; }
        }

        // Check to see if DbNodeStorageSizeInGBs property is set
        internal bool IsSetDbNodeStorageSizeInGBs()
        {
            return this._dbNodeStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The list of database servers associated with the Autonomous VM cluster.
        /// </para>
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
        /// The user-provided description of the Autonomous VM cluster.
        /// </para>
        /// </summary>
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
        /// The display name of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ExadataStorageInTBsLowestScaledValue. 
        /// <para>
        /// The minimum value to which you can scale down the Exadata storage, in TB.
        /// </para>
        /// </summary>
        public double ExadataStorageInTBsLowestScaledValue
        {
            get { return this._exadataStorageInTBsLowestScaledValue.GetValueOrDefault(); }
            set { this._exadataStorageInTBsLowestScaledValue = value; }
        }

        // Check to see if ExadataStorageInTBsLowestScaledValue property is set
        internal bool IsSetExadataStorageInTBsLowestScaledValue()
        {
            return this._exadataStorageInTBsLowestScaledValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// The Amazon Web Services Identity and Access Management (IAM) service roles associated
        /// with the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public List<IamRole> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && (this._iamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsMtlsEnabledVmCluster. 
        /// <para>
        /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM
        /// cluster.
        /// </para>
        /// </summary>
        public bool IsMtlsEnabledVmCluster
        {
            get { return this._isMtlsEnabledVmCluster.GetValueOrDefault(); }
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
        /// The Oracle license model that applies to the Autonomous VM cluster.
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
        /// Gets and sets the property MaxAcdsLowestScaledValue. 
        /// <para>
        /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
        /// </para>
        /// </summary>
        public int MaxAcdsLowestScaledValue
        {
            get { return this._maxAcdsLowestScaledValue.GetValueOrDefault(); }
            set { this._maxAcdsLowestScaledValue = value; }
        }

        // Check to see if MaxAcdsLowestScaledValue property is set
        internal bool IsSetMaxAcdsLowestScaledValue()
        {
            return this._maxAcdsLowestScaledValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryPerOracleComputeUnitInGBs. 
        /// <para>
        /// The amount of memory allocated per Oracle Compute Unit, in GB.
        /// </para>
        /// </summary>
        public int MemoryPerOracleComputeUnitInGBs
        {
            get { return this._memoryPerOracleComputeUnitInGBs.GetValueOrDefault(); }
            set { this._memoryPerOracleComputeUnitInGBs = value; }
        }

        // Check to see if MemoryPerOracleComputeUnitInGBs property is set
        internal bool IsSetMemoryPerOracleComputeUnitInGBs()
        {
            return this._memoryPerOracleComputeUnitInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int MemorySizeInGBs
        {
            get { return this._memorySizeInGBs.GetValueOrDefault(); }
            set { this._memorySizeInGBs = value; }
        }

        // Check to see if MemorySizeInGBs property is set
        internal bool IsSetMemorySizeInGBs()
        {
            return this._memorySizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of database server nodes in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int NodeCount
        {
            get { return this._nodeCount.GetValueOrDefault(); }
            set { this._nodeCount = value; }
        }

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this._nodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonProvisionableAutonomousContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs that can't be provisioned because of resource constraints.
        /// </para>
        /// </summary>
        public int NonProvisionableAutonomousContainerDatabases
        {
            get { return this._nonProvisionableAutonomousContainerDatabases.GetValueOrDefault(); }
            set { this._nonProvisionableAutonomousContainerDatabases = value; }
        }

        // Check to see if NonProvisionableAutonomousContainerDatabases property is set
        internal bool IsSetNonProvisionableAutonomousContainerDatabases()
        {
            return this._nonProvisionableAutonomousContainerDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
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
        /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
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
        /// The URL for accessing the OCI console page for this Autonomous VM cluster.
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
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network associated with this Autonomous
        /// VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string OdbNetworkArn
        {
            get { return this._odbNetworkArn; }
            set { this._odbNetworkArn = value; }
        }

        // Check to see if OdbNetworkArn property is set
        internal bool IsSetOdbNetworkArn()
        {
            return this._odbNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
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
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
        /// </para>
        /// </summary>
        public float PercentProgress
        {
            get { return this._percentProgress.GetValueOrDefault(); }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionableAutonomousContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int ProvisionableAutonomousContainerDatabases
        {
            get { return this._provisionableAutonomousContainerDatabases.GetValueOrDefault(); }
            set { this._provisionableAutonomousContainerDatabases = value; }
        }

        // Check to see if ProvisionableAutonomousContainerDatabases property is set
        internal bool IsSetProvisionableAutonomousContainerDatabases()
        {
            return this._provisionableAutonomousContainerDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedAutonomousContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int ProvisionedAutonomousContainerDatabases
        {
            get { return this._provisionedAutonomousContainerDatabases.GetValueOrDefault(); }
            set { this._provisionedAutonomousContainerDatabases = value; }
        }

        // Check to see if ProvisionedAutonomousContainerDatabases property is set
        internal bool IsSetProvisionedAutonomousContainerDatabases()
        {
            return this._provisionedAutonomousContainerDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedCpus. 
        /// <para>
        /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public float ProvisionedCpus
        {
            get { return this._provisionedCpus.GetValueOrDefault(); }
            set { this._provisionedCpus = value; }
        }

        // Check to see if ProvisionedCpus property is set
        internal bool IsSetProvisionedCpus()
        {
            return this._provisionedCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReclaimableCpus. 
        /// <para>
        /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous
        /// Databases.
        /// </para>
        /// </summary>
        public float ReclaimableCpus
        {
            get { return this._reclaimableCpus.GetValueOrDefault(); }
            set { this._reclaimableCpus = value; }
        }

        // Check to see if ReclaimableCpus property is set
        internal bool IsSetReclaimableCpus()
        {
            return this._reclaimableCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedCpus. 
        /// <para>
        /// The number of CPU cores reserved for system operations and redundancy.
        /// </para>
        /// </summary>
        public float ReservedCpus
        {
            get { return this._reservedCpus.GetValueOrDefault(); }
            set { this._reservedCpus = value; }
        }

        // Check to see if ReservedCpus property is set
        internal bool IsSetReservedCpus()
        {
            return this._reservedCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanListenerPortNonTls. 
        /// <para>
        /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
        /// </para>
        /// </summary>
        public int ScanListenerPortNonTls
        {
            get { return this._scanListenerPortNonTls.GetValueOrDefault(); }
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
        /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
        /// </para>
        /// </summary>
        public int ScanListenerPortTls
        {
            get { return this._scanListenerPortTls.GetValueOrDefault(); }
            set { this._scanListenerPortTls = value; }
        }

        // Check to see if ScanListenerPortTls property is set
        internal bool IsSetScanListenerPortTls()
        {
            return this._scanListenerPortTls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
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
        /// The current state of the Autonomous VM cluster. Possible values include <c>CREATING</c>,
        /// <c>AVAILABLE</c>, <c>UPDATING</c>, <c>DELETING</c>, <c>DELETED</c>, <c>FAILED</c>.
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
        /// Additional information about the current status of the Autonomous VM cluster.
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
        /// Gets and sets the property TimeDatabaseSslCertificateExpires. 
        /// <para>
        /// The expiration date and time of the database SSL certificate.
        /// </para>
        /// </summary>
        public DateTime TimeDatabaseSslCertificateExpires
        {
            get { return this._timeDatabaseSslCertificateExpires.GetValueOrDefault(); }
            set { this._timeDatabaseSslCertificateExpires = value; }
        }

        // Check to see if TimeDatabaseSslCertificateExpires property is set
        internal bool IsSetTimeDatabaseSslCertificateExpires()
        {
            return this._timeDatabaseSslCertificateExpires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOrdsCertificateExpires. 
        /// <para>
        /// The expiration date and time of the Oracle REST Data Services (ORDS) certificate.
        /// </para>
        /// </summary>
        public DateTime TimeOrdsCertificateExpires
        {
            get { return this._timeOrdsCertificateExpires.GetValueOrDefault(); }
            set { this._timeOrdsCertificateExpires = value; }
        }

        // Check to see if TimeOrdsCertificateExpires property is set
        internal bool IsSetTimeOrdsCertificateExpires()
        {
            return this._timeOrdsCertificateExpires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone of the Autonomous VM cluster.
        /// </para>
        /// </summary>
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
        /// The total number of Autonomous Container Databases that can be created with the allocated
        /// local storage.
        /// </para>
        /// </summary>
        public int TotalContainerDatabases
        {
            get { return this._totalContainerDatabases.GetValueOrDefault(); }
            set { this._totalContainerDatabases = value; }
        }

        // Check to see if TotalContainerDatabases property is set
        internal bool IsSetTotalContainerDatabases()
        {
            return this._totalContainerDatabases.HasValue; 
        }

    }
}