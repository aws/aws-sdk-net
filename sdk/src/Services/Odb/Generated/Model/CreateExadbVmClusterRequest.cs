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
    /// Container for the parameters to the CreateExadbVmCluster operation.
    /// Creates an Exascale VM cluster.
    /// </summary>
    public partial class CreateExadbVmClusterRequest : AmazonOdbRequest
    {
        private string _clientToken;
        private string _clusterName;
        private DataCollectionOptions _dataCollectionOptions;
        private string _displayName;
        private int? _enabledEcpuCount;
        private string _exascaleDbStorageVaultId;
        private string _gridImageId;
        private string _hostname;
        private LicenseModel _licenseModel;
        private int? _nodeCount;
        private string _odbNetworkId;
        private int? _scanListenerPortTcp;
        private int? _scanListenerPortTcpSsl;
        private string _shape;
        private ShapeAttribute _shapeAttribute;
        private List<string> _sshPublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _systemVersion;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _timeZone;
        private int? _totalEcpuCount;
        private int? _vmFileSystemStorageTotalSizeInGBs;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates one and uses it for the request to ensure idempotency. The client token
        /// is valid for up to 24 hours after it's first used.
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
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of preferences for the various diagnostic collection options for the Exascale
        /// VM cluster.
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
        /// A user-friendly name for the Exascale VM cluster.
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
        /// Gets and sets the property EnabledEcpuCount. 
        /// <para>
        /// The number of ECPUs to enable for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault for this Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
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
        /// Gets and sets the property GridImageId. 
        /// <para>
        /// The Grid Infrastructure software image ID for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the Exascale VM cluster.
        /// </para>
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Exascale VM cluster.
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
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of nodes in the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network for the Exascale VM cluster.
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
        /// Gets and sets the property ScanListenerPortTcpSsl. 
        /// <para>
        /// The port number for TCP connections with SSL to the single client access name (SCAN)
        /// listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=8999)]
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
        /// The shape of the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The version of the operating system of the image for the Exascale VM cluster.
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
        /// The list of resource tags to apply to the Exascale VM cluster.
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
        /// The time zone for the Exascale VM cluster.
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
        /// Gets and sets the property TotalEcpuCount. 
        /// <para>
        /// The total number of ECPUs for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2)]
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
        /// Gets and sets the property VmFileSystemStorageTotalSizeInGBs. 
        /// <para>
        /// The total amount of file system storage, in gigabytes (GB), for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? VmFileSystemStorageTotalSizeInGBs
        {
            get { return this._vmFileSystemStorageTotalSizeInGBs; }
            set { this._vmFileSystemStorageTotalSizeInGBs = value; }
        }

        // Check to see if VmFileSystemStorageTotalSizeInGBs property is set
        internal bool IsSetVmFileSystemStorageTotalSizeInGBs()
        {
            return this._vmFileSystemStorageTotalSizeInGBs.HasValue; 
        }

    }
}