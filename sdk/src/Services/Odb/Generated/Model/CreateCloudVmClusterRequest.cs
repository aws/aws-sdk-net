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
    /// Container for the parameters to the CreateCloudVmCluster operation.
    /// Creates a VM cluster on the specified Exadata infrastructure.
    /// </summary>
    public partial class CreateCloudVmClusterRequest : AmazonOdbRequest
    {
        private string _clientToken;
        private string _cloudExadataInfrastructureId;
        private string _clusterName;
        private int? _cpuCoreCount;
        private DataCollectionOptions _dataCollectionOptions;
        private double? _dataStorageSizeInTBs;
        private int? _dbNodeStorageSizeInGBs;
        private List<string> _dbServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _displayName;
        private string _giVersion;
        private string _hostname;
        private bool? _isLocalBackupEnabled;
        private bool? _isSparseDiskgroupEnabled;
        private LicenseModel _licenseModel;
        private int? _memorySizeInGBs;
        private string _odbNetworkId;
        private int? _scanListenerPortTcp;
        private List<string> _sshPublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _systemVersion;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The client
        /// token is valid for up to 24 hours after it's first used.
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
        /// The unique identifier of the Exadata infrastructure for this VM cluster.
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A name for the Grid Infrastructure cluster. The name isn't case sensitive.
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
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores to enable on the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=368)]
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
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of preferences for the various diagnostic collection options for the VM cluster.
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
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster.
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
        /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the VM cluster.
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
        /// Gets and sets the property GiVersion. 
        /// <para>
        /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid
        /// values, use the <c>ListGiVersions</c> operation and specify the shape of the Exadata
        /// infrastructure.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>19.0.0.0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be "localhost" or "hostname".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't contain "-version".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of the combined hostname and domain is 63 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The hostname must be unique within the subnet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=12)]
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
        /// Gets and sets the property IsLocalBackupEnabled. 
        /// <para>
        /// Specifies whether to enable database backups to local Exadata storage for the VM cluster.
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
        /// Specifies whether to create a sparse disk group for the VM cluster.
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the VM cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>LICENSE_INCLUDED</c> 
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
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster.
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
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network for the VM cluster.
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
        /// Gets and sets the property ScanListenerPortTcp. 
        /// <para>
        /// The port number for TCP connections to the single client access name (SCAN) listener.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>1024–8999</c> with the following exceptions: <c>2484</c>, <c>6100</c>,
        /// <c>6200</c>, <c>7060</c>, <c>7070</c>, <c>7085</c>, and <c>7879</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1521</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=8999)]
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
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property SystemVersion. 
        /// <para>
        /// The version of the operating system of the image for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the VM cluster.
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
        /// The time zone for the VM cluster. For a list of valid values for time zone, you can
        /// check the options in the console.
        /// </para>
        ///  
        /// <para>
        /// Default: UTC
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

    }
}