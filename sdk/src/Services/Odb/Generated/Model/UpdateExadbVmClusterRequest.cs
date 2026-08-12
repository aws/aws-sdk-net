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
    /// Container for the parameters to the UpdateExadbVmCluster operation.
    /// Updates the specified Exascale VM cluster.
    /// </summary>
    public partial class UpdateExadbVmClusterRequest : AmazonOdbRequest
    {
        private DataCollectionOptions _dataCollectionOptions;
        private string _displayName;
        private int? _enabledEcpuCount;
        private string _exadbVmClusterId;
        private string _gridImageId;
        private LicenseModel _licenseModel;
        private List<string> _sshPublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _systemVersion;
        private int? _totalEcpuCount;
        private UpdateAction _updateAction;
        private int? _vmFileSystemStorageTotalSizeInGBs;

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
        /// A new user-friendly name for the Exascale VM cluster.
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
        /// Gets and sets the property EnabledEcpuCount. 
        /// <para>
        /// The number of ECPUs to enable for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property ExadbVmClusterId. 
        /// <para>
        /// The unique identifier of the Exascale VM cluster to update.
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
        /// Gets and sets the property GridImageId. 
        /// <para>
        /// The Grid Infrastructure software image ID for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property TotalEcpuCount. 
        /// <para>
        /// The total number of ECPUs for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
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
        /// Gets and sets the property UpdateAction. 
        /// <para>
        /// The update action to perform on the Exascale VM cluster.
        /// </para>
        /// </summary>
        public UpdateAction UpdateAction
        {
            get { return this._updateAction; }
            set { this._updateAction = value; }
        }

        // Check to see if UpdateAction property is set
        internal bool IsSetUpdateAction()
        {
            return this._updateAction != null;
        }

        /// <summary>
        /// Gets and sets the property VmFileSystemStorageTotalSizeInGBs. 
        /// <para>
        /// The total amount of file system storage, in gigabytes (GB), for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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