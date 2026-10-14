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
    /// Container for the parameters to the UpdateExadbVmCluster operation. Updates the specified
    /// Exascale VM cluster.
    /// </summary>
    public partial class UpdateExadbVmClusterRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of preferences for the various diagnostic collection options for the Exascale
        /// VM cluster.
        /// </para>
        /// </summary>
        public DataCollectionOptions DataCollectionOptions { get; set; }

        /// <summary>
        /// Checks to see if the DataCollectionOptions property is set.
        /// </summary>
        internal bool IsSetDataCollectionOptions() => this.DataCollectionOptions != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new user-friendly name for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EnabledEcpuCount. 
        /// <para>
        /// The number of ECPUs to enable for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? EnabledEcpuCount { get; set; }

        /// <summary>
        /// Checks to see if the EnabledEcpuCount property is set.
        /// </summary>
        internal bool IsSetEnabledEcpuCount() => this.EnabledEcpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property ExadbVmClusterId. 
        /// <para>
        /// The unique identifier of the Exascale VM cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string ExadbVmClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ExadbVmClusterId property is set.
        /// </summary>
        internal bool IsSetExadbVmClusterId() => this.ExadbVmClusterId != null;

        /// <summary>
        /// Gets and sets the property GridImageId. 
        /// <para>
        /// The Grid Infrastructure software image ID for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GridImageId { get; set; }

        /// <summary>
        /// Checks to see if the GridImageId property is set.
        /// </summary>
        internal bool IsSetGridImageId() => this.GridImageId != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Exascale VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// The public key portion of one or more key pairs used for SSH access to the Exascale
        /// VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> SshPublicKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshPublicKeys property is set.
        /// </summary>
        internal bool IsSetSshPublicKeys() => this.SshPublicKeys != null && (this.SshPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemVersion. 
        /// <para>
        /// The version of the operating system of the image for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SystemVersion { get; set; }

        /// <summary>
        /// Checks to see if the SystemVersion property is set.
        /// </summary>
        internal bool IsSetSystemVersion() => this.SystemVersion != null;

        /// <summary>
        /// Gets and sets the property TotalEcpuCount. 
        /// <para>
        /// The total number of ECPUs for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2)]
        public int? TotalEcpuCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalEcpuCount property is set.
        /// </summary>
        internal bool IsSetTotalEcpuCount() => this.TotalEcpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateAction. 
        /// <para>
        /// The update action to perform on the Exascale VM cluster.
        /// </para>
        /// </summary>
        public UpdateAction UpdateAction { get; set; }

        /// <summary>
        /// Checks to see if the UpdateAction property is set.
        /// </summary>
        internal bool IsSetUpdateAction() => this.UpdateAction != null;

        /// <summary>
        /// Gets and sets the property VmFileSystemStorageTotalSizeInGBs. 
        /// <para>
        /// The total amount of file system storage, in gigabytes (GB), for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? VmFileSystemStorageTotalSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the VmFileSystemStorageTotalSizeInGBs property is set.
        /// </summary>
        internal bool IsSetVmFileSystemStorageTotalSizeInGBs() => this.VmFileSystemStorageTotalSizeInGBs.HasValue;
    }
}
