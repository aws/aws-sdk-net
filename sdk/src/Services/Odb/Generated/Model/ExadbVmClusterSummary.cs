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
    /// Summary information about an Exascale VM cluster.
    /// </summary>
    public partial class ExadbVmClusterSummary
    {
        private string _clusterName;
        private DateTime? _createdAt;
        private DataCollectionOptions _dataCollectionOptions;
        private string _displayName;
        private string _domain;
        private int? _enabledEcpuCount;
        private string _exadbVmClusterArn;
        private string _exadbVmClusterId;
        private string _exascaleDbStorageVaultArn;
        private string _exascaleDbStorageVaultId;
        private string _giVersion;
        private string _gridImageId;
        private GridImageType _gridImageType;
        private string _hostname;
        private List<IamRole> _iamRoles = AWSConfigs.InitializeCollections ? new List<IamRole>() : null;
        private ExadataIormConfig _iormConfigCache;
        private string _lastUpdateHistoryEntryId;
        private LicenseModel _licenseModel;
        private int? _listenerPort;
        private int? _memorySizeInGBs;
        private int? _nodeCount;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _ociUrl;
        private string _odbNetworkArn;
        private string _odbNetworkId;
        private float? _percentProgress;
        private string _scanDnsName;
        private string _scanDnsRecordId;
        private List<string> _scanIpIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _scanListenerPortTcp;
        private int? _scanListenerPortTcpSsl;
        private string _shape;
        private ShapeAttribute _shapeAttribute;
        private ExadbVmClusterStorageDetails _snapshotFileSystemStorage;
        private List<string> _sshPublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceStatus _status;
        private string _statusReason;
        private string _systemVersion;
        private string _timeZone;
        private int? _totalEcpuCount;
        private ExadbVmClusterStorageDetails _totalFileSystemStorage;
        private List<string> _vipIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ExadbVmClusterStorageDetails _vmFileSystemStorage;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Grid Infrastructure (GI) cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=11)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Exascale VM cluster was created.
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
        /// <para>
        /// The set of diagnostic collection options enabled for the Exascale VM cluster.
        /// </para>
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the Exascale VM cluster.
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
        /// The domain of the Exascale VM cluster.
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
        /// Gets and sets the property EnabledEcpuCount. 
        /// <para>
        /// The number of elastic compute processing units (ECPUs) enabled on the Exascale VM
        /// cluster.
        /// </para>
        /// </summary>
        public int? EnabledEcpuCount
        {
            get { return this._enabledEcpuCount; }
            set { this._enabledEcpuCount = value; }
        }

        // Check to see if EnabledEcpuCount property is set
        internal bool IsSetEnabledEcpuCount()
        {
            return this._enabledEcpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExadbVmClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExadbVmClusterArn
        {
            get { return this._exadbVmClusterArn; }
            set { this._exadbVmClusterArn = value; }
        }

        // Check to see if ExadbVmClusterArn property is set
        internal bool IsSetExadbVmClusterArn()
        {
            return this._exadbVmClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExadbVmClusterId. 
        /// <para>
        /// The unique identifier of the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string ExadbVmClusterId
        {
            get { return this._exadbVmClusterId; }
            set { this._exadbVmClusterId = value; }
        }

        // Check to see if ExadbVmClusterId property is set
        internal bool IsSetExadbVmClusterId()
        {
            return this._exadbVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Exascale storage vault associated with this
        /// Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExascaleDbStorageVaultArn
        {
            get { return this._exascaleDbStorageVaultArn; }
            set { this._exascaleDbStorageVaultArn = value; }
        }

        // Check to see if ExascaleDbStorageVaultArn property is set
        internal bool IsSetExascaleDbStorageVaultArn()
        {
            return this._exascaleDbStorageVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault associated with this Exascale
        /// VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
        public string ExascaleDbStorageVaultId
        {
            get { return this._exascaleDbStorageVaultId; }
            set { this._exascaleDbStorageVaultId = value; }
        }

        // Check to see if ExascaleDbStorageVaultId property is set
        internal bool IsSetExascaleDbStorageVaultId()
        {
            return this._exascaleDbStorageVaultId != null;
        }

        /// <summary>
        /// Gets and sets the property GiVersion. 
        /// <para>
        /// The software version of the Oracle Grid Infrastructure (GI) for the Exascale VM cluster.
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
        /// Gets and sets the property GridImageId. 
        /// <para>
        /// The Grid Infrastructure software image ID for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public string GridImageId
        {
            get { return this._gridImageId; }
            set { this._gridImageId = value; }
        }

        // Check to see if GridImageId property is set
        internal bool IsSetGridImageId()
        {
            return this._gridImageId != null;
        }

        /// <summary>
        /// Gets and sets the property GridImageType. 
        /// <para>
        /// The type of Grid Infrastructure image for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public GridImageType GridImageType
        {
            get { return this._gridImageType; }
            set { this._gridImageType = value; }
        }

        // Check to see if GridImageType property is set
        internal bool IsSetGridImageType()
        {
            return this._gridImageType != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
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
        /// with the Exascale VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property IormConfigCache. 
        /// <para>
        /// The I/O Resource Management (IORM) configuration cache details for the Exascale VM
        /// cluster.
        /// </para>
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
        /// The Oracle license model applied to the Exascale VM cluster.
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
        /// The port number configured for the listener on the Exascale VM cluster.
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
        /// The amount of memory, in gigabytes (GB), that's allocated for the Exascale VM cluster.
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
        /// The number of nodes in the Exascale VM cluster.
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
        /// The OCID of the Exascale VM cluster.
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
        /// The name of the OCI resource anchor for the Exascale VM cluster.
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
        /// The HTTPS link to the Exascale VM cluster in Oracle Cloud Infrastructure (OCI).
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
        /// The Amazon Resource Name (ARN) of the ODB network associated with this Exascale VM
        /// cluster.
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
        /// The unique identifier of the ODB network for the Exascale VM cluster.
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
        /// The amount of progress made on the current operation on the Exascale VM cluster, expressed
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
        /// The fully qualified domain name (FQDN) of the DNS record for the Single Client Access
        /// Name (SCAN) IP addresses that are associated with the Exascale VM cluster.
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
        /// Exascale VM cluster.
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
        /// The OCID of the SCAN IP addresses that are associated with the Exascale VM cluster.
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
        /// Gets and sets the property ScanListenerPortTcp. 
        /// <para>
        /// The port number for TCP connections to the Single Client Access Name (SCAN) listener
        /// for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public int? ScanListenerPortTcp
        {
            get { return this._scanListenerPortTcp; }
            set { this._scanListenerPortTcp = value; }
        }

        // Check to see if ScanListenerPortTcp property is set
        internal bool IsSetScanListenerPortTcp()
        {
            return this._scanListenerPortTcp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanListenerPortTcpSsl. 
        /// <para>
        /// The port number for TCP connections with SSL to the Single Client Access Name (SCAN)
        /// listener for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public int? ScanListenerPortTcpSsl
        {
            get { return this._scanListenerPortTcpSsl; }
            set { this._scanListenerPortTcpSsl = value; }
        }

        // Check to see if ScanListenerPortTcpSsl property is set
        internal bool IsSetScanListenerPortTcpSsl()
        {
            return this._scanListenerPortTcpSsl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The hardware model name of the Exadata infrastructure that's running the Exascale
        /// VM cluster.
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
        /// Gets and sets the property ShapeAttribute. 
        /// <para>
        /// The shape attribute for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public ShapeAttribute ShapeAttribute
        {
            get { return this._shapeAttribute; }
            set { this._shapeAttribute = value; }
        }

        // Check to see if ShapeAttribute property is set
        internal bool IsSetShapeAttribute()
        {
            return this._shapeAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotFileSystemStorage. 
        /// <para>
        /// The snapshot file system storage details for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public ExadbVmClusterStorageDetails SnapshotFileSystemStorage
        {
            get { return this._snapshotFileSystemStorage; }
            set { this._snapshotFileSystemStorage = value; }
        }

        // Check to see if SnapshotFileSystemStorage property is set
        internal bool IsSetSnapshotFileSystemStorage()
        {
            return this._snapshotFileSystemStorage != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// The public key portion of one or more key pairs used for SSH access to the Exascale
        /// VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The current status of the Exascale VM cluster.
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
        /// Additional information about the status of the Exascale VM cluster.
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
        /// Gets and sets the property SystemVersion. 
        /// <para>
        /// The operating system version of the image chosen for the Exascale VM cluster.
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
        /// The time zone of the Exascale VM cluster.
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
        /// Gets and sets the property TotalEcpuCount. 
        /// <para>
        /// The total number of ECPUs for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public int? TotalEcpuCount
        {
            get { return this._totalEcpuCount; }
            set { this._totalEcpuCount = value; }
        }

        // Check to see if TotalEcpuCount property is set
        internal bool IsSetTotalEcpuCount()
        {
            return this._totalEcpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFileSystemStorage. 
        /// <para>
        /// The total file system storage details for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public ExadbVmClusterStorageDetails TotalFileSystemStorage
        {
            get { return this._totalFileSystemStorage; }
            set { this._totalFileSystemStorage = value; }
        }

        // Check to see if TotalFileSystemStorage property is set
        internal bool IsSetTotalFileSystemStorage()
        {
            return this._totalFileSystemStorage != null;
        }

        /// <summary>
        /// Gets and sets the property VipIds. 
        /// <para>
        /// The virtual IP (VIP) addresses associated with the Exascale VM cluster. One VIP address
        /// is assigned per node to support failover. If a node fails, its VIP is reassigned to
        /// another active node in the cluster.
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

        /// <summary>
        /// Gets and sets the property VmFileSystemStorage. 
        /// <para>
        /// The VM file system storage details for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public ExadbVmClusterStorageDetails VmFileSystemStorage
        {
            get { return this._vmFileSystemStorage; }
            set { this._vmFileSystemStorage = value; }
        }

        // Check to see if VmFileSystemStorage property is set
        internal bool IsSetVmFileSystemStorage()
        {
            return this._vmFileSystemStorage != null;
        }

    }
}