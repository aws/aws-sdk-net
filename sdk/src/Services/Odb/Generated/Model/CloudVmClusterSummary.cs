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
    /// Information about a VM cluster.
    /// </summary>
    public partial class CloudVmClusterSummary
    {
        private string _cloudExadataInfrastructureId;
        private string _cloudVmClusterArn;
        private string _cloudVmClusterId;
        private string _clusterName;
        private ComputeModel _computeModel;
        private int? _cpuCoreCount;
        private DateTime? _createdAt;
        private DataCollectionOptions _dataCollectionOptions;
        private double? _dataStorageSizeInTBs;
        private int? _dbNodeStorageSizeInGBs;
        private List<string> _dbServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DiskRedundancy _diskRedundancy;
        private string _displayName;
        private string _domain;
        private string _giVersion;
        private string _hostname;
        private ExadataIormConfig _iormConfigCache;
        private bool? _isLocalBackupEnabled;
        private bool? _isSparseDiskgroupEnabled;
        private string _lastUpdateHistoryEntryId;
        private LicenseModel _licenseModel;
        private int? _listenerPort;
        private int? _memorySizeInGBs;
        private int? _nodeCount;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _ociUrl;
        private string _odbNetworkId;
        private float? _percentProgress;
        private string _scanDnsName;
        private string _scanDnsRecordId;
        private List<string> _scanIpIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _shape;
        private List<string> _sshPublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceStatus _status;
        private string _statusReason;
        private int? _storageSizeInGBs;
        private string _systemVersion;
        private string _timeZone;
        private List<string> _vipIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Exadata infrastructure that this VM cluster belongs to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CloudVmClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VM cluster.
        /// </para>
        /// </summary>
        public string CloudVmClusterArn
        {
            get { return this._cloudVmClusterArn; }
            set { this._cloudVmClusterArn = value; }
        }

        // Check to see if CloudVmClusterArn property is set
        internal bool IsSetCloudVmClusterArn()
        {
            return this._cloudVmClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudVmClusterId. 
        /// <para>
        /// The unique identifier of the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=64)]
        public string CloudVmClusterId
        {
            get { return this._cloudVmClusterId; }
            set { this._cloudVmClusterId = value; }
        }

        // Check to see if CloudVmClusterId property is set
        internal bool IsSetCloudVmClusterId()
        {
            return this._cloudVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Grid Infrastructure (GI) cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
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
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores enabled on the VM cluster.
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
        /// The date and time when the VM cluster was created.
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
        /// Gets and sets the property DataCollectionOptions.
        /// </summary>
        public DataCollectionOptions DataCollectionOptions
        {
            get { return this._dataCollectionOptions; }
            set { this._dataCollectionOptions = value; }
        }

        // Check to see if DataCollectionOptions property is set
        internal bool IsSetDataCollectionOptions()
        {
            return this._dataCollectionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size of the data disk group, in terabytes (TB), that's allocated for the VM cluster.
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
        /// The amount of local node storage, in gigabytes (GB), that's allocated for the VM cluster.
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
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The list of database servers for the VM cluster.
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
        /// Gets and sets the property DiskRedundancy. 
        /// <para>
        /// The type of redundancy configured for the VM cluster. <c>NORMAL</c> is 2-way redundancy.
        /// <c>HIGH</c> is 3-way redundancy.
        /// </para>
        /// </summary>
        public DiskRedundancy DiskRedundancy
        {
            get { return this._diskRedundancy; }
            set { this._diskRedundancy = value; }
        }

        // Check to see if DiskRedundancy property is set
        internal bool IsSetDiskRedundancy()
        {
            return this._diskRedundancy != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the VM cluster.
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain of the VM cluster.
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
        /// Gets and sets the property GiVersion. 
        /// <para>
        /// The software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
        /// </para>
        /// </summary>
        public string GiVersion
        {
            get { return this._giVersion; }
            set { this._giVersion = value; }
        }

        // Check to see if GiVersion property is set
        internal bool IsSetGiVersion()
        {
            return this._giVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the VM cluster.
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
        /// Gets and sets the property IormConfigCache.
        /// </summary>
        public ExadataIormConfig IormConfigCache
        {
            get { return this._iormConfigCache; }
            set { this._iormConfigCache = value; }
        }

        // Check to see if IormConfigCache property is set
        internal bool IsSetIormConfigCache()
        {
            return this._iormConfigCache != null;
        }

        /// <summary>
        /// Gets and sets the property IsLocalBackupEnabled. 
        /// <para>
        /// Indicates whether database backups to local Exadata storage is enabled for the VM
        /// cluster.
        /// </para>
        /// </summary>
        public bool? IsLocalBackupEnabled
        {
            get { return this._isLocalBackupEnabled; }
            set { this._isLocalBackupEnabled = value; }
        }

        // Check to see if IsLocalBackupEnabled property is set
        internal bool IsSetIsLocalBackupEnabled()
        {
            return this._isLocalBackupEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSparseDiskgroupEnabled. 
        /// <para>
        /// Indicates whether the VM cluster is configured with a sparse disk group.
        /// </para>
        /// </summary>
        public bool? IsSparseDiskgroupEnabled
        {
            get { return this._isSparseDiskgroupEnabled; }
            set { this._isSparseDiskgroupEnabled = value; }
        }

        // Check to see if IsSparseDiskgroupEnabled property is set
        internal bool IsSetIsSparseDiskgroupEnabled()
        {
            return this._isSparseDiskgroupEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateHistoryEntryId. 
        /// <para>
        /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
        /// </para>
        /// </summary>
        public string LastUpdateHistoryEntryId
        {
            get { return this._lastUpdateHistoryEntryId; }
            set { this._lastUpdateHistoryEntryId = value; }
        }

        // Check to see if LastUpdateHistoryEntryId property is set
        internal bool IsSetLastUpdateHistoryEntryId()
        {
            return this._lastUpdateHistoryEntryId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model applied to the VM cluster.
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
        /// Gets and sets the property ListenerPort. 
        /// <para>
        /// The port number configured for the listener on the VM cluster.
        /// </para>
        /// </summary>
        public int? ListenerPort
        {
            get { return this._listenerPort; }
            set { this._listenerPort = value; }
        }

        // Check to see if ListenerPort property is set
        internal bool IsSetListenerPort()
        {
            return this._listenerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GB), that's allocated for the VM cluster.
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
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of nodes in the VM cluster.
        /// </para>
        /// </summary>
        public int? NodeCount
        {
            get { return this._nodeCount; }
            set { this._nodeCount = value; }
        }

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this._nodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the VM cluster.
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
        /// The name of the OCI resource anchor for the VM cluster.
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
        /// The HTTPS link to the VM cluster in OCI.
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
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network for the VM cluster.
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
        /// The amount of progress made on the current operation on the VM cluster, expressed
        /// as a percentage.
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
        /// Gets and sets the property ScanDnsName. 
        /// <para>
        /// The FQDN of the DNS record for the Single Client Access Name (SCAN) IP addresses that
        /// are associated with the VM cluster.
        /// </para>
        /// </summary>
        public string ScanDnsName
        {
            get { return this._scanDnsName; }
            set { this._scanDnsName = value; }
        }

        // Check to see if ScanDnsName property is set
        internal bool IsSetScanDnsName()
        {
            return this._scanDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property ScanDnsRecordId. 
        /// <para>
        /// The OCID of the DNS record for the SCAN IP addresses that are associated with the
        /// VM cluster.
        /// </para>
        /// </summary>
        public string ScanDnsRecordId
        {
            get { return this._scanDnsRecordId; }
            set { this._scanDnsRecordId = value; }
        }

        // Check to see if ScanDnsRecordId property is set
        internal bool IsSetScanDnsRecordId()
        {
            return this._scanDnsRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanIpIds. 
        /// <para>
        /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> ScanIpIds
        {
            get { return this._scanIpIds; }
            set { this._scanIpIds = value; }
        }

        // Check to see if ScanIpIds property is set
        internal bool IsSetScanIpIds()
        {
            return this._scanIpIds != null && (this._scanIpIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The hardware model name of the Exadata infrastructure that's running the VM cluster.
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
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// The public key portion of one or more key pairs used for SSH access to the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshPublicKeys
        {
            get { return this._sshPublicKeys; }
            set { this._sshPublicKeys = value; }
        }

        // Check to see if SshPublicKeys property is set
        internal bool IsSetSshPublicKeys()
        {
            return this._sshPublicKeys != null && (this._sshPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the VM cluster.
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
        /// Additional information about the status of the VM cluster.
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
        /// Gets and sets the property StorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), that's allocated to the VM cluster.
        /// </para>
        /// </summary>
        public int? StorageSizeInGBs
        {
            get { return this._storageSizeInGBs; }
            set { this._storageSizeInGBs = value; }
        }

        // Check to see if StorageSizeInGBs property is set
        internal bool IsSetStorageSizeInGBs()
        {
            return this._storageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SystemVersion. 
        /// <para>
        /// The operating system version of the image chosen for the VM cluster.
        /// </para>
        /// </summary>
        public string SystemVersion
        {
            get { return this._systemVersion; }
            set { this._systemVersion = value; }
        }

        // Check to see if SystemVersion property is set
        internal bool IsSetSystemVersion()
        {
            return this._systemVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone of the VM cluster.
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
        /// Gets and sets the property VipIds. 
        /// <para>
        /// The virtual IP (VIP) addresses that are associated with the VM cluster. Oracle's Cluster
        /// Ready Services (CRS) creates and maintains one VIP address for each node in the VM
        /// cluster to enable failover. If one node fails, the VIP is reassigned to another active
        /// node in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> VipIds
        {
            get { return this._vipIds; }
            set { this._vipIds = value; }
        }

        // Check to see if VipIds property is set
        internal bool IsSetVipIds()
        {
            return this._vipIds != null && (this._vipIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}